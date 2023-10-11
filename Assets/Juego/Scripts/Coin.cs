using UnityEngine;
using System.Collections;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

namespace MoreMountains.CorgiEngine
{
	
	/// <summary>
	/// Coin manager
	/// </summary>
	[AddComponentMenu("Corgi Engine/Items/Coin")]
	public class Coin : PickableItem
	{
		[Header("Coin")]

		/// The amount of points to add when collected
		[Tooltip("The amount of points to add when collected")]
		public int PointsToAdd = 10;

		/// <summary>
		/// Triggered when something collides with the coin
		/// </summary>
		/// <param name="collider">Other.</param>
		protected override void Pick(GameObject picker) 
		{
			// we send a new points event for the GameManager to catch (and other classes that may listen to it too)
			CorgiEnginePointsEvent.Trigger(PointsMethods.Add, PointsToAdd);
		}
        
    }
	public class Contador : GameManager
		
    {
		GameManager gm;
		public int Puntos;
		public int Division;

		[MMInformation("Add this component to an object with a Collider2D set as trigger, and it'll become pickable by Player Characters. When picked, it'll increase the amount of lives as specified. You can decide here to have only new lives added, within the limit of current lives containers, expand this limit, fill it accordingly, or fill all containers.", MMInformationAttribute.InformationType.Info, false)]
		[Header("Normal one ups")]

		[Tooltip("the amount of lives that should be added when picking this item")]
		public int NumberOfAddedLives;
		[Header("Containers")]
		[Tooltip("the number of empty containers to add when picking this item")]
		public int NumberOfAddedEmptyContainers;
		[Tooltip("whether to fill the additional containers or not")]
		public bool FillAddedContainers = false;
		[Tooltip("whether to fill all containers or not")]
		public bool FillAllContainers = false;


		private void Update()
        {
			gm = FindObjectOfType<GameManager>();
			Puntos = Points;
			Division = Puntos % 10;
			Debug.Log(Puntos);
            if (Division==0)
            {
				GameManager.Instance.GainLives(NumberOfAddedLives);
				GameManager.Instance.AddLives(NumberOfAddedEmptyContainers, FillAddedContainers);
				if (FillAllContainers)
				{
					GameManager.Instance.GainLives(GameManager.Instance.MaximumLives);
				}
			}
		}
    }

}