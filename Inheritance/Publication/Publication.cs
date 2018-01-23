﻿using System;

public enum PublicationType {  Misc, Book, Magazine, Article };

public abstract class Publication
{
    private bool published = false;
    private DateTime datePublished;
    private int totalPages;

    public Publication(string title, string publisher, PublicationType pubType)
    {
        if (publisher == null)
            throw new ArgumentNullException("The publisher cannot be null.");
        else if (String.IsNullOrWhiteSpace(publisher))
            throw new ArgumentException("The publisher cannot consist only of whitespace.");
        Publisher = publisher;

        if (title == null)
            throw new ArgumentNullException("The title cannot be null.");
        else if (String.IsNullOrWhiteSpace(title))
            throw new ArgumentException("The title cannot consist only of whitespace.");
        Title = title;

        PubType = pubType;
    }

    public string Publisher { get; set; }

    public string Title { get; set; }
    
    public PublicationType PubType { get; set; }

    public string CopyrightName { get; private set; }

    public int CopyrightDate { get; private set; }

    public int Pages
    {
        get { return totalPages; }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("the number of pages cannot be zero or negative.");
            totalPages = value;
        }
    }

    public string GetPublicationDate()
    {
        if(!published)
            return "NYP";
        else 
            return datePublished.ToString("d");
    }

    public void Publish(DateTime datePublished)
    {
        published = true;
        this.datePublished = datePublished;
    }

    public void Copyright(string copyrightName, int copyrightDate)
    {
        if (CopyrightName == null)
            throw new ArgumentNullException("The name of the copyright holder cannot be null.");
        else if (String.IsNullOrWhiteSpace(copyrightName))
            throw new ArgumentException("The name of the copyright holder cannot consist only of whitespace.");
        CopyrightName = copyrightName;

        int currentYear = DateTime.Now.Year;
        if (copyrightDate < currentYear - 10 || copyrightDate > currentYear + 2)
            throw new ArgumentOutOfRangeException("The copyright year must be between {0} and {1}", Convert.ToString(currentYear - 10), Convert.ToString(currentYear + 2));
        CopyrightDate = copyrightDate;
    }

    public override string ToString()
    {
        return Title;
    }
}
