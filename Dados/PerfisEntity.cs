﻿using Negocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Negocio.Dominio;

namespace Dados
{
    public class PerfisEntity : IPerfilRepository
    {
        SocialWebContext db = new SocialWebContext();

        public void ApagarPerfil(Perfil perfil)
        {
            db.Perfils.Remove(perfil);
            db.SaveChanges();
        }

        public void EditarPerfil(Perfil perfil)
        {
            db.Entry(perfil).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Perfil ObterPerfilUnico(int id)
        {
            Perfil perfil = db.Perfils.Find(id);
            return perfil;
        }

        public Perfil ObterPerfilUsuario(string UserID)
        {
            try{
                Perfil perfil = db.Perfils.Where(x => x.UserID == UserID).First();
                return perfil;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Perfil> ObterPerfis()
        {           
            List<Perfil> perfis = db.Perfils.ToList();
            return perfis;
        }

        public void CriarPerfil(Perfil perfil)
        {
            db.Perfils.Add(perfil);
            db.SaveChanges();        
        }

        public void dispose()
        {
            db.Dispose();
        }
    }
}