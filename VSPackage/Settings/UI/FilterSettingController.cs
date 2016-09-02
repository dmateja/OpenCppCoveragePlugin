﻿// OpenCppCoverage is an open source code coverage for C++.
// Copyright (C) 2016 OpenCppCoverage
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.ObjectModel;

namespace OpenCppCoverage.VSPackage.Settings.UI
{
    //-------------------------------------------------------------------------
    class UnifiedDiffs
    {
        public string UnifiedDiffPath { get; set; }
        public string OptionalRootFolder { get; set; }
    }

    //-------------------------------------------------------------------------
    class FilterSettingController
    {
        //---------------------------------------------------------------------
        public FilterSettingController()
        {
            this.SourcePatterns = new ObservableCollection<BindableString>();
            this.ExcludedSourcePatterns = new ObservableCollection<BindableString>();
            this.ModulePatterns = new ObservableCollection<BindableString>();
            this.ExcludedModulePatterns = new ObservableCollection<BindableString>();
            this.UnifiedDiffs = new ObservableCollection<UnifiedDiffs>();            
        }

        public ObservableCollection<BindableString> SourcePatterns { get; private set; }
        public ObservableCollection<BindableString> ExcludedSourcePatterns { get; private set; }
        public ObservableCollection<BindableString> ModulePatterns { get; private set; }
        public ObservableCollection<BindableString> ExcludedModulePatterns { get; private set; }
        public ObservableCollection<UnifiedDiffs> UnifiedDiffs { get; private set; }
    }
}
