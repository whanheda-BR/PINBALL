using UnityEngine;
public class ForceExample : MonoBehaviour
{
private Rigidbody2D rb;
void Start()
{
rb = GetComponent<Rigidbody2D>();
Vector2 force = new Vector2(0f, 18f); // Força para a direita
rb.AddForce(force, ForceMode2D.Impulse); // Aplica a força instantaneamente
}
}