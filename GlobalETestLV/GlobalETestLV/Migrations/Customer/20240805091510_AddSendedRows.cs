﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GlobalETestLV.Migrations.Customer
{
    /// <inheritdoc />
    public partial class AddSendedRows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Template",
                table: "TimersItems",
                newName: "TemplateId");

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });
            migrationBuilder.InsertData(
                table: "Templates",
                columns: new[] { "Id", "Content" },
                    values: new object[,]
                    {
                        {1,@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional //EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">

<head>
	<!--[if gte mso 9]><xml><o:OfficeDocumentSettings><o:AllowPNG/><o:PixelsPerInch>96</o:PixelsPerInch></o:OfficeDocumentSettings></xml><![endif]-->
	<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
	<meta name=""viewport"" content=""width=device-width"">
	<!--[if !mso]><!-->
	<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
	<!--<![endif]-->
	<title></title>
	<!--[if !mso]><!-->
	<!--<![endif]-->
	<style type=""text/css"">
		body {
			margin: 0;
			padding: 0;
		}

		table,
		td,
		tr {
			vertical-align: top;
			border-collapse: collapse;
		}

		* {
			line-height: inherit;
		}

		a[x-apple-data-detectors=true] {
			color: inherit !important;
			text-decoration: none !important;
		}
	</style>
	<style type=""text/css"" id=""media-query"">
		@media (max-width: 520px) {

			.block-grid,
			.col {
				min-width: 320px !important;
				max-width: 100% !important;
				display: block !important;
			}

			.block-grid {
				width: 100% !important;
			}

			.col {
				width: 100% !important;
			}

			.col>div {
				margin: 0 auto;
			}

			img.fullwidth,
			img.fullwidthOnMobile {
				max-width: 100% !important;
			}

			.no-stack .col {
				min-width: 0 !important;
				display: table-cell !important;
			}

			.no-stack.two-up .col {
				width: 50% !important;
			}

			.no-stack .col.num4 {
				width: 33% !important;
			}

			.no-stack .col.num8 {
				width: 66% !important;
			}

			.no-stack .col.num4 {
				width: 33% !important;
			}

			.no-stack .col.num3 {
				width: 25% !important;
			}

			.no-stack .col.num6 {
				width: 50% !important;
			}

			.no-stack .col.num9 {
				width: 75% !important;
			}

			.video-block {
				max-width: none !important;
			}

			.mobile_hide {
				min-height: 0px;
				max-height: 0px;
				max-width: 0px;
				display: none;
				overflow: hidden;
				font-size: 0px;
			}

			.desktop_hide {
				display: block !important;
				max-height: none !important;
			}
		}
	</style>
</head>

<body class=""clean-body"" style=""margin: 0; padding: 0; -webkit-text-size-adjust: 100%; background-color: #FFFFFF;"">
	<!--[if IE]><div class=""ie-browser""><![endif]-->
	<table class=""nl-container"" style=""table-layout: fixed; vertical-align: top; min-width: 320px; Margin: 0 auto; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #FFFFFF; width: 100%;"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" width=""100%"" bgcolor=""#FFFFFF"" valign=""top"">
		<tbody>
			<tr style=""vertical-align: top;"" valign=""top"">
				<td style=""word-break: break-word; vertical-align: top;"" valign=""top"">
					<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td align=""center"" style=""background-color:#FFFFFF""><![endif]-->
					<div style=""background-color:transparent;"">
						<div class=""block-grid "" style=""Margin: 0 auto; min-width: 320px; max-width: 500px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; background-color: transparent;"">
							<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
								<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:500px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
								<!--[if (mso)|(IE)]><td align=""center"" width=""500"" style=""background-color:transparent;width:500px; border-top: 0px dotted transparent; border-left: 0px dotted transparent; border-bottom: 0px dotted transparent; border-right: 0px dotted transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:5px; padding-bottom:5px;""><![endif]-->
								<div class=""col num12"" style=""min-width: 320px; max-width: 500px; display: table-cell; vertical-align: top; width: 500px;"">
									<div style=""width:100% !important;"">
										<!--[if (!mso)&(!IE)]><!-->
										<div style=""border-top:0px dotted transparent; border-left:0px dotted transparent; border-bottom:0px dotted transparent; border-right:0px dotted transparent; padding-top:5px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
											<!--<![endif]-->
											<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 10px; padding-left: 10px; padding-top: 10px; padding-bottom: 10px; font-family: Arial, sans-serif""><![endif]-->
											<div style=""color:#555555;font-family:Arial, Helvetica Neue, Helvetica, sans-serif;line-height:1.2;padding-top:10px;padding-right:10px;padding-bottom:10px;padding-left:10px;"">
												<div style=""line-height: 1.2; font-size: 12px; color: #555555; font-family: Arial, Helvetica Neue, Helvetica, sans-serif; mso-line-height-alt: 14px;"">
													<p style=""font-size: 14px; line-height: 1.2; word-break: break-word; mso-line-height-alt: 17px; margin: 0;"">Template A here</p>
												</div>
											</div>
											<!--[if mso]></td></tr></table><![endif]-->
											<table class=""social_icons"" cellpadding=""0"" cellspacing=""0"" width=""100%"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" valign=""top"">
												<tbody>
													<tr style=""vertical-align: top;"" valign=""top"">
														<td style=""word-break: break-word; vertical-align: top; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
															<table class=""social_table"" align=""center"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-tspace: 0; mso-table-rspace: 0; mso-table-bspace: 0; mso-table-lspace: 0;"" valign=""top"">
																<tbody>
																	<tr style=""vertical-align: top; display: inline-block; text-align: center;"" align=""center"" valign=""top"">
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://www.facebook.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/facebook@2x.png"" alt=""Facebook"" title=""Facebook"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://twitter.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/twitter@2x.png"" alt=""Twitter"" title=""Twitter"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://instagram.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/instagram@2x.png"" alt=""Instagram"" title=""Instagram"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://www.linkedin.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/linkedin@2x.png"" alt=""LinkedIn"" title=""LinkedIn"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																	</tr>
																</tbody>
															</table>
														</td>
													</tr>
												</tbody>
											</table>
											<!--[if (!mso)&(!IE)]><!-->
										</div>
										<!--<![endif]-->
									</div>
								</div>
								<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
								<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
							</div>
						</div>
					</div>
					<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
				</td>
			</tr>
		</tbody>
	</table>
	<!--[if (IE)]></div><![endif]-->
</body>

</html>"},
                        {2,@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional //EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">

<head>
	<!--[if gte mso 9]><xml><o:OfficeDocumentSettings><o:AllowPNG/><o:PixelsPerInch>96</o:PixelsPerInch></o:OfficeDocumentSettings></xml><![endif]-->
	<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
	<meta name=""viewport"" content=""width=device-width"">
	<!--[if !mso]><!-->
	<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
	<!--<![endif]-->
	<title></title>
	<!--[if !mso]><!-->
	<!--<![endif]-->
	<style type=""text/css"">
		body {
			margin: 0;
			padding: 0;
		}

		table,
		td,
		tr {
			vertical-align: top;
			border-collapse: collapse;
		}

		* {
			line-height: inherit;
		}

		a[x-apple-data-detectors=true] {
			color: inherit !important;
			text-decoration: none !important;
		}
	</style>
	<style type=""text/css"" id=""media-query"">
		@media (max-width: 520px) {

			.block-grid,
			.col {
				min-width: 320px !important;
				max-width: 100% !important;
				display: block !important;
			}

			.block-grid {
				width: 100% !important;
			}

			.col {
				width: 100% !important;
			}

			.col>div {
				margin: 0 auto;
			}

			img.fullwidth,
			img.fullwidthOnMobile {
				max-width: 100% !important;
			}

			.no-stack .col {
				min-width: 0 !important;
				display: table-cell !important;
			}

			.no-stack.two-up .col {
				width: 50% !important;
			}

			.no-stack .col.num4 {
				width: 33% !important;
			}

			.no-stack .col.num8 {
				width: 66% !important;
			}

			.no-stack .col.num4 {
				width: 33% !important;
			}

			.no-stack .col.num3 {
				width: 25% !important;
			}

			.no-stack .col.num6 {
				width: 50% !important;
			}

			.no-stack .col.num9 {
				width: 75% !important;
			}

			.video-block {
				max-width: none !important;
			}

			.mobile_hide {
				min-height: 0px;
				max-height: 0px;
				max-width: 0px;
				display: none;
				overflow: hidden;
				font-size: 0px;
			}

			.desktop_hide {
				display: block !important;
				max-height: none !important;
			}
		}
	</style>
</head>

<body class=""clean-body"" style=""margin: 0; padding: 0; -webkit-text-size-adjust: 100%; background-color: #FFFFFF;"">
	<!--[if IE]><div class=""ie-browser""><![endif]-->
	<table class=""nl-container"" style=""table-layout: fixed; vertical-align: top; min-width: 320px; Margin: 0 auto; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #FFFFFF; width: 100%;"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" width=""100%"" bgcolor=""#FFFFFF"" valign=""top"">
		<tbody>
			<tr style=""vertical-align: top;"" valign=""top"">
				<td style=""word-break: break-word; vertical-align: top;"" valign=""top"">
					<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td align=""center"" style=""background-color:#FFFFFF""><![endif]-->
					<div style=""background-color:transparent;"">
						<div class=""block-grid "" style=""Margin: 0 auto; min-width: 320px; max-width: 500px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; background-color: transparent;"">
							<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
								<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:500px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
								<!--[if (mso)|(IE)]><td align=""center"" width=""500"" style=""background-color:transparent;width:500px; border-top: 0px dotted transparent; border-left: 0px dotted transparent; border-bottom: 0px dotted transparent; border-right: 0px dotted transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:5px; padding-bottom:5px;""><![endif]-->
								<div class=""col num12"" style=""min-width: 320px; max-width: 500px; display: table-cell; vertical-align: top; width: 500px;"">
									<div style=""width:100% !important;"">
										<!--[if (!mso)&(!IE)]><!-->
										<div style=""border-top:0px dotted transparent; border-left:0px dotted transparent; border-bottom:0px dotted transparent; border-right:0px dotted transparent; padding-top:5px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
											<!--<![endif]-->
											<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 10px; padding-left: 10px; padding-top: 10px; padding-bottom: 10px; font-family: Arial, sans-serif""><![endif]-->
											<div style=""color:#555555;font-family:Arial, Helvetica Neue, Helvetica, sans-serif;line-height:1.2;padding-top:10px;padding-right:10px;padding-bottom:10px;padding-left:10px;"">
												<div style=""line-height: 1.2; font-size: 12px; color: #555555; font-family: Arial, Helvetica Neue, Helvetica, sans-serif; mso-line-height-alt: 14px;"">
													<p style=""font-size: 14px; line-height: 1.2; word-break: break-word; mso-line-height-alt: 17px; margin: 0;"">Template B here</p>
												</div>
											</div>
											<!--[if mso]></td></tr></table><![endif]-->
											<table class=""social_icons"" cellpadding=""0"" cellspacing=""0"" width=""100%"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" valign=""top"">
												<tbody>
													<tr style=""vertical-align: top;"" valign=""top"">
														<td style=""word-break: break-word; vertical-align: top; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
															<table class=""social_table"" align=""center"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-tspace: 0; mso-table-rspace: 0; mso-table-bspace: 0; mso-table-lspace: 0;"" valign=""top"">
																<tbody>
																	<tr style=""vertical-align: top; display: inline-block; text-align: center;"" align=""center"" valign=""top"">
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://www.facebook.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/facebook@2x.png"" alt=""Facebook"" title=""Facebook"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://twitter.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/twitter@2x.png"" alt=""Twitter"" title=""Twitter"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://instagram.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/instagram@2x.png"" alt=""Instagram"" title=""Instagram"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://www.linkedin.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/linkedin@2x.png"" alt=""LinkedIn"" title=""LinkedIn"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																	</tr>
																</tbody>
															</table>
														</td>
													</tr>
												</tbody>
											</table>
											<!--[if (!mso)&(!IE)]><!-->
										</div>
										<!--<![endif]-->
									</div>
								</div>
								<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
								<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
							</div>
						</div>
					</div>
					<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
				</td>
			</tr>
		</tbody>
	</table>
	<!--[if (IE)]></div><![endif]-->
</body>

</html>"},
                        {3,@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional //EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">

<head>
	<!--[if gte mso 9]><xml><o:OfficeDocumentSettings><o:AllowPNG/><o:PixelsPerInch>96</o:PixelsPerInch></o:OfficeDocumentSettings></xml><![endif]-->
	<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
	<meta name=""viewport"" content=""width=device-width"">
	<!--[if !mso]><!-->
	<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
	<!--<![endif]-->
	<title></title>
	<!--[if !mso]><!-->
	<!--<![endif]-->
	<style type=""text/css"">
		body {
			margin: 0;
			padding: 0;
		}

		table,
		td,
		tr {
			vertical-align: top;
			border-collapse: collapse;
		}

		* {
			line-height: inherit;
		}

		a[x-apple-data-detectors=true] {
			color: inherit !important;
			text-decoration: none !important;
		}
	</style>
	<style type=""text/css"" id=""media-query"">
		@media (max-width: 520px) {

			.block-grid,
			.col {
				min-width: 320px !important;
				max-width: 100% !important;
				display: block !important;
			}

			.block-grid {
				width: 100% !important;
			}

			.col {
				width: 100% !important;
			}

			.col>div {
				margin: 0 auto;
			}

			img.fullwidth,
			img.fullwidthOnMobile {
				max-width: 100% !important;
			}

			.no-stack .col {
				min-width: 0 !important;
				display: table-cell !important;
			}

			.no-stack.two-up .col {
				width: 50% !important;
			}

			.no-stack .col.num4 {
				width: 33% !important;
			}

			.no-stack .col.num8 {
				width: 66% !important;
			}

			.no-stack .col.num4 {
				width: 33% !important;
			}

			.no-stack .col.num3 {
				width: 25% !important;
			}

			.no-stack .col.num6 {
				width: 50% !important;
			}

			.no-stack .col.num9 {
				width: 75% !important;
			}

			.video-block {
				max-width: none !important;
			}

			.mobile_hide {
				min-height: 0px;
				max-height: 0px;
				max-width: 0px;
				display: none;
				overflow: hidden;
				font-size: 0px;
			}

			.desktop_hide {
				display: block !important;
				max-height: none !important;
			}
		}
	</style>
</head>

<body class=""clean-body"" style=""margin: 0; padding: 0; -webkit-text-size-adjust: 100%; background-color: #FFFFFF;"">
	<!--[if IE]><div class=""ie-browser""><![endif]-->
	<table class=""nl-container"" style=""table-layout: fixed; vertical-align: top; min-width: 320px; Margin: 0 auto; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #FFFFFF; width: 100%;"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" width=""100%"" bgcolor=""#FFFFFF"" valign=""top"">
		<tbody>
			<tr style=""vertical-align: top;"" valign=""top"">
				<td style=""word-break: break-word; vertical-align: top;"" valign=""top"">
					<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td align=""center"" style=""background-color:#FFFFFF""><![endif]-->
					<div style=""background-color:transparent;"">
						<div class=""block-grid "" style=""Margin: 0 auto; min-width: 320px; max-width: 500px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; background-color: transparent;"">
							<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
								<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:500px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
								<!--[if (mso)|(IE)]><td align=""center"" width=""500"" style=""background-color:transparent;width:500px; border-top: 0px dotted transparent; border-left: 0px dotted transparent; border-bottom: 0px dotted transparent; border-right: 0px dotted transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:5px; padding-bottom:5px;""><![endif]-->
								<div class=""col num12"" style=""min-width: 320px; max-width: 500px; display: table-cell; vertical-align: top; width: 500px;"">
									<div style=""width:100% !important;"">
										<!--[if (!mso)&(!IE)]><!-->
										<div style=""border-top:0px dotted transparent; border-left:0px dotted transparent; border-bottom:0px dotted transparent; border-right:0px dotted transparent; padding-top:5px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
											<!--<![endif]-->
											<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 10px; padding-left: 10px; padding-top: 10px; padding-bottom: 10px; font-family: Arial, sans-serif""><![endif]-->
											<div style=""color:#555555;font-family:Arial, Helvetica Neue, Helvetica, sans-serif;line-height:1.2;padding-top:10px;padding-right:10px;padding-bottom:10px;padding-left:10px;"">
												<div style=""line-height: 1.2; font-size: 12px; color: #555555; font-family: Arial, Helvetica Neue, Helvetica, sans-serif; mso-line-height-alt: 14px;"">
													<p style=""font-size: 14px; line-height: 1.2; word-break: break-word; mso-line-height-alt: 17px; margin: 0;"">Template C here</p>
												</div>
											</div>
											<!--[if mso]></td></tr></table><![endif]-->
											<table class=""social_icons"" cellpadding=""0"" cellspacing=""0"" width=""100%"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" valign=""top"">
												<tbody>
													<tr style=""vertical-align: top;"" valign=""top"">
														<td style=""word-break: break-word; vertical-align: top; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
															<table class=""social_table"" align=""center"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-tspace: 0; mso-table-rspace: 0; mso-table-bspace: 0; mso-table-lspace: 0;"" valign=""top"">
																<tbody>
																	<tr style=""vertical-align: top; display: inline-block; text-align: center;"" align=""center"" valign=""top"">
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://www.facebook.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/facebook@2x.png"" alt=""Facebook"" title=""Facebook"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://twitter.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/twitter@2x.png"" alt=""Twitter"" title=""Twitter"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://instagram.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/instagram@2x.png"" alt=""Instagram"" title=""Instagram"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																		<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 1px; padding-left: 1px;"" valign=""top""><a href=""https://www.linkedin.com/"" target=""_blank""><img width=""32"" height=""32"" src=""https://d2fi4ri5dhpqd1.cloudfront.net/public/resources/social-networks-icon-sets/circle-color/linkedin@2x.png"" alt=""LinkedIn"" title=""LinkedIn"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: none; display: block;""></a></td>
																	</tr>
																</tbody>
															</table>
														</td>
													</tr>
												</tbody>
											</table>
											<!--[if (!mso)&(!IE)]><!-->
										</div>
										<!--<![endif]-->
									</div>
								</div>
								<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
								<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
							</div>
						</div>
					</div>
					<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
				</td>
			</tr>
		</tbody>
	</table>
	<!--[if (IE)]></div><![endif]-->
</body>

</html>"},
                    });
            migrationBuilder.CreateTable(
                name: "SendedRows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SendTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    TemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendedRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SendedRows_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SendedRows_Templates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimersItems_TemplateId",
                table: "TimersItems",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_SendedRows_CustomerId",
                table: "SendedRows",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SendedRows_TemplateId",
                table: "SendedRows",
                column: "TemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimersItems_Templates_TemplateId",
                table: "TimersItems",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimersItems_Templates_TemplateId",
                table: "TimersItems");

            migrationBuilder.DropTable(
                name: "SendedRows");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropIndex(
                name: "IX_TimersItems_TemplateId",
                table: "TimersItems");

            migrationBuilder.RenameColumn(
                name: "TemplateId",
                table: "TimersItems",
                newName: "Template");
        }
    }
}
