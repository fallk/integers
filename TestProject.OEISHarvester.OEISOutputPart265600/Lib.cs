using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A025604
{
public static readonly BigInteger[] Value={ 1L,0L,21L,180L,3699L,78186L,1763689L,40219584L,921030783L,21114454518L,484210273013L,11105346505100L,254708804007115L,5841980066693506L,133991588716915713L,3073232605116594392L,BigInteger.Parse("70487720404861582487"),BigInteger.Parse("1616707836356340649102"),BigInteger.Parse("37080846132267449237645") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025604Inst Instance=new A025604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025605
{
public static readonly BigInteger[] Value={ 0L,1L,8L,157L,3362L,76367L,1748900L,40115777L,920244134L,21108602611L,484166076904L,11105013004773L,254706278398058L,5841960927064087L,133991443518199596L,3073231503116849801L,BigInteger.Parse("70487712038010275886"),BigInteger.Parse("1616707772818851078203"),BigInteger.Parse("37080845649697782625136") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025605Inst Instance=new A025605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025606
{
public static readonly BigInteger[] Value={ 0L,1L,8L,163L,3398L,76753L,1751700L,40139295L,920426818L,21110069229L,484177665424L,11105105040891L,254707005772222L,5841966668784265L,133991488702577676L,3073231857864304087L,BigInteger.Parse("70487714816049472186"),BigInteger.Parse("1616707794524130044965"),BigInteger.Parse("37080845818916250489864") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025606Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025606.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025606Inst Instance=new A025606Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025607
{
public static readonly long[] Value={ 1L,0L,14L,84L,896L,10080L,127904L,1708224L,23426816L,325032960L,4532831744L,63353816064L,886318555136L,12404650352640L,173642248822784L,2430854346031104L,34031138021113856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025607Inst : IEnumerable<long>
{
public static readonly long[] Value=A025607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025607.Bytes);
public long this[int i]=>Value[i];

public static A025607Inst Instance=new A025607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025608
{
public static readonly BigInteger[] Value={ 0L,0L,2L,36L,560L,8160L,116192L,1638336L,23006720L,322513920L,4517714432L,63263118336L,885774356480L,12401385185280L,173622657769472L,2430736799809536L,34030432743587840L,476426763687690240L,6669978923292557312L,BigInteger.Parse("93379730316084903936"),BigInteger.Parse("1307316376765123788800") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025608Inst Instance=new A025608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025609
{
public static readonly long[] Value={ 0L,1L,6L,64L,720L,9136L,122016L,1673344L,23216640L,323773696L,4525272576L,63308468224L,886046453760L,12403017773056L,173632453287936L,2430795572936704L,34030785382318080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025609Inst : IEnumerable<long>
{
public static readonly long[] Value=A025609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025609.Bytes);
public long this[int i]=>Value[i];

public static A025609Inst Instance=new A025609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025610
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,24L,32L,36L,48L,64L,72L,96L,128L,144L,192L,216L,256L,288L,384L,432L,512L,576L,768L,864L,1024L,1152L,1296L,1536L,1728L,2048L,2304L,2592L,3072L,3456L,4096L,4608L,5184L,6144L,6912L,7776L,8192L,9216L,10368L,12288L,13824L,15552L,16384L,18432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025610Inst : IEnumerable<long>
{
public static readonly long[] Value=A025610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025610.Bytes);
public long this[int i]=>Value[i];

public static A025610Inst Instance=new A025610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025611
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,16L,18L,32L,36L,64L,72L,81L,128L,144L,162L,256L,288L,324L,512L,576L,648L,729L,1024L,1152L,1296L,1458L,2048L,2304L,2592L,2916L,4096L,4608L,5184L,5832L,6561L,8192L,9216L,10368L,11664L,13122L,16384L,18432L,20736L,23328L,26244L,32768L,36864L,41472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025611Inst : IEnumerable<long>
{
public static readonly long[] Value=A025611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025611.Bytes);
public long this[int i]=>Value[i];

public static A025611Inst Instance=new A025611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025612
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,16L,20L,32L,40L,64L,80L,100L,128L,160L,200L,256L,320L,400L,512L,640L,800L,1000L,1024L,1280L,1600L,2000L,2048L,2560L,3200L,4000L,4096L,5120L,6400L,8000L,8192L,10000L,10240L,12800L,16000L,16384L,20000L,20480L,25600L,32000L,32768L,40000L,40960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025612Inst : IEnumerable<long>
{
public static readonly long[] Value=A025612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025612.Bytes);
public long this[int i]=>Value[i];

public static A025612Inst Instance=new A025612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025629
{
public static readonly long[] Value={ 1L,6L,10L,36L,60L,100L,216L,360L,600L,1000L,1296L,2160L,3600L,6000L,7776L,10000L,12960L,21600L,36000L,46656L,60000L,77760L,100000L,129600L,216000L,279936L,360000L,466560L,600000L,777600L,1000000L,1296000L,1679616L,2160000L,2799360L,3600000L,4665600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025629Inst : IEnumerable<long>
{
public static readonly long[] Value=A025629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025629.Bytes);
public long this[int i]=>Value[i];

public static A025629Inst Instance=new A025629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025630
{
public static readonly long[] Value={ 1L,7L,8L,49L,56L,64L,343L,392L,448L,512L,2401L,2744L,3136L,3584L,4096L,16807L,19208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025630Inst : IEnumerable<long>
{
public static readonly long[] Value=A025630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025630.Bytes);
public long this[int i]=>Value[i];

public static A025630Inst Instance=new A025630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025631
{
public static readonly long[] Value={ 1L,7L,9L,49L,63L,81L,343L,441L,567L,729L,2401L,3087L,3969L,5103L,6561L,16807L,21609L,27783L,35721L,45927L,59049L,117649L,151263L,194481L,250047L,321489L,413343L,531441L,823543L,1058841L,1361367L,1750329L,2250423L,2893401L,3720087L,4782969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025631Inst : IEnumerable<long>
{
public static readonly long[] Value=A025631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025631.Bytes);
public long this[int i]=>Value[i];

public static A025631Inst Instance=new A025631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025632
{
public static readonly long[] Value={ 1L,7L,10L,49L,70L,100L,343L,490L,700L,1000L,2401L,3430L,4900L,7000L,10000L,16807L,24010L,34300L,49000L,70000L,100000L,117649L,168070L,240100L,343000L,490000L,700000L,823543L,1000000L,1176490L,1680700L,2401000L,3430000L,4900000L,5764801L,7000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025632Inst : IEnumerable<long>
{
public static readonly long[] Value=A025632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025632.Bytes);
public long this[int i]=>Value[i];

public static A025632Inst Instance=new A025632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025633
{
public static readonly long[] Value={ 1L,8L,9L,64L,72L,81L,512L,576L,648L,729L,4096L,4608L,5184L,5832L,6561L,32768L,36864L,41472L,46656L,52488L,59049L,262144L,294912L,331776L,373248L,419904L,472392L,531441L,2097152L,2359296L,2654208L,2985984L,3359232L,3779136L,4251528L,4782969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025633Inst : IEnumerable<long>
{
public static readonly long[] Value=A025633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025633.Bytes);
public long this[int i]=>Value[i];

public static A025633Inst Instance=new A025633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025634
{
public static readonly long[] Value={ 1L,8L,10L,64L,80L,100L,512L,640L,800L,1000L,4096L,5120L,6400L,8000L,10000L,32768L,40960L,51200L,64000L,80000L,100000L,262144L,327680L,409600L,512000L,640000L,800000L,1000000L,2097152L,2621440L,3276800L,4096000L,5120000L,6400000L,8000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025634Inst : IEnumerable<long>
{
public static readonly long[] Value=A025634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025634.Bytes);
public long this[int i]=>Value[i];

public static A025634Inst Instance=new A025634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025635
{
public static readonly long[] Value={ 1L,9L,10L,81L,90L,100L,729L,810L,900L,1000L,6561L,7290L,8100L,9000L,10000L,59049L,65610L,72900L,81000L,90000L,100000L,531441L,590490L,656100L,729000L,810000L,900000L,1000000L,4782969L,5314410L,5904900L,6561000L,7290000L,8100000L,9000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025635Inst : IEnumerable<long>
{
public static readonly long[] Value=A025635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025635.Bytes);
public long this[int i]=>Value[i];

public static A025635Inst Instance=new A025635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025636
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,2L,5L,0L,3L,6L,1L,4L,7L,2L,5L,0L,8L,3L,6L,1L,9L,4L,7L,2L,10L,5L,0L,8L,3L,11L,6L,1L,9L,4L,12L,7L,2L,10L,5L,0L,13L,8L,3L,11L,6L,1L,14L,9L,4L,12L,7L,2L,15L,10L,5L,0L,13L,8L,3L,16L,11L,6L,1L,14L,9L,4L,17L,12L,7L,2L,15L,10L,5L,18L,0L,13L,8L,3L,16L,11L,6L,19L,1L,14L,9L,4L,17L,12L,7L,20L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025636Inst : IEnumerable<long>
{
public static readonly long[] Value=A025636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025636.Bytes);
public long this[int i]=>Value[i];

public static A025636Inst Instance=new A025636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025637
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,2L,5L,0L,3L,6L,1L,4L,7L,2L,5L,8L,0L,3L,6L,9L,1L,4L,7L,10L,2L,5L,8L,11L,0L,3L,6L,9L,12L,1L,4L,7L,10L,13L,2L,5L,8L,11L,14L,0L,3L,6L,9L,12L,15L,1L,4L,7L,10L,13L,16L,2L,5L,8L,11L,14L,0L,17L,3L,6L,9L,12L,15L,1L,18L,4L,7L,10L,13L,16L,2L,19L,5L,8L,11L,14L,0L,17L,3L,20L,6L,9L,12L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025637Inst : IEnumerable<long>
{
public static readonly long[] Value=A025637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025637.Bytes);
public long this[int i]=>Value[i];

public static A025637Inst Instance=new A025637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025638
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,4L,1L,5L,2L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,10L,7L,4L,1L,11L,8L,5L,2L,12L,9L,6L,3L,0L,13L,10L,7L,4L,1L,14L,11L,8L,5L,2L,15L,12L,9L,6L,3L,0L,16L,13L,10L,7L,4L,1L,17L,14L,11L,8L,5L,2L,18L,15L,12L,9L,6L,3L,19L,0L,16L,13L,10L,7L,4L,20L,1L,17L,14L,11L,8L,5L,21L,2L,18L,15L,12L,9L,6L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025638Inst : IEnumerable<long>
{
public static readonly long[] Value=A025638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025638.Bytes);
public long this[int i]=>Value[i];

public static A025638Inst Instance=new A025638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025639
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,4L,1L,5L,2L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,10L,7L,4L,1L,11L,8L,5L,2L,12L,9L,6L,3L,13L,0L,10L,7L,4L,14L,1L,11L,8L,5L,15L,2L,12L,9L,6L,16L,3L,13L,0L,10L,7L,17L,4L,14L,1L,11L,8L,18L,5L,15L,2L,12L,9L,19L,6L,16L,3L,13L,0L,10L,20L,7L,17L,4L,14L,1L,11L,21L,8L,18L,5L,15L,2L,12L,22L,9L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025639Inst : IEnumerable<long>
{
public static readonly long[] Value=A025639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025639.Bytes);
public long this[int i]=>Value[i];

public static A025639Inst Instance=new A025639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025640
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,5L,0L,4L,3L,2L,6L,1L,5L,0L,4L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,9L,4L,8L,3L,7L,2L,6L,1L,10L,5L,0L,9L,4L,8L,3L,7L,2L,11L,6L,1L,10L,5L,0L,9L,4L,8L,3L,12L,7L,2L,11L,6L,1L,10L,5L,0L,9L,4L,13L,8L,3L,12L,7L,2L,11L,6L,1L,10L,5L,0L,14L,9L,4L,13L,8L,3L,12L,7L,2L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025640Inst : IEnumerable<long>
{
public static readonly long[] Value=A025640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025640.Bytes);
public long this[int i]=>Value[i];

public static A025640Inst Instance=new A025640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025641
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,2L,4L,1L,3L,0L,5L,2L,4L,1L,6L,3L,0L,5L,2L,7L,4L,1L,6L,3L,8L,0L,5L,2L,7L,4L,9L,1L,6L,3L,8L,0L,5L,10L,2L,7L,4L,9L,1L,6L,11L,3L,8L,0L,5L,10L,2L,7L,12L,4L,9L,1L,6L,11L,3L,8L,13L,0L,5L,10L,2L,7L,12L,4L,9L,14L,1L,6L,11L,3L,8L,13L,0L,5L,10L,15L,2L,7L,12L,4L,9L,14L,1L,6L,11L,16L,3L,8L,13L,0L,5L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025641Inst : IEnumerable<long>
{
public static readonly long[] Value=A025641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025641.Bytes);
public long this[int i]=>Value[i];

public static A025641Inst Instance=new A025641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025642
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,2L,4L,1L,3L,5L,0L,2L,4L,6L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,0L,9L,2L,4L,6L,8L,1L,10L,3L,5L,7L,0L,9L,2L,11L,4L,6L,8L,1L,10L,3L,12L,5L,7L,0L,9L,2L,11L,4L,13L,6L,8L,1L,10L,3L,12L,5L,14L,7L,0L,9L,2L,11L,4L,13L,6L,15L,8L,1L,10L,3L,12L,5L,14L,7L,0L,16L,9L,2L,11L,4L,13L,6L,15L,8L,1L,17L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025642Inst : IEnumerable<long>
{
public static readonly long[] Value=A025642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025642.Bytes);
public long this[int i]=>Value[i];

public static A025642Inst Instance=new A025642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025643
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,2L,4L,1L,3L,5L,0L,2L,4L,6L,1L,3L,5L,7L,0L,2L,4L,6L,8L,1L,3L,5L,7L,9L,0L,2L,4L,6L,8L,10L,1L,3L,5L,7L,9L,11L,0L,2L,4L,6L,8L,10L,12L,1L,3L,5L,7L,9L,11L,13L,0L,2L,4L,6L,8L,10L,12L,14L,1L,3L,5L,7L,9L,11L,13L,15L,0L,2L,4L,6L,8L,10L,12L,14L,16L,1L,3L,5L,7L,9L,11L,13L,15L,17L,0L,2L,4L,6L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025643Inst : IEnumerable<long>
{
public static readonly long[] Value=A025643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025643.Bytes);
public long this[int i]=>Value[i];

public static A025643Inst Instance=new A025643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025644
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,2L,0L,5L,3L,1L,6L,4L,2L,0L,7L,5L,3L,1L,8L,6L,4L,2L,0L,9L,7L,5L,3L,1L,10L,8L,6L,4L,2L,0L,11L,9L,7L,5L,3L,1L,12L,10L,8L,6L,4L,2L,0L,13L,11L,9L,7L,5L,3L,1L,14L,12L,10L,8L,6L,4L,2L,0L,15L,13L,11L,9L,7L,5L,3L,1L,16L,14L,12L,10L,8L,6L,4L,2L,0L,17L,15L,13L,11L,9L,7L,5L,3L,1L,18L,16L,14L,12L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025644Inst : IEnumerable<long>
{
public static readonly long[] Value=A025644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025644.Bytes);
public long this[int i]=>Value[i];

public static A025644Inst Instance=new A025644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025661
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,6L,5L,4L,3L,2L,1L,0L,7L,6L,5L,4L,3L,2L,1L,8L,0L,7L,6L,5L,4L,3L,2L,9L,1L,8L,0L,7L,6L,5L,4L,3L,10L,2L,9L,1L,8L,0L,7L,6L,5L,4L,11L,3L,10L,2L,9L,1L,8L,0L,7L,6L,5L,12L,4L,11L,3L,10L,2L,9L,1L,8L,0L,7L,6L,13L,5L,12L,4L,11L,3L,10L,2L,9L,1L,8L,0L,7L,14L,6L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025661Inst : IEnumerable<long>
{
public static readonly long[] Value=A025661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025661.Bytes);
public long this[int i]=>Value[i];

public static A025661Inst Instance=new A025661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025662
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,6L,0L,5L,4L,3L,2L,7L,1L,6L,0L,5L,4L,3L,8L,2L,7L,1L,6L,0L,5L,4L,9L,3L,8L,2L,7L,1L,6L,0L,5L,10L,4L,9L,3L,8L,2L,7L,1L,6L,11L,0L,5L,10L,4L,9L,3L,8L,2L,7L,12L,1L,6L,11L,0L,5L,10L,4L,9L,3L,8L,13L,2L,7L,12L,1L,6L,11L,0L,5L,10L,4L,9L,14L,3L,8L,13L,2L,7L,12L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025662Inst : IEnumerable<long>
{
public static readonly long[] Value=A025662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025662.Bytes);
public long this[int i]=>Value[i];

public static A025662Inst Instance=new A025662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025663
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,5L,0L,4L,3L,2L,6L,1L,5L,0L,4L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,9L,4L,8L,3L,7L,2L,6L,1L,10L,5L,0L,9L,4L,8L,3L,7L,2L,11L,6L,1L,10L,5L,0L,9L,4L,8L,3L,12L,7L,2L,11L,6L,1L,10L,5L,0L,9L,4L,13L,8L,3L,12L,7L,2L,11L,6L,1L,10L,5L,14L,0L,9L,4L,13L,8L,3L,12L,7L,2L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025663Inst : IEnumerable<long>
{
public static readonly long[] Value=A025663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025663.Bytes);
public long this[int i]=>Value[i];

public static A025663Inst Instance=new A025663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025664
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,4L,3L,2L,1L,0L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,6L,0L,5L,4L,3L,2L,1L,6L,0L,5L,4L,3L,2L,1L,6L,0L,5L,4L,3L,2L,7L,1L,6L,0L,5L,4L,3L,2L,7L,1L,6L,0L,5L,4L,3L,2L,7L,1L,6L,0L,5L,4L,3L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025664Inst : IEnumerable<long>
{
public static readonly long[] Value=A025664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025664.Bytes);
public long this[int i]=>Value[i];

public static A025664Inst Instance=new A025664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025665
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,4L,3L,2L,1L,5L,0L,4L,3L,2L,1L,5L,0L,4L,3L,2L,6L,1L,5L,0L,4L,3L,2L,6L,1L,5L,0L,4L,3L,7L,2L,6L,1L,5L,0L,4L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,9L,0L,4L,8L,3L,7L,2L,6L,1L,5L,9L,0L,4L,8L,3L,7L,2L,6L,10L,1L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025665Inst : IEnumerable<long>
{
public static readonly long[] Value=A025665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025665.Bytes);
public long this[int i]=>Value[i];

public static A025665Inst Instance=new A025665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025666
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,0L,3L,1L,2L,0L,3L,1L,4L,2L,0L,3L,1L,4L,2L,0L,5L,3L,1L,4L,2L,0L,5L,3L,1L,6L,4L,2L,0L,5L,3L,1L,6L,4L,2L,7L,0L,5L,3L,1L,6L,4L,2L,7L,0L,5L,3L,8L,1L,6L,4L,2L,7L,0L,5L,3L,8L,1L,6L,4L,9L,2L,7L,0L,5L,3L,8L,1L,6L,4L,9L,2L,7L,0L,5L,10L,3L,8L,1L,6L,4L,9L,2L,7L,0L,5L,10L,3L,8L,1L,6L,11L,4L,9L,2L,7L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025666Inst : IEnumerable<long>
{
public static readonly long[] Value=A025666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025666.Bytes);
public long this[int i]=>Value[i];

public static A025666Inst Instance=new A025666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025667
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,5L,1L,2L,3L,4L,0L,5L,1L,6L,2L,3L,4L,0L,5L,1L,6L,2L,7L,3L,4L,0L,5L,1L,6L,2L,7L,3L,8L,4L,0L,5L,1L,6L,2L,7L,3L,8L,4L,9L,0L,5L,1L,6L,2L,7L,3L,8L,4L,9L,0L,5L,10L,1L,6L,2L,7L,3L,8L,4L,9L,0L,5L,10L,1L,6L,11L,2L,7L,3L,8L,4L,9L,0L,5L,10L,1L,6L,11L,2L,7L,12L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025667Inst : IEnumerable<long>
{
public static readonly long[] Value=A025667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025667.Bytes);
public long this[int i]=>Value[i];

public static A025667Inst Instance=new A025667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025668
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,5L,6L,7L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,12L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025668Inst : IEnumerable<long>
{
public static readonly long[] Value=A025668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025668.Bytes);
public long this[int i]=>Value[i];

public static A025668Inst Instance=new A025668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025669
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,6L,5L,4L,3L,2L,1L,0L,7L,6L,5L,4L,3L,2L,1L,0L,8L,7L,6L,5L,4L,3L,2L,1L,0L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025669Inst : IEnumerable<long>
{
public static readonly long[] Value=A025669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025669.Bytes);
public long this[int i]=>Value[i];

public static A025669Inst Instance=new A025669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025670
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,6L,5L,4L,3L,2L,1L,0L,7L,6L,5L,4L,3L,2L,1L,0L,8L,7L,6L,5L,4L,3L,2L,1L,9L,0L,8L,7L,6L,5L,4L,3L,2L,10L,1L,9L,0L,8L,7L,6L,5L,4L,3L,11L,2L,10L,1L,9L,0L,8L,7L,6L,5L,4L,12L,3L,11L,2L,10L,1L,9L,0L,8L,7L,6L,5L,13L,4L,12L,3L,11L,2L,10L,1L,9L,0L,8L,7L,6L,14L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025670Inst : IEnumerable<long>
{
public static readonly long[] Value=A025670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025670.Bytes);
public long this[int i]=>Value[i];

public static A025670Inst Instance=new A025670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025671
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,6L,5L,4L,3L,2L,1L,7L,0L,6L,5L,4L,3L,2L,8L,1L,7L,0L,6L,5L,4L,3L,9L,2L,8L,1L,7L,0L,6L,5L,4L,10L,3L,9L,2L,8L,1L,7L,0L,6L,5L,11L,4L,10L,3L,9L,2L,8L,1L,7L,0L,6L,12L,5L,11L,4L,10L,3L,9L,2L,8L,1L,7L,13L,0L,6L,12L,5L,11L,4L,10L,3L,9L,2L,8L,14L,1L,7L,13L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025671Inst : IEnumerable<long>
{
public static readonly long[] Value=A025671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025671.Bytes);
public long this[int i]=>Value[i];

public static A025671Inst Instance=new A025671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025672
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,6L,5L,4L,3L,2L,1L,0L,6L,5L,4L,3L,2L,1L,0L,7L,6L,5L,4L,3L,2L,1L,0L,7L,6L,5L,4L,3L,2L,1L,0L,8L,7L,6L,5L,4L,3L,2L,1L,0L,8L,7L,6L,5L,4L,3L,2L,1L,0L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,9L,8L,7L,6L,5L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025672Inst : IEnumerable<long>
{
public static readonly long[] Value=A025672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025672.Bytes);
public long this[int i]=>Value[i];

public static A025672Inst Instance=new A025672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025673
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,0L,4L,1L,2L,3L,0L,4L,1L,5L,2L,3L,0L,4L,1L,5L,2L,6L,3L,0L,4L,1L,5L,2L,6L,3L,0L,7L,4L,1L,5L,2L,6L,3L,0L,7L,4L,1L,8L,5L,2L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,10L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,10L,0L,7L,4L,11L,1L,8L,5L,2L,9L,6L,3L,10L,0L,7L,4L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025673Inst : IEnumerable<long>
{
public static readonly long[] Value=A025673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025673.Bytes);
public long this[int i]=>Value[i];

public static A025673Inst Instance=new A025673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025674
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,5L,6L,0L,7L,1L,2L,3L,4L,5L,6L,0L,7L,1L,8L,2L,3L,4L,5L,6L,0L,7L,1L,8L,2L,9L,3L,4L,5L,6L,0L,7L,1L,8L,2L,9L,3L,10L,4L,5L,6L,0L,7L,1L,8L,2L,9L,3L,10L,4L,11L,5L,6L,0L,7L,1L,8L,2L,9L,3L,10L,4L,11L,5L,12L,6L,0L,7L,1L,8L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025674Inst : IEnumerable<long>
{
public static readonly long[] Value=A025674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025674.Bytes);
public long this[int i]=>Value[i];

public static A025674Inst Instance=new A025674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025675
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,5L,6L,7L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025675Inst : IEnumerable<long>
{
public static readonly long[] Value=A025675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025675.Bytes);
public long this[int i]=>Value[i];

public static A025675Inst Instance=new A025675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025676
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,5L,4L,3L,2L,1L,0L,6L,5L,4L,3L,2L,1L,0L,7L,6L,5L,4L,3L,2L,1L,0L,8L,7L,6L,5L,4L,3L,2L,1L,0L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025676Inst : IEnumerable<long>
{
public static readonly long[] Value=A025676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025676.Bytes);
public long this[int i]=>Value[i];

public static A025676Inst Instance=new A025676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025693
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,12L,15L,18L,22L,26L,30L,35L,40L,45L,51L,57L,64L,71L,78L,86L,94L,102L,111L,120L,129L,139L,149L,159L,170L,181L,193L,205L,217L,230L,243L,256L,270L,284L,298L,313L,328L,343L,359L,375L,392L,409L,426L,444L,462L,480L,499L,518L,537L,557L,577L,597L,618L,639L,661L,683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025693Inst : IEnumerable<long>
{
public static readonly long[] Value=A025693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025693.Bytes);
public long this[int i]=>Value[i];

public static A025693Inst Instance=new A025693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025694
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,13L,16L,19L,23L,27L,31L,36L,41L,46L,52L,58L,64L,70L,77L,84L,91L,99L,107L,115L,124L,133L,142L,152L,162L,172L,183L,194L,205L,217L,229L,241L,253L,266L,279L,292L,306L,320L,334L,349L,364L,379L,395L,411L,427L,444L,461L,478L,496L,514L,532L,550L,569L,588L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025694Inst : IEnumerable<long>
{
public static readonly long[] Value=A025694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025694.Bytes);
public long this[int i]=>Value[i];

public static A025694Inst Instance=new A025694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025695
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,13L,16L,19L,23L,27L,31L,35L,40L,45L,50L,56L,62L,68L,75L,82L,89L,96L,104L,112L,120L,129L,138L,147L,157L,167L,177L,187L,198L,209L,220L,232L,244L,256L,269L,282L,295L,308L,322L,336L,350L,365L,380L,395L,411L,427L,443L,459L,476L,493L,510L,528L,546L,564L,583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025695Inst : IEnumerable<long>
{
public static readonly long[] Value=A025695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025695.Bytes);
public long this[int i]=>Value[i];

public static A025695Inst Instance=new A025695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025696
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,15L,20L,26L,33L,41L,49L,58L,68L,79L,91L,103L,116L,130L,145L,161L,177L,194L,212L,231L,251L,271L,292L,314L,337L,360L,384L,409L,435L,462L,489L,517L,546L,576L,607L,638L,670L,703L,737L,772L,807L,843L,880L,918L,957L,996L,1036L,1077L,1119L,1162L,1205L,1249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025696Inst : IEnumerable<long>
{
public static readonly long[] Value=A025696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025696.Bytes);
public long this[int i]=>Value[i];

public static A025696Inst Instance=new A025696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025697
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,13L,17L,22L,27L,33L,40L,47L,55L,63L,72L,82L,92L,103L,115L,127L,140L,153L,167L,182L,197L,213L,229L,246L,264L,282L,301L,321L,341L,362L,383L,405L,428L,451L,475L,499L,524L,550L,576L,603L,630L,658L,687L,716L,746L,777L,808L,840L,872L,905L,939L,973L,1008L,1043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025697Inst : IEnumerable<long>
{
public static readonly long[] Value=A025697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025697.Bytes);
public long this[int i]=>Value[i];

public static A025697Inst Instance=new A025697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025698
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,16L,20L,25L,31L,37L,44L,51L,59L,67L,76L,86L,96L,107L,118L,130L,142L,155L,168L,182L,197L,212L,228L,244L,261L,278L,296L,315L,334L,354L,374L,395L,416L,438L,461L,484L,508L,532L,557L,582L,608L,634L,661L,689L,717L,746L,775L,805L,835L,866L,898L,930L,963L,996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025698Inst : IEnumerable<long>
{
public static readonly long[] Value=A025698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025698.Bytes);
public long this[int i]=>Value[i];

public static A025698Inst Instance=new A025698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025699
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,16L,20L,25L,30L,36L,42L,49L,56L,64L,72L,81L,90L,100L,111L,122L,134L,146L,159L,172L,186L,200L,215L,230L,246L,262L,279L,296L,314L,332L,351L,371L,391L,412L,433L,455L,477L,500L,523L,547L,571L,596L,621L,647L,673L,700L,727L,755L,784L,813L,843L,873L,904L,935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025699Inst : IEnumerable<long>
{
public static readonly long[] Value=A025699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025699.Bytes);
public long this[int i]=>Value[i];

public static A025699Inst Instance=new A025699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025700
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,13L,17L,21L,26L,31L,37L,43L,50L,57L,65L,73L,82L,91L,101L,111L,122L,133L,144L,156L,168L,181L,194L,208L,222L,237L,252L,268L,284L,301L,318L,336L,354L,373L,392L,412L,432L,453L,474L,495L,517L,539L,562L,585L,609L,633L,658L,683L,709L,735L,762L,789L,817L,845L,874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025700Inst : IEnumerable<long>
{
public static readonly long[] Value=A025700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025700.Bytes);
public long this[int i]=>Value[i];

public static A025700Inst Instance=new A025700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025701
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,23L,31L,40L,51L,63L,76L,90L,106L,123L,141L,160L,181L,203L,226L,250L,276L,303L,331L,361L,392L,424L,457L,492L,528L,565L,603L,643L,684L,726L,769L,814L,860L,907L,955L,1005L,1056L,1108L,1161L,1216L,1272L,1329L,1388L,1448L,1509L,1571L,1635L,1700L,1766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025701Inst : IEnumerable<long>
{
public static readonly long[] Value=A025701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025701.Bytes);
public long this[int i]=>Value[i];

public static A025701Inst Instance=new A025701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025702
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,29L,36L,44L,53L,63L,74L,86L,99L,112L,126L,141L,157L,174L,192L,211L,230L,250L,271L,293L,316L,340L,365L,390L,416L,443L,471L,500L,530L,561L,593L,625L,658L,692L,727L,763L,800L,838L,876L,915L,955L,996L,1038L,1081L,1125L,1169L,1214L,1260L,1307L,1355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025702Inst : IEnumerable<long>
{
public static readonly long[] Value=A025702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025702.Bytes);
public long this[int i]=>Value[i];

public static A025702Inst Instance=new A025702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025703
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,15L,20L,26L,33L,40L,48L,57L,67L,78L,89L,101L,114L,128L,142L,157L,173L,190L,208L,226L,245L,265L,286L,307L,329L,352L,376L,400L,425L,451L,478L,506L,534L,563L,593L,624L,655L,687L,720L,754L,789L,824L,860L,897L,935L,973L,1012L,1052L,1093L,1135L,1177L,1220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025703Inst : IEnumerable<long>
{
public static readonly long[] Value=A025703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025703.Bytes);
public long this[int i]=>Value[i];

public static A025703Inst Instance=new A025703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025704
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,14L,19L,24L,30L,37L,45L,53L,62L,72L,82L,93L,105L,118L,131L,145L,160L,175L,191L,208L,226L,244L,263L,283L,303L,324L,346L,369L,392L,416L,441L,466L,492L,519L,547L,575L,604L,634L,664L,695L,727L,760L,793L,827L,862L,897L,933L,970L,1008L,1046L,1085L,1125L,1165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025704Inst : IEnumerable<long>
{
public static readonly long[] Value=A025704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025704.Bytes);
public long this[int i]=>Value[i];

public static A025704Inst Instance=new A025704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025705
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,13L,17L,22L,27L,33L,40L,47L,55L,63L,72L,82L,92L,103L,114L,126L,139L,152L,166L,180L,195L,211L,227L,244L,261L,279L,298L,317L,337L,357L,378L,400L,422L,445L,468L,492L,517L,542L,568L,594L,621L,649L,677L,706L,735L,765L,796L,827L,859L,891L,924L,958L,992L,1027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025705Inst : IEnumerable<long>
{
public static readonly long[] Value=A025705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025705.Bytes);
public long this[int i]=>Value[i];

public static A025705Inst Instance=new A025705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025706
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,21L,28L,37L,47L,58L,70L,83L,97L,113L,130L,148L,167L,187L,208L,231L,255L,280L,306L,333L,361L,391L,422L,454L,487L,521L,556L,592L,630L,669L,709L,750L,792L,835L,880L,926L,973L,1021L,1070L,1120L,1172L,1225L,1279L,1334L,1390L,1447L,1506L,1566L,1627L,1689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025706Inst : IEnumerable<long>
{
public static readonly long[] Value=A025706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025706.Bytes);
public long this[int i]=>Value[i];

public static A025706Inst Instance=new A025706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025707
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,29L,37L,46L,55L,65L,76L,88L,101L,115L,130L,146L,163L,181L,199L,218L,238L,259L,281L,304L,328L,353L,379L,406L,433L,461L,490L,520L,551L,583L,616L,650L,685L,721L,757L,794L,832L,871L,911L,952L,994L,1037L,1081L,1126L,1171L,1217L,1264L,1312L,1361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025707Inst : IEnumerable<long>
{
public static readonly long[] Value=A025707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025707.Bytes);
public long this[int i]=>Value[i];

public static A025707Inst Instance=new A025707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025708
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,21L,27L,34L,42L,51L,61L,71L,82L,94L,107L,121L,136L,151L,167L,184L,202L,221L,241L,261L,282L,304L,327L,351L,375L,400L,426L,453L,481L,510L,539L,569L,600L,632L,665L,699L,733L,768L,804L,841L,879L,918L,957L,997L,1038L,1080L,1123L,1167L,1211L,1256L,1302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025708Inst : IEnumerable<long>
{
public static readonly long[] Value=A025708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025708.Bytes);
public long this[int i]=>Value[i];

public static A025708Inst Instance=new A025708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025725
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,29L,37L,46L,56L,67L,79L,92L,106L,121L,136L,152L,169L,187L,206L,226L,247L,269L,292L,316L,341L,367L,394L,422L,451L,481L,511L,542L,574L,607L,641L,676L,712L,749L,787L,826L,866L,907L,949L,992L,1036L,1080L,1125L,1171L,1218L,1266L,1315L,1365L,1416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025725Inst : IEnumerable<long>
{
public static readonly long[] Value=A025725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025725.Bytes);
public long this[int i]=>Value[i];

public static A025725Inst Instance=new A025725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025726
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,29L,37L,45L,54L,64L,75L,87L,100L,114L,129L,145L,161L,178L,196L,215L,235L,256L,278L,301L,325L,349L,374L,400L,427L,455L,484L,514L,545L,576L,608L,641L,675L,710L,746L,783L,821L,860L,899L,939L,980L,1022L,1065L,1109L,1154L,1200L,1247L,1294L,1342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025726Inst : IEnumerable<long>
{
public static readonly long[] Value=A025726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025726.Bytes);
public long this[int i]=>Value[i];

public static A025726Inst Instance=new A025726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025727
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,28L,35L,43L,52L,62L,73L,84L,96L,109L,123L,138L,154L,171L,188L,206L,225L,245L,266L,288L,310L,333L,357L,382L,408L,435L,463L,491L,520L,550L,581L,613L,646L,679L,713L,748L,784L,821L,859L,898L,937L,977L,1018L,1060L,1103L,1147L,1191L,1236L,1282L,1329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025727Inst : IEnumerable<long>
{
public static readonly long[] Value=A025727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025727.Bytes);
public long this[int i]=>Value[i];

public static A025727Inst Instance=new A025727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025728
{
public static readonly long[] Value={ 1L,3L,7L,13L,21L,31L,43L,57L,73L,91L,110L,131L,154L,179L,206L,235L,266L,299L,334L,370L,408L,448L,490L,534L,580L,628L,678L,730L,783L,838L,895L,954L,1015L,1078L,1143L,1210L,1279L,1350L,1422L,1496L,1572L,1650L,1730L,1812L,1896L,1982L,2070L,2159L,2250L,2343L,2438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025728Inst : IEnumerable<long>
{
public static readonly long[] Value=A025728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025728.Bytes);
public long this[int i]=>Value[i];

public static A025728Inst Instance=new A025728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025729
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,23L,31L,41L,52L,64L,77L,92L,108L,125L,144L,164L,185L,207L,231L,256L,282L,310L,339L,369L,401L,434L,468L,503L,540L,578L,617L,658L,700L,743L,787L,833L,880L,928L,978L,1029L,1081L,1134L,1189L,1245L,1302L,1361L,1421L,1482L,1545L,1609L,1674L,1740L,1808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025729Inst : IEnumerable<long>
{
public static readonly long[] Value=A025729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025729.Bytes);
public long this[int i]=>Value[i];

public static A025729Inst Instance=new A025729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025730
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,21L,28L,37L,47L,58L,70L,83L,97L,113L,130L,148L,167L,187L,208L,231L,255L,280L,306L,333L,361L,391L,422L,454L,487L,521L,556L,592L,630L,669L,709L,750L,792L,835L,880L,926L,973L,1021L,1070L,1120L,1172L,1225L,1279L,1334L,1390L,1447L,1506L,1566L,1627L,1689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025730Inst : IEnumerable<long>
{
public static readonly long[] Value=A025730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025730.Bytes);
public long this[int i]=>Value[i];

public static A025730Inst Instance=new A025730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025731
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,137L,155L,174L,194L,215L,237L,260L,284L,309L,335L,362L,390L,419L,449L,480L,513L,547L,582L,618L,655L,693L,732L,772L,813L,855L,898L,942L,987L,1033L,1081L,1130L,1180L,1231L,1283L,1336L,1390L,1445L,1501L,1558L,1616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025731Inst : IEnumerable<long>
{
public static readonly long[] Value=A025731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025731.Bytes);
public long this[int i]=>Value[i];

public static A025731Inst Instance=new A025731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025732
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,29L,37L,46L,56L,67L,79L,92L,106L,121L,137L,154L,172L,190L,209L,229L,250L,272L,295L,319L,344L,370L,397L,425L,454L,484L,515L,547L,580L,614L,649L,685L,721L,758L,796L,835L,875L,916L,958L,1001L,1045L,1090L,1136L,1183L,1231L,1280L,1330L,1381L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025732Inst : IEnumerable<long>
{
public static readonly long[] Value=A025732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025732.Bytes);
public long this[int i]=>Value[i];

public static A025732Inst Instance=new A025732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025733
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,29L,37L,46L,56L,66L,77L,89L,102L,116L,131L,147L,164L,182L,201L,220L,240L,261L,283L,306L,330L,355L,381L,408L,436L,464L,493L,523L,554L,586L,619L,653L,688L,724L,761L,799L,837L,876L,916L,957L,999L,1042L,1086L,1131L,1177L,1224L,1271L,1319L,1368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025733Inst : IEnumerable<long>
{
public static readonly long[] Value=A025733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025733.Bytes);
public long this[int i]=>Value[i];

public static A025733Inst Instance=new A025733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025734
{
public static readonly long[] Value={ 1L,5L,12L,22L,35L,51L,71L,94L,120L,149L,181L,216L,255L,297L,342L,390L,441L,495L,553L,614L,678L,745L,815L,888L,965L,1045L,1128L,1214L,1303L,1395L,1491L,1590L,1692L,1797L,1905L,2016L,2131L,2249L,2370L,2494L,2621L,2751L,2885L,3022L,3162L,3305L,3451L,3600L,3753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025734Inst : IEnumerable<long>
{
public static readonly long[] Value=A025734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025734.Bytes);
public long this[int i]=>Value[i];

public static A025734Inst Instance=new A025734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025735
{
public static readonly long[] Value={ 1L,3L,6L,11L,17L,24L,33L,43L,54L,67L,81L,97L,114L,132L,152L,173L,195L,219L,244L,270L,298L,327L,358L,390L,423L,458L,494L,531L,570L,610L,651L,694L,738L,784L,831L,879L,929L,980L,1032L,1086L,1141L,1197L,1255L,1314L,1375L,1437L,1500L,1565L,1631L,1698L,1767L,1837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025735Inst : IEnumerable<long>
{
public static readonly long[] Value=A025735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025735.Bytes);
public long this[int i]=>Value[i];

public static A025735Inst Instance=new A025735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025736
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,22L,30L,39L,49L,61L,74L,88L,103L,119L,137L,156L,176L,197L,220L,244L,269L,295L,322L,351L,381L,412L,444L,478L,513L,549L,586L,625L,665L,706L,748L,791L,836L,882L,929L,977L,1027L,1078L,1130L,1183L,1237L,1293L,1350L,1408L,1467L,1528L,1590L,1653L,1717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025736Inst : IEnumerable<long>
{
public static readonly long[] Value=A025736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025736.Bytes);
public long this[int i]=>Value[i];

public static A025736Inst Instance=new A025736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025737
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,21L,28L,36L,46L,57L,69L,82L,96L,111L,127L,144L,163L,183L,204L,226L,249L,273L,298L,324L,352L,381L,411L,442L,474L,507L,541L,577L,614L,652L,691L,731L,772L,814L,857L,902L,948L,995L,1043L,1092L,1142L,1193L,1245L,1299L,1354L,1410L,1467L,1525L,1584L,1644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025737Inst : IEnumerable<long>
{
public static readonly long[] Value=A025737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025737.Bytes);
public long this[int i]=>Value[i];

public static A025737Inst Instance=new A025737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025738
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,136L,153L,171L,191L,212L,234L,257L,281L,306L,332L,359L,387L,416L,446L,477L,509L,542L,576L,611L,647L,684L,723L,763L,804L,846L,889L,933L,978L,1024L,1071L,1119L,1168L,1218L,1269L,1321L,1374L,1428L,1483L,1540L,1598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025738Inst : IEnumerable<long>
{
public static readonly long[] Value=A025738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025738.Bytes);
public long this[int i]=>Value[i];

public static A025738Inst Instance=new A025738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025739
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,29L,37L,46L,56L,67L,79L,92L,106L,121L,137L,154L,172L,191L,211L,232L,253L,275L,298L,322L,347L,373L,400L,428L,457L,487L,518L,550L,583L,617L,652L,688L,725L,763L,802L,842L,883L,925L,967L,1010L,1054L,1099L,1145L,1192L,1240L,1289L,1339L,1390L,1442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025739Inst : IEnumerable<long>
{
public static readonly long[] Value=A025739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025739.Bytes);
public long this[int i]=>Value[i];

public static A025739Inst Instance=new A025739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025740
{
public static readonly long[] Value={ 1L,5L,12L,22L,36L,53L,73L,97L,124L,154L,188L,225L,265L,309L,356L,406L,460L,517L,577L,641L,708L,778L,852L,929L,1009L,1093L,1180L,1270L,1364L,1461L,1561L,1664L,1771L,1881L,1994L,2111L,2231L,2354L,2481L,2611L,2744L,2881L,3021L,3164L,3311L,3461L,3614L,3771L,3931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025740Inst : IEnumerable<long>
{
public static readonly long[] Value=A025740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025740.Bytes);
public long this[int i]=>Value[i];

public static A025740Inst Instance=new A025740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025757
{
public static readonly long[] Value={ 1L,1L,7L,69L,783L,9597L,123495L,1643397L,22413183L,311466829L,4392857431L,62702224213L,903886452975L,13138698859677L,192337495360071L,2832859169364261L,41946319269028191L,624009420903043821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025757Inst : IEnumerable<long>
{
public static readonly long[] Value=A025757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025757.Bytes);
public long this[int i]=>Value[i];

public static A025757Inst Instance=new A025757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025758
{
public static readonly BigInteger[] Value={ 1L,1L,11L,171L,3056L,58916L,1191376L,24896436L,532911346L,11617952106L,256966100966L,5750337968926L,129926216608236L,2959472057112396L,67877180959091156L,1566072624078270516L,BigInteger.Parse("36319953436423545851") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025758Inst Instance=new A025758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025759
{
public static readonly BigInteger[] Value={ 1L,1L,16L,361L,9346L,260710L,7622290L,230167345L,7116228250L,224012186830L,7152402830440L,230999414308090L,7531444277855740L,247510726140787240L,8189274963276187990L,BigInteger.Parse("272537576338530727585"),BigInteger.Parse("9116110475685684958810"),BigInteger.Parse("306286229879232067776310") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025759Inst Instance=new A025759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025760
{
public static readonly BigInteger[] Value={ 1L,1L,22L,680L,24074L,917414L,36618492L,1508943612L,63643109727L,2732349490669L,118957846271104L,5237911268468572L,232794783971436296L,10427673857731312064UL,BigInteger.Parse("470213556090357498728"),BigInteger.Parse("21325335129901497816528") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025760Inst Instance=new A025760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025761
{
public static readonly BigInteger[] Value={ 1L,1L,29L,1177L,54629L,2726977L,142504685L,7685245225L,424109499317L,23818681210961L,1356315674712509L,78100982458201017L,4538960021319997189L,BigInteger.Parse("265837773438037013857"),BigInteger.Parse("15672475449746510425485") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025761Inst Instance=new A025761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025762
{
public static readonly BigInteger[] Value={ 1L,1L,37L,1909L,112483L,7123123L,472012183L,32269160215L,2256940619488L,160620490138312L,11588554266307408L,845405636848547320L,BigInteger.Parse("62239772654736987376"),BigInteger.Parse("4617428134374127211320"),BigInteger.Parse("344799253687326693132448") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025762Inst Instance=new A025762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025763
{
public static readonly BigInteger[] Value={ 1L,1L,46L,2941L,214486L,16801306L,1376657776L,116346220021L,10057692309166L,884572748725086L,78862377561315156L,7108473985655908626L,BigInteger.Parse("646575307673212875996"),BigInteger.Parse("59260508917444358016516") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A025763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A025763Inst Instance=new A025763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025764
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,16L,17L,19L,20L,22L,24L,26L,28L,30L,32L,34L,36L,39L,41L,44L,46L,49L,51L,54L,57L,60L,63L,66L,69L,72L,75L,79L,82L,86L,89L,93L,96L,100L,104L,108L,112L,116L,120L,124L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025764Inst : IEnumerable<long>
{
public static readonly long[] Value=A025764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025764.Bytes);
public long this[int i]=>Value[i];

public static A025764Inst Instance=new A025764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025765
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,49L,51L,54L,56L,59L,61L,64L,66L,69L,72L,75L,78L,81L,84L,87L,90L,93L,96L,100L,103L,107L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025765Inst : IEnumerable<long>
{
public static readonly long[] Value=A025765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025765.Bytes);
public long this[int i]=>Value[i];

public static A025765Inst Instance=new A025765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025766
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,59L,61L,64L,66L,69L,71L,74L,76L,79L,81L,84L,87L,90L,93L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025766Inst : IEnumerable<long>
{
public static readonly long[] Value=A025766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025766.Bytes);
public long this[int i]=>Value[i];

public static A025766Inst Instance=new A025766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025767
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,15L,17L,18L,20L,22L,24L,26L,28L,30L,33L,35L,37L,40L,43L,45L,48L,51L,54L,57L,60L,63L,67L,70L,73L,77L,81L,84L,88L,92L,96L,100L,104L,108L,113L,117L,121L,126L,131L,135L,140L,145L,150L,155L,160L,165L,171L,176L,181L,187L,193L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025767Inst : IEnumerable<long>
{
public static readonly long[] Value=A025767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025767.Bytes);
public long this[int i]=>Value[i];

public static A025767Inst Instance=new A025767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025768
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,4L,4L,5L,6L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,27L,28L,30L,32L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,54L,56L,58L,61L,63L,65L,68L,71L,73L,76L,79L,81L,84L,87L,90L,93L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025768Inst : IEnumerable<long>
{
public static readonly long[] Value=A025768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025768.Bytes);
public long this[int i]=>Value[i];

public static A025768Inst Instance=new A025768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025769
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,23L,24L,25L,27L,28L,30L,32L,33L,35L,37L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,61L,63L,65L,68L,70L,72L,75L,77L,80L,83L,85L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025769Inst : IEnumerable<long>
{
public static readonly long[] Value=A025769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025769.Bytes);
public long this[int i]=>Value[i];

public static A025769Inst Instance=new A025769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025770
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,35L,37L,38L,40L,42L,43L,45L,47L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,75L,77L,79L,82L,84L,86L,89L,91L,93L,96L,99L,101L,104L,107L,109L,112L,115L,117L,120L,123L,126L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025770Inst : IEnumerable<long>
{
public static readonly long[] Value=A025770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025770.Bytes);
public long this[int i]=>Value[i];

public static A025770Inst Instance=new A025770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025771
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,29L,30L,31L,33L,34L,35L,37L,38L,40L,42L,43L,45L,47L,48L,50L,52L,53L,55L,57L,59L,61L,63L,65L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025771Inst : IEnumerable<long>
{
public static readonly long[] Value=A025771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025771.Bytes);
public long this[int i]=>Value[i];

public static A025771Inst Instance=new A025771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025772
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,3L,3L,4L,5L,6L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,21L,23L,24L,25L,27L,29L,31L,32L,34L,36L,38L,40L,42L,44L,46L,48L,51L,53L,55L,57L,60L,63L,65L,67L,70L,73L,76L,78L,81L,84L,87L,90L,93L,96L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025772Inst : IEnumerable<long>
{
public static readonly long[] Value=A025772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025772.Bytes);
public long this[int i]=>Value[i];

public static A025772Inst Instance=new A025772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025789
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,3L,3L,4L,5L,6L,6L,6L,6L,6L,6L,7L,8L,9L,10L,10L,10L,10L,10L,11L,12L,13L,14L,15L,15L,15L,15L,16L,17L,18L,19L,20L,21L,21L,21L,22L,23L,24L,25L,26L,27L,28L,28L,29L,30L,31L,32L,33L,34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025789Inst : IEnumerable<long>
{
public static readonly long[] Value=A025789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025789.Bytes);
public long this[int i]=>Value[i];

public static A025789Inst Instance=new A025789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025790
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,10L,11L,11L,12L,12L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,18L,19L,20L,20L,21L,22L,22L,23L,24L,25L,26L,26L,27L,28L,28L,29L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025790Inst : IEnumerable<long>
{
public static readonly long[] Value=A025790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025790.Bytes);
public long this[int i]=>Value[i];

public static A025790Inst Instance=new A025790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025791
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,5L,6L,6L,6L,6L,6L,6L,6L,7L,8L,9L,10L,10L,10L,10L,10L,10L,11L,12L,13L,14L,15L,15L,15L,15L,15L,16L,17L,18L,19L,20L,21L,21L,21L,21L,22L,23L,24L,25L,26L,27L,28L,28L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025791Inst : IEnumerable<long>
{
public static readonly long[] Value=A025791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025791.Bytes);
public long this[int i]=>Value[i];

public static A025791Inst Instance=new A025791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025792
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,5L,5L,6L,6L,6L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,21L,22L,23L,23L,24L,24L,25L,25L,26L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025792Inst : IEnumerable<long>
{
public static readonly long[] Value=A025792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025792.Bytes);
public long this[int i]=>Value[i];

public static A025792Inst Instance=new A025792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025793
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,5L,6L,6L,6L,6L,6L,6L,6L,6L,7L,8L,9L,10L,10L,10L,10L,10L,10L,10L,11L,12L,13L,14L,15L,15L,15L,15L,15L,15L,16L,17L,18L,19L,20L,21L,21L,21L,21L,21L,22L,23L,24L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025793Inst : IEnumerable<long>
{
public static readonly long[] Value=A025793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025793.Bytes);
public long this[int i]=>Value[i];

public static A025793Inst Instance=new A025793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025794
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,8L,9L,10L,10L,10L,10L,10L,10L,10L,10L,11L,12L,13L,14L,15L,15L,15L,15L,15L,15L,15L,16L,17L,18L,19L,20L,21L,21L,21L,21L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025794Inst : IEnumerable<long>
{
public static readonly long[] Value=A025794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025794.Bytes);
public long this[int i]=>Value[i];

public static A025794Inst Instance=new A025794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025795
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,5L,6L,7L,7L,8L,9L,9L,11L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,21L,23L,24L,25L,27L,28L,29L,31L,32L,34L,35L,37L,38L,40L,42L,43L,45L,47L,48L,51L,52L,54L,56L,58L,60L,62L,64L,66L,68L,71L,72L,75L,77L,79L,82L,84L,86L,89L,91L,94L,96L,99L,101L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025795Inst : IEnumerable<long>
{
public static readonly long[] Value=A025795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025795.Bytes);
public long this[int i]=>Value[i];

public static A025795Inst Instance=new A025795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025796
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,3L,1L,3L,3L,3L,3L,6L,3L,6L,6L,6L,6L,10L,6L,10L,10L,10L,10L,15L,10L,15L,15L,15L,15L,21L,15L,21L,21L,21L,21L,28L,21L,28L,28L,28L,28L,36L,28L,36L,36L,36L,36L,45L,36L,45L,45L,45L,45L,55L,45L,55L,55L,55L,55L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025796Inst : IEnumerable<long>
{
public static readonly long[] Value=A025796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025796.Bytes);
public long this[int i]=>Value[i];

public static A025796Inst Instance=new A025796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025797
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,3L,2L,3L,3L,4L,3L,5L,4L,6L,5L,7L,6L,8L,7L,9L,8L,11L,9L,12L,11L,13L,12L,15L,13L,17L,15L,18L,17L,20L,18L,22L,20L,24L,22L,26L,24L,28L,26L,30L,28L,33L,30L,35L,33L,37L,35L,40L,37L,43L,40L,45L,43L,48L,45L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025797Inst : IEnumerable<long>
{
public static readonly long[] Value=A025797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025797.Bytes);
public long this[int i]=>Value[i];

public static A025797Inst Instance=new A025797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025798
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,5L,4L,5L,7L,5L,7L,8L,7L,8L,10L,8L,10L,12L,10L,12L,14L,12L,14L,16L,14L,16L,19L,16L,19L,21L,19L,21L,24L,21L,24L,27L,24L,27L,30L,27L,30L,33L,30L,33L,37L,33L,37L,40L,37L,40L,44L,40L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025798Inst : IEnumerable<long>
{
public static readonly long[] Value=A025798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025798.Bytes);
public long this[int i]=>Value[i];

public static A025798Inst Instance=new A025798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A025799
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,3L,2L,4L,3L,4L,4L,5L,4L,6L,5L,7L,6L,8L,7L,9L,8L,10L,9L,11L,10L,13L,11L,14L,13L,15L,14L,17L,15L,18L,17L,20L,18L,22L,20L,23L,22L,25L,23L,27L,25L,29L,27L,31L,29L,33L,31L,35L,33L,37L,35L,40L,37L,42L,40L,44L,42L,47L,44L,49L,47L,52L,49L,55L,52L,57L,55L,60L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A025799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A025799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A025799Inst : IEnumerable<long>
{
public static readonly long[] Value=A025799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A025799.Bytes);
public long this[int i]=>Value[i];

public static A025799Inst Instance=new A025799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}