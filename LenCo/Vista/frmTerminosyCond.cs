using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenCo.Vista
{
    public partial class frmTerminosyCond : Form
    {
        public frmTerminosyCond()
        {
            InitializeComponent();
            cargarBienvenida();
        }

        private void cargarBienvenida()
        {
            string bienvenida =
            "Bienvenido a Lenco proporcionado por GarcINC. Nos complace ofrecerle acceso al Servicio, sujeto a estos términos y condiciones " +
            "(los 'Términos de Servicio') y a la Política de Privacidad correspondiente de GarcINC. Al acceder y utilizar el Servicio, usted expresa " +
            "su consentimiento, acuerdo y entendimiento de los Términos de Servicio y la Política de Privacidad. Si no está de acuerdo con los Términos " +
            "de Servicio o la Política de Privacidad, no utilice el Servicio." + "\n" +
            "Si utiliza el servicio está aceptando las modalidades operativas en vigencia descriptas más adelante, las declara conocer y aceptar," +
            "las que se habiliten en el futuro y en los términos y condiciones que a continuación se detallan: ";
            lblBienvenida.Text = bienvenida;

            string operaciones =
            "Las operaciones habilitadas son aquellas que estarán disponibles para los clientes, quienes deberán cumplir los requisitos que se " +
            "encuentren vigentes en su momento para operar el Servicio. Las mismas podrán ser ampliadas o restringidas por el proveedor, comunicándolo previamente " +
            "con una antelación no menor a 60 días, y comprenden entre otras, sin que pueda entenderse taxativamente las que se indican a continuación: ";
            lblOperaciones.Text = operaciones;

            string transacciones =
                "En ningún caso debe entenderse que la solicitud de un producto o servicio implica obligación alguna para el Acceso y uso del Servicio." + "\n" +
                "Para operar el Servicio se requerirá siempre que se trate de clientes de Lenco quienes podrán acceder mediante cualquier dispositivo con " +
                "conexión a la Red Internet. El cliente deberá proporcionar el nombre de usuario y clave, que será provista por la aplicación " +
                "como requisito previo a la primera operación, en la forma que le sea requerida. La clave personal y todo o cualquier otro mecanismo adicional de " +
                "autenticación personal provisto por el Banco tiene el carácter de secreto e intransferible, y por lo tanto asumo las consecuencias de su divulgación a terceros, " +
                "liberando a Lenco de toda responsabilidad que de ello se derive. En ningún caso Lenco requerirá que le suministre la totalidad de los datos, " +
                "ni enviara mail requiriendo información personalalguna.";
            lblTransacciones.Text = transacciones;

            string costo =
                "La empresa GarcINC podrá cobrar comisiones por el mantenimiento y / o uso de este Servicio o los que en el futuro implemente, entendiéndose facultado expresamente para " +
                "efectuar los correspondientes débitos en mis cuentas, aún en descubierto, por lo que presto para ello mi expresa conformidad. En " +
                "caso de cualquier modificación a la presente previsión, lo comunicará con al menos 60 días de antelación. ";
            lblCosto.Text = costo;

            string vigencia =
                "El Usuario podrá dejar sin efecto la relación que surja de la presente, en forma inmediata, sin otra responsabilidad que la derivada de los " +
                "gastos originados hasta esemomento. Si el cliente incumpliera cualquiera de las obligaciones asumidas en su relación contractual con empresa Lenco, " +
                "o de los presentes Términos y Condiciones, elBanco podrá decretar la caducidad del presente Servicio en forma inmediata, sin que ello genere derecho " +
                "a indemnización o compensación alguna. empresa XXX podrá dejar sin efecto la relación que surja de la presente, con un preaviso mínimo de 60 días, " +
                "sin otra responsabilidad. ";
            lblVigencia.Text = vigencia;

            string validez =
                "Los registros emitidos por la app serán prueba suficiente de las operaciones cursadas por dicho canal.Renuncio expresamente a cuestionar la idoneidad " +
                "o habilidad de ese medio de prueba.A los efectos del cumplimiento de disposiciones legales o contractuales, se otorga a las notificaciones por este medio " +
                "el mismo alcance de las notificaciones mediante documento escrito. ";
            lblValidez.Text = validez;

            string propIntelectual =
                "El software en Argentina está protegido por la ley 11.723, que regula la propiedad intelectual y los derechos de autor de todos aquellos creadores " +
                "de obras artísticas, literarias y científicas. ";
            lblPropidad.Text = propIntelectual;

            string privacidad =
    "Para utilizar los Servicios ofrecidos por GarcINC, los Usuarios deberán facilitar determinados datos de carácter personal.Su información personal se procesa y almacena " +
    "en servidores o medios magnéticos que mantienen altos estándares de seguridad y protección tanto física como tecnológica. Para mayor información sobre la privacidad de " +
    "los Datos Personales y casos en los que será revelada la informaciónpersonal, se pueden consultar nuestras políticas de privacidad.";
            lblPrivacidad.Text = privacidad;
        }
    }
}