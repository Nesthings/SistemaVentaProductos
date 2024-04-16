﻿namespace SistemaVentas.AplicacionWeb.Utilidades.Response
{
    public class GenericResponse<TObject>
    {
        public bool Estado { get; set; }

        public string? Mensaje { get; set; }

        public TObject? objeto { get; set; }

        public List<TObject>? ListaObjeto { get; set; }
    }
}
