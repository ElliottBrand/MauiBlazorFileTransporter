using Models;
using Microsoft.Maui.Essentials;

namespace MauiShareStation.Utilities
{
    public class FileSeeker
    {
        public static async Task<List<PickerMediaModel>> PickFilesAsync()
        {
            List<PickerMediaModel> pickerFiles = new();

            var files = await FilePicker.PickMultipleAsync();

            foreach (var file in files)
            {
                System.IO.Stream stream = await file.OpenReadAsync();
                byte[] buffer = new byte[stream.Length];

                await stream.ReadAsync(buffer);
                var imageModel = new PickerMediaModel
                {
                    FileBytes = buffer,
                    FileName = file.FileName
                };
                pickerFiles.Add(imageModel);
            }
            return pickerFiles;
        }
    }
}
