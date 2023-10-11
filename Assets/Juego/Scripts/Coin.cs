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
		private int contadormonedas;

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
	
    

}