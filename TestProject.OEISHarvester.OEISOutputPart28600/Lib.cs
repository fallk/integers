using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A022289
{
public static readonly long[] Value={ 0L,16L,63L,141L,250L,390L,561L,763L,996L,1260L,1555L,1881L,2238L,2626L,3045L,3495L,3976L,4488L,5031L,5605L,6210L,6846L,7513L,8211L,8940L,9700L,10491L,11313L,12166L,13050L,13965L,14911L,15888L,16896L,17935L };
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
public class A022289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022289Inst : IEnumerable<long>
{
public static readonly long[] Value=A022289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022289.Bytes);
public long this[int i]=>Value[i];

public static A022289Inst Instance=new A022289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022288
{
public static readonly long[] Value={ 0L,15L,61L,138L,246L,385L,555L,756L,988L,1251L,1545L,1870L,2226L,2613L,3031L,3480L,3960L,4471L,5013L,5586L,6190L,6825L,7491L,8188L,8916L,9675L,10465L,11286L,12138L,13021L,13935L,14880L,15856L,16863L,17901L };
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
public class A022288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022288Inst : IEnumerable<long>
{
public static readonly long[] Value=A022288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022288.Bytes);
public long this[int i]=>Value[i];

public static A022288Inst Instance=new A022288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022287
{
public static readonly long[] Value={ 0L,15L,59L,132L,234L,365L,525L,714L,932L,1179L,1455L,1760L,2094L,2457L,2849L,3270L,3720L,4199L,4707L,5244L,5810L,6405L,7029L,7682L,8364L,9075L,9815L,10584L,11382L,12209L,13065L,13950L,14864L,15807L,16779L };
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
public class A022287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022287Inst : IEnumerable<long>
{
public static readonly long[] Value=A022287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022287.Bytes);
public long this[int i]=>Value[i];

public static A022287Inst Instance=new A022287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022286
{
public static readonly long[] Value={ 0L,14L,57L,129L,230L,360L,519L,707L,924L,1170L,1445L,1749L,2082L,2444L,2835L,3255L,3704L,4182L,4689L,5225L,5790L,6384L,7007L,7659L,8340L,9050L,9789L,10557L,11354L,12180L,13035L,13919L,14832L,15774L,16745L };
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
public class A022286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022286Inst : IEnumerable<long>
{
public static readonly long[] Value=A022286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022286.Bytes);
public long this[int i]=>Value[i];

public static A022286Inst Instance=new A022286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022285
{
public static readonly long[] Value={ 0L,14L,55L,123L,218L,340L,489L,665L,868L,1098L,1355L,1639L,1950L,2288L,2653L,3045L,3464L,3910L,4383L,4883L,5410L,5964L,6545L,7153L,7788L,8450L,9139L,9855L,10598L,11368L,12165L,12989L,13840L,14718L,15623L };
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
public class A022285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022285Inst : IEnumerable<long>
{
public static readonly long[] Value=A022285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022285.Bytes);
public long this[int i]=>Value[i];

public static A022285Inst Instance=new A022285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022284
{
public static readonly long[] Value={ 0L,13L,53L,120L,214L,335L,483L,658L,860L,1089L,1345L,1628L,1938L,2275L,2639L,3030L,3448L,3893L,4365L,4864L,5390L,5943L,6523L,7130L,7764L,8425L,9113L,9828L,10570L,11339L,12135L,12958L,13808L,14685L,15589L };
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
public class A022284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022284Inst : IEnumerable<long>
{
public static readonly long[] Value=A022284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022284.Bytes);
public long this[int i]=>Value[i];

public static A022284Inst Instance=new A022284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022283
{
public static readonly long[] Value={ 0L,13L,51L,114L,202L,315L,453L,616L,804L,1017L,1255L,1518L,1806L,2119L,2457L,2820L,3208L,3621L,4059L,4522L,5010L,5523L,6061L,6624L,7212L,7825L,8463L,9126L,9814L,10527L,11265L,12028L,12816L,13629L,14467L };
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
public class A022283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022283Inst : IEnumerable<long>
{
public static readonly long[] Value=A022283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022283.Bytes);
public long this[int i]=>Value[i];

public static A022283Inst Instance=new A022283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022282
{
public static readonly long[] Value={ 0L,12L,49L,111L,198L,310L,447L,609L,796L,1008L,1245L,1507L,1794L,2106L,2443L,2805L,3192L,3604L,4041L,4503L,4990L,5502L,6039L,6601L,7188L,7800L,8437L,9099L,9786L,10498L,11235L,11997L,12784L,13596L,14433L };
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
public class A022282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022282Inst : IEnumerable<long>
{
public static readonly long[] Value=A022282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022282.Bytes);
public long this[int i]=>Value[i];

public static A022282Inst Instance=new A022282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022281
{
public static readonly long[] Value={ 0L,12L,47L,105L,186L,290L,417L,567L,740L,936L,1155L,1397L,1662L,1950L,2261L,2595L,2952L,3332L,3735L,4161L,4610L,5082L,5577L,6095L,6636L,7200L,7787L,8397L,9030L,9686L,10365L,11067L,11792L,12540L,13311L };
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
public class A022281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022281Inst : IEnumerable<long>
{
public static readonly long[] Value=A022281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022281.Bytes);
public long this[int i]=>Value[i];

public static A022281Inst Instance=new A022281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022280
{
public static readonly long[] Value={ 0L,11L,45L,102L,182L,285L,411L,560L,732L,927L,1145L,1386L,1650L,1937L,2247L,2580L,2936L,3315L,3717L,4142L,4590L,5061L,5555L,6072L,6612L,7175L,7761L,8370L,9002L,9657L,10335L,11036L,11760L,12507L,13277L };
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
public class A022280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022280Inst : IEnumerable<long>
{
public static readonly long[] Value=A022280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022280.Bytes);
public long this[int i]=>Value[i];

public static A022280Inst Instance=new A022280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022279
{
public static readonly long[] Value={ 0L,11L,43L,96L,170L,265L,381L,518L,676L,855L,1055L,1276L,1518L,1781L,2065L,2370L,2696L,3043L,3411L,3800L,4210L,4641L,5093L,5566L,6060L,6575L,7111L,7668L,8246L,8845L,9465L,10106L,10768L,11451L,12155L };
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
public class A022279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022279Inst : IEnumerable<long>
{
public static readonly long[] Value=A022279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022279.Bytes);
public long this[int i]=>Value[i];

public static A022279Inst Instance=new A022279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022278
{
public static readonly long[] Value={ 0L,10L,41L,93L,166L,260L,375L,511L,668L,846L,1045L,1265L,1506L,1768L,2051L,2355L,2680L,3026L,3393L,3781L,4190L,4620L,5071L,5543L,6036L,6550L,7085L,7641L,8218L,8816L,9435L,10075L,10736L,11418L,12121L };
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
public class A022278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022278Inst : IEnumerable<long>
{
public static readonly long[] Value=A022278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022278.Bytes);
public long this[int i]=>Value[i];

public static A022278Inst Instance=new A022278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022277
{
public static readonly long[] Value={ 0L,10L,39L,87L,154L,240L,345L,469L,612L,774L,955L,1155L,1374L,1612L,1869L,2145L,2440L,2754L,3087L,3439L,3810L,4200L,4609L,5037L,5484L,5950L,6435L,6939L,7462L,8004L,8565L,9145L,9744L,10362L,10999L,11655L,12330L,13024L,13737L,14469L,15220L,15990L,16779L,17587L,18414L };
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
public class A022277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022277Inst : IEnumerable<long>
{
public static readonly long[] Value=A022277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022277.Bytes);
public long this[int i]=>Value[i];

public static A022277Inst Instance=new A022277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022276
{
public static readonly long[] Value={ 0L,9L,37L,84L,150L,235L,339L,462L,604L,765L,945L,1144L,1362L,1599L,1855L,2130L,2424L,2737L,3069L,3420L,3790L,4179L,4587L,5014L,5460L,5925L,6409L,6912L,7434L,7975L,8535L,9114L,9712L,10329L,10965L,11620L,12294L,12987L,13699L,14430L,15180L,15949L,16737L,17544L,18370L };
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
public class A022276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022276Inst : IEnumerable<long>
{
public static readonly long[] Value=A022276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022276.Bytes);
public long this[int i]=>Value[i];

public static A022276Inst Instance=new A022276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022275
{
public static readonly long[] Value={ 0L,9L,35L,78L,138L,215L,309L,420L,548L,693L,855L,1034L,1230L,1443L,1673L,1920L,2184L,2465L,2763L,3078L,3410L,3759L,4125L,4508L,4908L,5325L,5759L,6210L,6678L,7163L,7665L,8184L,8720L,9273L,9843L,10430L,11034L,11655L,12293L,12948L,13620L,14309L,15015L };
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
public class A022275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022275Inst : IEnumerable<long>
{
public static readonly long[] Value=A022275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022275.Bytes);
public long this[int i]=>Value[i];

public static A022275Inst Instance=new A022275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022274
{
public static readonly long[] Value={ 0L,8L,33L,75L,134L,210L,303L,413L,540L,684L,845L,1023L,1218L,1430L,1659L,1905L,2168L,2448L,2745L,3059L,3390L,3738L,4103L,4485L,4884L,5300L,5733L,6183L,6650L,7134L,7635L,8153L,8688L,9240L,9809L,10395L,10998L,11618L,12255L,12909L,13580L,14268L,14973L };
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
public class A022274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022274Inst : IEnumerable<long>
{
public static readonly long[] Value=A022274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022274.Bytes);
public long this[int i]=>Value[i];

public static A022274Inst Instance=new A022274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022273
{
public static readonly long[] Value={ 0L,8L,31L,69L,122L,190L,273L,371L,484L,612L,755L,913L,1086L,1274L,1477L,1695L,1928L,2176L,2439L,2717L,3010L,3318L,3641L,3979L,4332L,4700L,5083L,5481L,5894L,6322L,6765L,7223L,7696L,8184L,8687L,9205L,9738L,10286L,10849L,11427L,12020L,12628L,13251L,13889L };
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
public class A022273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022273Inst : IEnumerable<long>
{
public static readonly long[] Value=A022273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022273.Bytes);
public long this[int i]=>Value[i];

public static A022273Inst Instance=new A022273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022272
{
public static readonly long[] Value={ 0L,7L,29L,66L,118L,185L,267L,364L,476L,603L,745L,902L,1074L,1261L,1463L,1680L,1912L,2159L,2421L,2698L,2990L,3297L,3619L,3956L,4308L,4675L,5057L,5454L,5866L,6293L,6735L,7192L,7664L,8151L,8653L,9170L,9702L,10249L,10811L,11388L,11980L,12587L,13209L,13846L,14498L };
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
public class A022272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022272Inst : IEnumerable<long>
{
public static readonly long[] Value=A022272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022272.Bytes);
public long this[int i]=>Value[i];

public static A022272Inst Instance=new A022272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022271
{
public static readonly long[] Value={ 0L,7L,27L,60L,106L,165L,237L,322L,420L,531L,655L,792L,942L,1105L,1281L,1470L,1672L,1887L,2115L,2356L,2610L,2877L,3157L,3450L,3756L,4075L,4407L,4752L,5110L,5481L,5865L,6262L,6672L,7095L,7531L,7980L,8442L,8917L,9405L,9906L,10420L,10947L,11487L,12040L };
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
public class A022271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022271Inst : IEnumerable<long>
{
public static readonly long[] Value=A022271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022271.Bytes);
public long this[int i]=>Value[i];

public static A022271Inst Instance=new A022271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022270
{
public static readonly long[] Value={ 0L,6L,25L,57L,102L,160L,231L,315L,412L,522L,645L,781L,930L,1092L,1267L,1455L,1656L,1870L,2097L,2337L,2590L,2856L,3135L,3427L,3732L,4050L,4381L,4725L,5082L,5452L,5835L,6231L,6640L,7062L,7497L,7945L,8406L,8880L,9367L,9867L,10380L,10906L,11445L };
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
public class A022270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022270Inst : IEnumerable<long>
{
public static readonly long[] Value=A022270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022270.Bytes);
public long this[int i]=>Value[i];

public static A022270Inst Instance=new A022270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022269
{
public static readonly long[] Value={ 0L,6L,23L,51L,90L,140L,201L,273L,356L,450L,555L,671L,798L,936L,1085L,1245L,1416L,1598L,1791L,1995L,2210L,2436L,2673L,2921L,3180L,3450L,3731L,4023L,4326L,4640L,4965L,5301L,5648L,6006L,6375L,6755L,7146L,7548L,7961L,8385L,8820L,9266L,9723L,10191L,10670L,11160L };
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
public class A022269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022269Inst : IEnumerable<long>
{
public static readonly long[] Value=A022269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022269.Bytes);
public long this[int i]=>Value[i];

public static A022269Inst Instance=new A022269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022268
{
public static readonly long[] Value={ 0L,5L,21L,48L,86L,135L,195L,266L,348L,441L,545L,660L,786L,923L,1071L,1230L,1400L,1581L,1773L,1976L,2190L,2415L,2651L,2898L,3156L,3425L,3705L,3996L,4298L,4611L,4935L,5270L,5616L,5973L,6341L,6720L,7110L,7511L,7923L,8346L,8780L,9225L,9681L,10148L,10626L,11115L };
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
public class A022268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022268Inst : IEnumerable<long>
{
public static readonly long[] Value=A022268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022268.Bytes);
public long this[int i]=>Value[i];

public static A022268Inst Instance=new A022268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022267
{
public static readonly long[] Value={ 0L,5L,19L,42L,74L,115L,165L,224L,292L,369L,455L,550L,654L,767L,889L,1020L,1160L,1309L,1467L,1634L,1810L,1995L,2189L,2392L,2604L,2825L,3055L,3294L,3542L,3799L,4065L,4340L,4624L,4917L,5219L,5530L,5850L,6179L };
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
public class A022267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022267Inst : IEnumerable<long>
{
public static readonly long[] Value=A022267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022267.Bytes);
public long this[int i]=>Value[i];

public static A022267Inst Instance=new A022267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022266
{
public static readonly long[] Value={ 0L,4L,17L,39L,70L,110L,159L,217L,284L,360L,445L,539L,642L,754L,875L,1005L,1144L,1292L,1449L,1615L,1790L,1974L,2167L,2369L,2580L,2800L,3029L,3267L,3514L,3770L,4035L,4309L,4592L,4884L,5185L,5495L,5814L,6142L,6479L,6825L,7180L,7544L,7917L,8299L,8690L,9090L,9499L };
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
public class A022266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022266Inst : IEnumerable<long>
{
public static readonly long[] Value=A022266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022266.Bytes);
public long this[int i]=>Value[i];

public static A022266Inst Instance=new A022266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022265
{
public static readonly long[] Value={ 0L,4L,15L,33L,58L,90L,129L,175L,228L,288L,355L,429L,510L,598L,693L,795L,904L,1020L,1143L,1273L,1410L,1554L,1705L,1863L,2028L,2200L,2379L,2565L,2758L,2958L,3165L,3379L,3600L,3828L,4063L,4305L,4554L,4810L };
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
public class A022265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022265Inst : IEnumerable<long>
{
public static readonly long[] Value=A022265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022265.Bytes);
public long this[int i]=>Value[i];

public static A022265Inst Instance=new A022265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022264
{
public static readonly long[] Value={ 0L,3L,13L,30L,54L,85L,123L,168L,220L,279L,345L,418L,498L,585L,679L,780L,888L,1003L,1125L,1254L,1390L,1533L,1683L,1840L,2004L,2175L,2353L,2538L,2730L,2929L,3135L,3348L,3568L,3795L,4029L,4270L,4518L,4773L,5035L,5304L,5580L,5863L,6153L,6450L,6754L,7065L,7383L };
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
public class A022264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022264Inst : IEnumerable<long>
{
public static readonly long[] Value=A022264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022264.Bytes);
public long this[int i]=>Value[i];

public static A022264Inst Instance=new A022264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022263
{
public static readonly BigInteger[] Value={ 1L,317733228541L,BigInteger.Parse("90858964067210376612667"),BigInteger.Parse("25696504083440779881815469635549047"),BigInteger.Parse("7258558056330718241144285557911444544132154908"),BigInteger.Parse("2050065905416034207242060732309202881550943087590159038828"),BigInteger.Parse("579000252913277034724666671128579290474420179812795955722564434314244") };
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
public class A022263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022263.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022263Inst Instance=new A022263Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022262
{
public static readonly BigInteger[] Value={ 1L,35303692060L,BigInteger.Parse("1121715605764106708446"),BigInteger.Parse("35248976794718684386485952344220"),BigInteger.Parse("1106318862415031509992507967997199980871301"),BigInteger.Parse("34718046121166753868579146371116506562228516029840080"),BigInteger.Parse("1089491124906108051165135239699867397777196296355089299912829976") };
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
public class A022262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022262.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022262Inst Instance=new A022262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022261
{
public static readonly BigInteger[] Value={ 1L,3922632451L,13848340811466703906UL,BigInteger.Parse("48352505889707776105242586606"),BigInteger.Parse("168620463706718874134703442098874261321"),BigInteger.Parse("587953159580355890974683988909617412559591458771"),BigInteger.Parse("2050069762911386221695293524269464063566943065726695501256") };
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
public class A022261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022261.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022261Inst Instance=new A022261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022260
{
public static readonly BigInteger[] Value={ 1L,435848050L,170967170463507055L,BigInteger.Parse("66327168553990994916016300"),BigInteger.Parse("25700421225173962543056800181928315"),BigInteger.Parse("9957038381881749517654238255938525131005050"),BigInteger.Parse("3857567937595016308705834953070576178084351138070085") };
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
public class A022260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022260Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022260.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022260.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022260Inst Instance=new A022260Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022259
{
public static readonly BigInteger[] Value={ 1L,48427561L,2110705802810605L,BigInteger.Parse("90983770072735012966405"),BigInteger.Parse("3917150001348391097251303957615"),BigInteger.Parse("168623318873839155489174680568370759015"),BigInteger.Parse("7258694620170400715835032365617891585605600635"),BigInteger.Parse("312463067466939934510699888848526630609825159414503235") };
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
public class A022259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022259Inst Instance=new A022259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022258
{
public static readonly BigInteger[] Value={ 1L,5380840L,26058095733124L,BigInteger.Parse("124806266065883690200"),BigInteger.Parse("597035499217287155085549610"),BigInteger.Parse("2855650645340126913932218722028600"),BigInteger.Parse("13658514212390616911370927114097728660820") };
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
public class A022258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022258Inst Instance=new A022258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022257
{
public static readonly BigInteger[] Value={ 1L,597871L,321704819164L,171201975319325044L,BigInteger.Parse("90997618413507253345810"),BigInteger.Parse("48360684318187059842589436510"),BigInteger.Parse("25700898795425967456865415317747420"),BigInteger.Parse("13658514212390616911370927114097728660820"),BigInteger.Parse("7258694620170400715835032365617891585605600635") };
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
public class A022257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022257Inst Instance=new A022257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022256
{
public static readonly BigInteger[] Value={ 1L,66430L,3971657053L,234844517989720L,13869447829832637406UL,BigInteger.Parse("818990894351617238824300"),BigInteger.Parse("48360684318187059842589436510"),BigInteger.Parse("2855650645340126913932218722028600"),BigInteger.Parse("168623318873839155489174680568370759015") };
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
public class A022256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022256Inst Instance=new A022256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022255
{
public static readonly BigInteger[] Value={ 1L,7381L,49031983L,322140667123L,2113887057661126L,13869447829832637406UL,BigInteger.Parse("90997618413507253345810"),BigInteger.Parse("597035499217287155085549610"),BigInteger.Parse("3917150001348391097251303957615"),BigInteger.Parse("25700421225173962543056800181928315"),BigInteger.Parse("168620463706718874134703442098874261321") };
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
public class A022255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022255Inst Instance=new A022255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022254
{
public static readonly BigInteger[] Value={ 1L,820L,605242L,441826660L,322140667123L,234844517989720L,171201975319325044L,BigInteger.Parse("124806266065883690200"),BigInteger.Parse("90983770072735012966405"),BigInteger.Parse("66327168553990994916016300"),BigInteger.Parse("48352505889707776105242586606"),BigInteger.Parse("35248976794718684386485952344220") };
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
public class A022254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022254Inst Instance=new A022254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022253
{
public static readonly BigInteger[] Value={ 1L,91L,7462L,605242L,49031983L,3971657053L,321704819164L,26058095733124L,2110705802810605L,170967170463507055L,13848340811466703906UL,BigInteger.Parse("1121715605764106708446"),BigInteger.Parse("90858964067210376612667"),BigInteger.Parse("7359576089446900104682897") };
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
public class A022253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022253Inst Instance=new A022253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022252
{
public static readonly BigInteger[] Value={ 1L,78536544841L,BigInteger.Parse("5482656778286418474121"),BigInteger.Parse("377502614721293061473789582165641"),BigInteger.Parse("25948117139655026088415620969665388037494409"),BigInteger.Parse("1783195450928011476668648470344552094424349050302879369"),BigInteger.Parse("122540725761559997805240746641257692029742922745214204200122046089") };
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
public class A022252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022252Inst Instance=new A022252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022251
{
public static readonly BigInteger[] Value={ 1L,9817068105L,BigInteger.Parse("85666512159498155145"),BigInteger.Parse("737309794366817196670904616585"),BigInteger.Parse("6334989535956426629319904274460839466633"),BigInteger.Parse("54418806485048320298126020637699477339315297310345"),BigInteger.Parse("467455771483523568551302853258472608792870981791648312186505") };
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
public class A022251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022251Inst Instance=new A022251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022250
{
public static readonly BigInteger[] Value={ 1L,1227133513L,1338539252338766985L,BigInteger.Parse("1440058191955372430686340745"),BigInteger.Parse("1546628304496854696033468524851058313"),BigInteger.Parse("1660730178183390221013476379650255525660841609"),BigInteger.Parse("1783202253071230934395807391969095566387830751237232265") };
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
public class A022250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022250Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022250.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022250Inst Instance=new A022250Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022249
{
public static readonly BigInteger[] Value={ 1L,153391689L,20914675798619273L,BigInteger.Parse("2812613653548502301460105"),BigInteger.Parse("377594800550975709003441429239433"),BigInteger.Parse("50681462910057431534320730090844329858697") };
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
public class A022249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022249Inst Instance=new A022249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022248
{
public static readonly BigInteger[] Value={ 1L,19173961L,326791806956681L,BigInteger.Parse("5493386001237942388361"),BigInteger.Parse("92186229916592298695053497993"),BigInteger.Parse("1546675492323688689677277254864590473"),BigInteger.Parse("25949007804224083420097621839124559742097033") };
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
public class A022248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022248Inst Instance=new A022248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022247
{
public static readonly BigInteger[] Value={ 1L,2396745L,5106121684105L,10729268895402608265UL,BigInteger.Parse("22506402447071849965115017"),BigInteger.Parse("47200787357710533846587480462985"),BigInteger.Parse("98987603216356624971042374274625033865"),BigInteger.Parse("207592149047991945127896428337152713645086345"),BigInteger.Parse("435352316509302207932941670577738326850779860686473") };
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
public class A022247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022247Inst Instance=new A022247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022246
{
public static readonly BigInteger[] Value={ 1L,299593L,79783113865L,20955593338439305L,BigInteger.Parse("5494724540479236953737"),BigInteger.Parse("1440453028909548546592331401"),BigInteger.Parse("377607559263493603746446715115145"),BigInteger.Parse("98987603216356624971042374274625033865"),BigInteger.Parse("25949007804224083420097621839124559742097033") };
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
public class A022246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022246Inst Instance=new A022246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022245
{
public static readonly BigInteger[] Value={ 1L,37449L,1246606473L,40928737412745L,1341480367403783817L,BigInteger.Parse("43958970159454591899273"),BigInteger.Parse("1440453028909548546592331401"),BigInteger.Parse("47200787357710533846587480462985"),BigInteger.Parse("1546675492323688689677277254864590473"),BigInteger.Parse("50681462910057431534320730090844329858697") };
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
public class A022245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022245Inst Instance=new A022245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022244
{
public static readonly BigInteger[] Value={ 1L,4681L,19477641L,79936505481L,327499862955657L,1341480367403783817L,BigInteger.Parse("5494724540479236953737"),BigInteger.Parse("22506402447071849965115017"),BigInteger.Parse("92186229916592298695053497993"),BigInteger.Parse("377594800550975709003441429239433"),BigInteger.Parse("1546628304496854696033468524851058313") };
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
public class A022244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022244Inst Instance=new A022244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022243
{
public static readonly BigInteger[] Value={ 1L,585L,304265L,156087945L,79936505481L,40928737412745L,20955593338439305L,10729268895402608265UL,BigInteger.Parse("5493386001237942388361"),BigInteger.Parse("2812613653548502301460105"),BigInteger.Parse("1440058191955372430686340745"),BigInteger.Parse("737309794366817196670904616585") };
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
public class A022243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022243Inst Instance=new A022243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022242
{
public static readonly BigInteger[] Value={ 1L,73L,4745L,304265L,19477641L,1246606473L,79783113865L,5106121684105L,326791806956681L,20914675798619273L,1338539252338766985L,BigInteger.Parse("85666512159498155145"),BigInteger.Parse("5482656778286418474121"),BigInteger.Parse("350890033810959074702473") };
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
public class A022242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022242Inst Instance=new A022242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022241
{
public static readonly BigInteger[] Value={ 1L,16148168401L,BigInteger.Parse("228167924870691555751"),BigInteger.Parse("3167372099179629291002826414551"),BigInteger.Parse("43858773775052010561068085080055954232604"),BigInteger.Parse("607098005839518055568051981319221867272218743306204"),BigInteger.Parse("8403089283059531541841722254852038933206966651131615823995604") };
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
public class A022241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022241Inst Instance=new A022241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022240
{
public static readonly BigInteger[] Value={ 1L,2306881200L,4656488262337620150L,BigInteger.Parse("9234320988196680367732171600"),BigInteger.Parse("18266877872505055585959373506477770853"),BigInteger.Parse("36121735336208679823466411064327588635221204800"),BigInteger.Parse("71425080387019299237581315602206452684576535149974900600") };
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
public class A022240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022240Inst Instance=new A022240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022239
{
public static readonly BigInteger[] Value={ 1L,329554457L,95030372653688550L,BigInteger.Parse("26922218610904350161500150"),BigInteger.Parse("7608029097572151019476340332672053"),BigInteger.Parse("2149207789489010647406518443408592558383021") };
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
public class A022239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022239Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022239.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022239Inst Instance=new A022239Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022238
{
public static readonly BigInteger[] Value={ 1L,47079208L,1939395353553757L,BigInteger.Parse("78490432990886231801200"),BigInteger.Parse("3168691824510592423395247884703"),BigInteger.Parse("127875753071992714335358328311551866824"),BigInteger.Parse("5160291746051272234978893428859106387360586971"),BigInteger.Parse("208236637980093164825596972398144064919402131047044800") };
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
public class A022238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022238Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022238.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022238Inst Instance=new A022238Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022237
{
public static readonly BigInteger[] Value={ 1L,6725601L,39579496050501L,BigInteger.Parse("228835075951868449701"),BigInteger.Parse("1319738336534843578720956303"),BigInteger.Parse("7608481579300344488889504665693103"),BigInteger.Parse("43861755035533826577243997768793428552803"),BigInteger.Parse("252854596323205247053675081227392663237129990403") };
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
public class A022237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022237Inst Instance=new A022237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022236
{
public static readonly BigInteger[] Value={ 1L,960800L,807744680100L,667157540444234400L,BigInteger.Parse("549661852436388016181802"),BigInteger.Parse("452697105941691435357049202400"),BigInteger.Parse("372818701621367349292382501162685300"),BigInteger.Parse("307032604808067352305645854537522502703200"),BigInteger.Parse("252854596323205247053675081227392663237129990403") };
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
public class A022236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022236Inst Instance=new A022236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022235
{
public static readonly BigInteger[] Value={ 1L,137257L,16484565700L,1945063360640100L,BigInteger.Parse("228930106321885702602"),BigInteger.Parse("26935000671139346639437914"),BigInteger.Parse("3168902828959544132129870582100"),BigInteger.Parse("372818701621367349292382501162685300"),BigInteger.Parse("43861755035533826577243997768793428552803") };
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
public class A022235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022235Inst Instance=new A022235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022234
{
public static readonly BigInteger[] Value={ 1L,19608L,336416907L,5670690600800L,95347005938577702L,BigInteger.Parse("1602592475815614015216"),BigInteger.Parse("26935000671139346639437914"),BigInteger.Parse("452697105941691435357049202400"),BigInteger.Parse("7608481579300344488889504665693103"),BigInteger.Parse("127875753071992714335358328311551866824") };
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
public class A022234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022234Inst Instance=new A022234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022233
{
public static readonly BigInteger[] Value={ 1L,2801L,6865251L,16531644851L,39709010932102L,95347005938577702L,BigInteger.Parse("228930106321885702602"),BigInteger.Parse("549661852436388016181802"),BigInteger.Parse("1319738336534843578720956303"),BigInteger.Parse("3168691824510592423395247884703"),BigInteger.Parse("7608029097572151019476340332672053") };
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
public class A022233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022233Inst Instance=new A022233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022232
{
public static readonly BigInteger[] Value={ 1L,400L,140050L,48177200L,16531644851L,5670690600800L,1945063360640100L,667157540444234400L,BigInteger.Parse("228835075951868449701"),BigInteger.Parse("78490432990886231801200"),BigInteger.Parse("26922218610904350161500150"),BigInteger.Parse("9234320988196680367732171600") };
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
public class A022232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022232Inst Instance=new A022232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022231
{
public static readonly BigInteger[] Value={ 1L,57L,2850L,140050L,6865251L,336416907L,16484565700L,807744680100L,39579496050501L,1939395353553757L,95030372653688550L,4656488262337620150L,BigInteger.Parse("228167924870691555751"),BigInteger.Parse("11180228318776923410607"),BigInteger.Parse("547831187620860507371400") };
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
public class A022231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022231Inst Instance=new A022231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022230
{
public static readonly BigInteger[] Value={ 1L,2612138803L,5848516394205967951L,BigInteger.Parse("12790160886494733304250601655"),BigInteger.Parse("27862895440026036935366271191556077095"),BigInteger.Parse("60659259454351187375733691191139808969963672263"),BigInteger.Parse("132044834674141024683472683631781840882298387938848321159") };
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
public class A022230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022230Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022230.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022230Inst Instance=new A022230Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022229
{
public static readonly BigInteger[] Value={ 1L,435356467L,162458788655384143L,BigInteger.Parse("59213707780769522731688119"),BigInteger.Parse("21499147706200521642647791579711015"),BigInteger.Parse("7800830687562794744818371174867996113478343") };
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
public class A022229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022229Inst Instance=new A022229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022228
{
public static readonly BigInteger[] Value={ 1L,72559411L,4512744117222991L,BigInteger.Parse("274137535269957102205111"),BigInteger.Parse("16588848493045381066264096333351"),BigInteger.Parse("1003193244092547201468344847250540706503"),BigInteger.Parse("60660559425600837230512947639888522210296616583"),BigInteger.Parse("3667925165214264518763232198536887427772300866095529223") };
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
public class A022228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022228Inst Instance=new A022228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022227
{
public static readonly BigInteger[] Value={ 1L,12093235L,125354001240655L,BigInteger.Parse("1269155234987097152695"),BigInteger.Parse("12800037205947411879866507815"),BigInteger.Parse("129011474730413928552335877184470727"),BigInteger.Parse("1300166289917858220549677344211755721874055") };
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
public class A022227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022227Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022227.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022227Inst Instance=new A022227Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022226
{
public static readonly BigInteger[] Value={ 1L,2015539L,3482055254095L,5875718100153221815L,BigInteger.Parse("9876570938882852540717095"),BigInteger.Parse("16590980186519640252690843276487"),BigInteger.Parse("27867073064694433516284053323814269063"),BigInteger.Parse("46806148995565935663430369990805328306755335"),BigInteger.Parse("78616403557485470161203927752846473114607475506695") };
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
public class A022226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022226Inst Instance=new A022226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022225
{
public static readonly BigInteger[] Value={ 1L,335923L,96723701071L,27202382491194295L,BigInteger.Parse("7620806375898728694055"),BigInteger.Parse("2133612436978999661759040967"),BigInteger.Parse("597287733061433620469903134280071"),BigInteger.Parse("167202936130018543413483273700960235527"),BigInteger.Parse("46806148995565935663430369990805328306755335") };
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
public class A022225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022225Inst Instance=new A022225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022224
{
public static readonly BigInteger[] Value={ 1L,55987L,2686760143L,125936508182839L,5880230843762528935L,BigInteger.Parse("274383335413146060060487"),BigInteger.Parse("12801903280371155724242141959"),BigInteger.Parse("597287733061433620469903134280071"),BigInteger.Parse("27867073064694433516284053323814269063") };
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
public class A022224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022224Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022224.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022224Inst Instance=new A022224Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022223
{
public static readonly BigInteger[] Value={ 1L,9331L,74630671L,583026951031L,4537117983992551L,BigInteger.Parse("35285166561510069127"),BigInteger.Parse("274383335413146060060487"),BigInteger.Parse("2133612436978999661759040967"),BigInteger.Parse("16590980186519640252690843276487"),BigInteger.Parse("129011474730413928552335877184470727") };
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
public class A022223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022223.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022223Inst Instance=new A022223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022222
{
public static readonly BigInteger[] Value={ 1L,1555L,2072815L,2698853335L,3500412775495L,4537117983992551L,5880230843762528935L,BigInteger.Parse("7620806375898728694055"),BigInteger.Parse("9876570938882852540717095"),BigInteger.Parse("12800037205947411879866507815"),BigInteger.Parse("16588848493045381066264096333351") };
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
public class A022222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022222.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022222Inst Instance=new A022222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022221
{
public static readonly BigInteger[] Value={ 1L,259L,57535L,12485095L,2698853335L,583026951031L,125936508182839L,27202382491194295L,5875718100153221815L,BigInteger.Parse("1269155234987097152695"),BigInteger.Parse("274137535269957102205111"),BigInteger.Parse("59213707780769522731688119"),BigInteger.Parse("12790160886494733304250601655") };
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
public class A022221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022221Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022221.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022221.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022221Inst Instance=new A022221Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022220
{
public static readonly BigInteger[] Value={ 1L,43L,1591L,57535L,2072815L,74630671L,2686760143L,96723701071L,3482055254095L,125354001240655L,4512744117222991L,162458788655384143L,5848516394205967951L,BigInteger.Parse("210546590207087679055"),BigInteger.Parse("7579677247549193442895"),BigInteger.Parse("272868380912335185925711") };
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
public class A022220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022220Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022220.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022220.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022220Inst Instance=new A022220Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022219
{
public static readonly BigInteger[] Value={ 1L,305175781L,77610214474995931L,BigInteger.Parse("19100611156944225555440431"),BigInteger.Parse("4670708278954101902438990598678556"),BigInteger.Parse("1140674654304411569828223908172341508228556"),BigInteger.Parse("278502847205686141650283863407927164540769884103556") };
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
public class A022219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022219Inst Instance=new A022219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022218
{
public static readonly BigInteger[] Value={ 1L,61035156L,3104408566792806L,BigInteger.Parse("152804888634672088643556"),BigInteger.Parse("7473133215765585192791624069181"),BigInteger.Parse("365015887882785053079719041834672291056"),BigInteger.Parse("17824182148160735190135826789101008407579416056"),BigInteger.Parse("870332534209370628368397575515105530919233947896291056") };
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
public class A022218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022218Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022218.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022218Inst Instance=new A022218Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022217
{
public static readonly BigInteger[] Value={ 1L,12207031L,124176340230306L,BigInteger.Parse("1222439084242108174806"),BigInteger.Parse("11957012900737114492991256681"),BigInteger.Parse("116805081731088587940522831693775431"),BigInteger.Parse("1140747634121270227670449517400445860666056"),BigInteger.Parse("11140256209730412546658078532854767895273286916056") };
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
public class A022217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022217Inst Instance=new A022217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022216
{
public static readonly BigInteger[] Value={ 1L,2441406L,4967053120931L,9779511680526143556UL,BigInteger.Parse("19131218685276848401412931"),BigInteger.Parse("37377622327704219905090668384806"),BigInteger.Parse("73007841108236063781239140920167306681"),BigInteger.Parse("142595264882979563844964491038787206333791056") };
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
public class A022216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022216Inst Instance=new A022216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022215
{
public static readonly BigInteger[] Value={ 1L,488281L,198682027181L,78236053707784181L,BigInteger.Parse("30609934249224268600431"),BigInteger.Parse("11960833022875371081037525431"),BigInteger.Parse("4672499438759279108929231093087931"),BigInteger.Parse("1825218456001772231793929085435472462931"),BigInteger.Parse("712977784594148279816735342927316866304884806") };
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
public class A022215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022215Inst Instance=new A022215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022214
{
public static readonly BigInteger[] Value={ 1L,97656L,7947261556L,625886840206056L,BigInteger.Parse("48975769621072897306"),BigInteger.Parse("3827456772141158994166056"),BigInteger.Parse("299039198587280398947721603556"),BigInteger.Parse("23362736428829868448189697999416056"),BigInteger.Parse("1825218456001772231793929085435472462931") };
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
public class A022214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022214Inst Instance=new A022214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022213
{
public static readonly BigInteger[] Value={ 1L,19531L,317886556L,5007031143556L,78360229974772306L,BigInteger.Parse("1224770494838892134806"),BigInteger.Parse("19138263752352528498478556"),BigInteger.Parse("299039198587280398947721603556"),BigInteger.Parse("4672499438759279108929231093087931"),BigInteger.Parse("73007841108236063781239140920167306681") };
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
public class A022213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022213Inst Instance=new A022213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022212
{
public static readonly BigInteger[] Value={ 1L,3906L,12714681L,40053706056L,125368356709806L,391901483074853556L,BigInteger.Parse("1224770494838892134806"),BigInteger.Parse("3827456772141158994166056"),BigInteger.Parse("11960833022875371081037525431"),BigInteger.Parse("37377622327704219905090668384806"),BigInteger.Parse("116805081731088587940522831693775431") };
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
public class A022212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022212Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022212.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022212Inst Instance=new A022212Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022211
{
public static readonly BigInteger[] Value={ 1L,22369621L,400319959420837L,BigInteger.Parse("6822861635108183247077"),BigInteger.Parse("114917519925881846404167134693"),BigInteger.Parse("1929880702992615813429218299211809253"),BigInteger.Parse("32385932129579122653905315624401024370889189") };
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
public class A022211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022211Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022211.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022211Inst Instance=new A022211Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022210
{
public static readonly BigInteger[] Value={ 1L,5592405L,25019996065701L,BigInteger.Parse("106607206793565997285"),BigInteger.Parse("448896535558672700374937061"),BigInteger.Parse("1884649011792085827682980366254565"),BigInteger.Parse("7906721240160746987619507371870782509541"),BigInteger.Parse("33165216768196105736186294932151329554455695845") };
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
public class A022210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022210Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022210.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022210Inst Instance=new A022210Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022209
{
public static readonly BigInteger[] Value={ 1L,1398101L,1563749404581L,1665737215212030181L,BigInteger.Parse("1753501675591663698472421"),BigInteger.Parse("1840477112202685809580351554021"),BigInteger.Parse("1930351405154232225472089767795511781"),BigInteger.Parse("2024243704924003025844684284218991557841381") };
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
public class A022209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022209Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022209.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022209Inst Instance=new A022209Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022208
{
public static readonly BigInteger[] Value={ 1L,349525L,97734250405L,26027119554103525L,BigInteger.Parse("6849609413493939400165"),BigInteger.Parse("1797339217481455290934231525"),BigInteger.Parse("471276749188750005563056686387685"),BigInteger.Parse("123549912998815788062283863044996567525") };
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
public class A022208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022208Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022208.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022208Inst Instance=new A022208Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022207
{
public static readonly BigInteger[] Value={ 1L,87381L,6108368805L,406672215935205L,BigInteger.Parse("26756185103024942565"),BigInteger.Parse("1755207390500040817377765"),BigInteger.Parse("115057361291389776393497498085"),BigInteger.Parse("7540859480106603961931048583270885"),BigInteger.Parse("494205307747746503853075131001823990245") };
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
public class A022207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022207Inst Instance=new A022207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022206
{
public static readonly BigInteger[] Value={ 1L,21845L,381767589L,6354157930725L,104514759495347685L,BigInteger.Parse("1714043588198181437925"),BigInteger.Parse("28089747579101385828291045"),BigInteger.Parse("460250514083576206796548772325"),BigInteger.Parse("7540859480106603961931048583270885"),BigInteger.Parse("123549912998815788062283863044996567525") };
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
public class A022206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022206Inst Instance=new A022206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022205
{
public static readonly BigInteger[] Value={ 1L,5461L,23859109L,99277752549L,408235958349285L,1673768626404966885L,BigInteger.Parse("6857430062381149327845"),BigInteger.Parse("28089747579101385828291045"),BigInteger.Parse("115057361291389776393497498085"),BigInteger.Parse("471276749188750005563056686387685"),BigInteger.Parse("1930351405154232225472089767795511781") };
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
public class A022205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022205Inst Instance=new A022205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022204
{
public static readonly BigInteger[] Value={ 1L,1365L,1490853L,1550842085L,1594283908581L,1634141006295525L,1673768626404966885L,BigInteger.Parse("1714043588198181437925"),BigInteger.Parse("1755207390500040817377765"),BigInteger.Parse("1797339217481455290934231525"),BigInteger.Parse("1840477112202685809580351554021") };
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
public class A022204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022204Inst Instance=new A022204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022203
{
public static readonly BigInteger[] Value={ 1L,797161L,476599444231L,263026177881648511L,BigInteger.Parse("141530177899268957392924"),BigInteger.Parse("75525744222315755534269847164"),BigInteger.Parse("40192610828533997938427918835113044"),BigInteger.Parse("21369772545260475331545384574852469714164"),BigInteger.Parse("11358504503408920628447755309084790198295654610") };
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
public class A022203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022203Inst Instance=new A022203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022202
{
public static readonly BigInteger[] Value={ 1L,265720L,52955405230L,9741692640081640L,BigInteger.Parse("1747282899667791058573"),BigInteger.Parse("310804949350361548416923680"),BigInteger.Parse("55133793282290501540016988429720"),BigInteger.Parse("9771253933538933149312961201158497760"),BigInteger.Parse("1731212183148357775944585240618840930624286") };
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
public class A022202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022202Inst Instance=new A022202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022201
{
public static readonly BigInteger[] Value={ 1L,88573L,5883904390L,360801469802830L,BigInteger.Parse("21571273555248777493"),BigInteger.Parse("1279025522911365763892449"),BigInteger.Parse("75628919722004322604209288760"),BigInteger.Parse("4467854961017673003571751798888920"),BigInteger.Parse("263862583736385343242102717216527933566") };
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
public class A022201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022201Inst Instance=new A022201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022200
{
public static readonly BigInteger[] Value={ 1L,29524L,653757313L,13362799477720L,266307564861468823L,BigInteger.Parse("5263390747480701708292"),BigInteger.Parse("103741619611085612124067759"),BigInteger.Parse("2042880353039758115797506899680"),BigInteger.Parse("40216143252770054194345243936096486"),BigInteger.Parse("791614563787525746761491781638123230424") };
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
public class A022200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022200Inst Instance=new A022200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022199
{
public static readonly BigInteger[] Value={ 1L,9841L,72636421L,494894285941L,3287582741506063L,BigInteger.Parse("21658948312410865183"),BigInteger.Parse("142299528422960399756323"),BigInteger.Parse("934054234760012359481199283"),BigInteger.Parse("6129263888495201102915629695046"),BigInteger.Parse("40216143252770054194345243936096486"),BigInteger.Parse("263862583736385343242102717216527933566") };
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
public class A022199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022199Inst Instance=new A022199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022198
{
public static readonly BigInteger[] Value={ 1L,3280L,8069620L,18326727760L,40581331447162L,89117945389585840L,BigInteger.Parse("195168545232713290660"),BigInteger.Parse("427028776969176679964080"),BigInteger.Parse("934054234760012359481199283"),BigInteger.Parse("2042880353039758115797506899680"),BigInteger.Parse("4467854961017673003571751798888920") };
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
public class A022198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022198Inst Instance=new A022198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022197
{
public static readonly BigInteger[] Value={ 1L,1093L,896260L,678468820L,500777836042L,366573514642546L,267598665689058580L,BigInteger.Parse("195168545232713290660"),BigInteger.Parse("142299528422960399756323"),BigInteger.Parse("103741619611085612124067759"),BigInteger.Parse("75628919722004322604209288760"),BigInteger.Parse("55133793282290501540016988429720") };
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
public class A022197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022197Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022197.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022197.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022197Inst Instance=new A022197Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022196
{
public static readonly BigInteger[] Value={ 1L,364L,99463L,25095280L,6174066262L,1506472167928L,366573514642546L,89117945389585840L,BigInteger.Parse("21658948312410865183"),BigInteger.Parse("5263390747480701708292"),BigInteger.Parse("1279025522911365763892449"),BigInteger.Parse("310804949350361548416923680"),BigInteger.Parse("75525744222315755534269847164") };
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
public class A022196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022196Inst Instance=new A022196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022195
{
public static readonly BigInteger[] Value={ 1L,8191L,44731051L,209386049731L,914807651274739L,3867895279362300499L,BigInteger.Parse("16094312257426532376339"),BigInteger.Parse("66441249531569955747981459"),BigInteger.Parse("273210326382611632738979052435"),BigInteger.Parse("1121258922081448861468067825426835"),BigInteger.Parse("4597164868683271949171164500871212435") };
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
public class A022195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022195Inst Instance=new A022195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022194
{
public static readonly BigInteger[] Value={ 1L,4095L,11180715L,26167664835L,57162391576563L,120843139740969555L,BigInteger.Parse("251413193158549532435"),BigInteger.Parse("518946525150879134496915"),BigInteger.Parse("1066968301301093995246996371"),BigInteger.Parse("2189425218271613769209626653075"),BigInteger.Parse("4488323837657412597958687922896275") };
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
public class A022194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022194Inst Instance=new A022194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022193
{
public static readonly BigInteger[] Value={ 1L,2047L,2794155L,3269560515L,3571013994483L,3774561792168531L,3926442969043883795L,BigInteger.Parse("4052305562169692070035"),BigInteger.Parse("4165817792093527797314451"),BigInteger.Parse("4274137206973266943778085267"),BigInteger.Parse("4380990637147598617372537398675") };
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
public class A022193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022193Inst Instance=new A022193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022192
{
public static readonly BigInteger[] Value={ 1L,1023L,698027L,408345795L,222984027123L,117843461817939L,61291693863308051L,BigInteger.Parse("31627961868755063955"),BigInteger.Parse("16256896431763117598611"),BigInteger.Parse("8339787869494479328087443"),BigInteger.Parse("4274137206973266943778085267"),BigInteger.Parse("2189425218271613769209626653075") };
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
public class A022192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022192Inst Instance=new A022192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022191
{
public static readonly BigInteger[] Value={ 1L,511L,174251L,50955971L,13910980083L,3675639930963L,955841412523283L,246614610741341843L,BigInteger.Parse("63379954960524853651"),BigInteger.Parse("16256896431763117598611"),BigInteger.Parse("4165817792093527797314451"),BigInteger.Parse("1066968301301093995246996371"),BigInteger.Parse("273210326382611632738979052435") };
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
public class A022191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022191Inst Instance=new A022191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022190
{
public static readonly BigInteger[] Value={ 1L,255L,43435L,6347715L,866251507L,114429029715L,14877590196755L,1919209135381395L,246614610741341843L,BigInteger.Parse("31627961868755063955"),BigInteger.Parse("4052305562169692070035"),BigInteger.Parse("518946525150879134496915"),BigInteger.Parse("66441249531569955747981459") };
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
public class A022190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A022190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022190Inst Instance=new A022190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}