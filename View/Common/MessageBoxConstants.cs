﻿using System;
using System.Collections.Generic;
using System.Text;

namespace db_projektarbeit.View.Common
{
    public class MessageBoxConstants
    {
        public const string CaptionSuccess = "SUCCESS";
        public const string CaptionError = "ERROR";
        public const string CaptionQuestion = "QUESTION";
        public const string CaptionInformation = "INFORMATION";

        public const string TextQuestionSureToDelete = "Möchten Sie diesen Datensatz wirklich löschen?";
        public const string TextSuccessDelete = "{0} konnte erfolgreich gelöscht werden.";
        public const string TextNotDeleted = "Datensatz wird nicht gelöscht.";
        public const string TextErrorDeleteBecauseLink = "Löschen aufgrund verlinkter {0} nicht " +
                                                         "möglich. Bitte löschen Sie diese " +
                                                         "Datensätze zuerst.";
    }
}