using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WeatherForecastApp.Database
{
    public partial class WeatherDBContext : DbContext
    {
        public WeatherDBContext()
        {
        }

        public WeatherDBContext(DbContextOptions<WeatherDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Forecast> Forecasts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=WeatherDB;Username=postgres;Password=7355608");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Timezone).HasColumnName("timezone");
            });

            modelBuilder.Entity<Forecast>(entity =>
            {
                entity.ToTable("Forecast");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.FeelsLike).HasColumnName("feels_like");

                entity.Property(e => e.FkCity).HasColumnName("fk_city");

                entity.Property(e => e.Humidity).HasColumnName("humidity");

                entity.Property(e => e.Pressure).HasColumnName("pressure");

                entity.Property(e => e.RequestTime).HasColumnName("request_time");

                entity.Property(e => e.Temperature).HasColumnName("temperature");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Weather_Description).HasColumnName("weather_description");

                entity.Property(e => e.Weather_Icon).HasColumnName("weather_icon");

                entity.Property(e => e.WindDegree).HasColumnName("wind_degree");

                entity.Property(e => e.WindSpeed).HasColumnName("wind_speed");

                entity.HasOne(d => d.FkCityNavigation)
                    .WithMany(p => p.Forecasts)
                    .HasForeignKey(d => d.FkCity)
                    .HasConstraintName("Forecast_fk_city_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
