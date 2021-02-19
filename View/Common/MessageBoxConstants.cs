using System;
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

        public const string TextMissingFormInfo = "Bitte füllen Sie die Formularfelder vollständig aus.";
        public const string TextMissingOrderEntity = "Speichern Sie zuerst Ihren Auftrag ab.";

        public const string TextErrorDeletedArticleGroup = "Die Artikelgruppe " +
                                                           "hat noch Untergruppen " +
                                                           "die zuerst gelöscht werden müssen.";

        public const string TextErrorDeleteLinkedArticles = "Die folgenden Artikel sind in der Artikelgruppe {0} " +
                                                            "({1}) und können somit nicht gelöscht werden: {2}";

        public const string TextOrderBilled = "Der Auftrag wurde erfolgreich abgerechnet.";
        public const string TextOrderTotalNotSet = "Der Auftrag muss ein gültiges Total haben um abgerechnet werden zu können.";

        public const string TextDBMigrated = "Die Datenbank 'Accounting' wurde inklusive Testdaten erstellt.";
    }
}