using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityInfoApp.Code {
    public class HttpHelper {

        public async Task<string> GetReponceAsync(string url) {
            using (HttpClient client = new HttpClient()) {
                var response = await client.GetAsync(url);

                if(response.IsSuccessStatusCode) {
                    return await response.Content.ReadAsStringAsync();
                } else {
                    return string.Empty;
                }
            }
        }
    }
}
