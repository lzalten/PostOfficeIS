using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostOfficeIS.Services.ParcelSevice
{
    public class ParcelPictureServicecs
    {
        public static async Task CreatePicturesAsync(int id)
        {
            using var client = new HttpClient();

            // Установка заголовка авторизации
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "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");
            string k = $"parcel box {id}";
            var requestContent = new StringContent("{\"inputs\": " + k + "}", Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://api-inference.huggingface.co/models/stabilityai/stable-diffusion-2-1", requestContent);

            // Получение ответа и вывод его содержимого
            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();
                using var fileStream = new FileStream($"C:\\Users\\ммм\\source\\repos\\TestDB\\TestDB\\ParcelsImg\\{id}.png", FileMode.Create);
                await stream.CopyToAsync(fileStream);
                fileStream.Flush();
                fileStream.Close();
            }
        }
    }
}
