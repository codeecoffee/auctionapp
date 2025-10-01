using auction_app.DTOs;
using auction_app.Entities;
using AutoMapper;

namespace auction_app.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Auction, AuctionDto>()
            .IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(d=>d.Item, 
                o=> o.MapFrom(s=> s));
        CreateMap<CreateAuctionDto, Item>();
    }
}