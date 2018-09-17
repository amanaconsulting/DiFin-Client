﻿// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System.Windows.Forms;

namespace AMANA.IFP
{
    public class ObjectListViewItem : ListViewItem
    {
        public object UnderlyingObject { get; set; }

        public ObjectListViewItem(object underlyingObject, string[] subItems)
            : base(subItems)
        {
            UnderlyingObject = underlyingObject;
        }
    }
}