using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GRIDCITY
{
    public enum blockType { Block, Arches, Columns, Dishpivot, DomeWithBase, HalfDome, SlitDome, Slope, Tile };

    public class CityManager : MonoBehaviour
    {

        #region Fields
        public Mesh[] meshArray;
        public Material[] materialArray;
        private static CityManager _instance;
        public GameObject buildingPrefab;
        public GameObject WallBlock;
        public GameObject WallTopper;

        public BuildingProfile wallProfile;

        private bool[,,] cityArray = new bool[30, 15, 30];   //increased array size to allow for larger city volume

        public static CityManager Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        #region Properties	
        #endregion

        #region Methods
        #region Unity Methods

        // Use this for internal initialization
        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }

            else
            {
                Destroy(gameObject);
                Debug.LogError("Multiple CityManager instances in Scene. Destroying clone!");
            };
        }

        // Use this for external initialization
        void Start()
        {
            // Select x and z size
            int OuterWallLength = 30;

            //start at bottom
            for (int height = 0; height < 3; height++)
            {
                //start on x's (-) edge, loop til (+) edge
                for (int x = -OuterWallLength; x <= OuterWallLength; x++)
                {
                    //start on z's (-) edge, loop til (+) edge
                    for (int z = -OuterWallLength; z <= OuterWallLength; z += 1)
                    {
                        //only if edge position selected, keeps wall hollow
                        if (Mathf.Abs(x) == OuterWallLength || Mathf.Abs(z) == OuterWallLength)
                        {
                            if (height < 2)
                            {
                                Instantiate(WallBlock);
                                WallBlock.transform.position = new Vector3(x, height, z);
                            }
                            else if (height == 2)
                            {
                                Instantiate(WallTopper);
                                WallTopper.transform.position = new Vector3(x, height, z);
                            }
                        }
                    }
                }
            }
            int InnerWallLength = 20;

            //Build inner wall
            for (int height = 0; height < 5; height++)
                //start on x's (-) edge, loop til (+) edge
                for (int x = -InnerWallLength; x <= InnerWallLength; x++)
                {
                    //start on z's (-) edge, loop til (+) edge
                    for (int z = -InnerWallLength; z <= InnerWallLength; z += 1)
                    {
                        //only if edge position selected, keeps wall hollow
                        if (Mathf.Abs(x) == InnerWallLength || Mathf.Abs(z) == InnerWallLength)
                        {
                            if (height < 4)
                            {
                                Instantiate(WallBlock);
                                WallBlock.transform.position = new Vector3(x, height, z);
                            }
                            else if (height == 4)
                            {
                                Instantiate(WallTopper);
                                WallTopper.transform.position = new Vector3(x, height, z);
                            }
                        }
                    }
                }
            #endregion
            #endregion
        }
    }
}