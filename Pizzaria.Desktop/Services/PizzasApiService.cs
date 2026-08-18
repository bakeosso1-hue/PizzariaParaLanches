using Pizzaria.Desktop.Helpers;
using Pizzaria.Desktop.DTOs;


namespace Pizzaria.Desktop.Services
{
    public class PizzaApiService
    {
        private readonly HttpClientHelper _http;

     
        public PizzaApiService()
        {
            _http = HttpClientHelper.Instance;
        }


        public async Task<List<PizzaResponseDto>> GetAllAsync()
        {
            try
            {
                var pizzas = await _http.GetAsync<List<PizzaResponseDto>>("/api/Pizza");
                return pizzas ?? new List<PizzaResponseDto>();
            }
            catch
            {
                return new List<PizzaResponseDto>();
            }
        }

  
        public async Task<PizzaResponseDto> GetByIdAsync(int id)
        {
            return await _http.GetAsync<PizzaResponseDto>($"/api/Pizza/{id}");
        }

     
        public async Task<(bool Success, PizzaResponseDto? Game, string ErrorMessage)>
            CreateAsync(CreatePizzaDto dto)
        {
            return await _http.PostAsync<PizzaResponseDto>("/api/Pizza", dto);
        }

     
        public async Task<(bool Success, PizzaResponseDto? Game, string ErrorMessage)>
            UpdateAsync(int id, UpdatePizzaDto dto)
        {
            return await _http.PutAsync<PizzaResponseDto>($"/api/Pizza/{id}", dto);
        }

       
        public async Task<(bool Success, string ErrorMessage)> DeleteAsync(int id)
        {
            return await _http.DeleteAsync($"/api/Pizza/{id}");
        }
    }



}
