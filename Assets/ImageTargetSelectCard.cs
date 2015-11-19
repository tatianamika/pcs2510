using UnityEngine;
using System.Collections;
using Vuforia;

public class ImageTargetSelectCard : MonoBehaviour,
ITrackableEventHandler
{
	private TrackableBehaviour mTrackableBehaviour;
	
	void Start()
	{
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}
	

	public GameObject card1;
	public GameObject card2;
	public GameObject card3;
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		// Seleciona carta
		int n = Random.Range(1,4); //sorteia numeros de 1 a 3
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED ||
		    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			// Seleciona carta
			if (n == 1){
				card1.GetComponent<SpriteRenderer>().enabled = true;
				card2.GetComponent<SpriteRenderer>().enabled = false;
				card3.GetComponent<SpriteRenderer>().enabled = false;
			}
			if (n == 2){
				card2.GetComponent<SpriteRenderer>().enabled = true;
				card1.GetComponent<SpriteRenderer>().enabled = false;
				card3.GetComponent<SpriteRenderer>().enabled = false;
			}
			if (n == 3){
				card3.GetComponent<SpriteRenderer>().enabled = true;
				card1.GetComponent<SpriteRenderer>().enabled = false;
				card2.GetComponent<SpriteRenderer>().enabled = false;
			}
		}
		else
		{
			card1.GetComponent<SpriteRenderer>().enabled = false;
			card2.GetComponent<SpriteRenderer>().enabled = false;
			card3.GetComponent<SpriteRenderer>().enabled = false;
		}
	}  
}
