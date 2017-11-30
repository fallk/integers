using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A202457
{
public static readonly long[] Value={ 1331L,2835L,5735L,10918L,19614L,33468L,54618L,85779L,130333L,192425L,277065L,390236L,539008L,731658L,977796L,1288497L,1676439L,2156047L,2743643L,3457602L,4318514L,5349352L,6575646L,8025663L,9730593L,11724741L,14045725L,16734680L };
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
public class A202457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202457Inst : IEnumerable<long>
{
public static readonly long[] Value=A202457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202457.Bytes);
public long this[int i]=>Value[i];

public static A202457Inst Instance=new A202457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202458
{
public static readonly long[] Value={ 1728L,4137L,9338L,19614L,38478L,71088L,124740L,209445L,338596L,529731L,805398L,1194128L,1731522L,2461458L,3437424L,4723983L,6398376L,8552269L,11293650L,14748882L,19064918L,24411684L,30984636L,39007497L,48735180L,60456903L,74499502L };
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
public class A202458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202458Inst : IEnumerable<long>
{
public static readonly long[] Value=A202458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202458.Bytes);
public long this[int i]=>Value[i];

public static A202458Inst Instance=new A202458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202459
{
public static readonly long[] Value={ 2197L,5854L,14586L,33468L,71088L,141192L,264822L,473031L,810265L,1338508L,2142292L,3334680L,5064336L,7523802L,10959108L,15680847L,22076853L,30626626L,41917654L,56663788L,75725832L,100134516L,131116026L,170120271L,218852073L,279305472L };
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
public class A202459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202459Inst : IEnumerable<long>
{
public static readonly long[] Value=A202459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202459.Bytes);
public long this[int i]=>Value[i];

public static A202459Inst Instance=new A202459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202460
{
public static readonly long[] Value={ 2744L,8064L,21972L,54618L,124740L,264822L,528390L,1000023L,1808746L,3145568L,5286030L,8618736L,13680954L,21202494L,32159196L,47837493L,69911652L,100535440L,142450112L,199110774L,274833336L,374964438L,506076906L,676193475L,895041702L };
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
public class A202460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202460Inst : IEnumerable<long>
{
public static readonly long[] Value=A202460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202460.Bytes);
public long this[int i]=>Value[i];

public static A202460Inst Instance=new A202460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202461
{
public static readonly long[] Value={ 512L,729L,729L,1000L,1194L,1000L,1331L,1876L,1876L,1331L,1728L,2835L,3362L,2835L,1728L,2197L,4137L,5735L,5735L,4137L,2197L,2744L,5854L,9338L,10918L,9338L,5854L,2744L,3375L,8064L,14586L,19614L,19614L,14586L,8064L,3375L,4096L,10851L,21972L,33468L,38478L };
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
public class A202461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202461Inst : IEnumerable<long>
{
public static readonly long[] Value=A202461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202461.Bytes);
public long this[int i]=>Value[i];

public static A202461Inst Instance=new A202461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202462
{
public static readonly long[] Value={ 1L,5L,21L,70L,214L,614L,1703L,4619L,12363L,32812L,86636L,228012L,598893L,1571089L,4118305L,10790194L,28262594L,74014290L,193807315L,507451415L,1328617751L,3478516440L,9107117016L,23843134680L,62422772569L,163425968669L,427856404653L };
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
public class A202462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202462Inst : IEnumerable<long>
{
public static readonly long[] Value=A202462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202462.Bytes);
public long this[int i]=>Value[i];

public static A202462Inst Instance=new A202462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202463
{
public static readonly long[] Value={ 4L,9L,216L,30L,20376L,432L,18000L,13338864L,15194736L,866452464L,5175273600L,35399473200L };
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
public class A202463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202463Inst : IEnumerable<long>
{
public static readonly long[] Value=A202463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202463.Bytes);
public long this[int i]=>Value[i];

public static A202463Inst Instance=new A202463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202464
{
public static readonly long[] Value={ 265L,1573L,9253L,54085L,317179L,1858993L,10894297L,63850777L,374215201L,2193190681L,12853833343L,75333557377L,441513844561L,2587618272973L,15165477047269L,88881616706701L,520916142332515L,3052978074328417L };
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
public class A202464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202464Inst : IEnumerable<long>
{
public static readonly long[] Value=A202464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202464.Bytes);
public long this[int i]=>Value[i];

public static A202464Inst Instance=new A202464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202465
{
public static readonly long[] Value={ 1573L,16561L,172197L,1774281L,18374521L,190112777L,1966463785L,20345296193L,210482281689L,2177526620233L,22527699867037L,233060360137857L,2411126165020333L,24944324990455409L,258061639015145685L };
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
public class A202465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202465Inst : IEnumerable<long>
{
public static readonly long[] Value=A202465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202465.Bytes);
public long this[int i]=>Value[i];

public static A202465Inst Instance=new A202465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202466
{
public static readonly BigInteger[] Value={ 9253L,172197L,3157010L,57262144L,1044865367L,19045287529L,347030298362L,6325139804762L,115276893817821L,2100921552416129L,38289856014452302L,697839603278397490L,12718251853368355369UL,BigInteger.Parse("231792595465614884173") };
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
public class A202466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202466Inst Instance=new A202466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202467
{
public static readonly BigInteger[] Value={ 54085L,1774281L,57262144L,1828904402L,58746383721L,1885066867201L,60472625443366L,1940390570621922L,62257900228006925L,1997548362431307729L,BigInteger.Parse("64092086253488512734"),BigInteger.Parse("2056411827878286085746"),BigInteger.Parse("65980528433359436484485") };
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
public class A202467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202467Inst Instance=new A202467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202468
{
public static readonly BigInteger[] Value={ 317179L,18374521L,1044865367L,58746383721L,3323590649777L,187820723381421L,10610932604054547L,599616560193259281L,BigInteger.Parse("33881738532796270907"),BigInteger.Parse("1914496303093962715299"),BigInteger.Parse("108180387260313623312899") };
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
public class A202468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202468Inst Instance=new A202468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202469
{
public static readonly BigInteger[] Value={ 1858993L,190112777L,19045287529L,1885066867201L,187820723381421L,18691199385898465L,1859521153822030023L,BigInteger.Parse("185045901525934158257"),BigInteger.Parse("18413176084400451943067"),BigInteger.Parse("1832207303424558956985631") };
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
public class A202469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202469Inst Instance=new A202469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202470
{
public static readonly BigInteger[] Value={ 10894297L,1966463785L,347030298362L,60472625443366L,10610932604054547L,1859521153822030023L,BigInteger.Parse("325778072452564800064"),BigInteger.Parse("57089473505402700427612"),BigInteger.Parse("10003712847692227326534941"),BigInteger.Parse("1752925427213891417645669229") };
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
public class A202470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202470Inst Instance=new A202470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202471
{
public static readonly long[] Value={ 265L,1573L,1573L,9253L,16561L,9253L,54085L,172197L,172197L,54085L,317179L,1774281L,3157010L,1774281L,317179L,1858993L,18374521L,57262144L,57262144L,18374521L,1858993L,10894297L,190112777L,1044865367L,1828904402L,1044865367L,190112777L };
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
public class A202471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202471Inst : IEnumerable<long>
{
public static readonly long[] Value=A202471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202471.Bytes);
public long this[int i]=>Value[i];

public static A202471Inst Instance=new A202471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202472
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,2L,3L,3L,3L,2L,6L,4L,3L,6L,3L,4L,6L,4L,5L,8L,4L,4L,7L,6L,4L,9L,8L,4L,11L,5L,5L,11L,6L,8L,9L,4L,7L,11L,7L,4L,13L,7L,5L,15L,7L,8L,13L,8L,9L,11L,7L,7L,13L,10L,5L,13L,7L,7L,19L,9L,8L,17L,9L,10L,16L,9L,9L,15L,12L,7L,19L,9L,7L,19L,9L,12L,17L,8L,14L };
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
public class A202472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202472Inst : IEnumerable<long>
{
public static readonly long[] Value=A202472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202472.Bytes);
public long this[int i]=>Value[i];

public static A202472Inst Instance=new A202472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202473
{
public static readonly long[] Value={ 2L,9L,7L,5L,4L,7L,1L,7L,1L,6L,5L,8L,4L,4L,0L,1L,6L,2L,9L,2L,7L,2L,4L,2L,1L,8L,5L,7L,7L,7L,2L,2L,5L,0L,3L,1L,0L,7L,9L,1L,2L,3L,5L,0L,2L,6L,6L,0L,9L,1L,3L,9L,4L,6L,4L,7L,9L,9L,6L,8L,6L,7L,3L,2L,5L,1L,0L,6L,6L,9L,5L,8L,9L,6L,8L,1L,0L,6L,2L,4L,0L,7L,6L,6L,5L,7L,4L,9L,4L,3L,9L,6L,6L,1L,4L,3L,9L,9L,6L,3L,3L,5L,6L,1L,8L };
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
public class A202473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202473Inst : IEnumerable<long>
{
public static readonly long[] Value=A202473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202473.Bytes);
public long this[int i]=>Value[i];

public static A202473Inst Instance=new A202473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202474
{
public static readonly BigInteger[] Value={ 1L,3L,14L,80L,539L,4179L,36630L,358056L,3860922L,45519870L,582466235L,8038684290L,119018991779L,1881685721265L,31638175704546L,563703015007056L,10609073237333432L,210305960538762456L,4379808881917047898L,BigInteger.Parse("95604092878386437940"),BigInteger.Parse("2182706554812339958778") };
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
public class A202474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202474.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202474Inst Instance=new A202474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202475
{
public static readonly long[] Value={ 3L,4L,5L,9L,8L,6L,5L,6L,4L,4L,0L,4L,4L,9L,9L,9L,1L,3L,4L,1L,8L,7L,8L,6L,1L,0L,8L,1L,0L,6L,8L,9L,8L,1L,2L,0L,2L,7L,7L,5L,1L,8L,4L,5L,9L,9L,0L,6L,4L,2L,8L,3L,1L,4L,5L,2L,9L,8L,0L,6L,8L,8L,7L,2L,8L,5L,8L,2L,5L,2L,2L,1L,2L,1L,1L,1L,4L,5L,1L,3L,1L,3L,8L,9L,7L,9L,2L };
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
public class A202475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202475Inst : IEnumerable<long>
{
public static readonly long[] Value=A202475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202475.Bytes);
public long this[int i]=>Value[i];

public static A202475Inst Instance=new A202475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202476
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,28L,74L,206L,601L,1826L,5766L,18851L,63676L,221678L,793958L,2920292L,11014653L,42543773L,168074091L,678403932L,2794920078L,11742254750L,50266213000L,219085792538L,971543475593L,4380664101448L,20071848941411L,93403455862117L,441206005123701L };
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
public class A202476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202476Inst : IEnumerable<long>
{
public static readonly long[] Value=A202476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202476.Bytes);
public long this[int i]=>Value[i];

public static A202476Inst Instance=new A202476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202477
{
public static readonly BigInteger[] Value={ 1L,1L,5L,40L,437L,6036L,100657L,1965160L,43937385L,1106488720L,30982333661L,954607270464L,32090625710365L,1168646120904640L,45826588690845705L,1924996299465966976L,BigInteger.Parse("86231288506425806033"),BigInteger.Parse("4103067277186778016000"),BigInteger.Parse("206655307175847710248885") };
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
public class A202477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202477Inst Instance=new A202477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202478
{
public static readonly long[] Value={ 3L,8L,7L,8L,2L };
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
public class A202478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202478Inst : IEnumerable<long>
{
public static readonly long[] Value=A202478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202478.Bytes);
public long this[int i]=>Value[i];

public static A202478Inst Instance=new A202478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202479
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,6L,4L,6L,6L,10L,6L,12L,9L,9L,8L,16L,9L,18L,10L,14L,15L,22L,10L,20L,18L,18L,15L,28L,15L,30L,16L,23L,24L,25L,16L,36L,27L,28L,19L,40L,21L,42L,25L,26L,33L,46L,20L,42L,30L,37L,30L,52L,27L,42L,28L,42L,42L,58L,23L,60L,45L,39L,32L,50L,35L,66L,40L,51L };
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
public class A202479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202479Inst : IEnumerable<long>
{
public static readonly long[] Value=A202479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202479.Bytes);
public long this[int i]=>Value[i];

public static A202479Inst Instance=new A202479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202480
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,1L,1L,0L,1L,-1L,1L,2L,-1L,-1L,1L,1L,5L,-5L,2L,1L,-1L,1L,9L,-10L,8L,-3L,-1L,1L,1L,14L,-14L,14L,-11L,4L,1L,-1L,1L,20L,-14L,14L,-17L,14L,-5L,-1L,1L,1L,27L,-6L,0L,-9L,19L,-17L,6L,1L,-1L };
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
public class A202480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202480Inst : IEnumerable<long>
{
public static readonly long[] Value=A202480.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202480.Bytes);
public long this[int i]=>Value[i];

public static A202480Inst Instance=new A202480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202481
{
public static readonly long[] Value={ 1L,10L,55L,231L,833L,2720L,8280L,23920L,66352L,178176L,465920L,1191680L,2991360L,7389184L,17999872L,43315200L,103116800L,243138560L,568393728L,1318518784L,3037265920L,6952058880L,15820390400L,35809918976L,80659611648L };
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
public class A202481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202481Inst : IEnumerable<long>
{
public static readonly long[] Value=A202481.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202481.Bytes);
public long this[int i]=>Value[i];

public static A202481Inst Instance=new A202481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202482
{
public static readonly long[] Value={ 1L,2L,10L,59L,385L,2672L,19336L,144218L,1100530L,8549888L,67386652L,537437222L,4328934754L,35162809688L,287688325672L,2368563539171L,19608128003473L,163116600371846L,1362822870625762L,11430476370562259L };
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
public class A202482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202482Inst : IEnumerable<long>
{
public static readonly long[] Value=A202482.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202482.Bytes);
public long this[int i]=>Value[i];

public static A202482Inst Instance=new A202482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202483
{
public static readonly long[] Value={ 1L,2L,1L,10L,4L,1L,59L,24L,6L,1L,385L,158L,42L,8L,1L,2672L,1106L,305L,64L,10L,1L,19336L,8064L,2283L,508L,90L,12L,1L,144218L,60541L,17484L,4052L,775L,120L,14L,1L,1100530L,464650L,136315L,32560L,6565L,1114L,154L,16L,1L };
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
public class A202483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202483Inst : IEnumerable<long>
{
public static readonly long[] Value=A202483.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202483.Bytes);
public long this[int i]=>Value[i];

public static A202483Inst Instance=new A202483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202484
{
public static readonly BigInteger[] Value={ 108L,1296L,42588L,3111696L,349399008L,75391979776L,34683335205048L,31497618411267856L,BigInteger.Parse("53353357774938031624"),BigInteger.Parse("175506661165679433462016"),BigInteger.Parse("1144167246050992881367449600"),BigInteger.Parse("14547294515194050040126081106176") };
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
public class A202484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202484Inst Instance=new A202484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202485
{
public static readonly long[] Value={ 108L,324L,1170L,4225L,14560L,50176L,174720L,608400L,2113020L,7338681L,25513362L,88698724L,308204050L,1070925625L,3722206950L,12937242564L,44959937760L,156246278400L,543023015040L,1887238517824L,6558819027904L,22794207851584L };
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
public class A202485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202485Inst : IEnumerable<long>
{
public static readonly long[] Value=A202485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202485.Bytes);
public long this[int i]=>Value[i];

public static A202485Inst Instance=new A202485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202486
{
public static readonly long[] Value={ 324L,1296L,6084L,28561L,132496L,614656L,2822400L,12960000L,59907600L,276922881L,1276847289L,5887339441L,27163984225L,125333700625L,578223368100L,2667616624656L,12306835772100L,56776601750625L,261938687630400L };
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
public class A202486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202486Inst : IEnumerable<long>
{
public static readonly long[] Value=A202486.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202486.Bytes);
public long this[int i]=>Value[i];

public static A202486Inst Instance=new A202486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202487
{
public static readonly long[] Value={ 1170L,6084L,42588L,298116L,1926288L,12446784L,81920160L,539168400L,3534548400L,23170928400L,152046773640L,997725295044L,6544683664680L,42930538579600L,281655584169120L,1847865662028864L,12122369483494680L,79525175944347225L };
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
public class A202487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202487Inst : IEnumerable<long>
{
public static readonly long[] Value=A202487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202487.Bytes);
public long this[int i]=>Value[i];

public static A202487Inst Instance=new A202487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202488
{
public static readonly long[] Value={ 4225L,28561L,298116L,3111696L,28005264L,252047376L,2377732644L,22430753361L,208538355600L,1938777760000L,18105705806400L,169084146471696L,1576826282769984L,14704992620052736L,137195887385735424L };
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
public class A202488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202488Inst : IEnumerable<long>
{
public static readonly long[] Value=A202488.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202488.Bytes);
public long this[int i]=>Value[i];

public static A202488Inst Instance=new A202488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202489
{
public static readonly long[] Value={ 14560L,132496L,1926288L,28005264L,349399008L,4359168576L,56953820952L,744118440129L,9593661694500L,123687762250000L,1600355267745000L,20706470360604900L,267678301470603000L,3460351852844410000L };
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
public class A202489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202489Inst : IEnumerable<long>
{
public static readonly long[] Value=A202489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202489.Bytes);
public long this[int i]=>Value[i];

public static A202489Inst Instance=new A202489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202490
{
public static readonly BigInteger[] Value={ 50176L,614656L,12446784L,252047376L,4359168576L,75391979776L,1364214656016L,24685405970481L,441349719305625L,7890879937890625L,141454688946390625L,2535766502901450625L,BigInteger.Parse("45440435551542015625"),BigInteger.Parse("814283641948594140625") };
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
public class A202490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202490Inst Instance=new A202490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202491
{
public static readonly BigInteger[] Value={ 174720L,2822400L,81920160L,2377732644L,56953820952L,1364214656016L,34683335205048L,881777464888644L,22015082631334650L,549644193193005625L,13795021325301502000UL,BigInteger.Parse("346228734374528569600"),BigInteger.Parse("8677470058423398780000") };
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
public class A202491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202491Inst Instance=new A202491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202492
{
public static readonly long[] Value={ 108L,324L,324L,1170L,1296L,1170L,4225L,6084L,6084L,4225L,14560L,28561L,42588L,28561L,14560L,50176L,132496L,298116L,298116L,132496L,50176L,174720L,614656L,1926288L,3111696L,1926288L,614656L,174720L,608400L,2822400L,12446784L,28005264L,28005264L };
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
public class A202492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202492Inst : IEnumerable<long>
{
public static readonly long[] Value=A202492.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202492.Bytes);
public long this[int i]=>Value[i];

public static A202492Inst Instance=new A202492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202493
{
public static readonly long[] Value={ 1L,15L,105L,532L,2241L,8361L,28610L,91740L,279624L,818272L,2315712L,6372480L,17123840L,45082368L,116596224L,296879104L,745543680L,1849344000L,4536958976L,11020075008L,26526547968L,63329075200L,150057123840L };
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
public class A202493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202493Inst : IEnumerable<long>
{
public static readonly long[] Value=A202493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202493.Bytes);
public long this[int i]=>Value[i];

public static A202493Inst Instance=new A202493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202494
{
public static readonly long[] Value={ 5L,2L,4L,6L,9L,0L,9L,7L,4L,5L,7L,7L,1L,4L,8L,7L,2L,4L,0L,9L,8L,7L,3L,6L,1L,1L,2L,8L,6L,0L,1L,8L,3L,5L,8L,5L,5L,4L,1L,9L,9L,2L,3L,5L,4L,6L,0L,0L,3L,1L,0L,9L,5L,1L,0L,3L,3L,8L,1L,7L,1L,3L,3L,0L,8L,4L,3L,6L,0L,6L,2L,1L,6L,7L,7L,8L,8L,9L,9L,7L,6L,0L,4L,5L,2L,2L,2L,3L,4L,4L,5L,6L,1L,0L,8L,4L,6L,4L,3L };
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
public class A202494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202494Inst : IEnumerable<long>
{
public static readonly long[] Value=A202494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202494.Bytes);
public long this[int i]=>Value[i];

public static A202494Inst Instance=new A202494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202495
{
public static readonly long[] Value={ 2L,3L,2L,3L,1L,3L,3L,8L,2L,5L,5L,5L,1L,8L,1L,6L,2L,2L,8L,9L,5L,5L,2L,5L,4L,6L,6L,8L,0L,9L,0L,5L,4L,6L,9L,9L,6L,0L,0L,6L,5L,5L,4L,0L,3L,7L,2L,9L,1L,0L,6L,2L,4L,0L,8L,2L,6L,5L,4L,5L,6L,7L,1L,7L,8L,1L,0L,2L,2L,7L,8L,1L,9L,9L,3L,8L,2L,6L,8L,1L,7L,5L,3L,4L,2L,0L,8L,9L,8L,2L,1L,8L,5L,6L,9L,6L,8L,3L,6L };
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
public class A202495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202495Inst : IEnumerable<long>
{
public static readonly long[] Value=A202495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202495.Bytes);
public long this[int i]=>Value[i];

public static A202495Inst Instance=new A202495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202496
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,8L,2L,3L,8L,9L,8L,7L,6L,4L,1L,2L,2L,9L,4L,8L,4L,6L,8L,7L,9L,7L,5L,2L,7L,1L,8L,4L,9L,2L,4L,4L,9L,3L,9L,1L,4L,7L,3L,6L,6L,1L,3L,6L,8L,6L,8L,7L,6L,8L,5L,2L,7L,6L,2L,6L,0L,1L,0L,7L,7L,7L,7L,3L,7L,9L,3L,6L,0L,8L,6L,4L,9L,8L,6L,4L,3L,3L,2L,1L,5L,5L,6L,8L,6L,0L,4L,1L,7L,7L,1L,0L,3L,4L,8L };
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
public class A202496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202496Inst : IEnumerable<long>
{
public static readonly long[] Value=A202496.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202496.Bytes);
public long this[int i]=>Value[i];

public static A202496Inst Instance=new A202496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202497
{
public static readonly long[] Value={ 1L,0L,8L,8L,5L,7L,5L,5L,2L,8L,7L,8L,5L,4L,5L,0L,5L,5L,3L,9L,7L,3L,7L,9L,1L,5L,2L,2L,1L,6L,5L,6L,4L,0L,7L,3L,9L,9L,4L,4L,4L,5L,9L,7L,4L,9L,8L,9L,8L,8L,5L,0L,0L,3L,4L,9L,0L,5L,1L,7L,3L,2L,1L,3L,6L,7L,0L,4L,2L,0L,4L,7L,1L,9L,5L,6L,0L,9L,2L,3L,1L,7L,5L,9L,3L,4L,6L,3L,6L,0L,3L,2L,2L,5L,1L,0L,1L,3L,7L };
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
public class A202497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202497Inst : IEnumerable<long>
{
public static readonly long[] Value=A202497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202497.Bytes);
public long this[int i]=>Value[i];

public static A202497Inst Instance=new A202497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202498
{
public static readonly long[] Value={ 4L,2L,6L,3L,0L,2L,7L,5L,1L,0L,0L,6L,8L,6L,2L,7L,4L,5L,6L,7L,3L,2L,3L,6L,2L,0L,7L,3L,4L,7L,6L,5L,8L,7L,3L,3L,4L,4L,9L,2L,2L,6L,6L,5L,0L,0L,7L,5L,7L,0L,1L,7L,5L,4L,3L,8L,6L,0L,5L,3L,6L,9L,7L,3L,2L,6L,2L,5L,7L,5L,3L,2L,8L,3L,7L,1L,3L,1L,5L,2L,2L,4L,4L,8L,2L,8L,8L,6L,8L,9L,1L,7L,5L,1L,2L,4L,7L,4L,2L };
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
public class A202498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202498Inst : IEnumerable<long>
{
public static readonly long[] Value=A202498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202498.Bytes);
public long this[int i]=>Value[i];

public static A202498Inst Instance=new A202498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202499
{
public static readonly long[] Value={ 3L,4L,9L,9L,6L,9L,6L,3L,1L,6L,5L,4L,6L,7L,9L,9L,8L,6L,6L,6L,2L,8L,9L,9L,0L,2L,3L,5L,1L,7L,6L,3L,2L,6L,3L,4L,8L,6L,3L,1L,5L,5L,6L,4L,7L,9L,0L,2L,1L,1L,3L,8L,1L,7L,6L,4L,4L,2L,9L,0L,5L,2L,7L,7L,7L,2L,2L,1L,6L,3L,5L,0L,1L,4L,8L,1L,4L,7L,6L,5L,2L,6L,2L,8L,5L,5L,9L,5L,5L,5L,6L,0L,7L,4L,7L,8L,2L,2L,4L };
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
public class A202499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202499Inst : IEnumerable<long>
{
public static readonly long[] Value=A202499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202499.Bytes);
public long this[int i]=>Value[i];

public static A202499Inst Instance=new A202499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202500
{
public static readonly long[] Value={ 3L,4L,1L,7L,5L,6L,0L,1L,7L,7L,8L,5L,8L,5L,6L,3L,9L,6L,8L,3L,1L,2L,6L,7L,1L,6L,6L,7L,7L,1L,7L,0L,5L,8L,3L,5L,1L,4L,5L,1L,6L,5L,4L,7L,6L,9L,3L,8L,9L,3L,9L,4L,4L,3L,6L,7L,5L,5L,6L,9L,3L,0L,1L,3L,5L,1L,5L,8L,2L,9L,7L,2L,2L,5L,1L,1L,9L,8L,9L,1L,2L,2L,4L,6L,7L,5L,1L,3L,1L,3L,8L,5L,9L,8L,8L,1L,3L,1L,2L };
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
public class A202500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202500Inst : IEnumerable<long>
{
public static readonly long[] Value=A202500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202500.Bytes);
public long this[int i]=>Value[i];

public static A202500Inst Instance=new A202500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202501
{
public static readonly long[] Value={ 4L,7L,4L,5L,4L,0L,9L,9L,9L,5L,1L,2L,6L,5L,1L,1L,2L,3L,0L,1L,7L,4L,6L,7L,9L,4L,4L,0L,4L,8L,2L,1L,2L,4L,5L,1L,1L,4L,9L,1L,0L,7L,6L,8L,0L,6L,5L,9L,9L,2L,6L,7L,1L,4L,0L,9L,8L,1L,3L,7L,9L,7L,2L,2L,7L,0L,6L,8L,8L,5L,5L,9L,8L,9L,9L,3L,3L,0L,8L,8L,5L,9L,8L,3L,1L,1L,4L,9L,3L,2L,0L,7L,0L,0L,5L,9L,0L,5L,9L };
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
public class A202501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202501Inst : IEnumerable<long>
{
public static readonly long[] Value=A202501.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202501.Bytes);
public long this[int i]=>Value[i];

public static A202501Inst Instance=new A202501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202502
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,3L,0L,0L,2L,5L,0L,0L,1L,3L,8L,0L,0L,0L,2L,5L,13L,0L,0L,0L,1L,3L,8L,21L,0L,0L,0L,0L,2L,5L,13L,34L,0L,0L,0L,0L,1L,3L,8L,21L,55L,0L,0L,0L,0L,0L,2L,5L,13L,34L,89L,0L,0L,0L,0L,0L,1L,3L,8L,21L,55L,144L,0L,0L,0L,0L,0L,0L,2L,5L,13L,34L,89L,233L,0L,0L,0L,0L,0L,0L,1L,3L,8L,21L,55L };
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
public class A202502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202502Inst : IEnumerable<long>
{
public static readonly long[] Value=A202502.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202502.Bytes);
public long this[int i]=>Value[i];

public static A202502Inst Instance=new A202502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202503
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,5L,5L,5L,5L,8L,9L,8L,8L,8L,13L,14L,15L,13L,13L,13L,21L,23L,24L,24L,21L,21L,21L,34L,37L,39L,39L,39L,34L,34L,34L,55L,60L,63L,64L,63L,63L,55L,55L,55L,89L,97L,102L,103L,104L,102L,102L,89L,89L,89L,144L,157L,165L,167L,168L,168L,165L,165L,144L,144L,144L };
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
public class A202503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202503Inst : IEnumerable<long>
{
public static readonly long[] Value=A202503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202503.Bytes);
public long this[int i]=>Value[i];

public static A202503Inst Instance=new A202503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202504
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,9L,7L,11L,13L,13L,23L,27L,39L,57L,73L,109L,149L,209L,305L,423L,615L,877L,1249L,1807L,2575L,3709L,5339L,7659L,11065L,15915L,22957L,33137L,47781L,69037L,99707L,144055L,208353L,301197L,435875L,630727L,913071L,1322233L,1915221L,2774755L };
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
public class A202504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202504Inst : IEnumerable<long>
{
public static readonly long[] Value=A202504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202504.Bytes);
public long this[int i]=>Value[i];

public static A202504Inst Instance=new A202504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202505
{
public static readonly long[] Value={ 1L,3L,5L,15L,21L,53L,109L,239L,489L,1051L,2253L,4853L,10511L,23033L,50791L,112187L,248217L,549917L,1220585L,2712351L,6037825L,13459637L,30045375L,67137267L,150165265L,336151499L,753099801L,1688448381L,3788174371L,8504582261L };
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
public class A202505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202505Inst : IEnumerable<long>
{
public static readonly long[] Value=A202505.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202505.Bytes);
public long this[int i]=>Value[i];

public static A202505Inst Instance=new A202505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202506
{
public static readonly long[] Value={ 1L,3L,15L,29L,95L,255L,747L,2215L,6649L,19967L,60145L,182003L,554625L,1691547L,5175093L,15875649L,48789933L,150258301L,463501341L,1431832723L,4429155217L,13716674493L,42524970155L,131966196475L,409893633219L,1274208141011L };
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
public class A202506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202506Inst : IEnumerable<long>
{
public static readonly long[] Value=A202506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202506.Bytes);
public long this[int i]=>Value[i];

public static A202506Inst Instance=new A202506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202507
{
public static readonly long[] Value={ 1L,5L,21L,75L,239L,883L,3285L,12619L,48079L,185533L,718529L,2793599L,10889311L,42597829L,167140877L,657518773L,2592183923L,10238899137L,40508826935L,160499036493L,636728024223L,2528978914493L,10055447397817L,40020622051941L };
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
public class A202507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202507Inst : IEnumerable<long>
{
public static readonly long[] Value=A202507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202507.Bytes);
public long this[int i]=>Value[i];

public static A202507Inst Instance=new A202507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202508
{
public static readonly long[] Value={ 1L,5L,27L,115L,529L,2369L,10799L,50519L,235731L,1110857L,5255015L,24917719L,118624427L,566325889L,2711707427L,13018061199L,62630442305L,301891809587L,1457550954737L,7047249198849L,34117462763559L,165364270152729L };
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
public class A202508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202508Inst : IEnumerable<long>
{
public static readonly long[] Value=A202508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202508.Bytes);
public long this[int i]=>Value[i];

public static A202508Inst Instance=new A202508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202509
{
public static readonly long[] Value={ 1L,7L,47L,217L,1041L,5429L,29295L,161469L,890659L,4953959L,27653867L,154912145L,870424381L,4906927687L,27742701519L,157251702011L,893270398075L,5083772866943L,28979759201581L,165434751255111L,945621770041509L };
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
public class A202509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202509Inst : IEnumerable<long>
{
public static readonly long[] Value=A202509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202509.Bytes);
public long this[int i]=>Value[i];

public static A202509Inst Instance=new A202509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202510
{
public static readonly long[] Value={ 1L,7L,57L,297L,1785L,11015L,68781L,436919L,2782455L,17852623L,114949893L,742430377L,4811939259L,31282061157L,203951966061L,1333111663347L,8732654184777L,57311401737559L,376739449264935L,2480070264283519L,16347300910687523L };
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
public class A202510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202510Inst : IEnumerable<long>
{
public static readonly long[] Value=A202510.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202510.Bytes);
public long this[int i]=>Value[i];

public static A202510Inst Instance=new A202510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202511
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,3L,5L,1L,1L,5L,15L,15L,5L,1L,5L,21L,29L,21L,9L,1L,7L,27L,75L,95L,53L,7L,1L,7L,47L,115L,239L,255L,109L,11L,1L,9L,57L,217L,529L,883L,747L,239L,13L,1L,9L,67L,297L,1041L,2369L,3285L,2215L,489L,13L,1L,11L,97L,479L,1785L,5429L,10799L,12619L,6649L,1051L,23L,1L,11L };
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
public class A202511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202511Inst : IEnumerable<long>
{
public static readonly long[] Value=A202511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202511.Bytes);
public long this[int i]=>Value[i];

public static A202511Inst Instance=new A202511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202512
{
public static readonly long[] Value={ 1L,15L,29L,75L,115L,217L,297L,479L,609L,887L,1091L,1493L,1765L,2315L,2689L,3399L,3875L,4777L,5373L,6491L,7213L,8555L,9439L,11041L,12061L,13947L,15157L,17331L,18719L,21221L,22809L,25663L,27453L,30659L,32699L,36301L,38545L,42567L,45089L,49527L,52303L,57205L };
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
public class A202512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202512Inst : IEnumerable<long>
{
public static readonly long[] Value=A202512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202512.Bytes);
public long this[int i]=>Value[i];

public static A202512Inst Instance=new A202512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202513
{
public static readonly long[] Value={ 5L,21L,95L,239L,529L,1041L,1785L,3009L,4655L,6937L,10007L,13823L,18963L,25151L,32837L,42225L,53147L,66679L,82163L,100347L,121523L,145299L,173373L,204621L,240115L,280223L,324311L,374807L,429953L,491279L,559193L,632717L,715225L,804133L,901479L };
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
public class A202513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202513Inst : IEnumerable<long>
{
public static readonly long[] Value=A202513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202513.Bytes);
public long this[int i]=>Value[i];

public static A202513Inst Instance=new A202513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202514
{
public static readonly long[] Value={ 9L,53L,255L,883L,2369L,5429L,11015L,20519L,35743L,58863L,92683L,140431L,206133L,294575L,410949L,561639L,753393L,994367L,1293591L,1660765L,2107089L,2644313L,3285935L,4046931L,4942529L,5990419L,7208417L,8617099L,10238327L,12094665L };
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
public class A202514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202514Inst : IEnumerable<long>
{
public static readonly long[] Value=A202514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202514.Bytes);
public long this[int i]=>Value[i];

public static A202514Inst Instance=new A202514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202515
{
public static readonly long[] Value={ 7L,109L,747L,3285L,10799L,29295L,68781L,145389L,282771L,514931L,887733L,1463059L,2320007L,3560523L,5310021L,7724815L,10991973L,15338839L,21031377L,28387187L,37770899L,49610615L,64391723L,82677087L,105095693L,132370313L,165301879L };
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
public class A202515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202515Inst : IEnumerable<long>
{
public static readonly long[] Value=A202515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202515.Bytes);
public long this[int i]=>Value[i];

public static A202515Inst Instance=new A202515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202516
{
public static readonly BigInteger[] Value={ 1L,5L,97L,14735L,22208431L,314664801905L,41448076127290195L,BigInteger.Parse("50905029765702161210225"),BigInteger.Parse("582983891132858366160979787245"),BigInteger.Parse("62080074367851800086180277369110042475"),BigInteger.Parse("61205889017397342360456211893643596980919936577") };
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
public class A202516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202516Inst Instance=new A202516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202517
{
public static readonly BigInteger[] Value={ 1L,1L,13L,2299L,4465027L,83649932869L,14413888012788031L,BigInteger.Parse("22412828378864422506133"),BigInteger.Parse("312169717565869706933620630009"),BigInteger.Parse("38865154523992131836783382601539858727"),BigInteger.Parse("43266472789023671032936589458127528396392744933") };
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
public class A202517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202517.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202517Inst Instance=new A202517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202518
{
public static readonly BigInteger[] Value={ 1L,1L,4L,111L,12600L,5722258L,10419647136L,76124127132667L,2234758718926030048L,BigInteger.Parse("263964471372716219981614"),BigInteger.Parse("125532541357451846737479404864"),BigInteger.Parse("240382906462440786858510574342553910"),BigInteger.Parse("1852958218856132372722626702327036659515008") };
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
public class A202518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202518Inst Instance=new A202518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202519
{
public static readonly long[] Value={ 1L,1L,7L,27L,165L,877L,5451L,32887L,210505L,1347865L,8859695L,58647219L,393704205L,2662542565L,18166847507L,124738843247L,861922384657L,5986483380145L,41780493605719L,292817777533259L,2060138522838645L,14544377538584925L,103007560370361691L,731635362026777831L };
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
public class A202519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202519Inst : IEnumerable<long>
{
public static readonly long[] Value=A202519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202519.Bytes);
public long this[int i]=>Value[i];

public static A202519Inst Instance=new A202519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202520
{
public static readonly BigInteger[] Value={ 3L,2835L,467775L,127702575L,350813659321125L,147926426347074375L,BigInteger.Parse("144228265688397515625"),BigInteger.Parse("84913182070036240111050234375"),BigInteger.Parse("206217727884373725983979140625"),BigInteger.Parse("45665884751355139750522260795703125"),BigInteger.Parse("48463572986198162681964482985158015982421875"),BigInteger.Parse("176412350932310924219767245054034888177646484375") };
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
public class A202520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202520Inst Instance=new A202520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202521
{
public static readonly long[] Value={ 4L,1L,6L,2L,3L,8L,9L,10L,11L,13L,12L,5L,14L,15L,16L,17L,18L,20L,21L,22L,7L,24L,25L,26L,27L,19L,28L,30L,32L,33L,101L,34L,35L,36L,38L,39L,103L };
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
public class A202521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202521Inst : IEnumerable<long>
{
public static readonly long[] Value=A202521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202521.Bytes);
public long this[int i]=>Value[i];

public static A202521Inst Instance=new A202521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202522
{
public static readonly BigInteger[] Value={ 15L,30L,1134L,17010L,364864500L,547296750L,390769879500L,976924698750L,58468943220187500L,17540682966056250L,3234019037547375000L,BigInteger.Parse("1397904728979852843750"),BigInteger.Parse("1054020165650809044187500"),BigInteger.Parse("10163765883061372926093750"),BigInteger.Parse("3396527282801449604442009375000"),BigInteger.Parse("2547395462101087203331507031250") };
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
public class A202522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202522Inst Instance=new A202522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202523
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,4L,0L,0L,0L,1L,0L,4L,0L,1L,0L,5L,0L,4L,0L,0L,0L,3L,0L,5L,0L,0L,0L,6L,0L,1L,1L,2L,0L,6L,0L,6L,1L,1L,0L,4L,0L,12L,0L,1L,1L,12L,1L,9L,0L,0L,1L,10L,0L,10L,0L,1L,2L,10L,1L,4L };
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
public class A202523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202523Inst : IEnumerable<long>
{
public static readonly long[] Value=A202523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202523.Bytes);
public long this[int i]=>Value[i];

public static A202523Inst Instance=new A202523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202524
{
public static readonly long[] Value={ 86L,518L,2263L,9746L,46621L,216973L,986000L,4557888L,21113706L,97219263L,448210042L,2069521757L,9547241581L };
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
public class A202524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202524Inst : IEnumerable<long>
{
public static readonly long[] Value=A202524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202524.Bytes);
public long this[int i]=>Value[i];

public static A202524Inst Instance=new A202524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202525
{
public static readonly long[] Value={ 86L,198L,417L,890L,1940L,4184L,8994L,19420L,41918L,90355L,194874L,420410L,906707L,1955533L,4217976L,9097605L,19621946L,42321918L,91282656L,196883149L,424648818L,915907828L,1975482000L,4260832180L,9190009191L,19821539577L,42752232438L };
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
public class A202525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202525Inst : IEnumerable<long>
{
public static readonly long[] Value=A202525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202525.Bytes);
public long this[int i]=>Value[i];

public static A202525Inst Instance=new A202525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202526
{
public static readonly long[] Value={ 198L,518L,1084L,2232L,4901L,10584L,22525L,48429L,104282L,223728L,480328L,1032213L,2217044L,4761249L,10227241L,21967770L,47183252L,101344728L,217680229L,467553984L,1004256629L,2157044997L,4633115818L,9951459720L,21374732936L };
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
public class A202526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202526Inst : IEnumerable<long>
{
public static readonly long[] Value=A202526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202526.Bytes);
public long this[int i]=>Value[i];

public static A202526Inst Instance=new A202526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202527
{
public static readonly long[] Value={ 417L,1084L,2263L,4669L,10240L,22118L,47098L,101249L,218000L,467743L,1004221L,2157988L,4635082L,9954218L,21381733L,45927212L,98644463L,211878013L,455096536L,977499190L,2099565274L,4509660401L,9686297296L,20805178151L,44687426189L };
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
public class A202527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202527Inst : IEnumerable<long>
{
public static readonly long[] Value=A202527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202527.Bytes);
public long this[int i]=>Value[i];

public static A202527Inst Instance=new A202527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202528
{
public static readonly long[] Value={ 890L,2232L,4669L,9746L,21297L,45899L,97936L,210562L,453068L,972285L,2087770L,4485977L,9635163L,20693096L,44448598L,95473096L,205062389L,440453226L,946055233L,2032027019L,4364582616L,9374693066L,20135896348L,43249855813L };
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
public class A202528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202528Inst : IEnumerable<long>
{
public static readonly long[] Value=A202528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202528.Bytes);
public long this[int i]=>Value[i];

public static A202528Inst Instance=new A202528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202529
{
public static readonly long[] Value={ 1940L,4901L,10240L,21297L,46621L,100550L,214388L,460948L,992061L,2128796L,4570909L,9821889L,21095902L,45306296L,97317908L,209034085L,448973976L,964350281L,2071342213L,4449024294L,9556039324L,20525432468L,44086562621L,94693444852L };
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
public class A202529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202529Inst : IEnumerable<long>
{
public static readonly long[] Value=A202529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202529.Bytes);
public long this[int i]=>Value[i];

public static A202529Inst Instance=new A202529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202530
{
public static readonly long[] Value={ 4184L,10584L,22118L,45899L,100550L,216973L,462445L,994256L,2140144L,4592250L,9860075L,21187586L,45507845L,97733497L,209931772L,450924056L,968516494L,2080273923L,4468253006L,9597335189L,20614070621L,44276998192L,95102536960L };
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
public class A202530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202530Inst : IEnumerable<long>
{
public static readonly long[] Value=A202530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202530.Bytes);
public long this[int i]=>Value[i];

public static A202530Inst Instance=new A202530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202531
{
public static readonly long[] Value={ 8994L,22525L,47098L,97936L,214388L,462445L,986000L,2119913L,4562593L,9790618L,21022108L,45171964L,97022597L,208368988L,447576365L,961372373L,2064884218L,4435160104L,9526346212L,20461585981L,43949347976L,94398876097L,202759283897L };
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
public class A202531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202531Inst : IEnumerable<long>
{
public static readonly long[] Value=A202531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202531.Bytes);
public long this[int i]=>Value[i];

public static A202531Inst Instance=new A202531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202532
{
public static readonly long[] Value={ 86L,198L,198L,417L,518L,417L,890L,1084L,1084L,890L,1940L,2232L,2263L,2232L,1940L,4184L,4901L,4669L,4669L,4901L,4184L,8994L,10584L,10240L,9746L,10240L,10584L,8994L,19420L,22525L,22118L,21297L,21297L,22118L,22525L,19420L,41918L,48429L,47098L,45899L,46621L };
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
public class A202532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202532Inst : IEnumerable<long>
{
public static readonly long[] Value=A202532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202532.Bytes);
public long this[int i]=>Value[i];

public static A202532Inst Instance=new A202532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202533
{
public static readonly long[] Value={ 2L,6L,10L,42L,2L,22L,130L,10L,34L,798L,70L,230L,2L,6L,58L,4774L,154L,14L,962L,26L,82L,602L,42L,658L,34L,374L,5830L,6270L,38L,118L,7930L,390L,26L,3082L,46L,7810L,1606L,22L,22L,158L,306L,2822L,12818L,754L,2314L,168454L,12958L,418L,2134L,66L,1010L,7210L,14L,214L,104858L };
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
public class A202533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202533Inst : IEnumerable<long>
{
public static readonly long[] Value=A202533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202533.Bytes);
public long this[int i]=>Value[i];

public static A202533Inst Instance=new A202533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202534
{
public static readonly BigInteger[] Value={ 0L,0L,3L,49L,972L,32565L,2096275L,268431316L,68719455589L,35184371972857L,36028797018285398L,BigInteger.Parse("73786976294833992867"),BigInteger.Parse("302231454903657266032107"),BigInteger.Parse("2475880078570760549607349126"),BigInteger.Parse("40564819207303340847893119613487"),BigInteger.Parse("1329227995784915872903807049800202429") };
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
public class A202534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202534Inst Instance=new A202534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202535
{
public static readonly long[] Value={ 1L,2L,6L,0L,20L,12L,42L,0L,0L,40L,110L,0L,156L,84L,120L,0L,272L,0L,342L,0L,252L,220L,506L,0L,0L,312L,0L,0L,812L,240L,930L,0L,660L,544L,840L,0L,1332L,684L,936L,0L,1640L,504L,1806L,0L,0L,1012L,2162L,0L,0L,0L,1632L,0L,2756L,0L,2200L,0L,2052L,1624L,3422L };
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
public class A202535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202535Inst : IEnumerable<long>
{
public static readonly long[] Value=A202535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202535.Bytes);
public long this[int i]=>Value[i];

public static A202535Inst Instance=new A202535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202536
{
public static readonly long[] Value={ 1L,0L,1L,3L,3L,8L,21L,31L,70L,165L,286L,615L,1351L,2548L,5353L,11343L,22320L,46349L,96516L,193944L,400313L,826747L,1678540L,3453642L,7105102L,14498569L,29781633L,61158957L,125108639L,256763850L,526846289L,1079030715L,2213527089L,4540131569L,9304062828L };
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
public class A202536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202536Inst : IEnumerable<long>
{
public static readonly long[] Value=A202536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202536.Bytes);
public long this[int i]=>Value[i];

public static A202536Inst Instance=new A202536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202537
{
public static readonly long[] Value={ 3L,8L,2L,2L,4L,5L,0L,8L,5L,8L,4L,0L,0L,3L,5L,6L,4L,1L,3L,2L,9L,3L,5L,8L,4L,9L,9L,1L,8L,4L,8L,5L,7L,3L,9L,3L,7L,5L,9L,4L,1L,6L,4L,2L,2L,4L,2L,0L,1L,9L,5L,4L,3L,0L,0L,2L,9L,2L,8L,3L,9L,3L,8L,3L,6L,1L,6L,5L,4L,8L,9L,0L,5L,5L,0L,5L,8L,3L,1L,8L,2L,0L,1L,7L,0L,1L,3L,5L,0L,8L,5L,1L,5L,9L,0L,0L,9L,1L,2L };
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
public class A202537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202537Inst : IEnumerable<long>
{
public static readonly long[] Value=A202537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202537.Bytes);
public long this[int i]=>Value[i];

public static A202537Inst Instance=new A202537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202538
{
public static readonly long[] Value={ 3L,2L,2L,2L,8L,4L,6L,1L,5L,9L,7L,1L,0L,3L,0L,0L,6L,0L,0L,3L,6L,2L,3L,5L,4L,8L,6L,2L,8L,9L,1L,3L,9L,2L,3L,5L,4L,5L,5L,4L,4L,3L,1L,1L,4L,8L,0L,7L,4L,6L,3L,8L,6L,8L,3L,0L,3L,7L,2L,4L,5L,0L,6L,7L,0L,1L,4L,1L,5L,2L,2L,6L,1L,2L,9L,4L,3L,3L,8L,1L,6L,4L,6L,7L,8L,0L,0L,8L,9L,8L,7L,3L,2L,7L,2L,1L,6L,4L,6L };
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
public class A202538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202538Inst : IEnumerable<long>
{
public static readonly long[] Value=A202538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202538.Bytes);
public long this[int i]=>Value[i];

public static A202538Inst Instance=new A202538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202539
{
public static readonly long[] Value={ 2L,8L,1L,1L,9L,9L,5L,7L,4L,3L,2L,2L,9L,6L,1L,8L,4L,6L,5L,1L,2L,0L,5L,0L,7L,6L,4L,0L,6L,7L,8L,7L,8L,2L,9L,9L,7L,9L,2L,0L,2L,3L,2L,2L,5L,7L,4L,4L,0L,6L,6L,4L,6L,2L,6L,7L,5L,7L,3L,0L,3L,3L,4L,3L,1L,8L,0L,3L,8L,4L,5L,3L,0L,6L,2L,1L,2L,0L,8L,9L,1L,3L,2L,2L,9L,8L,7L,7L,0L,7L,4L,7L,5L,4L,9L,4L,0L,5L,4L };
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
public class A202539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202539Inst : IEnumerable<long>
{
public static readonly long[] Value=A202539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202539.Bytes);
public long this[int i]=>Value[i];

public static A202539Inst Instance=new A202539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202540
{
public static readonly long[] Value={ 1L,9L,9L,4L,6L,0L,5L,7L,8L,2L,4L,3L,0L,0L,5L,3L,5L,1L,4L,8L,8L,5L,7L,7L,7L,1L,8L,3L,8L,4L,9L,4L,9L,1L,7L,8L,3L,9L,2L,7L,7L,6L,9L,2L,6L,2L,0L,8L,1L,2L,4L,9L,2L,4L,0L,1L,5L,3L,6L,4L,5L,4L,7L,1L,6L,8L,0L,8L,6L,6L,4L,3L,9L,3L,8L,4L,3L,2L,8L,5L,4L,8L,7L,9L,2L,7L,9L,9L,8L,0L,3L,6L,1L,6L,3L,6L,4L,6L,4L };
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
public class A202540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202540Inst : IEnumerable<long>
{
public static readonly long[] Value=A202540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202540.Bytes);
public long this[int i]=>Value[i];

public static A202540Inst Instance=new A202540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202541
{
public static readonly long[] Value={ 2L,4L,0L,6L,0L,5L,9L,1L,2L,5L,2L,9L,8L,0L,1L,7L,2L,3L,7L,4L,8L,8L,7L,9L,4L,5L,6L,7L,1L,2L,1L,8L,4L,2L,1L,1L,5L,6L,7L,5L,9L,2L,1L,6L,7L,1L,9L,2L,8L,3L,0L,2L,5L,9L,8L,3L,0L,5L,0L,9L,0L,8L,4L,4L,2L,0L,0L,8L,1L,9L,3L,3L,8L,0L,4L,1L,1L,0L,8L,8L,7L,2L,0L,6L,0L,0L,4L,7L,1L,4L,5L,6L,1L,3L,6L,1L,7L,3L,7L };
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
public class A202541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202541Inst : IEnumerable<long>
{
public static readonly long[] Value=A202541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202541.Bytes);
public long this[int i]=>Value[i];

public static A202541Inst Instance=new A202541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202542
{
public static readonly long[] Value={ 1L,6L,0L,4L,0L,3L,9L,4L,1L,6L,8L,6L,5L,3L,4L,4L,8L,2L,4L,9L,9L,2L,5L,2L,9L,7L,1L,1L,4L,1L,4L,5L,6L,1L,4L,1L,0L,4L,5L,0L,6L,1L,4L,4L,4L,7L,9L,5L,2L,2L,0L,1L,7L,3L,2L,2L,0L,3L,3L,9L,3L,8L,9L,6L,1L,3L,3L,8L,7L,9L,5L,5L,8L,6L,9L,4L,0L,7L,2L,5L,8L,1L,3L,7L,3L,3L,6L,4L,7L,6L,3L,7L,4L,2L,4L,1L,1L,5L,8L };
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
public class A202542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202542Inst : IEnumerable<long>
{
public static readonly long[] Value=A202542.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202542.Bytes);
public long this[int i]=>Value[i];

public static A202542Inst Instance=new A202542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202543
{
public static readonly long[] Value={ 9L,6L,2L,4L,2L,3L,6L,5L,0L,1L,1L,9L,2L,0L,6L,8L,9L,4L,9L,9L,5L,5L,1L,7L,8L,2L,6L,8L,4L,8L,7L,3L,6L,8L,4L,6L,2L,7L,0L,3L,6L,8L,6L,6L,8L,7L,7L,1L,3L,2L,1L,0L,3L,9L,3L,2L,2L,0L,3L,6L,3L,3L,7L,6L,8L,0L,3L,2L,7L,7L,3L,5L,2L,1L,6L,4L,4L,3L,5L,4L,8L,8L,2L,4L,0L,1L,8L,8L,5L,8L,2L,4L,5L,4L,4L,6L,9L,4L,9L };
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
public class A202543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202543Inst : IEnumerable<long>
{
public static readonly long[] Value=A202543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202543.Bytes);
public long this[int i]=>Value[i];

public static A202543Inst Instance=new A202543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202544
{
public static readonly BigInteger[] Value={ 1L,2L,18L,1094L,658492L,5534917394L,876480920594230L,BigInteger.Parse("3399581643395993926522") };
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
public class A202544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202544Inst Instance=new A202544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202545
{
public static readonly long[] Value={ 1L,8L,86L,1094L,15184L,219934L,3249298L,48427802L,724492208L,10855670258L,162764756218L,2441054713126L,36613379378704L,549186530733206L,8237716581278546L,123565284853121186L,1853476648287687712L };
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
public class A202545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202545Inst : IEnumerable<long>
{
public static readonly long[] Value=A202545.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202545.Bytes);
public long this[int i]=>Value[i];

public static A202545Inst Instance=new A202545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202546
{
public static readonly BigInteger[] Value={ 1L,16L,422L,15184L,658492L,31670778L,1605067272L,83391232150L,4381848547778L,231395948507974L,12245606508739280L,648623284638627434L,BigInteger.Parse("34368743751642250540"),BigInteger.Parse("1821371899756234451072"),BigInteger.Parse("96529219722687416879248") };
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
public class A202546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202546Inst Instance=new A202546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202547
{
public static readonly BigInteger[] Value={ 1L,32L,2094L,219934L,31670778L,5534917394L,1078490778110L,222425177005132L,47166084815234578L,10132160238913275232UL,BigInteger.Parse("2189244152545815718298"),BigInteger.Parse("474218997901396743953114"),BigInteger.Parse("102831073878890605814623386") };
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
public class A202547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202547.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202547Inst Instance=new A202547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202548
{
public static readonly BigInteger[] Value={ 1L,64L,10438L,3249298L,1605067272L,1078490778110L,876480920594230L,794166642153146254L,BigInteger.Parse("762568739496974188204"),BigInteger.Parse("753928983875460610050918"),BigInteger.Parse("755888883107420734464676952"),BigInteger.Parse("762735395600844011293201732846") };
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
public class A202548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A202548.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A202548Inst Instance=new A202548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202549
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,8L,18L,8L,1L,1L,16L,86L,86L,16L,1L,1L,32L,422L,1094L,422L,32L,1L,1L,64L,2094L,15184L,15184L,2094L,64L,1L,1L,128L,10438L,219934L,658492L,219934L,10438L,128L,1L,1L,256L,52126L,3249298L,31670778L,31670778L,3249298L,52126L,256L,1L,1L,512L };
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
public class A202549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202549Inst : IEnumerable<long>
{
public static readonly long[] Value=A202549.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202549.Bytes);
public long this[int i]=>Value[i];

public static A202549Inst Instance=new A202549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202550
{
public static readonly long[] Value={ 1L,4L,1L,21L,8L,1L,124L,58L,12L,1L,782L,416L,111L,16L,1L,5144L,2997L,940L,180L,20L,1L,34845L,21752L,7653L,1760L,265L,24L,1L,241196L,159062L,61068L,16014L,2940L,366L,28L,1L,1697498L,1171136L,481944L,139712L,29600L,4544L };
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
public class A202550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202550Inst : IEnumerable<long>
{
public static readonly long[] Value=A202550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202550.Bytes);
public long this[int i]=>Value[i];

public static A202550Inst Instance=new A202550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202551
{
public static readonly long[] Value={ 1L,1L,-1L,0L,-1L,1L,-1L,1L,1L,-1L,-1L,3L,-2L,-1L,1L,0L,2L,-5L,3L,1L,-1L,1L,-2L,-2L,7L,-4L,-1L,1L,1L,-5L,7L,1L,-9L,5L,1L,-1L,0L,-3L,12L,-15L,1L,11L,-6L,-1L,1L,-1L,3L,3L,-21L,26L,-4L,-13L,7L,1L,-1L };
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
public class A202551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202551Inst : IEnumerable<long>
{
public static readonly long[] Value=A202551.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202551.Bytes);
public long this[int i]=>Value[i];

public static A202551Inst Instance=new A202551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202552
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,23L,65L,201L,679L,2489L,9831L,41673L,188858L,911216L,4664879L,25265271L,144350862L,867748340L,5475788662L,36194252078L,250093494424L,1803204139718L,13543620370665L,105800880875545L,858375849401380L,7222921375625584L };
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
public class A202552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202552Inst : IEnumerable<long>
{
public static readonly long[] Value=A202552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202552.Bytes);
public long this[int i]=>Value[i];

public static A202552Inst Instance=new A202552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202553
{
public static readonly long[] Value={ 2L,8L,66L,1526L,103806L,22360610L,15635171834L,36727396390100L };
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
public class A202553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202553Inst : IEnumerable<long>
{
public static readonly long[] Value=A202553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202553.Bytes);
public long this[int i]=>Value[i];

public static A202553Inst Instance=new A202553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202554
{
public static readonly long[] Value={ 3L,8L,17L,37L,73L,151L,293L,598L,1159L,2358L,4581L,9314L,18143L,36880L,72001L,146325L,286185L,581427L,1138813L,2312865L,4535493L,9207989L,18074789L,36682275L,72066977L,146206411L,287454709L,582979035L,1146938817L,2325328271L,4577459549L };
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
public class A202554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202554Inst : IEnumerable<long>
{
public static readonly long[] Value=A202554.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202554.Bytes);
public long this[int i]=>Value[i];

public static A202554Inst Instance=new A202554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202555
{
public static readonly long[] Value={ 4L,17L,66L,235L,824L,2848L,9520L,31648L,104536L,339553L,1099666L,3549038L,11338836L,36160324L,115069316L,363700188L,1148126044L,3619072821L,11352513438L,35579368776L,111388887136L,347450537496L,1083054672896L,3373317547471L };
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
public class A202555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202555Inst : IEnumerable<long>
{
public static readonly long[] Value=A202555.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202555.Bytes);
public long this[int i]=>Value[i];

public static A202555Inst Instance=new A202555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A202556
{
public static readonly long[] Value={ 5L,37L,235L,1526L,9325L,57255L,342295L,2048759L,12097875L,71623580L,421070137L,2483305077L,14588495861L,85996521989L,505767515227L,2984447588198L,17583885515973L,103920730449567L,613473612747653L,3631554358770128L };
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
public class A202556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A202556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A202556Inst : IEnumerable<long>
{
public static readonly long[] Value=A202556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A202556.Bytes);
public long this[int i]=>Value[i];

public static A202556Inst Instance=new A202556Inst();

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