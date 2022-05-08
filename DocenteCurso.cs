using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_01
{
    public class DocenteCurso: BusinessEntity
    {
        private TiposCragos _cargo;

        public TiposCragos Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        private int _IDCurso;

        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        private int _IDDocente;

        public int IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }
        public enum TiposCragos
    {
       /* esto va? 
        Deleted,
        New,
        Modified,
        Unmodified*/
    }
    }
}
