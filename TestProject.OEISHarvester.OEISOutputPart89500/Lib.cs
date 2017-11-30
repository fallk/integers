using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A109141
{
public static readonly BigInteger[] Value={ 1L,0L,66L,110L,-6528L,-21780L,986898L,5029200L,-173972160L,-1211972300L,33051614904L,297628438800L,-6538730283946L,-73793338948560L,1321581552446628L,18387553507364580L,-269415270699505128L,-4592418987961074600L,BigInteger.Parse("54819166320379762180"),BigInteger.Parse("1147693439998612940400") };
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
public class A109141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109141Inst Instance=new A109141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109142
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,153L,1020L,4284L,6120L,-196146L,-2652864L,-19986084L,-90202680L,85692546L,6608267064L,76663736316L,545345198712L,2029226503266L,-9086615598096L,-245241505186236L,-2527595927294760L,-16280108470658466L,-42945349007834280L,518834893753561140L,9490863671561772360UL };
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
public class A109142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109142Inst Instance=new A109142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109143
{
public static readonly BigInteger[] Value={ 1L,24L,-486L,18960L,-866028L,43409520L,-2305522278L,127386486480L,-7243559214894L,420974335099176L,-24888628571711040L,1491922400816664432L,BigInteger.Parse("-90454843306100805420"),BigInteger.Parse("5536766153219810009520"),BigInteger.Parse("-341663245004722577661324"),BigInteger.Parse("21230836457057377337055600"),BigInteger.Parse("-1327296238831338778081286796") };
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
public class A109143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109143Inst Instance=new A109143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109144
{
public static readonly long[] Value={ 1L,0L,18L,24L,-324L,-720L,9234L,33696L,-307926L,-1614000L,10860480L,78618672L,-385935492L,-3854459520L,13226566500L,189101997360L,-408244450788L,-9247223107008L,9292147273170L,449330421257568L,41307157825920L,-21633699079357296L,-25580513164295232L,1028997388914059808L };
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
public class A109144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109144Inst : IEnumerable<long>
{
public static readonly long[] Value=A109144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109144.Bytes);
public long this[int i]=>Value[i];

public static A109144Inst Instance=new A109144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109145
{
public static readonly BigInteger[] Value={ 1L,0L,0L,8160L,592110L,16744320L,-772066560L,-147175522560L,-9650399136480L,-196151407403520L,28722811654632960L,3694656375443262240L,BigInteger.Parse("205418279156897590080"),BigInteger.Parse("607856257587978679680"),BigInteger.Parse("-1018114883046487751477760"),BigInteger.Parse("-102010684902578350260376320") };
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
public class A109145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109145Inst Instance=new A109145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109146
{
public static readonly BigInteger[] Value={ 1L,0L,126L,1568L,756L,-165312L,-1227240L,19894464L,414106686L,-456317568L,-96106099320L,-809737207776L,15047550684488L,345938324437440L,-318788546956992L,-91256560218798912L,-842108390970746508L,15331399952805675648UL,BigInteger.Parse("380895013380314119302"),BigInteger.Parse("-178390965727200705696") };
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
public class A109146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109146Inst Instance=new A109146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109147
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1948800L,4619660850L,1910524008960L,249158110118400L,-46169150185843200L,BigInteger.Parse("-100137034474962893100"),BigInteger.Parse("-65217623251022392012800"),BigInteger.Parse("-20570898809667730816373760"),BigInteger.Parse("-1498883887269598785313680000"),BigInteger.Parse("3095512575505317779623339924200") };
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
public class A109147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109147Inst Instance=new A109147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109148
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1092000L,812652750L,137687921280L,-18901550304000L,-41392481221728000L,BigInteger.Parse("-22579382531877444000"),BigInteger.Parse("-4757955959922389952000"),BigInteger.Parse("1353302426315369501637120"),BigInteger.Parse("1905092084151861771102300000"),BigInteger.Parse("927128194726105837069347288000") };
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
public class A109148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109148Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109148.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109148Inst Instance=new A109148Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109149
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,992L,63L,992L,0L,0L,0L,0L,-492032L,-62496L,-986048L,-62496L,-492032L,0L,0L,488095744L,92994048L,1470192608L,186113088L,1470192608L,92994048L,488095744L,-605238722560L,-153750159360L,-2435600714752L,-461870500896L,-3660733827008L,-461870500896L };
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
public class A109149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109149Inst : IEnumerable<long>
{
public static readonly long[] Value=A109149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109149.Bytes);
public long this[int i]=>Value[i];

public static A109149Inst Instance=new A109149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109150
{
public static readonly long[] Value={ 2L,5L,6L,10L,11L,12L,17L,18L,19L,20L,21L,26L,27L,28L,29L,30L,31L,37L,38L,39L,40L,41L,42L,43L,45L,46L,50L,51L,52L,53L,54L,55L,56L,57L,61L,65L,66L,67L,68L,69L,70L,71L,72L,73L,76L,77L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,97L,101L,102L,103L,104L,105L,106L,107L };
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
public class A109150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109150Inst : IEnumerable<long>
{
public static readonly long[] Value=A109150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109150.Bytes);
public long this[int i]=>Value[i];

public static A109150Inst Instance=new A109150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109151
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,16256L,255L,16256L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-132128768L,-4145280L,-264290048L,-4145280L,-132128768L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2147885252608L,101078507520L,6445241319296L,202165305600L,6445241319296L,101078507520L,2147885252608L };
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
public class A109151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109151Inst : IEnumerable<long>
{
public static readonly long[] Value=A109151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109151.Bytes);
public long this[int i]=>Value[i];

public static A109151Inst Instance=new A109151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109152
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,6L,4L,3L,1L,22L,14L,6L,4L,1L,94L,56L,24L,8L,5L,1L,450L,262L,102L,36L,10L,6L,1L,2366L,1348L,516L,160L,50L,12L,7L,1L,13450L,7574L,2814L,868L,230L,66L,14L,8L,1L,81802L,45616L,16752L,4968L,1330L,312L,84L,16L,9L,1L,527826L,292442L,106026L,31148L,7930L,1914L,406L,104L,18L,10L,1L };
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
public class A109152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109152Inst : IEnumerable<long>
{
public static readonly long[] Value=A109152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109152.Bytes);
public long this[int i]=>Value[i];

public static A109152Inst Instance=new A109152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109153
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,94L,450L,2366L,13450L,81802L,527826L,3590294L,25609782L,190753502L,1478339866L,11884997478L,98859026322L,848881803218L,7509881820930L,68330806392070L,638444805545622L,6117166765086366L,60028033370994386L };
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
public class A109153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109153Inst : IEnumerable<long>
{
public static readonly long[] Value=A109153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109153.Bytes);
public long this[int i]=>Value[i];

