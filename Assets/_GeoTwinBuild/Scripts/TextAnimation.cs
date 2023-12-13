using UnityEngine;
namespace Trisgram.GeoTwinBuild {
    public class TextAnimation : MonoBehaviour {
        private const string PLAYER = "Player";
        [SerializeField] private Animation _table;

        private void OnTriggerEnter(Collider other) {
            if (other.gameObject.tag == PLAYER) {
                _table.Play("OpenOut");
            }
        }
        private void OnTriggerExit(Collider other) {
            if (other.gameObject.tag == PLAYER) {
                _table.Play("Closein");
            }
        }
    }
}