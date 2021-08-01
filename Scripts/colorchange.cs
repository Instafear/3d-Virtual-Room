using UnityEngine;

public class colorchange : MonoBehaviour
{
    [SerializeField] [Range(0f,1f)] float lerptime;
    [SerializeField] [Range(0f, 10f)] float emission_intensity;
    [SerializeField] Color[] mycolor;
    public Material mat;
    int i = 0;
    float t=0f;
    void Update()
    {
        mat.SetColor("_EmissionColor", mat.color * emission_intensity);
        mat.color = Color.Lerp(mat.color,mycolor[i], lerptime*Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerptime * Time.deltaTime);
        if(t>0.9f)
        {
            t = 0f;
            i++;
            if (i >= mycolor.Length)
                i = 0;
        }


    }
}
