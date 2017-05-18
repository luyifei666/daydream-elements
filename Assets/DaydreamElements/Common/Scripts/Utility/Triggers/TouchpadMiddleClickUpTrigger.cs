﻿// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

/// Trigger that fires for 1 frame on click up if touching middle region.
public class TouchpadMiddleClickUpTrigger : BaseActionTrigger {
  private float edgeWidth = .2f;

  public override bool TriggerActive() {
    if (GvrController.ClickButtonUp == false) {
      return false;
    }

    float xPos = GvrController.TouchPos.x;
    if (xPos < edgeWidth || xPos > (1 - edgeWidth)) {
      return false;
    }

    return true;
  }
}