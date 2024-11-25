namespace MyHotel.Api.Middlewares
{
    public class IsShabatMiddleware
    {
        private readonly RequestDelegate _next;
        public IsShabatMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var day=DateTime.Now.DayOfWeek;
            if(day!=DayOfWeek.Wednesday)
            {
                await _next(context);
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
        }
    }
}
