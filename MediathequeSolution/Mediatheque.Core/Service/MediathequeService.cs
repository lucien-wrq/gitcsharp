using Mediatheque.Core.Model;
using System.Text;

namespace Mediatheque.Core.Service
{
    public class MediathequeService
    {
        private List<ObjetDePret> _fondDeCommerce = new List<ObjetDePret>();
        private INotationService _notationService;

        public MediathequeService(INotationService notationService)
        {
            _notationService = notationService;
        }

        public void AddObjet(ObjetDePret objet)
        {
            _fondDeCommerce.Add(objet);
        }

        public int GetNombreObjet()
        {
            return _fondDeCommerce.Count;
        }

        public string GetNombreJeux()
        {
            var jeux = _fondDeCommerce.OfType<JeuxDeSociete>().ToList();
            int nombreJeux = jeux.Count;
            if (nombreJeux == 0)
            {
                return "Il n'y a pas de jeux dans le fond de commerce.";
            }
            return nombreJeux + " jeux de société sont disponibles.";
        }
    }
}
