[CreateAssetMenu]
public class FloatVariable : SriptableObject
{
    public float Value;
}

// Hitpoints
// Damage Amounts
// Timing Data

/*
public class DumbEnemy : MonoBehaviour
{
    public FloatVariable MaxHP;
    public FloatVariable MoveSpeed;
}
*/



// Float Reference
[Serializable]
public class FloatReference
{
    public bool UseConstant = true;
    public float ConstantValue;
    public FloatVariable Variable;
  
    public float Value
    {
        get {  return UseConstant ? ConstantValue : Variable.Value}
    }
}

public class DumbEnemy : MonoBehaviour
{
    public FloatReference MaxHP;
    public FloatReference MoveSpeed;
}
