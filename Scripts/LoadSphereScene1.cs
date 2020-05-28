using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

[System.Obsolete]
public class LoadSphereScene : MonoBehaviour, ITrackableEventHandler
{

    #region PRIVATE_MEMBERS
    private TrackableBehaviour mTrackableBehaviour;
    #endregion // PRIVATE_MEMBERS
    #region MONOBEHAVIOUR_METHODS

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

    }
    #endregion

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Debug.Log("DETECTED!"
            SceneManager.LoadScene("Sphere");
        }
        else
        {
            Debug.Log("LOST!");
        }
    }
}