using UnityEngine;
using UnityEngine.Events;

namespace Rcam4 {

public sealed class KnobToFloat : MonoBehaviour
{
    #region Editable attributes

    [SerializeField] InputHandle _handle = null;
    [SerializeField] int _knobIndex = 0;
    [SerializeField] float _minValue = 0;
    [SerializeField] float _maxValue = 1;
    [SerializeField] UnityEvent<float> _event = null;

    #endregion

    #region MonoBehaviour implementation

    void LateUpdate()
      => _event.Invoke(Mathf.Lerp(_minValue, _maxValue, _handle.GetKnob(_knobIndex)));

    #endregion
}

} // namespace Rcam4
