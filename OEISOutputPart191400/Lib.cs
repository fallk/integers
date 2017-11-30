using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A285998
{
public static readonly long[] Value={ 1L,4L,7L,16L,22L,40L,50L,80L,95L,140L,161L,224L,252L,336L,372L,480L,525L,660L,715L,880L,946L,1144L,1222L,1456L,1547L,1820L,1925L,2240L,2360L,2720L,2856L,3264L,3417L,3876L,4047L,4560L,4750L,5320L,5530L,6160L,6391L,7084L,7337L,8096L,8372L,9200L,9500L,10400L,10725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285998Inst : IEnumerable<long>
{
public static readonly long[] Value=A285998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285998.Bytes);
public long this[int i]=>Value[i];

public static A285998Inst Instance=new A285998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285999
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,4L,6L,6L,8L,10L,12L,12L,14L,16L,18L,18L,20L,22L,24L,24L,28L,30L,32L,32L,34L,36L,40L,40L,42L,44L,46L,46L,50L,52L,54L,56L,58L,60L,64L,64L,66L,68L,70L,72L,76L,78L,80L,80L,82L,84L,88L,90L,92L,94L,98L,98L,102L,104L,106L,108L,110L,112L,116L,116L,120L,122L,124L,126L,130L,132L,134L,134L,136L,138L,144L,146L,148L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285999Inst : IEnumerable<long>
{
public static readonly long[] Value=A285999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285999.Bytes);
public long this[int i]=>Value[i];

public static A285999Inst Instance=new A285999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286002
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,8L,12L,12L,15L,16L,20L,18L,24L,24L,26L,27L,32L,30L,36L,34L,38L,40L,44L,40L,47L,48L,50L,50L,56L,52L,60L,58L,62L,64L,66L,63L,72L,72L,74L,72L,80L,76L,84L,82L,84L,88L,92L,86L,95L,94L,98L,98L,104L,100L,106L,104L,110L,112L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286002Inst : IEnumerable<long>
{
public static readonly long[] Value=A286002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286002.Bytes);
public long this[int i]=>Value[i];

public static A286002Inst Instance=new A286002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286003
{
public static readonly long[] Value={ 2L,5L,6L,9L,13L,14L,17L,21L,27L,28L,30L,36L,40L,44L,45L,48L,55L,58L,59L,61L,62L,68L,72L,75L,76L,80L,84L,90L,93L,99L,103L,106L,107L,108L,111L,114L,115L,121L,122L,123L,125L,126L,129L,136L,139L,140L,144L,147L,148L,151L,155L,156L,157L,163L,167L,170L,171L,175L,178L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286003Inst : IEnumerable<long>
{
public static readonly long[] Value=A286003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286003.Bytes);
public long this[int i]=>Value[i];

public static A286003Inst Instance=new A286003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286004
{
public static readonly long[] Value={ 12L,20L,24L,33L,37L,43L,51L,52L,65L,69L,77L,83L,87L,96L,100L,118L,124L,132L,133L,160L,164L,172L,199L,226L,230L,234L,238L,245L,249L,253L,267L,275L,298L,306L,307L,315L,320L,338L,346L,347L,351L,355L,361L,362L,363L,376L,380L,384L,388L,402L,411L,415L,433L,437L,442L,443L,451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286004Inst : IEnumerable<long>
{
public static readonly long[] Value=A286004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286004.Bytes);
public long this[int i]=>Value[i];

public static A286004Inst Instance=new A286004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286005
{
public static readonly long[] Value={ 29L,60L,91L,92L,141L,154L,185L,204L,217L,241L,254L,279L,285L,342L,403L,441L,473L,497L,510L,528L,541L,572L,603L,622L,666L,697L,715L,753L,771L,779L,780L,811L,841L,873L,922L,936L,954L,973L,1022L,1047L,1053L,1066L,1091L,1122L,1234L,1291L,1347L,1404L,1422L,1453L,1496L,1561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286005Inst : IEnumerable<long>
{
public static readonly long[] Value=A286005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286005.Bytes);
public long this[int i]=>Value[i];

public static A286005Inst Instance=new A286005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286006
{
public static readonly long[] Value={ 186L,447L,635L,765L,1035L,1092L,1378L,1435L,1540L,2015L,2553L,2740L,2808L,3027L,4154L,4465L,4497L,4603L,4766L,4816L,4897L,5084L,5166L,5265L,5403L,5590L,5666L,5747L,5828L,6245L,6515L,6572L,6759L,6809L,7029L,7559L,7690L,7991L,8459L,8810L,8859L,9202L,9234L,9340L,9821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286006Inst : IEnumerable<long>
{
public static readonly long[] Value=A286006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286006.Bytes);
public long this[int i]=>Value[i];

public static A286006Inst Instance=new A286006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286071
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,85L,496L,3229L,25117L,215225L,2100430L,22187281L,261228199L,3284651245L,45163266604L,659277401525L,10380194835601L,172251467909809L,3057368096689690L,56867779157145769L,1122474190194034555L,BigInteger.Parse("23137433884903034501"),BigInteger.Parse("502874858021076645784") };
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
public class A286071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286071Inst Instance=new A286071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286072
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,16L,84L,512L,3572L,28080L,256820L,2553728L,28064776L,337319944L,4385615904L,61255920936L,921584068648L,14720437293952L,250190161426720L,4507229152534944L,85630125536152160L,1711040906290680448L,BigInteger.Parse("35969941361999955392"),BigInteger.Parse("790961860293623563648") };
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
public class A286072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286072Inst Instance=new A286072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286073
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,12L,60L,340L,2280L,17220L,151872L,1459584L,15624000L,182318400L,2316837600L,31596570720L,465582237120L,7283287851840L,121620647715840L,2149774858183680L,40196871701360640L,790002144844738560L,16364478334463078400UL,BigInteger.Parse("354458730544573132800") };
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
public class A286073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286073Inst Instance=new A286073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286074
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,13L,45L,250L,1342L,10085L,76165L,715588L,6786108L,78636601L,896672473L,12112535378L,163963519810L,2534311844905L,39211836764457L,688584972407680L,12003902219337760L,234324625117308533L,4571805253649981173L,BigInteger.Parse("98183221386947058286") };
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
public class A286074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286074Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286074.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286074.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286074Inst Instance=new A286074Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286075
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,8L,38L,182L,1194L,7932L,69192L,591936L,6286272L,66914880L,840036960L,10567285920L,154755036000L,2246755924800L,37283584936320L,618705247829760L,11472473012232960L,212762383625594880L,4386435706887413760L,BigInteger.Parse("89954629722500659200"),BigInteger.Parse("2030764767987849062400") };
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
public class A286075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286075.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286075Inst Instance=new A286075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286076
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,8L,78L,206L,2722L,10516L,169544L,883580L,16569420L,110272040L,2339828920L,19127099680L,450962267600L,4399562960000L,113769961266000L,1295735797694000L,36390357922438000L,475484093140888000L,14390912055770276000UL,BigInteger.Parse("212715123602601932000") };
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
public class A286076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286076Inst Instance=new A286076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286077
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,16L,80L,468L,3220L,24436L,218032L,2114244L,22759788L,267150264L,3413938512L,46668380592L,690881123856L,10841100147072L,181434400544160L,3215124610986240L,60280035304993920L,1186176116251848960L,BigInteger.Parse("24624604679704053120"),BigInteger.Parse("534223121657911528320") };
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
public class A286077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286077Inst Instance=new A286077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286078
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1111L,0L,111111L,0L,11111111L,1111L,1111111111L,1L,111111111111L,100L,11111111111111L,0L,1111111111111111L,11100001L,111111111111111111L,1L,11111111111111111111UL,1000000L,BigInteger.Parse("1111111111111111111111"),0L,BigInteger.Parse("111111111111111111111111"),11100000L };
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
public class A286078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286078Inst Instance=new A286078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286079
{
public static readonly ulong[] Value={ 1L,11L,100L,1111L,0L,111111L,0L,11111111L,111100000L,1111111111L,10000000000L,111111111111L,10000000000L,11111111111111L,0L,1111111111111111L,10000111000000000L,111111111111111111L,1000000000000000000L,11111111111111111111UL,100000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286079Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286079.Bytes);
public ulong this[int i]=>Value[i];

public static A286079Inst Instance=new A286079Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286080
{
public static readonly long[] Value={ 1L,3L,1L,15L,0L,63L,0L,255L,15L,1023L,1L,4095L,4L,16383L,0L,65535L,225L,262143L,1L,1048575L,64L,4194303L,0L,16777215L,224L,67108863L,0L,268435455L,0L,1073741823L,0L,4294967295L,57568L,17179869183L,0L,68719476735L,16448L,274877906943L,0L,1099511627775L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286080Inst : IEnumerable<long>
{
public static readonly long[] Value=A286080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286080.Bytes);
public long this[int i]=>Value[i];

public static A286080Inst Instance=new A286080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286081
{
public static readonly long[] Value={ 1L,3L,4L,15L,0L,63L,0L,255L,480L,1023L,1024L,4095L,1024L,16383L,0L,65535L,69120L,262143L,262144L,1048575L,16384L,4194303L,0L,16777215L,917504L,67108863L,0L,268435455L,0L,1073741823L,0L,4294967295L,235798528L,17179869183L,0L,68719476735L,1077936128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286081Inst : IEnumerable<long>
{
public static readonly long[] Value=A286081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286081.Bytes);
public long this[int i]=>Value[i];

public static A286081Inst Instance=new A286081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286082
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1110L,1L,111110L,0L,11111111L,0L,1111111110L,1L,111111111100L,11L,11111111111100L,11L,1111111111110100L,1000L,111111111111110111L,1000L,11111111111111110110UL,1001L,BigInteger.Parse("1111111111111111110010"),1100L,BigInteger.Parse("111111111111111111110011"),1100L };
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
public class A286082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286082Inst Instance=new A286082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286083
{
public static readonly BigInteger[] Value={ 1L,1L,0L,111L,10000L,11111L,0L,11111111L,0L,111111111L,10000000000L,1111111111L,1100000000000L,111111111111L,110000000000000L,10111111111111L,10000000000000L,111011111111111111L,1000000000000000L,1101111111111111111L,BigInteger.Parse("100100000000000000000") };
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
public class A286083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286083Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286083.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286083.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286083Inst Instance=new A286083Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286084
{
public static readonly long[] Value={ 1L,2L,0L,14L,1L,62L,0L,255L,0L,1022L,1L,4092L,3L,16380L,3L,65524L,8L,262135L,8L,1048566L,9L,4194290L,12L,16777203L,12L,67108851L,4L,268435448L,7L,1073741752L,64L,4294967071L,224L,17179868955L,132L,68719476603L,132L,274877906555L,256L,1099511627455L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286084Inst : IEnumerable<long>
{
public static readonly long[] Value=A286084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286084.Bytes);
public long this[int i]=>Value[i];

public static A286084Inst Instance=new A286084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286085
{
public static readonly long[] Value={ 1L,1L,0L,7L,16L,31L,0L,255L,0L,511L,1024L,1023L,6144L,4095L,24576L,12287L,8192L,245759L,32768L,458751L,1179648L,1310719L,1572864L,13631487L,6291456L,54525951L,16777216L,33554431L,469762048L,125829119L,16777216L,4177526783L,234881024L,14562623487L,4429185024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286085Inst : IEnumerable<long>
{
public static readonly long[] Value=A286085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286085.Bytes);
public long this[int i]=>Value[i];

public static A286085Inst Instance=new A286085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286086
{
public static readonly long[] Value={ 1L,1L,10L,10L,100L,100L,1010L,1010L,10000L,10000L,101100L,101100L,1000010L,1000010L,10101000L,10101000L,100000100L,100000100L,1010001010L,1010001010L,10001100000L,10001100000L,101010010000L,101010010000L,1000001101000L,1000001101000L,10100010000100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286086Inst : IEnumerable<long>
{
public static readonly long[] Value=A286086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286086.Bytes);
public long this[int i]=>Value[i];

public static A286086Inst Instance=new A286086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286151
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,5L,6L,11L,13L,9L,10L,7L,5L,8L,14L,15L,22L,8L,7L,26L,20L,21L,16L,38L,9L,42L,19L,27L,28L,37L,47L,58L,62L,52L,43L,35L,36L,29L,23L,48L,14L,51L,25L,34L,44L,45L,56L,30L,39L,19L,16L,41L,33L,64L,54L,55L,46L,80L,31L,25L,20L,23L,32L,88L,53L,65L,66L,79L,93L,108L,32L,41L,39L,31L,116L,102L,89L,77L,78L,67L,57L,94L,140L,33L,27L,30L,148L,101L,63L,76L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286151Inst : IEnumerable<long>
{
public static readonly long[] Value=A286151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286151.Bytes);
public long this[int i]=>Value[i];

public static A286151Inst Instance=new A286151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286152
{
public static readonly long[] Value={ 0L,2L,2L,12L,2L,40L,2L,59L,18L,61L,2L,179L,2L,86L,73L,261L,2L,265L,2L,265L,100L,148L,2L,757L,33L,185L,129L,367L,2L,1297L,2L,1097L,166L,271L,131L,1735L,2L,320L,205L,1105L,2L,1741L,2L,619L,517L,430L,2L,3113L,52L,850L,295L,769L,2L,1747L,205L,1517L,346L,625L,2L,5297L,2L,698L,730L,4497L,248L,2821L,2L,1117L,460L,2821L,2L,7069L,2L,941L,1070L,1315L,248L,3457L,2L,4513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286152Inst : IEnumerable<long>
{
public static readonly long[] Value=A286152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286152.Bytes);
public long this[int i]=>Value[i];

public static A286152Inst Instance=new A286152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286153
{
public static readonly long[] Value={ 2L,11L,13L,7L,5L,8L,22L,8L,7L,26L,16L,38L,9L,42L,19L,37L,47L,58L,62L,52L,43L,29L,23L,48L,14L,51L,25L,34L,56L,30L,39L,19L,16L,41L,33L,64L,46L,80L,31L,25L,20L,23L,32L,88L,53L,79L,93L,108L,32L,41L,39L,31L,116L,102L,89L,67L,57L,94L,140L,33L,27L,30L,148L,101L,63L,76L,106L,68L,81L,157L,176L,34L,29L,184L,166L,87L,75L,118L,92L,138L,69L,175L,158L,216L,35L,224L,165L,185L,74L,150L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286153Inst : IEnumerable<long>
{
public static readonly long[] Value=A286153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286153.Bytes);
public long this[int i]=>Value[i];

public static A286153Inst Instance=new A286153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286154
{
public static readonly long[] Value={ 0L,1L,5L,2L,18L,2L,40L,7L,23L,7L,96L,7L,142L,16L,38L,29L,238L,16L,308L,29L,80L,46L,444L,29L,234L,67L,173L,67L,676L,29L,791L,121L,212L,121L,328L,67L,1093L,154L,302L,121L,1339L,67L,1499L,191L,302L,232L,1785L,121L,994L,191L,530L,277L,2227L,154L,864L,277L,668L,379L,2718L,121L,2944L,436L,668L,497L,1228L,191L,3505L,497L,992L,277L,3936L,277L,4207L,631L,822L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286154Inst : IEnumerable<long>
{
public static readonly long[] Value=A286154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286154.Bytes);
public long this[int i]=>Value[i];

public static A286154Inst Instance=new A286154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286155
{
public static readonly long[] Value={ -1L,4L,6L,2L,-2L,3L,11L,3L,2L,15L,7L,23L,-3L,27L,10L,22L,30L,39L,43L,35L,28L,16L,12L,31L,-4L,34L,14L,21L,37L,17L,24L,10L,7L,26L,20L,45L,29L,57L,18L,14L,-5L,12L,19L,65L,36L,56L,68L,81L,19L,26L,24L,18L,89L,77L,66L,46L,38L,69L,109L,20L,-6L,17L,117L,76L,44L,55L,79L,47L,58L,124L,141L,21L,16L,149L,133L,64L,54L,91L,67L,107L,48L,140L,125L,177L,-7L,185L,132L,150L,53L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286155Inst : IEnumerable<long>
{
public static readonly long[] Value=A286155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286155.Bytes);
public long this[int i]=>Value[i];

public static A286155Inst Instance=new A286155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286156
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,6L,2L,5L,4L,10L,2L,5L,1L,3L,15L,2L,5L,9L,4L,7L,21L,2L,5L,9L,1L,8L,6L,28L,2L,5L,9L,14L,4L,3L,11L,36L,2L,5L,9L,14L,1L,8L,7L,10L,45L,2L,5L,9L,14L,20L,4L,13L,12L,16L,55L,2L,5L,9L,14L,20L,1L,8L,3L,6L,15L,66L,2L,5L,9L,14L,20L,27L,4L,13L,7L,11L,22L,78L,2L,5L,9L,14L,20L,27L,1L,8L,19L,12L,17L,21L,91L,2L,5L,9L,14L,20L,27L,35L,4L,13L,3L,18L,10L,29L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286156Inst : IEnumerable<long>
{
public static readonly long[] Value=A286156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286156.Bytes);
public long this[int i]=>Value[i];

public static A286156Inst Instance=new A286156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286157
{
public static readonly long[] Value={ 1L,3L,2L,6L,1L,2L,10L,4L,5L,2L,15L,3L,1L,5L,2L,21L,7L,4L,9L,5L,2L,28L,6L,8L,1L,9L,5L,2L,36L,11L,3L,4L,14L,9L,5L,2L,45L,10L,7L,8L,1L,14L,9L,5L,2L,55L,16L,12L,13L,4L,20L,14L,9L,5L,2L,66L,15L,6L,3L,8L,1L,20L,14L,9L,5L,2L,78L,22L,11L,7L,13L,4L,27L,20L,14L,9L,5L,2L,91L,21L,17L,12L,19L,8L,1L,27L,20L,14L,9L,5L,2L,105L,29L,10L,18L,3L,13L,4L,35L,27L,20L,14L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286157Inst : IEnumerable<long>
{
public static readonly long[] Value=A286157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286157.Bytes);
public long this[int i]=>Value[i];

public static A286157Inst Instance=new A286157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286158
{
public static readonly long[] Value={ 1L,3L,1L,6L,4L,1L,10L,3L,4L,1L,15L,7L,8L,4L,1L,21L,6L,3L,8L,4L,1L,28L,11L,7L,13L,8L,4L,1L,36L,10L,12L,3L,13L,8L,4L,1L,45L,16L,6L,7L,19L,13L,8L,4L,1L,55L,15L,11L,12L,3L,19L,13L,8L,4L,1L,66L,22L,17L,18L,7L,26L,19L,13L,8L,4L,1L,78L,21L,10L,6L,12L,3L,26L,19L,13L,8L,4L,1L,91L,29L,16L,11L,18L,7L,34L,26L,19L,13L,8L,4L,1L,105L,28L,23L,17L,25L,12L,3L,34L,26L,19L,13L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286158Inst : IEnumerable<long>
{
public static readonly long[] Value=A286158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286158.Bytes);
public long this[int i]=>Value[i];

public static A286158Inst Instance=new A286158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286159
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,6L,1L,4L,3L,10L,1L,4L,8L,7L,15L,1L,4L,8L,3L,6L,21L,1L,4L,8L,13L,7L,11L,28L,1L,4L,8L,13L,3L,12L,10L,36L,1L,4L,8L,13L,19L,7L,6L,16L,45L,1L,4L,8L,13L,19L,3L,12L,11L,15L,55L,1L,4L,8L,13L,19L,26L,7L,18L,17L,22L,66L,1L,4L,8L,13L,19L,26L,3L,12L,6L,10L,21L,78L,1L,4L,8L,13L,19L,26L,34L,7L,18L,11L,16L,29L,91L,1L,4L,8L,13L,19L,26L,34L,3L,12L,25L,17L,23L,28L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286159Inst : IEnumerable<long>
{
public static readonly long[] Value=A286159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286159.Bytes);
public long this[int i]=>Value[i];

public static A286159Inst Instance=new A286159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286160
{
public static readonly long[] Value={ 1L,2L,5L,12L,14L,23L,27L,59L,42L,40L,65L,109L,90L,61L,86L,261L,152L,142L,189L,179L,148L,115L,275L,473L,273L,148L,318L,265L,434L,674L,495L,1097L,320L,226L,430L,1093L,702L,271L,430L,757L,860L,832L,945L,485L,619L,373L,1127L,1969L,1032L,485L,698L,619L,1430L,838L,1030L,1105L,856L,556L,1769L,2791L,1890L,625L,1117L,4497L,1426L,1196L,2277L,935L,1220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286160Inst : IEnumerable<long>
{
public static readonly long[] Value=A286160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286160.Bytes);
public long this[int i]=>Value[i];

public static A286160Inst Instance=new A286160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286161
{
public static readonly long[] Value={ 1L,5L,2L,18L,2L,23L,2L,59L,7L,23L,2L,94L,2L,23L,16L,195L,2L,80L,2L,94L,16L,23L,2L,355L,7L,23L,29L,94L,2L,467L,2L,672L,16L,23L,16L,706L,2L,23L,16L,355L,2L,467L,2L,94L,67L,23L,2L,1331L,7L,80L,16L,94L,2L,302L,16L,355L,16L,23L,2L,1894L,2L,23L,67L,2422L,16L,467L,2L,94L,16L,467L,2L,2779L,2L,23L,67L,94L,16L,467L,2L,1331L,121L,23L,2L,1894L,16L,23L,16L,355L,2L,1832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286161Inst : IEnumerable<long>
{
public static readonly long[] Value=A286161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286161.Bytes);
public long this[int i]=>Value[i];

public static A286161Inst Instance=new A286161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286162
{
public static readonly long[] Value={ 2L,5L,7L,9L,16L,12L,29L,14L,16L,23L,67L,18L,67L,38L,121L,20L,16L,23L,67L,31L,436L,80L,277L,25L,67L,80L,631L,48L,277L,138L,497L,27L,16L,23L,67L,31L,436L,80L,277L,40L,436L,467L,1771L,94L,1771L,302L,1129L,33L,67L,80L,631L,94L,1771L,668L,2557L,59L,277L,302L,2557L,156L,1129L,530L,2017L,35L,16L,23L,67L,31L,436L,80L,277L,40L,436L,467L,1771L,94L,1771L,302L,1129L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286162Inst : IEnumerable<long>
{
public static readonly long[] Value=A286162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286162.Bytes);
public long this[int i]=>Value[i];

public static A286162Inst Instance=new A286162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286163
{
public static readonly long[] Value={ 2L,5L,12L,14L,23L,42L,38L,44L,40L,61L,80L,117L,80L,84L,216L,152L,23L,148L,80L,148L,601L,142L,302L,375L,109L,142L,911L,183L,302L,1020L,530L,560L,61L,61L,142L,856L,467L,142L,412L,430L,467L,1741L,1832L,265L,2497L,412L,1178L,1323L,109L,265L,826L,265L,1832L,1735L,2932L,489L,412L,412L,2630L,2835L,1178L,672L,2787L,2144L,61L,625L,80L,148L,601L,850L,302L,2998L,467L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286163Inst : IEnumerable<long>
{
public static readonly long[] Value=A286163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286163.Bytes);
public long this[int i]=>Value[i];

public static A286163Inst Instance=new A286163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286164
{
public static readonly long[] Value={ 0L,2L,5L,7L,9L,16L,14L,29L,12L,16L,20L,67L,27L,16L,23L,121L,35L,67L,44L,67L,23L,16L,54L,277L,18L,16L,38L,67L,65L,436L,77L,497L,23L,16L,31L,631L,90L,16L,23L,277L,104L,436L,119L,67L,80L,16L,135L,1129L,25L,67L,23L,67L,152L,277L,31L,277L,23L,16L,170L,1771L,189L,16L,80L,2017L,31L,436L,209L,67L,23L,436L,230L,2557L,252L,16L,80L,67L,40L,436L,275L,1129L,138L,16L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286164Inst : IEnumerable<long>
{
public static readonly long[] Value=A286164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286164.Bytes);
public long this[int i]=>Value[i];

public static A286164Inst Instance=new A286164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286165
{
public static readonly long[] Value={ 1L,2L,3L,12L,7L,58L,13L,242L,29L,1006L,49L,4046L,125L,16306L,205L,65330L,509L,261826L,829L,1047794L,1997L,4193074L,3325L,16774082L,7997L,67103938L,13309L,268422914L,31997L,1073722306L,53053L,4294917314L,127997L,17179791106L,212221L,68719276802L,511997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286165Inst : IEnumerable<long>
{
public static readonly long[] Value=A286165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286165.Bytes);
public long this[int i]=>Value[i];

public static A286165Inst Instance=new A286165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286166
{
public static readonly long[] Value={ 1L,1L,6L,3L,28L,23L,88L,79L,368L,479L,1120L,1855L,6080L,4991L,22912L,19711L,98048L,69119L,386560L,324607L,1473536L,1259519L,6264832L,4444159L,24768512L,17620991L,100556800L,68108287L,401063936L,284393471L,1585020928L,1128071167L,6436093952L,4358799359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286166Inst : IEnumerable<long>
{
public static readonly long[] Value=A286166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286166.Bytes);
public long this[int i]=>Value[i];

public static A286166Inst Instance=new A286166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286311
{
public static readonly long[] Value={ 0L,1L,1L,3L,5L,8L,12L,19L,31L,51L,83L,134L,216L,349L,565L,915L,1481L,2396L,3876L,6271L,10147L,16419L,26567L,42986L,69552L,112537L,182089L,294627L,476717L,771344L,1248060L,2019403L,3267463L,5286867L,8554331L,13841198L,22395528L,36236725L,58632253L,94868979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286311Inst : IEnumerable<long>
{
public static readonly long[] Value=A286311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286311.Bytes);
public long this[int i]=>Value[i];

public static A286311Inst Instance=new A286311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286312
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,5L,3L,1L,5L,7L,6L,5L,1L,6L,9L,9L,6L,6L,1L,7L,11L,12L,10L,7L,7L,1L,8L,13L,15L,14L,10L,7L,8L,1L,9L,15L,18L,18L,15L,11L,7L,9L,1L,10L,17L,21L,22L,20L,15L,12L,17L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286312Inst : IEnumerable<long>
{
public static readonly long[] Value=A286312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286312.Bytes);
public long this[int i]=>Value[i];

public static A286312Inst Instance=new A286312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286313
{
public static readonly long[] Value={ 19L,31L,43L,61L,73L,79L,127L,157L,163L,229L,271L,349L,373L,379L,433L,439L,499L,607L,643L,673L,733L,751L,937L,967L,1009L,1093L,1213L,1279L,1291L,1429L,1489L,1543L,1549L,1597L,1609L,1657L,1777L,1861L,1987L,2131L,2203L,2287L,2341L,2347L,2371L,2383L,2389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286313Inst : IEnumerable<long>
{
public static readonly long[] Value=A286313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286313.Bytes);
public long this[int i]=>Value[i];

public static A286313Inst Instance=new A286313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286314
{
public static readonly BigInteger[] Value={ 6L,231L,20400L,2003001L,200045352L,20000567352L,1959085094400L,200000030000001L,20118337236261000L,1999999999505541852L,BigInteger.Parse("200000000030000000001"),BigInteger.Parse("19994255180823548693100"),BigInteger.Parse("1959183673472326530612252"),BigInteger.Parse("200000000000105810631542400"),BigInteger.Parse("20118343160415860069040000000") };
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
public class A286314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286314Inst Instance=new A286314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286315
{
public static readonly BigInteger[] Value={ 8L,1332L,1030302L,1007141184L,1000302990372L,1000781337641904L,1000003970597090004L,BigInteger.Parse("1000751615026326041904"),BigInteger.Parse("1000203571630368710405892"),BigInteger.Parse("1004272191614371538730009600"),BigInteger.Parse("1000000970912716777250166728808"),BigInteger.Parse("1000834130646589459517111102258880") };
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
public class A286315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286315Inst Instance=new A286315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286316
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,9L,11L,13L,15L,17L,20L,22L,25L,28L,32L,35L,40L,44L,50L,56L,63L,70L,80L,89L,101L,113L,128L,143L,162L,181L,204L,228L,256L,285L,320L,355L,396L,439L,489L,540L,599L,660L,730L,803L,886L,972L,1070L,1172L,1287L,1408L,1544L,1686L,1846L,2014L,2202L,2400L,2621L,2854L,3114L,3389L,3693L,4016L,4374L,4753L,5172L,5617L,6107L,6628L,7201L,7810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286316Inst : IEnumerable<long>
{
public static readonly long[] Value=A286316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286316.Bytes);
public long this[int i]=>Value[i];

public static A286316Inst Instance=new A286316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286317
{
public static readonly long[] Value={ 1L,2L,5L,18L,59L,306L,1861L,15097L,146893L,1693416L,22239872L,327670703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286317Inst : IEnumerable<long>
{
public static readonly long[] Value=A286317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286317.Bytes);
public long this[int i]=>Value[i];

public static A286317Inst Instance=new A286317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286318
{
public static readonly long[] Value={ 1L,1L,3L,11L,36L,213L,1405L,12274L,125235L,1490851L,20003121L,299274006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286318Inst : IEnumerable<long>
{
public static readonly long[] Value=A286318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286318.Bytes);
public long this[int i]=>Value[i];

public static A286318Inst Instance=new A286318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286319
{
public static readonly long[] Value={ 2L,3L,5L,7L,41L,59L,67L,89L,101L,131L,139L,379L,457L,743L,761L,1193L,1201L,1381L,1549L,1567L,1747L,1789L,2137L,2411L,2557L,2647L,2663L,2729L,2731L,3011L,3221L,3251L,3449L,4057L,4159L,4447L,4561L,4751L,5179L,5641L,6173L,6397L,6599L,6833L,7229L,8669L,9059L,9157L,9323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286319Inst : IEnumerable<long>
{
public static readonly long[] Value=A286319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286319.Bytes);
public long this[int i]=>Value[i];

public static A286319Inst Instance=new A286319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286320
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,1L,2L,3L,2L,1L,2L,3L,3L,2L,4L,5L,3L,2L,4L,5L,3L,2L,4L,6L,4L,2L,4L,7L,5L,2L,5L,8L,5L,2L,5L,8L,6L,3L,5L,10L,8L,4L,6L,10L,8L,4L,6L,10L,9L,5L,8L,12L,10L,6L,9L,13L,10L,6L,9L,15L,12L,7L,10L,17L,14L,7L,11L,18L,15L,8L,11L,18L,16L,9L,11L,20L,18L,10L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286320Inst : IEnumerable<long>
{
public static readonly long[] Value=A286320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286320.Bytes);
public long this[int i]=>Value[i];

public static A286320Inst Instance=new A286320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286321
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,2L,1L,3L,4L,2L,6L,1L,3L,6L,4L,4L,2L,6L,5L,1L,8L,3L,9L,10L,4L,12L,4L,2L,15L,6L,9L,5L,1L,10L,8L,3L,6L,9L,20L,10L,4L,7L,12L,4L,12L,2L,8L,15L,6L,14L,16L,5L,18L,1L,16L,20L,8L,18L,3L,6L,19L,9L,24L,20L,10L,28L,4L,7L,30L,12L,32L,4L,12L,35L,2L,8L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286321Inst : IEnumerable<long>
{
public static readonly long[] Value=A286321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286321.Bytes);
public long this[int i]=>Value[i];

public static A286321Inst Instance=new A286321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286322
{
public static readonly long[] Value={ 4L,9L,221L,289L,697L,1819L,2329L,4369L,4913L,6439L,18769L,21331L,35209L,66049L,128881L,184783L,197143L,258121L,281929L,516961L,739903L,971203L,1762249L,1942663L,2070721L,2898703L,2952673L,3820819L,4142881L,5550943L,5869681L,8288641L,16230481L,16773619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286322Inst : IEnumerable<long>
{
public static readonly long[] Value=A286322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286322.Bytes);
public long this[int i]=>Value[i];

public static A286322Inst Instance=new A286322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286323
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,13L,15L,17L,18L,20L,21L,23L,24L,26L,27L,29L,30L,32L,34L,35L,37L,38L,40L,41L,43L,44L,46L,47L,49L,51L,52L,54L,55L,57L,58L,60L,61L,63L,64L,66L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,83L,85L,86L,88L,89L,91L,92L,94L,95L,97L,99L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286323Inst : IEnumerable<long>
{
public static readonly long[] Value=A286323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286323.Bytes);
public long this[int i]=>Value[i];

public static A286323Inst Instance=new A286323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286324
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,4L,4L,2L,4L,2L,4L,4L,4L,2L,8L,2L,4L,4L,4L,2L,8L,2L,6L,4L,4L,4L,4L,2L,4L,4L,8L,2L,8L,2L,4L,4L,4L,2L,8L,2L,4L,4L,4L,2L,8L,4L,8L,4L,4L,2L,8L,2L,4L,4L,6L,4L,8L,2L,4L,4L,8L,2L,8L,2L,4L,4L,4L,4L,8L,2L,8L,4L,4L,2L,8L,4L,4L,4L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286324Inst : IEnumerable<long>
{
public static readonly long[] Value=A286324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286324.Bytes);
public long this[int i]=>Value[i];

public static A286324Inst Instance=new A286324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286325
{
public static readonly long[] Value={ 1L,6L,45L,60L,90L,270L,420L,630L,672L,2970L,5460L,8190L,9072L,9100L,10080L,15925L,22680L,22848L,27300L,30240L,40950L,45360L,54600L,81900L,95550L,99792L,136500L,163800L,172900L,204750L,208656L,245700L,249480L,312480L,332640L,342720L,385560L,409500L,472500L,491400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286325Inst : IEnumerable<long>
{
public static readonly long[] Value=A286325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286325.Bytes);
public long this[int i]=>Value[i];

public static A286325Inst Instance=new A286325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286326
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,2L,1L,3L,2L,2L,3L,1L,3L,3L,2L,4L,2L,3L,4L,1L,4L,3L,3L,5L,2L,4L,4L,2L,5L,3L,4L,5L,1L,5L,4L,3L,6L,3L,5L,5L,2L,6L,4L,4L,6L,2L,6L,5L,3L,7L,4L,5L,6L,1L,7L,5L,4L,7L,3L,6L,6L,3L,8L,5L,5L,7L,2L,7L,6L,4L,8L,4L,6L,7L,2L,8L,6L,5L,8L,3L,7L,7L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286326Inst : IEnumerable<long>
{
public static readonly long[] Value=A286326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286326.Bytes);
public long this[int i]=>Value[i];

public static A286326Inst Instance=new A286326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286407
{
public static readonly long[] Value={ 1L,1L,10L,10L,110L,110L,1110L,1110L,11110L,11100L,111100L,111100L,1111100L,1111110L,11111100L,11111110L,111111100L,111111110L,1111111100L,1111111100L,11111111110L,11111111100L,111111111100L,111111111110L,1111111111110L,1111111111110L,11111111111110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286407Inst : IEnumerable<long>
{
public static readonly long[] Value=A286407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286407.Bytes);
public long this[int i]=>Value[i];

public static A286407Inst Instance=new A286407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286408
{
public static readonly ulong[] Value={ 1L,10L,10L,100L,1100L,11000L,111000L,1110000L,11110000L,11100000L,111100000L,1111000000L,11111000000L,1111110000000L,1111110000000L,111111100000000L,111111100000000L,11111111000000000L,11111111000000000L,111111110000000000L,11111111110000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286408Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286408.Bytes);
public ulong this[int i]=>Value[i];

public static A286408Inst Instance=new A286408Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286409
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,6L,14L,14L,30L,28L,60L,60L,124L,126L,252L,254L,508L,510L,1020L,1020L,2046L,2044L,4092L,4094L,8190L,8190L,16382L,16382L,32766L,32766L,65534L,65534L,131070L,131070L,262142L,262142L,524286L,518142L,1047550L,1032702L,2081278L,2095102L,4178430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286409Inst : IEnumerable<long>
{
public static readonly long[] Value=A286409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286409.Bytes);
public long this[int i]=>Value[i];

public static A286409Inst Instance=new A286409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286410
{
public static readonly long[] Value={ 1L,2L,2L,4L,12L,24L,56L,112L,240L,224L,480L,960L,1984L,8064L,8064L,32512L,32512L,130560L,130560L,261120L,1047552L,1046528L,2095104L,8384512L,16773120L,33546240L,67100672L,134201344L,268419072L,536838144L,1073709056L,2147418112L,4294901760L,8589803520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286410Inst : IEnumerable<long>
{
public static readonly long[] Value=A286410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286410.Bytes);
public long this[int i]=>Value[i];

public static A286410Inst Instance=new A286410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286411
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1100L,11L,111100L,1111L,11110110L,1001L,1111111110L,11L,111111101100L,111011L,11111111101100L,10011000L,1111111101100011L,1111110L,111111111101101010L,111100110L,11111111111111100110UL,100111110L,BigInteger.Parse("1111111111111011100110"),111100110L };
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
public class A286411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286411Inst Instance=new A286411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286412
{
public static readonly ulong[] Value={ 1L,1L,110L,11L,11000L,1111L,1111000L,1101111L,100100000L,111111111L,11000000000L,1101111111L,1101110000000L,110111111111L,110010000000L,1100011011111111L,1111110000000000L,10101101111111111L,110011110000000000L,1100111111111111111L,11111001000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286412Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286412.Bytes);
public ulong this[int i]=>Value[i];

public static A286412Inst Instance=new A286412Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286413
{
public static readonly long[] Value={ 1L,2L,3L,12L,3L,60L,15L,246L,9L,1022L,3L,4076L,59L,16364L,152L,65379L,126L,261994L,486L,1048550L,318L,4194022L,486L,16775486L,3558L,67108838L,1854L,268434662L,14310L,1073730494L,45670L,4294931366L,15742L,17179824806L,126310L,68719366334L,110822L,274877865894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286413Inst : IEnumerable<long>
{
public static readonly long[] Value=A286413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286413.Bytes);
public long this[int i]=>Value[i];

public static A286413Inst Instance=new A286413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286414
{
public static readonly long[] Value={ 1L,1L,6L,3L,24L,15L,120L,111L,288L,511L,1536L,895L,7040L,3583L,3200L,50943L,64512L,89087L,211968L,425983L,1019904L,1695743L,3391488L,8167423L,13590528L,27262975L,65470464L,108265471L,217939968L,527630335L,858161152L,1708064767L,4252499968L,6797656063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286414Inst : IEnumerable<long>
{
public static readonly long[] Value=A286414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286414.Bytes);
public long this[int i]=>Value[i];

public static A286414Inst Instance=new A286414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286415
{
public static readonly long[] Value={ 19L,23L,29L,41L,43L,47L,53L,59L,61L,67L,83L,89L,173L,271L,277L,313L,379L,397L,419L,479L,491L,571L,577L,593L,617L,631L,673L,811L,839L,877L,911L,977L,1777L,1913L,2131L,2311L,2377L,2399L,2713L,2791L,2939L,2971L,4177L,4339L,4919L,4993L,5119L,5791L,6133L,6737L,6997L,7193L,7333L,7919L,8111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286415Inst : IEnumerable<long>
{
public static readonly long[] Value=A286415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286415.Bytes);
public long this[int i]=>Value[i];

public static A286415Inst Instance=new A286415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286416
{
public static readonly long[] Value={ 1L,3L,1L,8L,6L,1L,24L,25L,10L,1L,83L,98L,63L,15L,1L,324L,399L,338L,135L,21L,1L,1400L,1746L,1727L,980L,257L,28L,1L,6609L,8271L,8874L,6426L,2455L,448L,36L,1L,33758L,42284L,47191L,40334L,20506L,5474L,730L,45L,1L,185136L,231939L,263458L,250839L,158827L,57239L,11128L,1128L,55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286416Inst : IEnumerable<long>
{
public static readonly long[] Value=A286416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286416.Bytes);
public long this[int i]=>Value[i];

public static A286416Inst Instance=new A286416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286417
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,6L,4L,9L,11L,13L,15L,18L,10L,21L,23L,26L,14L,29L,8L,17L,36L,19L,20L,12L,16L,25L,39L,43L,22L,24L,31L,32L,34L,69L,37L,75L,78L,35L,41L,45L,44L,53L,47L,48L,49L,71L,52L,27L,28L,50L,58L,55L,30L,59L,64L,65L,33L,67L,138L,70L,141L,73L,38L,77L,57L,61L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286417Inst : IEnumerable<long>
{
public static readonly long[] Value=A286417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286417.Bytes);
public long this[int i]=>Value[i];

public static A286417Inst Instance=new A286417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286418
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,7L,14L,14L,7L,37L,170L,312L,170L,37L,197L,2904L,13945L,13945L,2904L,197L,1172L,74779L,1241696L,3228524L,1241696L,74779L,1172L,8018L,2751790L,196846257L,1723178763L,1723178763L,196846257L,2751790L,8018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286418Inst : IEnumerable<long>
{
public static readonly long[] Value=A286418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286418.Bytes);
public long this[int i]=>Value[i];

public static A286418Inst Instance=new A286418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286419
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286419Inst : IEnumerable<long>
{
public static readonly long[] Value=A286419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286419.Bytes);
public long this[int i]=>Value[i];

public static A286419Inst Instance=new A286419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286420
{
public static readonly long[] Value={ 1L,7L,8L,10L,15L,18L,19L,25L,26L,28L,31L,32L,37L,43L,44L,46L,51L,54L,55L,60L,66L,67L,69L,72L,73L,79L,80L,82L,87L,90L,91L,97L,98L,100L,103L,104L,109L,115L,116L,118L,121L,122L,128L,129L,131L,136L,139L,140L,145L,151L,152L,154L,159L,162L,163L,169L,170L,172L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286420Inst : IEnumerable<long>
{
public static readonly long[] Value=A286420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286420.Bytes);
public long this[int i]=>Value[i];

public static A286420Inst Instance=new A286420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286421
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,11L,12L,13L,14L,16L,17L,20L,21L,22L,23L,24L,27L,29L,30L,33L,34L,35L,36L,38L,39L,40L,41L,42L,45L,47L,48L,49L,50L,52L,53L,56L,57L,58L,59L,61L,62L,63L,64L,65L,68L,70L,71L,74L,75L,76L,77L,78L,81L,83L,84L,85L,86L,88L,89L,92L,93L,94L,95L,96L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286421Inst : IEnumerable<long>
{
public static readonly long[] Value=A286421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286421.Bytes);
public long this[int i]=>Value[i];

public static A286421Inst Instance=new A286421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286422
{
public static readonly BigInteger[] Value={ 2L,12L,130L,9492L,1166928L,1431128744L,2907639077764L,76670800431934272L,BigInteger.Parse("3341096345926174809912"),BigInteger.Parse("2311650738313947870105792416"),BigInteger.Parse("2645105778378736719464340469683304"),BigInteger.Parse("56641723029988800376624313271476598959936") };
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
public class A286422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286422Inst Instance=new A286422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286519
{
public static readonly ulong[] Value={ 1L,11L,101L,1111L,11111L,111111L,1111111L,11111111L,111111111L,1111111111L,11111111111L,111111111111L,1111111111111L,11111111111111L,111111111111111L,1111111111111111L,11111111111111111L,111111111111111111L,1111111111111111111L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286519Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286519.Bytes);
public ulong this[int i]=>Value[i];

public static A286519Inst Instance=new A286519Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286520
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,5L,1L,1L,1L,1L,1L,5L,1L,1L,1L,3L,1L,5L,1L,2L,2L,1L,1L,4L,1L,2L,1L,2L,1L,3L,1L,3L,1L,1L,1L,17L,1L,1L,2L,1L,1L,5L,1L,2L,1L,5L,1L,9L,1L,1L,2L,2L,1L,5L,1L,4L,1L,1L,1L,17L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286520Inst : IEnumerable<long>
{
public static readonly long[] Value=A286520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286520.Bytes);
public long this[int i]=>Value[i];

public static A286520Inst Instance=new A286520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286521
{
public static readonly long[] Value={ 1L,3L,5L,15L,31L,63L,127L,255L,511L,1023L,2047L,4095L,8191L,16383L,32767L,65535L,131071L,262143L,524287L,1048575L,2097151L,4194303L,8388607L,16777215L,33554431L,67108863L,134217727L,268435455L,536870911L,1073741823L,2147483647L,4294967295L,8589934591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286521Inst : IEnumerable<long>
{
public static readonly long[] Value=A286521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286521.Bytes);
public long this[int i]=>Value[i];

public static A286521Inst Instance=new A286521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286522
{
public static readonly long[] Value={ 2L,4L,8L,14L,23L,36L,52L,72L,93L,116L,138L,158L,174L,185L,191L,191L,186L,176L,162L,146L,128L,110L,93L,77L,62L,49L,38L,29L,22L,16L,12L,8L,6L,4L,2L,2L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286522Inst : IEnumerable<long>
{
public static readonly long[] Value=A286522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286522.Bytes);
public long this[int i]=>Value[i];

public static A286522Inst Instance=new A286522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286523
{
public static readonly BigInteger[] Value={ 2L,4L,8L,128L,640L,8192L,1605632L,536870912L,100663296L,137438953472L,32195899484536832L,1152921504606846976L,BigInteger.Parse("214035842104995017129984"),BigInteger.Parse("75557863725914323419136"),BigInteger.Parse("2417851639229258349412352"),BigInteger.Parse("2658455991569831745807614120560689152"),BigInteger.Parse("16645314084009764791991725029402697793536"),BigInteger.Parse("680564733841876926926749214863536422912"),BigInteger.Parse("2958953999535335146041291694037024012985750731620352") };
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
public class A286523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286523Inst Instance=new A286523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286524
{
public static readonly BigInteger[] Value={ 1L,1L,1L,9L,27L,225L,30375L,7441875L,1071875L,1181472075L,232602314765625L,7296820763203125L,BigInteger.Parse("1228777319702643046875"),BigInteger.Parse("407740293448065703125"),BigInteger.Parse("12646770836979187723815"),BigInteger.Parse("13904872587870848957579157123046875"),BigInteger.Parse("89477855102948913042021876086806640625"),BigInteger.Parse("3865644245069923858264226752294921875"),BigInteger.Parse("18203690021177687874093952515006818038631103515625") };
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
public class A286524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286524Inst Instance=new A286524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286525
{
public static readonly BigInteger[] Value={ 1L,1L,3L,978L,7885536L,1030690752000L,2681594035175055000L,BigInteger.Parse("111102459342780333711432912"),BigInteger.Parse("82765346051371433995689422809152600"),BigInteger.Parse("984929152509556378339959477248973638627262816"),BigInteger.Parse("201525938526971993585665495909682003042353826154218776128") };
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
public class A286525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286525Inst Instance=new A286525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286526
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2874L,84086160L,77920099694640L,BigInteger.Parse("1787320731699689472000"),BigInteger.Parse("1208369393947533515948886636000"),BigInteger.Parse("22022604563875220592723146462014970246400"),BigInteger.Parse("10631042739086498005729294276105510004209560426195000"),BigInteger.Parse("136864426940639977623403211038729959780835360788855628470904385280") };
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
public class A286526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286526Inst Instance=new A286526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286527
{
public static readonly long[] Value={ 1L,6L,70L,210L,2622L,9282L,277134L,1159710L,8064030L,56185590L,186605430L,2748628830L,5053814978L,72641163166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286527Inst : IEnumerable<long>
{
public static readonly long[] Value=A286527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286527.Bytes);
public long this[int i]=>Value[i];

public static A286527Inst Instance=new A286527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286528
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,1L,3L,2L,2L,3L,3L,3L,3L,4L,2L,4L,3L,3L,4L,4L,3L,5L,4L,2L,5L,3L,3L,4L,4L,4L,5L,5L,3L,6L,4L,4L,5L,5L,5L,6L,6L,5L,7L,6L,4L,7L,5L,5L,6L,6L,3L,7L,4L,4L,5L,5L,5L,6L,6L,5L,5L,6L,6L,6L,7L,7L,7L,8L,4L,7L,5L,5L,6L,6L,6L,7L,7L,3L,8L,4L,4L,5L,5L,5L,6L,6L,5L,7L,6L,6L,7L,7L,5L,7L,6L,6L,7L,7L,7L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286528Inst : IEnumerable<long>
{
public static readonly long[] Value=A286528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286528.Bytes);
public long this[int i]=>Value[i];

public static A286528Inst Instance=new A286528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286529
{
public static readonly long[] Value={ 2L,3L,2L,2L,2L,4L,3L,6L,6L,4L,2L,6L,4L,6L,2L,4L,2L,8L,4L,4L,3L,4L,3L,6L,6L,8L,2L,4L,2L,4L,4L,4L,2L,4L,4L,6L,4L,8L,2L,10L,2L,6L,6L,6L,4L,6L,3L,4L,6L,8L,4L,4L,4L,4L,2L,7L,2L,4L,2L,12L,6L,8L,4L,2L,4L,4L,4L,4L,2L,8L,2L,12L,6L,8L,5L,4L,5L,4L,5L,12L,4L,4L,4L,12L,2L,12L,4L,12L,4L,8L,4L,6L,2L,6L,6L,12L,6L,8L,8L,2L,2L,8L,8L,10L,2L,8L,2L,16L,4L,4L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286529Inst : IEnumerable<long>
{
public static readonly long[] Value=A286529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286529.Bytes);
public long this[int i]=>Value[i];

public static A286529Inst Instance=new A286529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286530
{
public static readonly long[] Value={ 1L,1L,0L,-1L,0L,0L,1L,2L,3L,0L,0L,0L,2L,2L,-2L,-1L,0L,2L,2L,-2L,-1L,0L,1L,-2L,3L,4L,-2L,-2L,0L,-4L,2L,-2L,-2L,0L,0L,-3L,2L,4L,-2L,2L,0L,-2L,4L,0L,-2L,2L,1L,-6L,3L,2L,0L,-2L,2L,-4L,-2L,-1L,-2L,0L,0L,0L,4L,4L,-2L,-5L,0L,-4L,2L,-2L,-2L,0L,0L,0L,4L,4L,-1L,-2L,1L,-4L,3L,2L,-1L,0L,2L,0L,-2L,8L,0L,4L,2L,-4L,0L,0L,-2L,2L,2L,0L,4L,2L,2L,-7L,0L,0L,6L,2L,-6L,4L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286530Inst : IEnumerable<long>
{
public static readonly long[] Value=A286530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286530.Bytes);
public long this[int i]=>Value[i];

public static A286530Inst Instance=new A286530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286531
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,3L,5L,2L,6L,4L,7L,3L,7L,5L,5L,2L,8L,6L,9L,4L,10L,7L,7L,3L,9L,7L,11L,5L,7L,5L,5L,2L,12L,8L,13L,6L,14L,9L,9L,4L,14L,10L,15L,7L,10L,7L,7L,3L,13L,9L,15L,7L,15L,11L,11L,5L,9L,7L,11L,5L,7L,5L,5L,2L,16L,12L,17L,8L,18L,13L,13L,6L,19L,14L,20L,9L,14L,9L,9L,4L,18L,14L,21L,10L,21L,15L,15L,7L,14L,10L,15L,7L,10L,7L,7L,3L,17L,13L,20L,9L,21L,15L,15L,7L,20L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286531Inst : IEnumerable<long>
{
public static readonly long[] Value=A286531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286531.Bytes);
public long this[int i]=>Value[i];

public static A286531Inst Instance=new A286531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286532
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,5L,2L,4L,4L,6L,3L,6L,4L,7L,2L,4L,5L,6L,4L,8L,4L,9L,3L,6L,4L,10L,4L,8L,6L,11L,2L,4L,4L,6L,4L,9L,4L,9L,4L,8L,4L,12L,4L,8L,4L,13L,3L,6L,6L,10L,5L,8L,8L,14L,4L,8L,4L,12L,4L,12L,4L,15L,2L,4L,6L,6L,4L,8L,7L,9L,4L,8L,4L,14L,4L,8L,6L,13L,4L,8L,6L,12L,4L,8L,4L,16L,4L,8L,8L,12L,6L,8L,4L,17L,3L,6L,4L,10L,4L,12L,9L,14L,4L,9L,4L,12L,4L,18L,4L,19L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286532Inst : IEnumerable<long>
{
public static readonly long[] Value=A286532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286532.Bytes);
public long this[int i]=>Value[i];

public static A286532Inst Instance=new A286532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286533
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,5L,3L,2L,6L,7L,7L,5L,4L,5L,3L,2L,8L,9L,10L,7L,9L,11L,7L,5L,6L,7L,7L,5L,4L,5L,3L,2L,12L,13L,14L,9L,14L,15L,10L,7L,13L,15L,15L,11L,9L,11L,7L,5L,8L,9L,10L,7L,9L,11L,7L,5L,6L,7L,7L,5L,4L,5L,3L,2L,16L,17L,18L,13L,19L,20L,14L,9L,18L,21L,21L,15L,14L,15L,10L,7L,17L,20L,21L,15L,20L,22L,15L,11L,13L,15L,15L,11L,9L,11L,7L,5L,12L,13L,14L,9L,14L,15L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286533Inst : IEnumerable<long>
{
public static readonly long[] Value=A286533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286533.Bytes);
public long this[int i]=>Value[i];

public static A286533Inst Instance=new A286533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286534
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,2L,3L,6L,7L,5L,5L,6L,5L,2L,3L,6L,8L,5L,6L,9L,10L,5L,5L,10L,11L,5L,4L,6L,5L,2L,3L,6L,8L,6L,10L,12L,10L,4L,5L,13L,14L,5L,5L,13L,10L,5L,5L,10L,13L,5L,5L,15L,10L,5L,5L,11L,11L,5L,5L,6L,5L,2L,3L,6L,8L,5L,11L,12L,13L,5L,5L,16L,17L,5L,5L,13L,11L,5L,5L,10L,18L,5L,11L,19L,10L,5L,5L,10L,20L,5L,5L,13L,10L,5L,5L,10L,13L,6L,5L,20L,10L,5L,6L,10L,21L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286534Inst : IEnumerable<long>
{
public static readonly long[] Value=A286534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286534.Bytes);
public long this[int i]=>Value[i];

public static A286534Inst Instance=new A286534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286631
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,2L,8L,12L,4L,6L,16L,6L,24L,12L,2L,12L,32L,8L,30L,48L,12L,36L,6L,4L,24L,64L,6L,24L,60L,16L,96L,60L,6L,72L,12L,24L,12L,48L,12L,128L,30L,2L,72L,120L,12L,48L,192L,32L,180L,30L,8L,144L,24L,30L,120L,36L,48L,96L,60L,12L,256L,60L,36L,6L,216L,6L,240L,60L,4L,144L,384L,24L,96L,360L,64L,60L,24L,6L,288L,48L,24L,210L,360L,60L,72L,240L,16L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286631Inst : IEnumerable<long>
{
public static readonly long[] Value=A286631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286631.Bytes);
public long this[int i]=>Value[i];

public static A286631Inst Instance=new A286631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286632
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,4L,2L,4L,1L,3L,3L,5L,3L,5L,2L,5L,4L,6L,3L,4L,2L,4L,2L,6L,2L,4L,3L,6L,1L,3L,4L,6L,3L,5L,4L,7L,4L,6L,4L,5L,5L,7L,2L,5L,3L,5L,3L,7L,5L,7L,3L,5L,4L,6L,3L,7L,6L,8L,4L,4L,3L,5L,5L,7L,6L,8L,4L,6L,3L,5L,6L,8L,3L,5L,5L,7L,5L,7L,3L,6L,4L,6L,5L,8L,1L,3L,5L,6L,2L,4L,4L,6L,2L,4L,2L,8L,4L,6L,6L,8L,2L,4L,2L,6L,3L,5L,4L,7L,4L,6L,5L,8L,5L,7L,5L,9L,5L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286632Inst : IEnumerable<long>
{
public static readonly long[] Value=A286632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286632.Bytes);
public long this[int i]=>Value[i];

public static A286632Inst Instance=new A286632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286633
{
public static readonly long[] Value={ 1L,2L,3L,2L,6L,4L,9L,3L,12L,2L,6L,6L,18L,8L,18L,4L,24L,12L,27L,6L,12L,3L,9L,4L,36L,4L,12L,6L,36L,2L,6L,12L,48L,6L,18L,12L,54L,16L,36L,9L,24L,24L,54L,4L,18L,8L,18L,6L,72L,24L,54L,6L,24L,12L,27L,6L,72L,36L,81L,12L,12L,6L,18L,18L,96L,36L,81L,12L,36L,6L,18L,36L,108L,8L,24L,18L,72L,24L,54L,8L,48L,12L,36L,18L,108L,2L,6L,24L,36L,4L,12L,12L,36L,3L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286633Inst : IEnumerable<long>
{
public static readonly long[] Value=A286633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286633.Bytes);
public long this[int i]=>Value[i];

public static A286633Inst Instance=new A286633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286634
{
public static readonly long[] Value={ 2L,2L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,3L,3L,1L,1L,2L,1L,3L,2L,1L,2L,2L,1L,1L,1L,1L,7L,1L,3L,1L,5L,1L,3L,3L,2L,1L,3L,1L,5L,1L,2L,1L,3L,6L,1L,1L,1L,3L,1L,5L,3L,3L,1L,1L,1L,2L,1L,5L,7L,2L,1L,1L,7L,3L,5L,1L,2L,3L,2L,1L,3L,2L,1L,2L,2L,1L,5L,1L,1L,1L,3L,2L,1L,2L,2L,1L,1L,6L,2L,1L,1L,1L,3L,3L,1L,3L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286634Inst : IEnumerable<long>
{
public static readonly long[] Value=A286634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286634.Bytes);
public long this[int i]=>Value[i];

public static A286634Inst Instance=new A286634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286635
{
public static readonly long[] Value={ 21361L,8L,4L,134L,6L,4L,57L,6L,34L,65L,14L,9L,14L,6L,4L,21L,12L,4L,26L,8L,26L,779L,102L,99L,33L,8L,4L,14L,12L,4L,9L,6L,70L,33L,169L,25L,98L,8L,4L,14L,410L,4L,458L,6L,10L,25L,6L,26L,14L,8L,4L,122L,6L,4L,231L,8L,836L,62L,18L,74L,39L,8L,4L,1101L,14L,4L,81L,8L,68L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286635Inst : IEnumerable<long>
{
public static readonly long[] Value=A286635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286635.Bytes);
public long this[int i]=>Value[i];

public static A286635Inst Instance=new A286635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286636
{
public static readonly long[] Value={ 2L,6L,10L,14L,18L,26L,30L,38L,42L,46L,50L,54L,62L,66L,74L,82L,86L,90L,98L,102L,110L,114L,118L,122L,126L,138L,146L,150L,154L,158L,170L,174L,182L,186L,194L,198L,206L,222L,226L,230L,234L,242L,246L,258L,262L,266L,270L,278L,282L,290L,294L,306L,314L,318L,326L,334L,338L,350L,354L,362L,366L,370L,374L,378L,390L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286636Inst : IEnumerable<long>
{
public static readonly long[] Value=A286636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286636.Bytes);
public long this[int i]=>Value[i];

public static A286636Inst Instance=new A286636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286637
{
public static readonly long[] Value={ 3L,37L,47L,73L,107L,121L,181L,191L,239L,249L,253L,299L,337L,359L,429L,431L,433L,503L,529L,537L,541L,579L,587L,649L,659L,661L,671L,759L,767L,781L,789L,793L,851L,863L,933L,937L,971L,1067L,1069L,1079L,1081L,1093L,1191L,1199L,1237L,1249L,1257L,1261L,1307L,1319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286637Inst : IEnumerable<long>
{
public static readonly long[] Value=A286637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286637.Bytes);
public long this[int i]=>Value[i];

public static A286637Inst Instance=new A286637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286638
{
public static readonly BigInteger[] Value={ 1L,10L,1L,1100L,11L,111100L,11L,11110000L,1111L,1111110000L,1111L,111111110000L,1111L,11111111110000L,1111L,1111111100000000L,11111111L,111111111100000000L,11100001L,11111111111100011100UL,10000001L,BigInteger.Parse("1111111111111101100100"),10000001L,BigInteger.Parse("111111111111111000100100") };
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
public class A286638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286638.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286638Inst Instance=new A286638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286639
{
public static readonly BigInteger[] Value={ 1L,1L,100L,11L,11000L,1111L,1100000L,1111L,111100000L,111111L,11110000000L,11111111L,1111000000000L,1111111111L,111100000000000L,11111111L,11111111000000000L,1111111111L,1000011100000000000L,111000111111111111L,BigInteger.Parse("100000010000000000000"),10011011111111111111UL };
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
public class A286639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286639.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286639Inst Instance=new A286639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286640
{
public static readonly long[] Value={ 1L,2L,1L,12L,3L,60L,3L,240L,15L,1008L,15L,4080L,15L,16368L,15L,65280L,255L,261888L,225L,1048348L,129L,4194148L,129L,16776740L,475L,67108388L,1L,268435452L,3L,1073737856L,3940L,4294901897L,65124L,17179803801L,63588L,68719412105L,63588L,274877842313L,64612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286640Inst : IEnumerable<long>
{
public static readonly long[] Value=A286640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286640.Bytes);
public long this[int i]=>Value[i];

public static A286640Inst Instance=new A286640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286641
{
public static readonly long[] Value={ 1L,1L,4L,3L,24L,15L,96L,15L,480L,63L,1920L,255L,7680L,1023L,30720L,255L,130560L,1023L,276480L,233471L,1056768L,638975L,4227072L,2392063L,28770304L,9568255L,67108864L,67108863L,402653184L,4456447L,326631424L,2432761855L,1291714560L,10267918335L,5116526592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286641Inst : IEnumerable<long>
{
public static readonly long[] Value=A286641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286641.Bytes);
public long this[int i]=>Value[i];

public static A286641Inst Instance=new A286641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286642
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1111L,11L,111111L,11L,11111111L,1111L,1111111111L,1111L,111111111111L,1111L,11111111111111L,1111L,1111111111111111L,11111111L,111111111111111111L,11100001L,11111111111111111111UL,10000001L,BigInteger.Parse("1111111111111111111111"),10000001L,BigInteger.Parse("111111111111111111111111") };
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
public class A286642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286642.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A286642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286642Inst Instance=new A286642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286643
{
public static readonly ulong[] Value={ 1L,11L,100L,1111L,11000L,111111L,1100000L,11111111L,111100000L,1111111111L,11110000000L,111111111111L,1111000000000L,11111111111111L,111100000000000L,1111111111111111L,11111111000000000L,111111111111111111L,1000011100000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286643Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286643.Bytes);
public ulong this[int i]=>Value[i];

public static A286643Inst Instance=new A286643Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}