# OptimizelyHtmlTextBlockDemo

This project is based on the **Optimizely Alloy MVC** template and includes a custom content block called `HtmlTextBlock`.

## 🚀 Technologies Used

- .NET 8
- Optimizely CMS 12 (formerly Episerver)
- Razor Views
- ASP.NET Core Identity

---

## 🔧 Custom Features

### 🧱 HtmlTextBlock

A reusable content block that allows editors to:

- Enter rich HTML content using the `XhtmlString` field
- Select the team associated with the content using a dropdown (`Alpha`, `Bravo`, `Charlie`)

### 🗂 Usage in CMS

1. The block can be created from the **Assets → Blocks** panel.
2. It can be added to a **ContactPage** via the `MainContentArea` property.
3. The block is rendered on the frontend displaying the HTML content and selected team.

---


