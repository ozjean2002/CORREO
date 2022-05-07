using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorApp2.Helpers
{
    public static class IJSExtensions
    {
        public static ValueTask<object> Messages(this IJSRuntime js, string titulo, string mensaje, TypeMessageSweetAlert type)
        {
            return js.InvokeAsync<object>("Swal.fire", titulo, mensaje, type.ToString());
        }

        public enum TypeMessageSweetAlert
        {
            question, warning, error, success, info
        }
    }
}
