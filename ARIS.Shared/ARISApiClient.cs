using ARIS.Shared.Requests;
using ARIS.Shared.Responses;
using System.Net.Http.Json;

namespace ARIS.Shared
{
    public class ARISApiClient(HttpClient httpClient)
    {
        public async Task<DashboardData> GetDashboardData()
        {
            return await httpClient.GetFromJsonAsync<DashboardData>("/api/dashboard") ?? new DashboardData();
        }

        public async Task<StudentRegistrationRequest> RegisterStudent(StudentRegistrationRequest data)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/Students/RegisterStudent", data);
            if (response.IsSuccessStatusCode)
            {
#pragma warning disable CS8603 // Possible null reference return.
                return await response.Content.ReadFromJsonAsync<StudentRegistrationRequest>();
#pragma warning restore CS8603 // Possible null reference return.
            }
            else
            {
                // Handle error
                throw new HttpRequestException($"Response status code does not indicate success: {(int)response.StatusCode} ({response.StatusCode}).");
            }
        }

        public async Task<List<StudentBasicData>> GetAllStudentsBasicData()
        {
            HttpResponseMessage response = await httpClient.GetAsync("/api/Students/GetAllBasicStudentData");
            if (response.IsSuccessStatusCode)
            {
#pragma warning disable CS8603 // Possible null reference return.
                   return await response.Content.ReadFromJsonAsync<List<StudentBasicData>>();
#pragma warning restore CS8603 // Possible null reference return.
            }
            else
            {
                // Handle error
                throw new HttpRequestException($"Response status code does not indicate success: {(int)response.StatusCode} ({response.StatusCode}).");
            }
        }

        public async Task<StudentAdvancedData> GetStudentAdvancedData(int Id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"/api/Students/GetAdvancedStudentData?id={Id}");
            if (response.IsSuccessStatusCode)
            {
#pragma warning disable CS8603 // Possible null reference return.
                return await response.Content.ReadFromJsonAsync<StudentAdvancedData>();
#pragma warning restore CS8603 // Possible null reference return.
            }
            else
            {
                // Handle error
                throw new HttpRequestException($"Response status code does not indicate success: {(int)response.StatusCode} ({response.StatusCode}).");
            }
        }

        public async Task<HttpResponseMessage> AssignStudentToForm(int studentId, int formId)
        {
            return await httpClient.PostAsync($"api/Forms/{formId}/students/{studentId}", null);
        }
    }
}