public static A109153Inst Instance=new A109153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109154
{
public static readonly long[] Value={ 1L,2L,4L,14L,56L,262L,1348L,7574L,45616L,292442L,1978788L,14060654L,104403304L,807162070L,6476169012L,53781863598L,461194543136L,4075567775538L,37048022605956L,345883045698222L,3311798037556952L,32480125869403430L };
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
public class A109154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109154Inst : IEnumerable<long>
{
public static readonly long[] Value=A109154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109154.Bytes);
public long this[int i]=>Value[i];

public static A109154Inst Instance=new A109154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109155
{
public static readonly long[] Value={ 1L,3L,6L,24L,102L,516L,2814L,16752L,106026L,712260L,5027190L,37158600L,286141638L,2289018708L,18961164774L,162271001760L,1431533922642L,12994777356228L,121174578691398L,1159065402957240L,11357543381281638L,113876839666712676L };
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
public class A109155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109155Inst : IEnumerable<long>
{
public static readonly long[] Value=A109155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109155.Bytes);
public long this[int i]=>Value[i];

public static A109155Inst Instance=new A109155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109156
{
public static readonly long[] Value={ 1L,2L,5L,14L,47L,188L,867L,4460L,25025L,150890L,967825L,6554482L,46600855L,346228012L,2677951311L,21495038944L,178565654041L,1531692226714L,13538763090277L,123096619532030L,1149440819867767L,11007471611129700L };
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
public class A109156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109156Inst : IEnumerable<long>
{
public static readonly long[] Value=A109156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109156.Bytes);
public long this[int i]=>Value[i];

public static A109156Inst Instance=new A109156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109157
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,0L,2L,2L,2L,32L,8L,8L,4L,5L,5L,4L,252L,64L,84L,24L,28L,12L,14L,12L,8L,2112L,520L,680L,240L,232L,88L,76L,37L,37L,28L,16L,18484L,4480L,5804L,1992L,2012L,776L,656L,264L,206L,106L,94L,64L,32L,166976L,40008L,51592L,17440L,17400L,6776L,5680L,2392L,1768L };
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
public class A109157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109157Inst : IEnumerable<long>
{
public static readonly long[] Value=A109157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109157.Bytes);
public long this[int i]=>Value[i];

public static A109157Inst Instance=new A109157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109158
{
public static readonly long[] Value={ 1L,1L,2L,4L,3L,1L,10L,20L,18L,12L,5L,1L,66L,132L,122L,92L,54L,24L,7L,1L,498L,996L,930L,732L,478L,264L,118L,40L,9L,1L,4066L,8132L,7634L,6140L,4214L,2552L,1342L,600L,218L,60L,11L,1L,34970L,69940L,65874L,53676L,37910L,24136L,13782L,7016L,3122L,1180L,362L,84L,13L,1L };
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
public class A109158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109158Inst : IEnumerable<long>
{
public static readonly long[] Value=A109158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109158.Bytes);
public long this[int i]=>Value[i];

public static A109158Inst Instance=new A109158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109159
{
public static readonly BigInteger[] Value={ 1L,0L,0L,5208L,264771L,9275448L,105399504L,-6731254440L,-553692038004L,-21802507065864L,-400684321812096L,12872305942604280L,1485636235823593980L,BigInteger.Parse("69288912971916416856"),BigInteger.Parse("1651037314634527670096"),BigInteger.Parse("-22551727588731476610888"),BigInteger.Parse("-4467328894885460428544076") };
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
public class A109159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109159Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109159.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109159Inst Instance=new A109159Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109160
{
public static readonly BigInteger[] Value={ 1L,0L,0L,362712L,390271635L,265919867448L,119372436731408L,35165328152926680L,4260989164725972252L,BigInteger.Parse("-2765088990206995856136"),BigInteger.Parse("-2692105699505729141030784"),BigInteger.Parse("-1467256124653195331689768968"),BigInteger.Parse("-579590214086196376253799028340"),BigInteger.Parse("-149981940435137858852953807120680"),BigInteger.Parse("-132239778045221172571869470882672") };
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
public class A109160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109160Inst Instance=new A109160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109161
{
public static readonly long[] Value={ 5L,15L,16L,27L,28L,29L,41L,42L,43L,44L,57L,58L,59L,60L,61L,75L,76L,77L,78L,79L,80L };
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
public class A109161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109161Inst : IEnumerable<long>
{
public static readonly long[] Value=A109161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109161.Bytes);
public long this[int i]=>Value[i];

public static A109161Inst Instance=new A109161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109162
{
public static readonly BigInteger[] Value={ 1L,2L,3L,6L,15L,210L,10659L,54230826L,BigInteger.Parse("249853434654335387610276087") };
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
public class A109162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109162Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109162.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109162Inst Instance=new A109162Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109163
{
public static readonly long[] Value={ 3L,6L,10L,30L,42L,70L,22L,66L,330L,770L,2310L,130L,182L,546L,2730L,1430L,6006L,10010L,102L,510L,238L,3570L,1122L,2618L,442L,2210L,6630L,9282L,15470L,4862L,510510L,114L,266L,798L,2090L,6270L,14630L,1482L,7410L,17290L,16302L,27170L,570570L,646L,3230L };
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
public class A109163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109163Inst : IEnumerable<long>
{
public static readonly long[] Value=A109163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109163.Bytes);
public long this[int i]=>Value[i];

public static A109163Inst Instance=new A109163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109164
{
public static readonly long[] Value={ 1L,6L,20L,57L,154L,408L,1073L,2814L,7372L,19305L,50546L,132336L,346465L,907062L,2374724L,6217113L,16276618L,42612744L,111561617L,292072110L,764654716L,2001892041L,5241021410L,13721172192L,35922495169L,94046313318L,246216444788L };
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
public class A109164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109164Inst : IEnumerable<long>
{
public static readonly long[] Value=A109164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109164.Bytes);
public long this[int i]=>Value[i];

public static A109164Inst Instance=new A109164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109165
{
public static readonly long[] Value={ 1L,2L,5L,10L,23L,46L,105L,210L,479L,958L,2185L,4370L,9967L,19934L,45465L,90930L,207391L,414782L,946025L,1892050L,4315343L,8630686L,19684665L,39369330L,89792639L,179585278L,409593865L,819187730L,1868384047L,3736768094L,8522732505L };
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
public class A109165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109165Inst : IEnumerable<long>
{
public static readonly long[] Value=A109165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109165.Bytes);
public long this[int i]=>Value[i];

public static A109165Inst Instance=new A109165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109166
{
public static readonly long[] Value={ 1L,37L,58L,119L,130L,195L,292L,419L,453L,464L,561L,617L,618L,652L,679L,720L,762L,787L,827L,830L,945L,1034L,1090L,1139L,1191L,1200L,1344L,1383L,1386L,1451L,1496L,1519L,1774L,1783L,1820L,1822L,1911L,1966L,1973L,2018L,2128L,2219L,2247L,2378L,2566L,2644L };
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
public class A109166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109166Inst : IEnumerable<long>
{
public static readonly long[] Value=A109166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109166.Bytes);
public long this[int i]=>Value[i];

public static A109166Inst Instance=new A109166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109167
{
public static readonly long[] Value={ 1L,2L,1L,0L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,18L };
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
public class A109167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109167Inst : IEnumerable<long>
{
public static readonly long[] Value=A109167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109167.Bytes);
public long this[int i]=>Value[i];

public static A109167Inst Instance=new A109167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109168
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,4L,4L,8L,5L,6L,6L,8L,7L,8L,8L,16L,9L,10L,10L,12L,11L,12L,12L,16L,13L,14L,14L,16L,15L,16L,16L,32L,17L,18L,18L,20L,19L,20L,20L,24L,21L,22L,22L,24L,23L,24L,24L,32L,25L,26L,26L,28L,27L,28L,28L,32L,29L,30L,30L,32L,31L,32L,32L,64L,33L,34L,34L,36L,35L,36L,36L,40L,37L,38L,38L };
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
public class A109168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109168Inst : IEnumerable<long>
{
public static readonly long[] Value=A109168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109168.Bytes);
public long this[int i]=>Value[i];

public static A109168Inst Instance=new A109168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109169
{
public static readonly long[] Value={ 1L,4L,0L,8L,4L,9L,4L,2L,7L,9L,2L,2L,8L,9L,0L,6L,9L,8L,5L,7L,4L,8L,4L,7L,4L,2L,7L,9L,0L,8L,0L,6L,9L,7L,9L,9L,1L,6L,1L,3L,9L,9L,8L,9L,5L,5L,7L,8L,2L,0L,5L,1L,2L,8L,1L,4L,6L,6L,2L,6L,3L,8L,1L,7L,5L,2L,4L,8L,6L,2L,9L,7L,7L,8L,9L,9L,0L,3L,0L,8L,5L,3L,3L,0L,1L,2L,5L,6L,2L,8L,5L,4L,3L,0L,4L,8L,6L,9L,1L,8L,6L,4L,8L,1L,2L };
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
public class A109169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109169Inst : IEnumerable<long>
{
public static readonly long[] Value=A109169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109169.Bytes);
public long this[int i]=>Value[i];

public static A109169Inst Instance=new A109169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109170
{
public static readonly long[] Value={ 2L,1L,4L,2L,6L,2L,8L,4L,10L,3L,12L,4L,14L,4L,16L,8L,18L,5L,20L,6L,22L,6L,24L,8L,26L,7L,28L,8L,30L,8L,32L,16L,34L,9L,36L,10L,38L,10L,40L,12L,42L,11L,44L,12L,46L,12L,48L,16L,50L,13L,52L,14L,54L,14L,56L,16L,58L,15L,60L,16L,62L,16L,64L,32L,66L,17L,68L,18L,70L,18L,72L,20L,74L,19L,76L,20L,78L };
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
public class A109170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109170Inst : IEnumerable<long>
{
public static readonly long[] Value=A109170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109170.Bytes);
public long this[int i]=>Value[i];

public static A109170Inst Instance=new A109170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109171
{
public static readonly long[] Value={ 2L,8L,1L,6L,9L,8L,8L,5L,5L,8L,4L,5L,7L,8L,1L,3L,9L,7L,1L,4L,9L,6L,9L,4L,8L,5L,5L,8L,1L,6L,1L,3L,9L,5L,9L,8L,3L,2L,2L,7L,9L,9L,7L,9L,1L,1L,5L,6L,4L,1L,0L,2L,5L,6L,2L,9L,3L,2L,5L,2L,7L,6L,3L,5L,0L,4L,9L,7L,2L,5L,9L,5L,5L,7L,9L,8L,0L,6L,1L,7L,0L,6L,6L,0L,2L,5L,1L,2L,5L,7L,0L,8L,6L,0L,9L,7L,3L,8L,3L,7L,2L,9L,6L,2L,5L };
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
public class A109171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109171Inst : IEnumerable<long>
{
public static readonly long[] Value=A109171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109171.Bytes);
public long this[int i]=>Value[i];

public static A109171Inst Instance=new A109171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109172
{
public static readonly BigInteger[] Value={ 2L,7L,41L,1723L,2967005L,8803121637031L,BigInteger.Parse("77494950556354550188857929") };
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
public class A109172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109172Inst Instance=new A109172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109173
{
public static readonly BigInteger[] Value={ 1L,3L,5L,31L,929L,863971L,746445024869L,BigInteger.Parse("557180175152428473492031"),BigInteger.Parse("310449747582890872093779269721785644810947012929"),BigInteger.Parse("96379045774280656880008037888192772255684941220159788508646084243678677683026025975278640171971") };
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
public class A109173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109173Inst Instance=new A109173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109174
{
public static readonly long[] Value={ 0L,1L,4L,2L,5L,5L,8L,3L,11L,6L,6L,6L,9L,9L,9L,4L,12L,12L,12L,7L,7L,7L,15L,7L,15L,10L,10L,10L,10L,10L,18L,5L,18L,13L,13L,13L,13L,13L,13L,8L,21L,8L,8L,8L,16L,16L,16L,8L,16L,16L,16L,11L,11L,11L,24L,11L,11L,11L,11L,11L,19L,19L,19L,6L,19L,19L,19L,14L,14L,14L,14L,14L,27L,14L,14L,14L,14L,14L,14L };
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
public class A109174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109174Inst : IEnumerable<long>
{
public static readonly long[] Value=A109174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109174.Bytes);
public long this[int i]=>Value[i];

public static A109174Inst Instance=new A109174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109175
{
public static readonly long[] Value={ 1L,3L,9L,24L,58L,143L,345L,836L,2018L,4875L,11769L,28416L,68602L,165623L,399849L,965324L,2330498L,5626323L,13583145L,32792616L,79168378L,191129375L,461427129L,1113983636L,2689394402L,6492772443L,15674939289L,37842651024L,91360241338L };
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
public class A109175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109175Inst : IEnumerable<long>
{
public static readonly long[] Value=A109175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109175.Bytes);
public long this[int i]=>Value[i];

public static A109175Inst Instance=new A109175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109176
{
public static readonly long[] Value={ 10243L,12043L,20143L,20341L,20431L,23041L,24103L,30241L,32401L,40123L,40213L,40231L,41023L,41203L,42013L,43201L };
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
public class A109176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109176Inst : IEnumerable<long>
{
public static readonly long[] Value=A109176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109176.Bytes);
public long this[int i]=>Value[i];

public static A109176Inst Instance=new A109176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109177
{
public static readonly long[] Value={ 10235647L,10236547L,10243567L,10243657L,10245637L,10247563L,10254367L,10254763L,10256347L,10256473L,10257463L,10264357L,10264537L,10346257L,10356427L,10364527L,10425367L,10425637L,10425673L,10426357L,10426753L };
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
public class A109177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109177Inst : IEnumerable<long>
{
public static readonly long[] Value=A109177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109177.Bytes);
public long this[int i]=>Value[i];

public static A109177Inst Instance=new A109177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109178
{
public static readonly long[] Value={ 76540231L,76532041L,76524031L,76523401L,76520341L,76514203L,76512043L,76504321L,76504231L,76503241L,76502143L,76501423L,76453021L,76451203L,76435201L,76425103L,76421053L,76401253L,76345201L,76340521L,76325401L };
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
public class A109178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109178Inst : IEnumerable<long>
{
public static readonly long[] Value=A109178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109178.Bytes);
public long this[int i]=>Value[i];

public static A109178Inst Instance=new A109178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109179
{
public static readonly long[] Value={ 10243657L,10247563L,10254367L,10254763L,10264537L,10356427L,10432567L,10452367L,10457263L,10467253L,10475263L,10562437L,10574623L,10654327L,10725643L,12067543L,12306457L,12360457L,12364507L,12460753L,12530647L };
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
public class A109179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109179Inst : IEnumerable<long>
{
public static readonly long[] Value=A109179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109179.Bytes);
public long this[int i]=>Value[i];

public static A109179Inst Instance=new A109179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109180
{
public static readonly long[] Value={ 0L,1L,4L,7L,9L,11L,14L,17L,18L,20L,21L,23L,24L,25L,26L,28L,33L,35L,38L,39L,40L,41L,43L,46L,47L,50L,51L,52L,55L,56L,60L,61L,62L,63L,64L,65L,66L,71L,72L,73L,75L,77L,78L,79L,80L,81L,82L,83L,84L,86L,87L,91L,92L,94L,96L,97L,99L,100L,101L,102L,103L,104L,105L,106L,108L,109L,110L,111L,116L };
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
public class A109180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109180Inst : IEnumerable<long>
{
public static readonly long[] Value=A109180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109180.Bytes);
public long this[int i]=>Value[i];

public static A109180Inst Instance=new A109180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109181
{
public static readonly long[] Value={ 2L,13L,17L,37L,73L,2L,11L,11L,59L,59L,131L,83L,131L,163L,17L,89L,11L,19L,59L,19L,67L,43L,67L,139L,139L,17L,97L,41L,113L,53L,61L,101L,37L,53L,61L,101L,73L,109L,131L,67L,139L,107L,179L,149L,109L,137L,83L,163L,139L,131L,179L,163L,211L,11L,83L,11L,19L,83L,131L,11L,83L,47L,67L,103L,11L,19L,59L,47L,107L,43L,67L,107L,179L,47L,127L,167L,199L,131L,67L,163L };
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
public class A109181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109181Inst : IEnumerable<long>
{
public static readonly long[] Value=A109181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109181.Bytes);
public long this[int i]=>Value[i];

public static A109181Inst Instance=new A109181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109182
{
public static readonly long[] Value={ 293L,2106L,2161L,2763L,3698L,3793L,3795L,3812L,3922L,3959L,3995L,4000L,4205L,4224L,4260L,4728L,4953L,5065L,5283L,5617L,5700L,5751L,5932L,6326L,6333L,6422L,6539L,6623L,7375L,7475L,7501L,7533L,7542L,8306L,8568L,8751L,8777L,8994L,9102L,9259L,9354L,9480L };
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
public class A109182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109182Inst : IEnumerable<long>
{
public static readonly long[] Value=A109182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109182.Bytes);
public long this[int i]=>Value[i];

public static A109182Inst Instance=new A109182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109183
{
public static readonly long[] Value={ 3795L,3995L,10234L,17125L,18134L,19322L,20979L,22843L,22979L,23052L,23078L,23684L,24358L,27884L,28826L,31212L,31458L,34334L,35188L,37710L,39740L,40465L,41523L,42892L,44878L,46077L,47319L,48951L,51258L,54687L,55846L,59105L,59420L,59638L };
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
public class A109183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109183Inst : IEnumerable<long>
{
public static readonly long[] Value=A109183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109183.Bytes);
public long this[int i]=>Value[i];

public static A109183Inst Instance=new A109183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109184
{
public static readonly long[] Value={ 929L,16661L,17471L,36263L,70607L,72227L,73037L,91019L,1074701L,1082801L,1180811L,1262621L,1328231L,1360631L,1508051L,1532351L,1630361L,1712171L,1802081L,3160613L,3218123L,7014107L,7300037L,9002009L,102383201L,102707201L,103282301L };
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
public class A109184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109184Inst : IEnumerable<long>
{
public static readonly long[] Value=A109184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109184.Bytes);
public long this[int i]=>Value[i];

public static A109184Inst Instance=new A109184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109185
{
public static readonly long[] Value={ 97879L,98689L,1878781L,1968691L,1976791L,1984891L,3768673L,3784873L,3792973L,3858583L,3948493L,3964693L,7278727L,7392937L,7466647L,7564657L,7654567L,7662667L,7850587L,7916197L,9078709L,9446449L,9470749L,9626269L,9634369L };
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
public class A109185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109185Inst : IEnumerable<long>
{
public static readonly long[] Value=A109185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109185.Bytes);
public long this[int i]=>Value[i];

public static A109185Inst Instance=new A109185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109186
{
public static readonly BigInteger[] Value={ 1L,5L,36L,340L,3968L,55045L,883578L,16092772L,327632793L,7369013917L,181373908752L,4847134062319L,139729893353690L,4320778186663065L,142630863311312977L,5005242986601625051L,BigInteger.Parse("186036975046460920033"),BigInteger.Parse("7299970808014926301354"),BigInteger.Parse("301529053235119043206790") };
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
public class A109186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109186.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109186Inst Instance=new A109186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109187
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,6L,0L,1L,6L,0L,12L,0L,1L,0L,30L,0L,20L,0L,1L,20L,0L,90L,0L,30L,0L,1L,0L,140L,0L,210L,0L,42L,0L,1L,70L,0L,560L,0L,420L,0L,56L,0L,1L,0L,630L,0L,1680L,0L,756L,0L,72L,0L,1L,252L,0L,3150L,0L,4200L,0L,1260L,0L,90L,0L,1L,0L,2772L,0L,11550L,0L,9240L,0L,1980L,0L,110L,0L,1L,924L };
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
public class A109187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109187Inst : IEnumerable<long>
{
public static readonly long[] Value=A109187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109187.Bytes);
public long this[int i]=>Value[i];

public static A109187Inst Instance=new A109187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109188
{
public static readonly long[] Value={ 1L,2L,9L,28L,95L,306L,987L,3144L,9963L,31390L,98483L,307836L,959257L,2981174L,9243405L,28601712L,88342659L,272428758L,838903371L,2579937060L,7924966749L,24317716038L,74546117121L,228317474952L,698708409525L,2136597743826L };
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
public class A109188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109188Inst : IEnumerable<long>
{
public static readonly long[] Value=A109188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109188.Bytes);
public long this[int i]=>Value[i];

public static A109188Inst Instance=new A109188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109189
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,2L,4L,0L,1L,8L,4L,6L,0L,1L,16L,20L,6L,8L,0L,1L,46L,40L,36L,8L,10L,0L,1L,114L,128L,72L,56L,10L,12L,0L,1L,310L,324L,254L,112L,80L,12L,14L,0L,1L,822L,932L,654L,432L,160L,108L,14L,16L,0L,1L,2238L,2540L,1986L,1128L,670L,216L,140L,16L,18L,0L,1L,6094L,7164L,5546L };
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
public class A109189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109189Inst : IEnumerable<long>
{
public static readonly long[] Value=A109189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109189.Bytes);
public long this[int i]=>Value[i];

public static A109189Inst Instance=new A109189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109190
{
public static readonly long[] Value={ 1L,0L,2L,2L,8L,16L,46L,114L,310L,822L,2238L,6094L,16764L,46308L,128650L,358862L,1005056L,2824416L,7962122L,22508350L,63792424L,181219680L,515905018L,1471593638L,4205280902L,12037415526L,34510499066L,99083855234L,284870069780L };
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
public class A109190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109190Inst : IEnumerable<long>
{
public static readonly long[] Value=A109190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109190.Bytes);
public long this[int i]=>Value[i];

public static A109190Inst Instance=new A109190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109191
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,2L,13L,5L,1L,34L,14L,3L,91L,40L,9L,1L,247L,114L,28L,4L,678L,327L,87L,14L,1L,1877L,942L,267L,48L,5L,5233L,2723L,815L,161L,20L,1L,14674L,7892L,2478L,528L,75L,6L,41349L,22924L,7512L,1706L,270L,27L,1L,117001L,66712L,22718L,5452L,941L,110L,7L,332260L };
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
public class A109191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109191Inst : IEnumerable<long>
{
public static readonly long[] Value=A109191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109191.Bytes);
public long this[int i]=>Value[i];

public static A109191Inst Instance=new A109191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109192
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,34L,91L,247L,678L,1877L,5233L,14674L,41349L,117001L,332260L,946527L,2703915L,7743268L,22223607L,63909987L,184121946L,531318553L,1535522513L,4443815554L,12876794147L,37356832679L,108494114718L,315415738025L };
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
public class A109192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109192Inst : IEnumerable<long>
{
public static readonly long[] Value=A109192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109192.Bytes);
public long this[int i]=>Value[i];

public static A109192Inst Instance=new A109192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109193
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,6L,1L,14L,4L,1L,30L,20L,1L,64L,68L,8L,1L,140L,196L,56L,1L,318L,524L,248L,16L,1L,750L,1356L,888L,144L,1L,1828L,3476L,2832L,784L,32L,1L,4576L,8932L,8448L,3344L,352L,1L,11700L,23136L,24248L,12368L,2272L,64L,1L,30420L,60528L,68120L,41808L,11232L,832L,1L };
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
public class A109193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109193Inst : IEnumerable<long>
{
public static readonly long[] Value=A109193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109193.Bytes);
public long this[int i]=>Value[i];

public static A109193Inst Instance=new A109193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109194
{
public static readonly long[] Value={ 2L,6L,22L,70L,224L,700L,2174L,6702L,20572L,62920L,191932L,584220L,1775258L,5386846L,16326734L,49435150L,149557436L,452133880L,1366012832L,4124825872L,12449394278L,37558361290L,113266431860L,341467468420L,1029119688014L };
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
public class A109194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109194Inst : IEnumerable<long>
{
public static readonly long[] Value=A109194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109194.Bytes);
public long this[int i]=>Value[i];

public static A109194Inst Instance=new A109194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109195
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,9L,9L,1L,21L,25L,5L,51L,69L,20L,1L,127L,189L,70L,7L,323L,518L,230L,35L,1L,835L,1422L,726L,147L,9L,2188L,3915L,2235L,560L,54L,1L,5798L,10813L,6765L,2002L,264L,11L,15511L,29964L,20240L,6853L,1143L,77L,1L,41835L,83304L,60060L,22737L,4563L,429L,13L };
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
public class A109195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109195Inst : IEnumerable<long>
{
public static readonly long[] Value=A109195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109195.Bytes);
public long this[int i]=>Value[i];

public static A109195Inst Instance=new A109195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109196
{
public static readonly long[] Value={ 1L,3L,11L,35L,112L,350L,1087L,3351L,10286L,31460L,95966L,292110L,887629L,2693423L,8163367L,24717575L,74778718L,226066940L,683006416L,2062412936L,6224697139L,18779180645L,56633215930L,170733734210L,514559844007L,1550364293145L };
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
public class A109196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109196Inst : IEnumerable<long>
{
public static readonly long[] Value=A109196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109196.Bytes);
public long this[int i]=>Value[i];

public static A109196Inst Instance=new A109196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109197
{
public static readonly long[] Value={ 2L,3L,9L,1L,3L,1L,7L,3L,1L,1L,11L,1L,1L,3L,3L,1L,3L,3L,11L,1L,9L,2L,1L,2L,11L,1L,3L,4L,1L,1L,1L,2L,7L,5L,1L,1L,7L,4L,5L,1L,7L,2L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,2L,5L,2L,5L,4L,1L,1L,1L,1L,1L,2L,1L,1L,5L,7L,3L,1L,9L,1L,11L,4L,3L,2L,1L,2L,1L,1L,1L,14L,5L,2L,5L,1L,1L,5L,1L,6L,7L,2L,1L,2L,7L,1L,1L,6L,13L,8L,1L };
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
public class A109197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109197Inst : IEnumerable<long>
{
public static readonly long[] Value=A109197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109197.Bytes);
public long this[int i]=>Value[i];

public static A109197Inst Instance=new A109197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109198
{
public static readonly long[] Value={ 2L,3L,1L,8L,1L,2L,1L,8L,5L,4L,9L,4L,11L,2L,13L,2L,1L,12L,1L,12L,7L,5L,1L,2L,5L,3L,3L,10L,1L,18L,7L,4L,3L,2L,5L,2L,7L,2L,7L,2L,7L,6L,1L,2L,5L,7L,3L,4L,11L,2L,3L,16L,5L,2L,11L,2L,9L,2L,1L,40L,1L,4L,5L,8L,5L,9L,17L,2L,7L,5L,1L,6L,1L,4L,3L,14L,3L,4L,1L,18L,9L,10L,3L,6L,5L,3L,15L,4L,9L,3L,7L,10L,11L,2L,3L,12L };
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
public class A109198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109198Inst : IEnumerable<long>
{
public static readonly long[] Value=A109198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109198.Bytes);
public long this[int i]=>Value[i];

public static A109198Inst Instance=new A109198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109199
{
public static readonly long[] Value={ 2L,3L,3L,1L,3L,1L,7L,1L,1L,14L,1L,1L,1L,1L,1L,2L,3L,1L,1L,5L,17L,1L,1L,1L,17L,2L,1L,10L,9L,1L,1L,4L,1L,4L,5L,1L,1L,6L,1L,1L,1L,5L,1L,4L,5L,7L,5L,6L,13L,5L,1L,14L,1L,4L,5L,2L,3L,1L,1L,14L,7L,1L,1L,4L,7L,1L,5L,4L,1L,16L,3L,1L,1L,1L,3L,4L,5L,6L,1L,10L,7L,1L,9L,4L,1L,3L,1L,16L,3L,4L,31L,15L,1L,4L,1L,3L,5L,6L,1L,4L };
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
public class A109199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109199Inst : IEnumerable<long>
{
public static readonly long[] Value=A109199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109199.Bytes);
public long this[int i]=>Value[i];

public static A109199Inst Instance=new A109199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109200
{
public static readonly long[] Value={ 2L,3L,1L,2L,7L,3L,5L,16L,3L,4L,1L,10L,1L,2L,3L,8L,1L,2L,5L,10L,3L,2L,1L,8L,5L,4L,9L,2L,9L,3L,13L,8L,15L,8L,7L,2L,5L,2L,3L,16L,3L,9L,31L,14L,3L,4L,3L,10L,11L,2L,3L,2L,9L,12L,5L,4L,3L,10L,5L,6L,11L,6L,9L,16L,5L,28L,19L,4L,3L,16L,3L,6L,7L,4L,9L,28L,9L,6L,11L,12L,7L,10L,7L,14L,29L,3L,11L,8L,3L,18L,7L,8L,3L,4L };
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
public class A109200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109200Inst : IEnumerable<long>
{
public static readonly long[] Value=A109200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109200.Bytes);
public long this[int i]=>Value[i];

public static A109200Inst Instance=new A109200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109201
{
public static readonly long[] Value={ 2L,3L,1L,4L,1L,3L,7L,2L,5L,10L,1L,2L,5L,6L,5L,2L,7L,6L,11L,6L,3L,5L,3L,7L,11L,2L,3L,2L,9L,10L,7L,5L,5L,5L,5L,2L,1L,2L,5L,2L,3L,2L,5L,4L,9L,4L,3L,2L,5L,11L,3L,11L,3L,3L,5L,7L,1L,4L,3L,4L,11L,4L,5L,16L,7L,2L,7L,2L,3L,25L,9L,6L,5L,2L,5L,2L,5L,2L,5L,4L,17L,20L,7L,4L,5L,4L,15L,2L,5L,6L,7L,6L,3L,5L,1L,2L,5L,8L,3L };
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
public class A109201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109201Inst : IEnumerable<long>
{
public static readonly long[] Value=A109201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109201.Bytes);
public long this[int i]=>Value[i];

public static A109201Inst Instance=new A109201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109202
{
public static readonly long[] Value={ 2L,3L,1L,2L,5L,6L,7L,4L,5L,8L,1L,6L,7L,5L,27L,16L,1L,12L,1L,2L,3L,8L,3L,6L,7L,2L,5L,2L,3L,12L,7L,4L,9L,2L,5L,6L,7L,4L,21L,2L,9L,4L,11L,6L,3L,4L,1L,2L,7L,25L,21L,14L,1L,4L,5L,4L,15L,8L,3L,22L,17L,8L,21L,10L,5L,2L,1L,14L,9L,32L,11L,6L,1L,13L,3L,2L,3L,3L,1L,2L,63L,4L,5L,10L,11L,9L,9L,4L,5L,33L,19L,6L,3L };
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
public class A109202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109202Inst : IEnumerable<long>
{
public static readonly long[] Value=A109202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109202.Bytes);
public long this[int i]=>Value[i];

public static A109202Inst Instance=new A109202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109203
{
public static readonly long[] Value={ 2L,3L,3L,14L,3L,2L,1L,5L,7L,1L,1L,4L,5L,1L,3L,7L,1L,10L,1L,11L,1L,4L,1L,6L,13L,3L,1L,20L,1L,4L,11L,4L,1L,1L,1L,16L,5L,5L,1L,4L,3L,6L,1L,1L,15L,4L,5L,1L,17L,4L,1L,1L,1L,1L,11L,4L,1L,14L,1L,10L,1L,14L,7L,4L,15L,4L,1L,4L,1L,1L,1L,9L,1L,15L,9L,8L,9L,10L,5L,14L,3L,1L,5L,6L,1L,3L,19L,14L,5L,6L,41L,4L,1L,14L,1L };
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
public class A109203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109203Inst : IEnumerable<long>
{
public static readonly long[] Value=A109203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109203.Bytes);
public long this[int i]=>Value[i];

public static A109203Inst Instance=new A109203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109204
{
public static readonly long[] Value={ 2L,3L,5L,10L,5L,2L,11L,4L,7L,2L,9L,4L,7L,5L,3L,2L,7L,16L,7L,2L,39L,2L,25L,12L,5L,7L,21L,2L,5L,3L,7L,16L,9L,17L,5L,24L,19L,4L,3L,20L,7L,6L,11L,4L,3L,4L,17L,12L,17L,2L,7L,70L,3L,3L,5L,2L,11L,16L,5L,42L,7L,4L,3L,26L,3L,9L,25L,26L,9L,5L,33L,6L,23L,12L,23L,2L,9L,6L,7L,2L,23L,4L,3L,16L,11L,16L,9L,2L,3L };
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
public class A109204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109204Inst : IEnumerable<long>
{
public static readonly long[] Value=A109204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109204.Bytes);
public long this[int i]=>Value[i];

public static A109204Inst Instance=new A109204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109205
{
public static readonly long[] Value={ 2L,3L,7L,4L,1L,4L,5L,2L,5L,10L,3L,2L,11L,7L,9L,8L,1L,10L,7L,4L,7L,4L,5L,2L,5L,3L,1L,20L,3L,9L,7L,2L,7L,5L,21L,4L,5L,2L,3L,4L,3L,4L,25L,3L,3L,13L,31L,2L,7L,24L,7L,2L,5L,2L,1L,4L,9L,7L,5L,4L,23L,9L,17L,8L,29L,8L,17L,2L,3L,10L,13L,2L,13L,7L,5L,4L,11L,8L,5L,10L,17L,4L,21L,5L,31L,4L,5L,4L,13L,2L,7L,4L,25L };
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
public class A109205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109205Inst : IEnumerable<long>
{
public static readonly long[] Value=A109205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109205.Bytes);
public long this[int i]=>Value[i];

public static A109205Inst Instance=new A109205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109206
{
public static readonly long[] Value={ 2L,3L,1L,2L,3L,6L,1L,4L,9L,8L,13L,4L,1L,2L,3L,8L,7L,6L,5L,28L,3L,4L,5L,6L,5L,2L,9L,4L,9L,6L,29L,2L,15L,7L,5L,48L,5L,5L,33L,8L,7L,24L,17L,4L,15L,14L,11L,4L,5L,8L,9L,10L,7L,6L,31L,8L,3L,4L,5L,18L,13L,34L,5L,2L,5L,18L,35L,12L,15L,2L,27L,6L,31L,5L,3L,34L,5L,9L,7L,2L,3L,4L,13L,14L,23L,2L,15L,22L,21L,48L };
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
public class A109206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109206Inst : IEnumerable<long>
{
public static readonly long[] Value=A109206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109206.Bytes);
public long this[int i]=>Value[i];

public static A109206Inst Instance=new A109206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109207
{
public static readonly long[] Value={ 3998993L,7696967L,7778777L,7794977L,7868687L,7884887L,7958597L,9586859L,9758579L,9782879L,9938399L,138989831L,139969931L,148888841L,148969841L,157888751L,159929951L,166888661L,167787761L,168929861L,169666961L,174989471L };
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
public class A109207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109207Inst : IEnumerable<long>
{
public static readonly long[] Value=A109207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109207.Bytes);
public long this[int i]=>Value[i];

public static A109207Inst Instance=new A109207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109208
{
public static readonly long[] Value={ 2L,3L,5L,7L,919L,31513L,1008001L,1123211L,1160611L,1268621L,1286821L,1311131L,1317131L,1412141L,1628261L,1802081L,1826281L,3187813L,3228223L,3245423L,3286823L,3291923L,3362633L,3528253L,3591953L,3765673L,3773773L,3781873L };
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
public class A109208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109208Inst : IEnumerable<long>
{
public static readonly long[] Value=A109208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109208.Bytes);
public long this[int i]=>Value[i];

public static A109208Inst Instance=new A109208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109209
{
public static readonly long[] Value={ 1123211L,1412141L,3228223L,3773773L,7949497L,9495949L,100161001L,101060101L,101141101L,110232011L,111050111L,112030211L,112111211L,113111311L,121111121L,122363221L,122444221L,125252521L,131030131L,131111131L,138313831L,138383831L };
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
public class A109209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109209Inst : IEnumerable<long>
{
public static readonly long[] Value=A109209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109209.Bytes);
public long this[int i]=>Value[i];

public static A109209Inst Instance=new A109209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109210
{
public static readonly long[] Value={ 2L,16L,30L,31L,39L,42L,45L,48L,53L,54L,66L,67L,68L,69L,71L,74L,94L,100L,103L,110L,111L,116L,119L,124L,126L,128L,131L,139L,140L,142L,145L,147L,148L,150L,152L,157L,160L,161L,162L,165L,166L,172L,174L,176L,180L,183L,184L,186L,191L,199L,201L,208L,209L,213L,230L,235L };
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
public class A109210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109210Inst : IEnumerable<long>
{
public static readonly long[] Value=A109210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109210.Bytes);
public long this[int i]=>Value[i];

public static A109210Inst Instance=new A109210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109211
{
public static readonly long[] Value={ 21L,37L,47L,48L,57L,60L,63L,69L,74L,75L,85L,85L,88L,89L,91L,95L,118L,121L,126L,132L,134L,139L,141L,146L,150L,151L,156L,163L,164L,167L,171L,173L,173L,178L,180L,182L,186L,186L,187L,189L,189L,192L,194L,195L,198L,202L,203L,205L,210L,218L,220L,227L,227L,233L,253L };
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
public class A109211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109211Inst : IEnumerable<long>
{
public static readonly long[] Value=A109211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109211.Bytes);
public long this[int i]=>Value[i];

public static A109211Inst Instance=new A109211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109212
{
public static readonly long[] Value={ 20L,22L,18L,18L,19L,19L,19L,22L,22L,22L,20L,19L,21L,21L,21L,22L,25L,22L,24L,23L,24L,24L,23L,23L,25L,24L,26L,25L,25L,26L,27L,27L,26L,29L,29L,26L,27L,26L,26L,25L,24L,21L,21L,20L,19L,20L,20L,20L,20L,20L,20L,20L,19L,21L,24L,23L,23L,23L,23L,22L,21L,23L,23L,25L,26L,26L,25L,26L,26L };
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
public class A109212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109212Inst : IEnumerable<long>
{
public static readonly long[] Value=A109212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109212.Bytes);
public long this[int i]=>Value[i];

public static A109212Inst Instance=new A109212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109213
{
public static readonly BigInteger[] Value={ 1L,2L,2L,4L,8L,32L,184L,15392L,5400584L,74651892640L,25003708306137848L,BigInteger.Parse("6335942056759761366725617280"),BigInteger.Parse("20682199297864337408779128828731176793076928") };
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
public class A109213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109213Inst Instance=new A109213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109214
{
public static readonly BigInteger[] Value={ 1L,2L,2L,4L,8L,32L,256L,5888L,3838976L,34109301760L,231888097227054080L,BigInteger.Parse("1556059601911449331359933440"),BigInteger.Parse("125186119679477750610733678211850458005934080"),BigInteger.Parse("55507466796083630515105997822341552764197877620395801846452095434158080") };
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
public class A109214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109214Inst Instance=new A109214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109215
{
public static readonly BigInteger[] Value={ 17L,5L,3L,11L,11L,3L,677L,17L,3L,83L,23L,3L,5L,29L,3L,1049L,23L,3L,307L,41L,3L,5L,5L,3L,41L,53L,3L,BigInteger.Parse("523347633027360537213687137"),59L,3L,11L,5L,3L,227L,71L,3L,630023L,101L,3L,29L,47L,3L,5L,89L,3L,1957243L,11L,3L,251L,101L,3L,5L,5L,3L,29L,113L,3L,1289L,11L,3L,701L,5L,3L,307L };
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
public class A109215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109215Inst Instance=new A109215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109216
{
public static readonly long[] Value={ 3L,17L,3L,3L,593L,3L,3L,32993L,3L,3L,2097593L,3L,3L,73L,3L,3L,8589935681L,3L,3L,17L,3L,3L,11L,3L,3L,83L,3L,3L,11L,3L,3L,17L,3L,3L,857L,3L,3L,71329L,3L,3L,59L,3L,3L,19L,3L,3L,11L,3L,3L,17L,3L,3L,4561633L,3L,3L,2940725100673L,3L,3L,193L,3L,3L,1867L,3L,3L,17L,3L,3L,44449L,3L,3L,19L,3L,3L };
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
public class A109216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109216Inst : IEnumerable<long>
{
public static readonly long[] Value=A109216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109216.Bytes);
public long this[int i]=>Value[i];

public static A109216Inst Instance=new A109216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109217
{
public static readonly long[] Value={ 0L,0L,1L,11L,1101L,11011L,110111L,1101111L,110111101L,1101111011L,11011110111L,110111101111L,1101111011111L,11011110111111L,1101111011111101L,11011110111111011L,110111101111110111L,1101111011111101111L };
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
public class A109217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109217Inst : IEnumerable<long>
{
public static readonly long[] Value=A109217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109217.Bytes);
public long this[int i]=>Value[i];

public static A109217Inst Instance=new A109217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109218
{
public static readonly long[] Value={ 3L,20L,24L,30L,42L,78L,84L,98L,608L,698L,728L,746L };
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
public class A109218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109218Inst : IEnumerable<long>
{
public static readonly long[] Value=A109218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109218.Bytes);
public long this[int i]=>Value[i];

public static A109218Inst Instance=new A109218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109219
{
public static readonly long[] Value={ 8L,0L,9L,3L,9L,6L,5L,9L,7L,3L,6L,6L,2L,9L,0L,1L,0L,9L,5L,7L,8L,6L,8L,0L,4L,7L,8L,7L,2L,6L,3L,8L,2L,1L,1L,9L,3L,7L,2L,7L,8L,7L,6L,4L,8L,2L,6L,1L,1L,3L,0L,1L,6L,5L,8L,7L,7L,5L,8L,3L,3L,2L,4L,9L,0L,8L,8L,1L,4L,9L,1L,1L,3L,7L,3L,6L,2L,2L,7L,8L,9L,3L,7L,4L,6L,0L,1L,8L,3L,3L,8L,5L,7L,3L,5L,3L,0L,1L,4L,6L,2L,7L,1L,2L,6L };
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
public class A109219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109219Inst : IEnumerable<long>
{
public static readonly long[] Value=A109219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109219.Bytes);
public long this[int i]=>Value[i];

public static A109219Inst Instance=new A109219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109220
{
public static readonly long[] Value={ 1L,3L,7L,20L,53L,143L,385L,1036L,2789L,7507L,20207L,54392L,146409L,394095L,1060801L,2855400L,7685993L,20688691L,55688567L,149899116L,403489373L,1086088287L,2923466753L,7869210964L,21181866061L,57016065763L,153472396895L };
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
public class A109220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109220Inst : IEnumerable<long>
{
public static readonly long[] Value=A109220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109220.Bytes);
public long this[int i]=>Value[i];

public static A109220Inst Instance=new A109220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109221
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,5L,3L,1L,1L,1L,7L,5L,6L,1L,1L,1L,9L,7L,15L,6L,1L,1L,1L,11L,9L,28L,15L,10L,1L,1L,1L,13L,11L,45L,28L,35L,10L,1L,1L,1L,15L,13L,66L,45L,84L,35L,15L,1L,1L,1L,17L,15L,91L,66L,165L,84L,70L,15L,1L,1L,1L,19L,17L,120L,91L,286L,165L,210L,70L,21L,1L,1L,1L,21L,19L };
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
public class A109221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109221Inst : IEnumerable<long>
{
public static readonly long[] Value=A109221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109221.Bytes);
public long this[int i]=>Value[i];

public static A109221Inst Instance=new A109221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109222
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,21L,40L,76L,145L,276L,526L,1002L,1909L,3637L,6929L,13201L,25150L,47915L,91286L,173915L,331337L,631252L,1202640L,2291229L,4365172L,8316378L,15844082L,30185609L,57508601L,109563441L,208736561L,397677834L,757642355L,1443434582L };
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
public class A109222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109222Inst : IEnumerable<long>
{
public static readonly long[] Value=A109222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109222.Bytes);
public long this[int i]=>Value[i];

public static A109222Inst Instance=new A109222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109223
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,5L,1L,1L,1L,6L,5L,7L,1L,1L,1L,6L,15L,7L,9L,1L,1L,1L,10L,15L,28L,9L,11L,1L,1L,1L,10L,35L,28L,45L,11L,13L,1L,1L,1L,15L,35L,84L,45L,66L,13L,15L,1L,1L,1L,15L,70L,84L,165L,66L,91L,15L,17L,1L,1L,1L,21L,70L,210L,165L,286L,91L,120L,17L,19L,1L,1L,1L,21L,126L,210L };
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
public class A109223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109223Inst : IEnumerable<long>
{
public static readonly long[] Value=A109223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109223.Bytes);
public long this[int i]=>Value[i];

public static A109223Inst Instance=new A109223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109224
{
public static readonly long[] Value={ 3L,13L,42L,128L,343L,881L,2189L,5359L,13023L,31537L,76245L,184191L,444807L };
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
public class A109224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109224Inst : IEnumerable<long>
{
public static readonly long[] Value=A109224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109224.Bytes);
public long this[int i]=>Value[i];

public static A109224Inst Instance=new A109224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109225
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,7L,6L,1L,1L,5L,12L,13L,8L,1L,1L,6L,17L,26L,21L,10L,1L,1L,7L,24L,43L,48L,31L,12L,1L,1L,8L,31L,68L,91L,80L,43L,14L,1L,1L,9L,40L,99L,160L,171L,124L,57L,16L,1L,1L,10L,49L,140L,259L,332L,295L,182L,73L,18L,1L,1L,11L,60L,189L,400L,591L,628L,477L };
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
public class A109225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109225Inst : IEnumerable<long>
{
public static readonly long[] Value=A109225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109225.Bytes);
public long this[int i]=>Value[i];

public static A109225Inst Instance=new A109225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109226
{
public static readonly long[] Value={ 30L,34L,42L,46L,53L,61L,62L,66L,91L,97L,99L,106L,114L,121L,137L,145L,146L,150L,154L,162L,172L,175L,180L,189L,203L,214L,217L,221L,232L,239L,250L,258L,259L,263L,266L,274L,278L,289L,293L,297L,304L,309L,316L,319L,324L,331L,334L,335L,338L,342L,344L,350L,357L,360L };
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
public class A109226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109226Inst : IEnumerable<long>
{
public static readonly long[] Value=A109226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109226.Bytes);
public long this[int i]=>Value[i];

public static A109226Inst Instance=new A109226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109227
{
public static readonly BigInteger[] Value={ 1L,11L,1101L,110101L,1101010001L,110101000101L,1101010001010001L,110101000101000101L,BigInteger.Parse("1101010001010001010001"),BigInteger.Parse("1101010001010001010001000001"),BigInteger.Parse("110101000101000101000100000101"),BigInteger.Parse("110101000101000101000100000101000001") };
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
public class A109227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109227Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109227.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109227Inst Instance=new A109227Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109228
{
public static readonly long[] Value={ 1L,3L,9L,17L,159L };
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
public class A109228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109228Inst : IEnumerable<long>
{
public static readonly long[] Value=A109228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109228.Bytes);
public long this[int i]=>Value[i];

public static A109228Inst Instance=new A109228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109229
{
public static readonly BigInteger[] Value={ 1L,12L,1124L,212338L,11434656L,2124676182L,215338937900L,2011338654109729L,BigInteger.Parse("20314234480170281558"),BigInteger.Parse("20317265802504533296"),BigInteger.Parse("50431498946030705115"),BigInteger.Parse("50834622289546876944"),BigInteger.Parse("50937835732083050773"),BigInteger.Parse("50937875857418523592") };
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
public class A109229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109229Inst Instance=new A109229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109230
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,6L,12L,14L };
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
public class A109230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109230Inst : IEnumerable<long>
{
public static readonly long[] Value=A109230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109230.Bytes);
public long this[int i]=>Value[i];

public static A109230Inst Instance=new A109230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109231
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,13L,15L,16L,18L,20L,21L,23L,24L,26L,27L,29L,30L,32L,33L,35L,37L,38L,40L,41L,43L,44L,46L,47L,49L,50L,52L,54L,55L,57L,58L,60L,61L,63L,64L,66L,67L,69L,70L,72L,74L,75L,77L,78L,80L,81L,83L,84L,86L,87L,89L,91L,92L,94L,95L,97L,98L,100L };
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
public class A109231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109231Inst : IEnumerable<long>
{
public static readonly long[] Value=A109231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109231.Bytes);
public long this[int i]=>Value[i];

public static A109231Inst Instance=new A109231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109232
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,19L,22L,25L,28L,31L,34L,36L,39L,42L,45L,48L,51L,53L,56L,59L,62L,65L,68L,71L,73L,76L,79L,82L,85L,88L,90L,93L,96L,99L,102L,105L,107L,110L,113L,116L,119L,122L,125L,127L,130L,133L,136L,139L,142L,144L,147L,150L,153L,156L,159L,161L };
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
public class A109232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109232Inst : IEnumerable<long>
{
public static readonly long[] Value=A109232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109232.Bytes);
public long this[int i]=>Value[i];

public static A109232Inst Instance=new A109232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109233
{
public static readonly long[] Value={ 2L,1L,5L,8L,3L,11L,14L,4L,17L,19L,6L,22L,25L,7L,28L,31L,9L,34L,10L,36L,39L,12L,42L,45L,13L,48L,51L,15L,53L,56L,16L,59L,62L,18L,65L,20L,68L,71L,21L,73L,76L,23L,79L,82L,24L,85L,88L,26L,90L,93L,27L,96L,29L,99L,102L,30L,105L,107L,32L,110L,113L,33L,116L,119L };
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
public class A109233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109233Inst : IEnumerable<long>
{
public static readonly long[] Value=A109233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109233.Bytes);
public long this[int i]=>Value[i];

public static A109233Inst Instance=new A109233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109234
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,77L };
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
public class A109234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109234Inst : IEnumerable<long>
{
public static readonly long[] Value=A109234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109234.Bytes);
public long this[int i]=>Value[i];

public static A109234Inst Instance=new A109234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109235
{
public static readonly long[] Value={ 6L,13L,20L,26L,33L,40L,46L,53L,60L,67L,73L,80L,87L,93L,100L,107L,114L,120L,127L,134L,140L,147L,154L,160L,167L,174L,181L,187L,194L,201L,207L,214L,221L,228L,234L,241L,248L,254L,261L,268L,275L,281L,288L,295L,301L,308L,315L,321L,328L,335L,342L,348L };
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
public class A109235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109235Inst : IEnumerable<long>
{
public static readonly long[] Value=A109235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109235.Bytes);
public long this[int i]=>Value[i];

public static A109235Inst Instance=new A109235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109236
{
public static readonly long[] Value={ 6L,13L,20L,26L,33L,1L,40L,46L,53L,60L,67L,73L,2L,80L,87L,93L,100L,107L,114L,3L,120L,127L,134L,140L,147L,4L,154L,160L,167L,174L,181L,187L,5L,194L,201L,207L,214L,221L,228L,7L,234L,241L,248L,254L,261L,8L,268L,275L,281L,288L,295L,301L,9L,308L,315L };
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
public class A109236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109236Inst : IEnumerable<long>
{
public static readonly long[] Value=A109236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109236.Bytes);
public long this[int i]=>Value[i];

public static A109236Inst Instance=new A109236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109237
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,26L,27L,28L,30L,31L,32L,34L,35L,36L,38L,39L,40L,42L,43L,44L,45L,47L,48L,49L,51L,52L,53L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L,86L };
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
public class A109237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109237Inst : IEnumerable<long>
{
public static readonly long[] Value=A109237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109237.Bytes);
public long this[int i]=>Value[i];

public static A109237Inst Instance=new A109237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109238
{
public static readonly long[] Value={ 4L,8L,12L,16L,20L,25L,29L,33L,37L,41L,46L,50L,54L,58L,62L,67L,71L,75L,79L,83L,88L,92L,96L,100L,104L,109L,113L,117L,121L,125L,130L,134L,138L,142L,146L,151L,155L,159L,163L,167L,171L,176L,180L,184L,188L,192L,197L,201L,205L,209L,213L,218L,222L,226L };
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
public class A109238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109238Inst : IEnumerable<long>
{
public static readonly long[] Value=A109238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109238.Bytes);
public long this[int i]=>Value[i];

public static A109238Inst Instance=new A109238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109239
{
public static readonly long[] Value={ 4L,8L,12L,1L,16L,20L,25L,2L,29L,33L,37L,3L,41L,46L,50L,5L,54L,58L,62L,6L,67L,71L,75L,79L,7L,83L,88L,92L,9L,96L,100L,104L,10L,109L,113L,117L,11L,121L,125L,130L,13L,134L,138L,142L,146L,14L,151L,155L,159L,15L,163L,167L,171L,17L,176L,180L,184L,18L,188L,192L };
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
public class A109239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109239Inst : IEnumerable<long>
{
public static readonly long[] Value=A109239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109239.Bytes);
public long this[int i]=>Value[i];

public static A109239Inst Instance=new A109239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109240
{
public static readonly long[] Value={ 12L,16L,31L,55L,74L,84L,86L,93L,108L,114L,133L,161L,164L,170L,200L,211L,218L,224L,231L,242L,252L,271L,287L,301L,347L,358L,449L,450L,505L,520L,556L,576L,597L,621L,622L,629L,632L,657L,667L,703L,716L,733L,756L,767L,782L,788L,789L,813L,814L,834L,850L,852L,882L };
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
public class A109240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109240Inst : IEnumerable<long>
{
public static readonly long[] Value=A109240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109240.Bytes);
public long this[int i]=>Value[i];

public static A109240Inst Instance=new A109240Inst();

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