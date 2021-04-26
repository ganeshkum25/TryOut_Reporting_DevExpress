function onCustomizeLocalization(s, e) {
    e.LoadMessages($.get("/js/localization/dx-analytics-core.de.json"));
    e.LoadMessages($.get("/js/localization/dx-reporting.de.json"));
}