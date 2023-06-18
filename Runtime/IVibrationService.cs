// Copyright © 2023 Nikolay Melnikov. All rights reserved.
// SPDX-License-Identifier: Apache-2.0

using JetBrains.Annotations;

namespace Depra.Vibration.Runtime
{
    public interface IVibrationService
    {
        [UsedImplicitly]
        bool Enabled { get; }
        
        [UsedImplicitly]
        void Vibrate(string presetIdent);

        [UsedImplicitly]
        void CancelAll();
    }
}