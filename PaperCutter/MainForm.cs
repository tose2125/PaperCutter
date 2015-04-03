using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tose2125.PaperCutter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SettingOutputMmPresetSelector.DataSource = paperSizeList.Keys.ToList();
            SettingOutputAnchorSelector.DataSource = Enum.GetValues(typeof(Anchor));
        }

        private const decimal mmPerIn = 25.4m;
        private List<String> filePathList = new List<String>();
        private Int32 currentPreviewImage = 0;
        private Dictionary<String, PaperSize> paperSizeList = new Dictionary<String, PaperSize>() {
            {"A3", new PaperSize(297, 420)},
            {"B4", new PaperSize(257, 364)},
            {"A4", new PaperSize(210, 297)},
            {"B5", new PaperSize(182, 257)},
            {"A5", new PaperSize(148, 210)},
            {"B6", new PaperSize(128, 182)},
            {"A6", new PaperSize(105, 148)},
            {"写真2L", new PaperSize(127, 178)},
            {"ハガキ", new PaperSize(102, 152)},
            {"写真L", new PaperSize(89, 127)},
        };
        private void UpdateImagePreview()
        {
            if (currentPreviewImage < 0) { currentPreviewImage = 0; }
            if (filePathList.Count <= currentPreviewImage) { currentPreviewImage = filePathList.Count - 1; }
            if (filePathList.Count < 1) { currentPreviewImage = -1; }
            SettingPreviewLabel.Text = (currentPreviewImage + 1).ToString() + "枚目 " + (filePathList.Count).ToString() + "枚中";
            ImagePreviewBox.ImageLocation = null;
            if (0 < filePathList.Count)
            {
                try
                {
                    ImagePreviewBox.ImageLocation = filePathList[currentPreviewImage];
                }
                catch (ArgumentException)
                {
                    filePathList.RemoveAt(currentPreviewImage);
                }
                catch (System.IO.IOException)
                {
                    filePathList.RemoveAt(currentPreviewImage);
                }
                finally
                {
                    if (ImagePreviewBox.ImageLocation == null && 0 < filePathList.Count)
                    {
                        UpdateImagePreview();
                    }
                }
            }
        }

        private void DraganddropPanel_DragEnter(object sender, DragEventArgs e)
        {//ファイルをドラッグした時に、ドロップ可能であることを表示します。
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void DraganddropPanel_DragDrop(object sender, DragEventArgs e)
        {//ファイルをドロップした時に、追加します。
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                filePathList.AddRange((String[])e.Data.GetData(DataFormats.FileDrop));
                UpdateImagePreview();
            }
        }
        private void ImagePreviewBox_MouseDown(object sender, MouseEventArgs e)
        {//画像をドラッグした時に、ドラッグをさせます。
            if (e.Button == MouseButtons.Left)
            {
                if (0 < filePathList.Count)
                {
                    try
                    {
                        ImagePreviewBox.DoDragDrop(new DataObject(DataFormats.FileDrop, new String[] { filePathList[currentPreviewImage] }), DragDropEffects.Move);
                    }
                    catch (ArgumentException)
                    {
                        filePathList.RemoveAt(currentPreviewImage);
                    }
                    catch (UriFormatException)
                    {
                        filePathList.RemoveAt(currentPreviewImage);
                    }
                    finally
                    {
                        UpdateImagePreview();
                    }
                }
            }
        }
        private void DeleteButton_DragEnter(object sender, DragEventArgs e)
        {//画像をドラッグした時に、ドロップ可能であることを表示します。
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        private void DeleteButton_DragDrop(object sender, DragEventArgs e)
        {//画像をドロップした時に、削除します。
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                filePathList.RemoveAll(currentPath =>
                {
                    return 0 < ((String[])e.Data.GetData(DataFormats.FileDrop)).Count(currentCurrentPath =>
                    {
                        return currentPath == currentCurrentPath;
                    });
                });
                UpdateImagePreview();
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            filePathList.RemoveAll(currentPath =>
            {
                return filePathList[currentPreviewImage] == currentPath;
            });
            UpdateImagePreview();
        }
        private void SettingPreviewPreviousButton_Click(object sender, EventArgs e)
        {//プレビューを一つ戻します。
            currentPreviewImage--;
            if (currentPreviewImage < 0) { currentPreviewImage = filePathList.Count - 1; }
            UpdateImagePreview();
        }
        private void SettingPreviewNextButton_Click(object sender, EventArgs e)
        {//プレビューを一つ進めます。
            currentPreviewImage++;
            if (currentPreviewImage > filePathList.Count - 1) { currentPreviewImage = 0; }
            UpdateImagePreview();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {//画像を切り取ります。
            for (int i = 0; i < filePathList.Count; i++)
            {
                Bitmap originalImage = new Bitmap(filePathList[i]);
                String originalPath = filePathList[i];
                PaperSize originalSize = new PaperSize(SettingInputMmWidth.Value, SettingInputMmHeight.Value);
                if (SettingInputDpiSelector.Checked)
                {
                    originalSize.Width = originalImage.Width / SettingInputDpiWidth.Value * mmPerIn;
                    originalSize.Height = originalImage.Height / SettingInputDpiHeight.Value * mmPerIn;
                }
                PaperSize trimmingSize = new PaperSize(SettingOutputMmWidth.Value, SettingOutputMmHeight.Value);
                Anchor trimmingAnchor = (Anchor)SettingOutputAnchorSelector.SelectedItem;
                ImageTrimming.Crop(ref originalImage, originalPath, originalSize, trimmingSize, trimmingAnchor);
                originalImage = null;
            }
        }

        private void SettingInputMmReplaceButton_Click(object sender, EventArgs e)
        {//入力画像の大きさの縦横を入れ替えます。
            decimal temp = SettingInputMmWidth.Value;
            SettingInputMmWidth.Value = SettingInputMmHeight.Value;
            SettingInputMmHeight.Value = temp;
        }
        private void SettingOutputMmReplaceButton_Click(object sender, EventArgs e)
        {//出力画像の大きさの縦横を入れ替えます。
            decimal temp = SettingOutputMmWidth.Value;
            SettingOutputMmWidth.Value = SettingOutputMmHeight.Value;
            SettingOutputMmHeight.Value = temp;
        }
        private void SettingInputDpiHeight_ValueChanged(object sender, EventArgs e)
        {//入力画像の解像度の同期をします。高さから幅
            if (SettingInputDpiSyncToggleButton.Checked) { SettingInputDpiWidth.Value = SettingInputDpiHeight.Value; }
        }
        private void SettingInputDpiWidth_ValueChanged(object sender, EventArgs e)
        {//入力画像の解像度の同期をします。幅から高さ
            if (SettingInputDpiSyncToggleButton.Checked) { SettingInputDpiHeight.Value = SettingInputDpiWidth.Value; }
        }
        private void SettingOutputMmPresetSelector_SelectedValueChanged(object sender, EventArgs e)
        {//出力画像の大きさをプリセットから設定します。
            try
            {
                SettingOutputMmWidth.Value = paperSizeList[(String)SettingOutputMmPresetSelector.SelectedValue].Width;
                SettingOutputMmHeight.Value = paperSizeList[(String)SettingOutputMmPresetSelector.SelectedValue].Height;
            }
            catch (IndexOutOfRangeException ee)
            {
                Console.Write(ee.Message);
            }
        }
    }

}
