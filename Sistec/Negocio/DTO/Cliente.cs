using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Sistec
{
    [Table ("TB_CLIENTE")]
    public class Cliente 
    {
        [Key]
        public int CLIID{get;set;}
        public string CLINOME{get;set;}
        public string CLICPF{get;set;}
        public string CLICOMPLEMENTO{get;set;}
        public string CLIBAIRRO{get;set;}
        public string CLIENDERECO{get;set;}
        public string CLICEP{get;set;}
        public string CLICIDADE{get;set;}
        public string CLIUF{get;set;}
        public DateTime CLIDATAHORAENTRADA{get;set;}
        public string CLIEMAIL{get;set;}
        public string CLITELEFONE{get;set;}
        public string CLIATIVO{get;set;}
    }
}

/*
create table DBO.TB_CLIENTE (
    CLIID                int                  identity(1, 1),
    CLINOME              varchar(50)          collate SQL_Latin1_General_CP850_CI_AI not null,
    CLICOMPLEMENTO       varchar(100)         collate SQL_Latin1_General_CP850_CI_AI not null,
    CLIBAIRRO            varchar(50)          collate SQL_Latin1_General_CP850_CI_AI not null,
	CLIENDERECO          varchar(100)         collate SQL_Latin1_General_CP850_CI_AI not null,
	CLICEP               varchar(8)           collate SQL_Latin1_General_CP850_CI_AI not null,
	CLICIDADE            varchar(50)          collate SQL_Latin1_General_CP850_CI_AI not null,
	CLIUF                varchar(2)          collate SQL_Latin1_General_CP850_CI_AI not null,
    CLIDATAHORACRIACAO   datetime             not null constraint DF__Cliente_usudata__2C5E7C59 default getdate(),
    CLIATIVO             bit                  not null constraint DF__Cliente_usuativ__2D52A092 default (1),
    CLICPF               varchar(14)          null,
    CLITELEFONE          varchar(20)          null,
    constraint PK_Cliente primary key nonclustered (CLIID),
    )
*/