// by @unmanuel

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace vr_BAND {

	public class ARScan : MonoBehaviour {
	    
		public GameObject introScreen, scanner;

		public UnityEvent OnStart;

		void Start() {
			scanner.SetActive(false);
			OnStart?.Invoke();
		}

	    public void StartScan() {
	    	introScreen.SetActive(false);
	    	scanner.SetActive(true);
	    }

	    public void GotoSite(string url) {
	    	Application.OpenURL(url);
	    }

	    public void Quit() {
	    	Application.Quit();
	    }
	}
}
