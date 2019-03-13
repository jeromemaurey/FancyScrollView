﻿using UnityEngine;
using System.Collections.Generic;

namespace FancyScrollView
{
    public class Example01ScrollView : FancyScrollView<Example01CellDto>
    {
        [SerializeField] ScrollPositionController scrollPositionController;

        void Awake()
        {
            scrollPositionController.OnUpdatePosition(p => UpdatePosition(p));
        }

        public void UpdateData(IList<Example01CellDto> data)
        {
            UpdateContents(data);
            scrollPositionController.SetDataCount(CellData.Count);
        }
    }
}
