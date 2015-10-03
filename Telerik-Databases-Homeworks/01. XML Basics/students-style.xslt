<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:students="urn:students"
>
  <xsl:template match="/">
    <html>
      <head>
        <link rel="stylesheet" type="text/css" href="students-styles.css"></link>
      </head>
      <body>
        <h1>Students:</h1>
        <table>
          <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Birth Date</th>
            <th>Phone</th>
            <th>Email</th>
            <th>Course</th>
            <th>Speciality</th>
            <th>Faculty Number</th>
            <th>Exams</th>
          </tr>
          <xsl:for-each select="students/student">
            <tr>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="sex"/>
              </td>
              <td>
                <xsl:value-of select="birthDate"/>
              </td>
              <td>
                <xsl:value-of select="phone"/>
              </td>
              <td>
                <xsl:value-of select="email"/>
              </td>
              <td>
                <xsl:value-of select="course"/>
              </td>
              <td>
                <xsl:value-of select="speciality"/>
              </td>
              <td>
                <xsl:value-of select="facultyNumber"/>
              </td>
              <td>
                <xsl:for-each select="exams/exam">
                  <div>
                    <p>Name:
                      <xsl:value-of select="name"/>
                    </p>
                    <p>Tutor:
                      <xsl:value-of select="tutor"/>
                    </p>
                    <p>Score:
                      <xsl:value-of select="score"/>
                    </p>
                  </div>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
