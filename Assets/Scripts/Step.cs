using UnityEngine;

public class Step : MonoBehaviour
{
    #region Variables

    [TextArea(5, 10)]
    [SerializeField] private string _answers;
    [TextArea(3, 10)]
    [SerializeField] private string _description;

    [SerializeField] private Step[] _nextSteps;

    #endregion

    #region Properties

    public string Answers => _answers;
    public string Description => _description;
    public Step[] NextSteps => _nextSteps;

    #endregion
}