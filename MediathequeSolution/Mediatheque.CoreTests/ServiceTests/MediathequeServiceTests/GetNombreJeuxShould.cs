using Mediatheque.Core.Model;
using Mediatheque.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.CoreTests.ServiceTests.MediathequeServiceTests
{
    [TestClass]
    public class GetNombreJeuxShould
    {
        [TestMethod]
        public void ReturnMessage_WhenNoJeux()
        {
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);

            // Act
            string actual = mediathequeService.GetNombreJeux();

            // Assert
            Assert.AreEqual("Il n'y a pas de jeux dans le fond de commerce.", actual);
        }

        [TestMethod]
        public void ReturnMessage_WhenOnlyCDs()
        {
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            mediathequeService.AddObjet(new CD("Spice world", "Spice girl"));

            // Act
            string actual = mediathequeService.GetNombreJeux();

            // Assert
            Assert.AreEqual("Il n'y a pas de jeux dans le fond de commerce.", actual);
        }

        [TestMethod]
        public void ReturnJeuxNombre_WhenMultipleJeux()
        {
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            var jeu1 = new JeuxDeSociete("Jeux de 54 cartes", 3, 99, "carrefour", TypeJeuxDeSociete.Carte);
            var jeu2 = new JeuxDeSociete("Monopoly", 8, 99, "amazon", TypeJeuxDeSociete.Plateau);
            mediathequeService.AddObjet(jeu1);
            mediathequeService.AddObjet(jeu2);

            // Act
            string actual = mediathequeService.GetNombreJeux();

            // Assert
            string expected = "2 jeux de société sont disponibles.";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnJeuxNombre_WhenMixedObjects()
        {
            // Arrange
            MediathequeService mediathequeService = new MediathequeService(null);
            var jeu1 = new JeuxDeSociete("Jeux de 54 cartes", 3, 99, "carrefour", TypeJeuxDeSociete.Carte);
            var jeu2 = new JeuxDeSociete("Monopoly", 8, 99, "amazon", TypeJeuxDeSociete.Plateau);
            mediathequeService.AddObjet(jeu1);
            mediathequeService.AddObjet(jeu2);
            mediathequeService.AddObjet(new CD("Spice world", "Spice girl"));

            // Act
            string actual = mediathequeService.GetNombreJeux();

            // Assert
            string expected = "2 jeux de société sont disponibles.";
            Assert.AreEqual(expected, actual);
        }
    }
}


