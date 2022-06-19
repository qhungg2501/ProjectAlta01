using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAlta.Data;
using ProjectAlta.Entity;
using ProjectAlta.DTO;
namespace ProjectAlta.Respository
{
    public interface IEDocumentRespository
    {
        List<DocumentDTO> GetAll();
        DocumentDTO GetById(int docId);
        bool Insert(DocumentDTO document);
        bool Update(DocumentDTO document);
        bool Delete(int docId);
        void Save();
    }
}
