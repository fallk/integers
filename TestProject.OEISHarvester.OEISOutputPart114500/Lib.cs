using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278180
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,8L,15L,16L,17L,33L,35L,37L,72L,76L,80L,84L,164L,172L,180L,188L,368L,384L,401L,418L,435L,853L,888L,925L,962L,999L,1961L,2037L,2117L,2201L,2285L,2369L,4654L,4826L,5006L,5194L,5382L,5570L,10952L,11336L,11737L,12155L,12590L,13025L,13460L,26485L,27373L,28298L,29260L,30259L,31258L,32257L,63515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278180Inst : IEnumerable<long>
{
public static readonly long[] Value=A278180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278180.Bytes);
public long this[int i]=>Value[i];

public static A278180Inst Instance=new A278180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278181
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,9L,12L,14L,19L,22L,29L,33L,42L,47L,59L,74L,82L,99L,108L,129L,155L,169L,202L,243L,265L,316L,378L,411L,486L,575L,622L,728L,861L,1017L,1099L,1280L,1487L,1595L,1832L,2116L,2440L,2609L,2980L,3425L,3933L,4198L,4779L,5473L,6262L,6673L,7570L,8631L,9828L,10450L,11800L,13389L,15267L,17383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278181Inst : IEnumerable<long>
{
public static readonly long[] Value=A278181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278181.Bytes);
public long this[int i]=>Value[i];

public static A278181Inst Instance=new A278181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278182
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,4L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278182Inst : IEnumerable<long>
{
public static readonly long[] Value=A278182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278182.Bytes);
public long this[int i]=>Value[i];

public static A278182Inst Instance=new A278182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278183
{
public static readonly long[] Value={ 0L,3L,28L,200L,1532L,11794L,90538L,695252L,5339294L,41003018L,314882364L,2418138526L,18570087298L,142608927356L,1095164819630L,8410314860218L,64586987065356L,495995568270926L,3808996439085090L,29251176423848812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278183Inst : IEnumerable<long>
{
public static readonly long[] Value=A278183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278183.Bytes);
public long this[int i]=>Value[i];

public static A278183Inst Instance=new A278183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278184
{
public static readonly BigInteger[] Value={ 0L,19L,544L,13720L,347116L,8803344L,223230876L,5660949042L,143557203008L,3640498372990L,92320193797850L,2341167983288042L,59370190792031534L,1505581649925192516L,BigInteger.Parse("38180374263992817136"),BigInteger.Parse("968224459304580152320") };
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
public class A278184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278184Inst Instance=new A278184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278185
{
public static readonly BigInteger[] Value={ 0L,136L,13012L,1075258L,91270219L,7737459027L,656008970388L,55620335387114L,4715820197535009L,399835065589298715L,BigInteger.Parse("33900377809514573711"),BigInteger.Parse("2874274212652455298123"),BigInteger.Parse("243697940183994435905588") };
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
public class A278185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278185Inst Instance=new A278185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278186
{
public static readonly BigInteger[] Value={ 0L,935L,295190L,81691958L,23124026160L,6545874548694L,1852662745588838L,524386828923495662L,BigInteger.Parse("148424784547109672280"),BigInteger.Parse("42010806495461042971956"),BigInteger.Parse("11890925205860266718183950"),BigInteger.Parse("3365660260074301506275917454") };
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
public class A278186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278186Inst Instance=new A278186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278187
{
public static readonly BigInteger[] Value={ 0L,6381L,6715738L,6196345742L,5858713218010L,5537142857552112L,5232919178331757631L,BigInteger.Parse("4945638025497366239942"),BigInteger.Parse("4674127103296221122266834"),BigInteger.Parse("4417520697715221210576165981") };
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
public class A278187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278187Inst Instance=new A278187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278188
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,0L,19L,28L,0L,0L,136L,544L,200L,0L,0L,935L,13012L,13720L,1532L,0L,0L,6381L,295190L,1075258L,347116L,11794L,0L,0L,43478L,6715738L,81691958L,91270219L,8803344L,90538L,0L,0L,296105L,152540636L,6196345742L,23124026160L,7737459027L,223230876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278188Inst : IEnumerable<long>
{
public static readonly long[] Value=A278188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278188.Bytes);
public long this[int i]=>Value[i];

public static A278188Inst Instance=new A278188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278189
{
public static readonly long[] Value={ 0L,3L,19L,136L,935L,6381L,43478L,296105L,2016307L,13729364L,93484479L,636542307L,4334257038L,29512224731L,200950553535L,1368284654492L,9316734157423L,63438214373401L,431954692843542L,2941205998493005L,20026852048660187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278189Inst : IEnumerable<long>
{
public static readonly long[] Value=A278189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278189.Bytes);
public long this[int i]=>Value[i];

public static A278189Inst Instance=new A278189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278190
{
public static readonly BigInteger[] Value={ 0L,28L,544L,13012L,295190L,6715738L,152540636L,3464413662L,78677378754L,1786751336003L,40576751391716L,921488781267445L,20926797071937044L,475242697298621311L,10792651081336090474UL,BigInteger.Parse("245098594252284069018") };
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
public class A278190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278190Inst Instance=new A278190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278191
{
public static readonly BigInteger[] Value={ 0L,200L,13720L,1075258L,81691958L,6196345742L,469577175712L,35577034730206L,2695338849906758L,204197662339944373L,15469874074262345128UL,BigInteger.Parse("1171986102689397728682"),BigInteger.Parse("88788773705648773915186") };
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
public class A278191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278191Inst Instance=new A278191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278192
{
public static readonly BigInteger[] Value={ 0L,1532L,347116L,91270219L,23124026160L,5858713218010L,1482450100931615L,375049865320978231L,BigInteger.Parse("94879541460515598902"),BigInteger.Parse("24002203229663363493985"),BigInteger.Parse("6071950545418789283104046"),BigInteger.Parse("1536048854453696521513657702") };
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
public class A278192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278192Inst Instance=new A278192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278193
{
public static readonly BigInteger[] Value={ 0L,11794L,8803344L,7737459027L,6545874548694L,5537142857552112L,4678308031001778581L,BigInteger.Parse("3951925612543275997042"),BigInteger.Parse("3338154929554215989823146"),BigInteger.Parse("2819671588394426773289855424"),BigInteger.Parse("2381712111047192598048356777986") };
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
public class A278193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278193Inst Instance=new A278193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278194
{
public static readonly BigInteger[] Value={ 0L,0L,1L,-14L,336L,-1408L,256256L,14746368L,1766772736L,242121048064L,41267065061376L,8461792420167680L,2057680174397259776L,BigInteger.Parse("585429994601202057216"),BigInteger.Parse("192659868531986620481536") };
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
public class A278194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278194Inst Instance=new A278194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278195
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,-28L,882L,-17116L,803803L,13713336L,3671012164L,506128123928L,96524822605365L,21542790273363260L,5676618945053498806L,BigInteger.Parse("1739246268204447115932"),BigInteger.Parse("613255488134158250903887"),BigInteger.Parse("246554708506039690689322544"),BigInteger.Parse("112115693433705109495581088008") };
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
public class A278195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278195Inst Instance=new A278195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278228
{
public static readonly long[] Value={ 2L,4L,6L,8L,12L,6L,12L,12L,24L,30L,32L,6L,30L,12L,48L,24L,60L,6L,12L,72L,6L,48L,60L,60L,12L,30L,24L,72L,30L,30L,128L,60L,30L,60L,60L,24L,6L,12L,120L,30L,180L,30L,192L,6L,60L,72L,12L,96L,60L,30L,60L,240L,12L,180L,30L,120L,120L,48L,6L,30L,12L,60L,60L,120L,6L,30L,12L,12L,60L,60L,30L,360L,48L,30L,60L,384L,210L,6L,30L,30L,420L,6L,432L,30L,120L,60L,180L,6L,210L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278228Inst : IEnumerable<long>
{
public static readonly long[] Value=A278228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278228.Bytes);
public long this[int i]=>Value[i];

public static A278228Inst Instance=new A278228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278229
{
public static readonly long[] Value={ 2L,2L,4L,2L,6L,4L,6L,2L,12L,6L,2L,2L,16L,6L,6L,30L,12L,4L,6L,6L,6L,2L,30L,6L,2L,6L,6L,6L,6L,36L,6L,12L,30L,2L,24L,6L,2L,12L,12L,30L,30L,4L,6L,30L,6L,2L,2L,6L,6L,2L,30L,12L,6L,6L,24L,60L,6L,2L,6L,30L,6L,60L,2L,24L,16L,6L,2L,2L,60L,6L,30L,6L,2L,6L,2L,60L,30L,6L,12L,6L,24L,4L,30L,6L,2L,30L,30L,6L,6L,12L,6L,30L,6L,12L,2L,30L,12L,6L,30L,6L,2L,30L,72L,6L,6L,2L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278229Inst : IEnumerable<long>
{
public static readonly long[] Value=A278229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278229.Bytes);
public long this[int i]=>Value[i];

public static A278229Inst Instance=new A278229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278230
{
public static readonly long[] Value={ 2L,2L,2L,6L,2L,8L,6L,6L,2L,2L,12L,12L,2L,6L,6L,2L,6L,6L,24L,6L,12L,6L,2L,2L,30L,6L,12L,6L,6L,2L,30L,2L,12L,12L,6L,6L,60L,6L,6L,2L,2L,12L,2L,12L,6L,30L,12L,6L,30L,24L,2L,2L,30L,2L,6L,6L,12L,6L,30L,2L,48L,2L,30L,6L,30L,6L,30L,72L,6L,6L,6L,2L,60L,12L,30L,6L,6L,30L,6L,60L,2L,6L,2L,12L,6L,2L,6L,30L,6L,12L,30L,6L,60L,2L,24L,6L,2L,6L,6L,12L,30L,6L,12L,6L,12L,210L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278230Inst : IEnumerable<long>
{
public static readonly long[] Value=A278230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278230.Bytes);
public long this[int i]=>Value[i];

public static A278230Inst Instance=new A278230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278231
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,6L,2L,6L,6L,12L,2L,6L,2L,4L,8L,2L,16L,12L,2L,12L,6L,2L,6L,30L,2L,2L,12L,8L,6L,24L,4L,6L,12L,48L,4L,24L,6L,2L,12L,60L,2L,12L,6L,6L,24L,6L,2L,6L,6L,6L,32L,6L,6L,36L,2L,12L,12L,6L,2L,24L,2L,2L,30L,6L,60L,6L,6L,48L,16L,2L,6L,60L,6L,2L,24L,6L,6L,12L,6L,12L,6L,2L,30L,6L,64L,30L,2L,12L,6L,72L,2L,30L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278231Inst : IEnumerable<long>
{
public static readonly long[] Value=A278231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278231.Bytes);
public long this[int i]=>Value[i];

public static A278231Inst Instance=new A278231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278232
{
public static readonly long[] Value={ 2L,6L,12L,12L,6L,30L,6L,30L,6L,24L,6L,6L,30L,30L,60L,6L,30L,6L,30L,6L,4L,8L,6L,144L,24L,48L,6L,30L,30L,30L,6L,210L,6L,30L,30L,12L,12L,24L,6L,120L,6L,30L,60L,6L,6L,30L,6L,210L,60L,6L,30L,6L,30L,30L,210L,6L,30L,30L,30L,30L,30L,30L,6L,210L,6L,30L,96L,30L,210L,60L,30L,210L,60L,6L,6L,30L,30L,30L,30L,30L,420L,30L,60L,30L,6L,30L,30L,24L,120L,30L,12L,12L,30L,6L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278232Inst : IEnumerable<long>
{
public static readonly long[] Value=A278232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278232.Bytes);
public long this[int i]=>Value[i];

public static A278232Inst Instance=new A278232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278233
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,6L,2L,8L,6L,12L,2L,12L,2L,6L,8L,16L,16L,30L,2L,36L,4L,6L,6L,24L,2L,6L,12L,12L,6L,24L,2L,32L,6L,48L,6L,60L,2L,6L,12L,72L,2L,12L,6L,12L,24L,30L,2L,48L,6L,6L,32L,12L,6L,60L,2L,24L,12L,30L,2L,72L,2L,6L,12L,64L,36L,30L,2L,144L,4L,30L,6L,120L,2L,6L,24L,12L,6L,60L,6L,144L,4L,6L,30L,36L,64L,30L,2L,24L,6L,120L,2L,60L,6L,6L,12L,96L,2L,30L,12L,12L,30L,96L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278233Inst : IEnumerable<long>
{
public static readonly long[] Value=A278233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278233.Bytes);
public long this[int i]=>Value[i];

public static A278233Inst Instance=new A278233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278234
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,4L,2L,6L,6L,30L,6L,12L,2L,6L,4L,12L,6L,12L,2L,4L,6L,12L,4L,8L,2L,6L,6L,30L,6L,12L,6L,30L,30L,210L,30L,60L,6L,30L,12L,60L,30L,60L,6L,12L,30L,60L,12L,24L,2L,6L,6L,30L,6L,12L,4L,12L,12L,60L,12L,36L,6L,30L,12L,60L,30L,60L,6L,12L,30L,60L,12L,24L,2L,6L,4L,12L,6L,12L,6L,30L,12L,60L,30L,60L,4L,12L,8L,24L,12L,36L,6L,12L,12L,36L,12L,24L,2L,4L,6L,12L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278234Inst : IEnumerable<long>
{
public static readonly long[] Value=A278234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278234.Bytes);
public long this[int i]=>Value[i];

public static A278234Inst Instance=new A278234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278235
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,4L,4L,8L,6L,12L,2L,6L,6L,12L,4L,12L,2L,6L,6L,12L,6L,30L,2L,4L,4L,8L,6L,12L,4L,8L,8L,16L,12L,24L,6L,12L,12L,24L,12L,36L,6L,12L,12L,24L,30L,60L,2L,6L,6L,12L,4L,12L,6L,12L,12L,24L,12L,36L,4L,12L,12L,36L,8L,24L,6L,30L,30L,60L,12L,60L,2L,6L,6L,12L,6L,30L,6L,12L,12L,24L,30L,60L,6L,30L,30L,60L,12L,60L,4L,12L,12L,36L,12L,60L,2L,6L,6L,12L,6L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278235Inst : IEnumerable<long>
{
public static readonly long[] Value=A278235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278235.Bytes);
public long this[int i]=>Value[i];

public static A278235Inst Instance=new A278235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278236
{
public static readonly long[] Value={ 1L,2L,2L,6L,4L,12L,2L,6L,6L,30L,12L,60L,4L,12L,12L,60L,36L,180L,8L,24L,24L,120L,72L,360L,2L,6L,6L,30L,12L,60L,6L,30L,30L,210L,60L,420L,12L,60L,60L,420L,180L,1260L,24L,120L,120L,840L,360L,2520L,4L,12L,12L,60L,36L,180L,12L,60L,60L,420L,180L,1260L,36L,180L,180L,1260L,900L,6300L,72L,360L,360L,2520L,1800L,12600L,8L,24L,24L,120L,72L,360L,24L,120L,120L,840L,360L,2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278236Inst : IEnumerable<long>
{
public static readonly long[] Value=A278236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278236.Bytes);
public long this[int i]=>Value[i];

public static A278236Inst Instance=new A278236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278237
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,4L,6L,2L,12L,2L,6L,6L,16L,4L,12L,2L,12L,6L,6L,2L,24L,2L,6L,8L,12L,6L,30L,2L,64L,6L,6L,2L,36L,2L,6L,6L,24L,2L,30L,4L,12L,12L,6L,2L,48L,2L,30L,12L,12L,2L,24L,2L,24L,6L,6L,6L,60L,2L,6L,12L,32L,2L,30L,2L,12L,6L,12L,6L,72L,6L,6L,6L,12L,2L,30L,2L,48L,16L,6L,2L,60L,2L,30L,30L,24L,6L,60L,6L,12L,6L,6L,2L,192L,6L,6L,12L,36L,2L,30L,2L,48L,6L,30L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278237Inst : IEnumerable<long>
{
public static readonly long[] Value=A278237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278237.Bytes);
public long this[int i]=>Value[i];

public static A278237Inst Instance=new A278237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278238
{
public static readonly long[] Value={ 1L,4L,4L,16L,16L,36L,4L,64L,36L,144L,4L,144L,4L,36L,64L,256L,256L,900L,4L,1296L,16L,36L,36L,576L,4L,36L,144L,144L,36L,576L,4L,1024L,36L,2304L,36L,3600L,4L,36L,144L,5184L,4L,144L,36L,144L,576L,900L,4L,2304L,36L,36L,1024L,144L,36L,3600L,4L,576L,144L,900L,4L,5184L,4L,36L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278238Inst : IEnumerable<long>
{
public static readonly long[] Value=A278238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278238.Bytes);
public long this[int i]=>Value[i];

public static A278238Inst Instance=new A278238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278239
{
public static readonly long[] Value={ 1L,4L,6L,16L,12L,60L,6L,64L,30L,180L,6L,240L,12L,60L,24L,256L,240L,420L,6L,720L,12L,60L,30L,960L,6L,180L,60L,240L,30L,360L,30L,1024L,30L,5040L,30L,1680L,6L,60L,360L,2880L,30L,180L,210L,240L,120L,420L,6L,3840L,60L,60L,96L,720L,210L,1260L,6L,960L,60L,420L,30L,2160L,12L,420L,60L,4096L,180L,420L,30L,45360L,60L,420L,30L,6720L,30L,60L,840L,240L,30L,12600L,30L,11520L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278239Inst : IEnumerable<long>
{
public static readonly long[] Value=A278239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278239.Bytes);
public long this[int i]=>Value[i];

public static A278239Inst Instance=new A278239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278240
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,12L,2L,30L,6L,30L,6L,420L,2L,30L,30L,210L,2L,840L,2L,4620L,60L,210L,6L,60060L,30L,30L,30L,30030L,30L,60060L,2L,2310L,210L,30L,210L,38798760L,6L,30L,210L,1021020L,6L,180180L,30L,510510L,30030L,210L,30L,446185740L,6L,510510L,2310L,510510L,30L,240240L,30030L,9699690L,210L,30030L,6L,1203362940780L,2L,30L,60060L,510510L,30L,19399380L,6L,510510L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278240Inst : IEnumerable<long>
{
public static readonly long[] Value=A278240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278240.Bytes);
public long this[int i]=>Value[i];

public static A278240Inst Instance=new A278240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278241
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,6L,6L,30L,30L,24L,6L,2L,24L,48L,30L,24L,30L,60L,30L,360L,30L,6L,180L,30L,420L,210L,60L,30L,60L,30L,60L,180L,30L,60L,2L,30L,60L,1680L,420L,210L,30L,240L,60L,30L,210L,420L,30L,60L,30L,60L,2310L,60L,2310L,420L,30L,30L,420L,4620L,30L,2310L,420L,30L,2310L,6L,6720L,6L,420L,30L,3360L,30L,30L,30L,2520L,120120L,6L,2L,420L,420L,1260L,6L,840L,30L,4620L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278241Inst : IEnumerable<long>
{
public static readonly long[] Value=A278241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278241.Bytes);
public long this[int i]=>Value[i];

public static A278241Inst Instance=new A278241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278242
{
public static readonly long[] Value={ 2L,2L,2L,4L,2L,6L,6L,6L,2L,24L,12L,6L,6L,6L,30L,60L,2L,6L,210L,6L,6L,60L,30L,6L,30L,210L,210L,240L,6L,30L,4620L,6L,6L,420L,210L,2310L,210L,30L,210L,60L,6L,30L,30030L,6L,30L,9240L,2310L,30L,30L,30L,9240L,4620L,30L,30L,30030L,4620L,30L,420L,30L,210L,210L,6L,2310L,9240L,6L,30030L,30030L,30L,60L,420L,60060L,30L,2310L,30L,2310L,60060L,210L,30030L,446185740L,6L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278242Inst : IEnumerable<long>
{
public static readonly long[] Value=A278242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278242.Bytes);
public long this[int i]=>Value[i];

public static A278242Inst Instance=new A278242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278243
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,12L,6L,30L,2L,60L,12L,120L,6L,180L,30L,210L,2L,420L,60L,1080L,12L,2160L,120L,2520L,6L,2520L,180L,7560L,30L,6300L,210L,2310L,2L,4620L,420L,37800L,60L,90720L,1080L,75600L,12L,226800L,2160L,544320L,120L,453600L,2520L,138600L,6L,138600L,2520L,756000L,180L,2268000L,7560L,831600L,30L,415800L,6300L,2079000L,210L,485100L,2310L,30030L,2L,60060L,4620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278243Inst : IEnumerable<long>
{
public static readonly long[] Value=A278243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278243.Bytes);
public long this[int i]=>Value[i];

public static A278243Inst Instance=new A278243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278276
{
public static readonly long[] Value={ 0L,13L,122L,1461L,16842L,196726L,2293193L,26748095L,311952675L,3638315600L,42433460041L,494899976008L,5771998528706L,67318594537535L,785134131756525L,9156988685842075L,106797600929943552L,1245576243371149125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278276Inst : IEnumerable<long>
{
public static readonly long[] Value=A278276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278276.Bytes);
public long this[int i]=>Value[i];

public static A278276Inst Instance=new A278276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278277
{
public static readonly BigInteger[] Value={ 0L,36L,661L,15728L,350649L,7974561L,180592726L,4093629985L,92770708201L,2102508396678L,47649509554925L,1079892701460069L,24473856622606826L,554656753862884753L,12570315495304559959UL,BigInteger.Parse("284883998059198465598") };
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
public class A278277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278277Inst Instance=new A278277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278278
{
public static readonly BigInteger[] Value={ 0L,109L,3723L,172091L,7466627L,329985827L,14526103064L,640011857446L,28192246592564L,1241921389868057L,54708244420668156L,2409976614356023808L,BigInteger.Parse("106162841585764737411"),BigInteger.Parse("4676622598537493878129"),BigInteger.Parse("206011798163918590188603") };
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
public class A278278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278278Inst Instance=new A278278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278279
{
public static readonly BigInteger[] Value={ 0L,317L,20736L,1870365L,157609938L,13538466880L,1158266740087L,99182079495633L,8491049196878995L,726961954823301592L,BigInteger.Parse("62238120572972036597"),BigInteger.Parse("5328470518831632979210"),BigInteger.Parse("456192709882426407920004") };
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
public class A278279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278279Inst Instance=new A278279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278280
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,4L,5L,0L,0L,13L,25L,16L,0L,0L,36L,122L,136L,49L,0L,0L,109L,661L,1461L,839L,153L,0L,0L,317L,3723L,15728L,16842L,5013L,476L,0L,0L,938L,20736L,172091L,350649L,196726L,30370L,1483L,0L,0L,2754L,115446L,1870365L,7466627L,7974561L,2293193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278280Inst : IEnumerable<long>
{
public static readonly long[] Value=A278280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278280.Bytes);
public long this[int i]=>Value[i];

public static A278280Inst Instance=new A278280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278281
{
public static readonly long[] Value={ 0L,2L,4L,13L,36L,109L,317L,938L,2754L,8114L,23869L,70264L,206775L,608587L,1791104L,5271458L,15514416L,45660689L,134384272L,395507653L,1164021849L,3425843074L,10082628314L,29674271654L,87334607025L,257035243772L,756482665279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278281Inst : IEnumerable<long>
{
public static readonly long[] Value=A278281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278281.Bytes);
public long this[int i]=>Value[i];

public static A278281Inst Instance=new A278281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278282
{
public static readonly long[] Value={ 0L,5L,25L,122L,661L,3723L,20736L,115446L,643201L,3583987L,19968771L,111259772L,619906272L,3453935575L,19244300244L,107223525884L,597417624393L,3328633543713L,18546157153693L,103333677917171L,575744553924121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278282Inst : IEnumerable<long>
{
public static readonly long[] Value=A278282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278282.Bytes);
public long this[int i]=>Value[i];

public static A278282Inst Instance=new A278282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278283
{
public static readonly long[] Value={ 0L,16L,136L,1461L,15728L,172091L,1870365L,20361727L,221557310L,2411418252L,26242720295L,285604090818L,3108225766879L,33827018841718L,368140557268407L,4006490289802208L,43602794999327810L,474531057207686074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278283Inst : IEnumerable<long>
{
public static readonly long[] Value=A278283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278283.Bytes);
public long this[int i]=>Value[i];

public static A278283Inst Instance=new A278283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278284
{
public static readonly BigInteger[] Value={ 0L,49L,839L,16842L,350649L,7466627L,157609938L,3332353281L,70423579121L,1488690711220L,31465894708605L,665110590387221L,14058553586577416L,297159984661665232L,6281145221048978301L,BigInteger.Parse("132766286493553767967") };
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
public class A278284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278284Inst Instance=new A278284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278285
{
public static readonly BigInteger[] Value={ 0L,153L,5013L,196726L,7974561L,329985827L,13538466880L,556397458939L,22855524139957L,939108990106903L,38582376309904861L,1585188853495876230L,BigInteger.Parse("65127697958640926840"),BigInteger.Parse("2675798844803131047876"),BigInteger.Parse("109936009766691550151969") };
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
public class A278285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278285Inst Instance=new A278285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278286
{
public static readonly BigInteger[] Value={ 0L,476L,30370L,2293193L,180592726L,14526103064L,1158266740087L,92512375832471L,7385561338360758L,589775066919535309L,BigInteger.Parse("47090974186795340550"),BigInteger.Parse("3760172975855159952403"),BigInteger.Parse("300241490821466632869029") };
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
public class A278286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278286Inst Instance=new A278286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278287
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,1L,1L,1L,0L,1L,2L,1L,1L,2L,1L,1L,3L,2L,2L,4L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,3L,2L,2L,3L,1L,2L,3L,1L,3L,5L,2L,2L,5L,2L,1L,4L,3L,2L,4L,3L,2L,4L,3L,2L,5L,3L,2L,5L,3L,1L,6L,3L,2L,4L,4L,2L,4L,4L,3L,4L,3L,2L,5L,2L,2L,6L,2L,2L,6L,1L,2L,4L,1L,2L,4L,2L,1L,5L,3L,3L,5L,2L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278287Inst : IEnumerable<long>
{
public static readonly long[] Value=A278287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278287.Bytes);
public long this[int i]=>Value[i];

public static A278287Inst Instance=new A278287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278288
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,3L,4L,6L,2L,4L,8L,3L,8L,4L,12L,6L,10L,10L,11L,12L,15L,9L,12L,19L,7L,15L,17L,10L,18L,22L,17L,12L,22L,21L,22L,25L,25L,26L,22L,26L,26L,27L,32L,25L,30L,27L,35L,21L,23L,31L,31L,32L,37L,37L,38L,37L,39L,37L,40L,40L,41L,45L,28L,37L,42L,38L,50L,33L,43L,58L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278288Inst : IEnumerable<long>
{
public static readonly long[] Value=A278288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278288.Bytes);
public long this[int i]=>Value[i];

public static A278288Inst Instance=new A278288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278289
{
public static readonly BigInteger[] Value={ 1L,1L,16L,101376L,1190156828672L,BigInteger.Parse("68978321274090930831360"),BigInteger.Parse("40824193474825703180733027309531955200"),BigInteger.Parse("440873872874088459550341319780612789503586208384381091840"),BigInteger.Parse("140992383930585613207663170866505518985873138480180692888967131590224605582721024") };
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
public class A278289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278289Inst Instance=new A278289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278290
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,2L,1L,4L,4L,2L,1L,4L,4L,4L,2L,1L,4L,4L,4L,4L,2L,1L,4L,4L,4L,4L,4L,2L,1L,4L,4L,4L,4L,4L,4L,2L,1L,4L,4L,4L,4L,4L,4L,4L,2L,1L,4L,4L,4L,4L,4L,4L,4L,4L,2L,1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,2L,1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,2L,1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,2L,1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,2L,1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278290Inst : IEnumerable<long>
{
public static readonly long[] Value=A278290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278290.Bytes);
public long this[int i]=>Value[i];

public static A278290Inst Instance=new A278290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278291
{
public static readonly long[] Value={ 3L,10L,15L,22L,26L,28L,34L,35L,39L,45L,58L,76L,86L,87L,94L,95L,99L,117L,119L,122L,123L,125L,134L,136L,142L,143L,146L,148L,154L,159L,165L,171L,172L,175L,178L,202L,203L,206L,214L,215L,218L,219L,231L,245L,246L,254L,285L,286L,297L,299L,302L,303L,327L,333L,335L,351L,357L,362L,370L,376L,382L,388L,394L,395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278291Inst : IEnumerable<long>
{
public static readonly long[] Value=A278291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278291.Bytes);
public long this[int i]=>Value[i];

public static A278291Inst Instance=new A278291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279589
{
public static readonly long[] Value={ 1L,-2L,1L,0L,-1L,3L,-3L,1L,0L,-1L,3L,-3L,1L,0L,-1L,3L,-3L,1L,0L,-1L,4L,-7L,7L,-4L,-1L,9L,-17L,17L,-9L,-1L,14L,-27L,27L,-14L,-1L,19L,-37L,38L,-23L,5L,21L,-53L,68L,-58L,29L,23L,-89L,133L,-128L,73L,25L,-145L,233L,-233L,138L,23L,-215L,366L,-385L,257L,-24L,-281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279589Inst : IEnumerable<long>
{
public static readonly long[] Value=A279589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279589.Bytes);
public long this[int i]=>Value[i];

public static A279589Inst Instance=new A279589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279590
{
public static readonly long[] Value={ 1L,-3L,4L,-3L,-1L,8L,-15L,18L,-13L,-3L,30L,-63L,89L,-86L,29L,97L,-278L,453L,-511L,314L,245L,-1151L,2170L,-2795L,2305L,-6L,-4331L,9921L,-14534L,14549L,-5887L,-13958L,43029L,-72127L,83898L,-55979L,-30079L,174330L,-342124L,454087L,-393943L,45299L,638945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279590Inst : IEnumerable<long>
{
public static readonly long[] Value=A279590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279590.Bytes);
public long this[int i]=>Value[i];

public static A279590Inst Instance=new A279590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279591
{
public static readonly long[] Value={ 1L,-2L,0L,3L,-2L,-4L,8L,0L,-16L,16L,16L,-48L,16L,79L,-108L,-52L,265L,-156L,-372L,672L,80L,-1408L,1216L,1600L,-3968L,704L,7169L,-8391L,-6000L,22463L,-10045L,-34660L,53708L,16192L,-122112L,87120L,156688L,-325360L,7375L,636819L,-636074L,-639771L,1883405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279591Inst : IEnumerable<long>
{
public static readonly long[] Value=A279591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279591.Bytes);
public long this[int i]=>Value[i];

public static A279591Inst Instance=new A279591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279592
{
public static readonly long[] Value={ 1L,-3L,5L,-9L,18L,-36L,72L,-144L,287L,-570L,1132L,-2250L,4473L,-8892L,17676L,-35137L,69847L,-138845L,276002L,-548649L,1090629L,-2168001L,4309649L,-8566912L,17029689L,-33852374L,67293256L,-133768530L,265911039L,-528589801L,1050754338L,-2088736250L,4152082903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279592Inst : IEnumerable<long>
{
public static readonly long[] Value=A279592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279592.Bytes);
public long this[int i]=>Value[i];

public static A279592Inst Instance=new A279592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279593
{
public static readonly long[] Value={ 1L,-2L,1L,0L,0L,0L,0L,0L,-1L,3L,-3L,1L,0L,0L,0L,0L,0L,-1L,3L,-3L,1L,0L,0L,0L,1L,-4L,5L,-1L,-2L,1L,0L,0L,-1L,6L,-14L,15L,-6L,-1L,1L,0L,0L,-1L,7L,-18L,21L,-10L,0L,1L,1L,-7L,18L,-18L,-3L,20L,-13L,1L,0L,9L,-34L,68L,-72L,29L,13L,-15L,2L,0L,11L,-48L,107L,-127L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279593Inst : IEnumerable<long>
{
public static readonly long[] Value=A279593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279593.Bytes);
public long this[int i]=>Value[i];

public static A279593Inst Instance=new A279593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279594
{
public static readonly long[] Value={ 1L,-2L,1L,0L,-1L,3L,-3L,1L,0L,-1L,3L,-3L,2L,-4L,5L,-1L,-3L,7L,-14L,15L,-6L,-2L,8L,-18L,22L,-17L,18L,-17L,-4L,29L,-47L,69L,-71L,28L,24L,-63L,110L,-136L,109L,-76L,36L,76L,-213L,296L,-348L,316L,-92L,-215L,455L,-664L,767L,-595L,270L,102L,-697L,1383L,-1745L,1742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279594Inst : IEnumerable<long>
{
public static readonly long[] Value=A279594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279594.Bytes);
public long this[int i]=>Value[i];

public static A279594Inst Instance=new A279594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279595
{
public static readonly long[] Value={ 1L,-3L,5L,-9L,17L,-30L,52L,-91L,160L,-281L,493L,-865L,1518L,-2664L,4675L,-8204L,14397L,-25265L,44337L,-77805L,136534L,-239592L,420441L,-737798L,1294700L,-2271961L,3986877L,-6996242L,12277127L,-21544115L,37805987L,-66342603L,116419152L,-204294349L,358499270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279595Inst : IEnumerable<long>
{
public static readonly long[] Value=A279595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279595.Bytes);
public long this[int i]=>Value[i];

public static A279595Inst Instance=new A279595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279596
{
public static readonly long[] Value={ 2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,6L,6L,4L,6L,6L,6L,6L,6L,6L,7L,7L,7L,8L,7L,6L,6L,8L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279596Inst : IEnumerable<long>
{
public static readonly long[] Value=A279596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279596.Bytes);
public long this[int i]=>Value[i];

public static A279596Inst Instance=new A279596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279597
{
public static readonly BigInteger[] Value={ 1L,10L,10L,1100L,111L,111110L,10L,11111000L,1111L,1111101000L,100011L,111111001110L,1111010L,11111111101000L,100111L,1111111110011100L,11110111L,111111111010110110L,1000110110L,11111111110011110110UL,11110110110L,BigInteger.Parse("1111111111111010110110"),1000110110L };
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
public class A279597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279597Inst Instance=new A279597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279598
{
public static readonly ulong[] Value={ 1L,1L,10L,11L,11100L,11111L,100000L,11111L,111100000L,1011111L,11000100000L,11100111111L,101111000000L,10111111111L,111001000000000L,11100111111111L,11101111000000000L,11011010111111111L,110110001000000000L,1101111001111111111L,11011011110000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279598Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279598.Bytes);
public ulong this[int i]=>Value[i];

public static A279598Inst Instance=new A279598Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279599
{
public static readonly long[] Value={ 1L,2L,2L,12L,7L,62L,2L,248L,15L,1000L,35L,4046L,122L,16360L,39L,65436L,247L,261814L,566L,1047798L,1974L,4193974L,566L,16775670L,3894L,67103670L,8886L,268422198L,32694L,1073736374L,8246L,4294942390L,62006L,17179785462L,142006L,68719263798L,524278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279599Inst : IEnumerable<long>
{
public static readonly long[] Value=A279599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279599.Bytes);
public long this[int i]=>Value[i];

public static A279599Inst Instance=new A279599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279600
{
public static readonly long[] Value={ 1L,1L,2L,3L,28L,31L,32L,31L,480L,95L,1568L,1855L,3008L,1535L,29184L,14847L,122368L,112127L,221696L,455679L,900096L,1794047L,3547136L,7315455L,14278656L,28794879L,57286656L,113459199L,230670336L,458620927L,906100736L,1836711935L,3634233344L,7456817151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279600Inst : IEnumerable<long>
{
public static readonly long[] Value=A279600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279600.Bytes);
public long this[int i]=>Value[i];

public static A279600Inst Instance=new A279600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279601
{
public static readonly BigInteger[] Value={ 1L,0L,101L,0L,10111L,100L,1010101L,10100L,101000001L,1011100L,10101010101L,101011000L,1010000011011L,10111011010L,101010101000000L,1010110011111L,10100000110010000L,101110100010111L,1010101000101011100L,10101010100010101L,BigInteger.Parse("101000001111101001100") };
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
public class A279601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279601Inst Instance=new A279601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279602
{
public static readonly ulong[] Value={ 1L,0L,101L,0L,11101L,1000L,1010101L,101000L,100000101L,11101000L,10101010101L,110101000L,1101100000101L,1011011101000L,101010101L,1111100110101000L,1001100000101L,111010001011101000L,11101010001010101L,10101000101010101000UL,1100101111100000101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279602Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279602.Bytes);
public ulong this[int i]=>Value[i];

public static A279602Inst Instance=new A279602Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279603
{
public static readonly long[] Value={ 1L,0L,5L,0L,23L,4L,85L,20L,321L,92L,1365L,344L,5147L,1498L,21824L,5535L,82320L,23831L,348508L,87317L,1318732L,381125L,5588628L,1414805L,21075092L,6096001L,89224380L,22402217L,337601664L,97608767L,1430611386L,361842384L,5395273271L,1562208940L,22839914069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279603Inst : IEnumerable<long>
{
public static readonly long[] Value=A279603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279603.Bytes);
public long this[int i]=>Value[i];

public static A279603Inst Instance=new A279603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279604
{
public static readonly long[] Value={ 1L,0L,5L,0L,29L,8L,85L,40L,261L,232L,1365L,424L,6917L,5864L,341L,63912L,4869L,238312L,119893L,690856L,417541L,2671336L,1356117L,11102632L,5395205L,33850088L,32076885L,156416680L,2416389L,1057596136L,785600853L,191007144L,7932826373L,3579503336L,22879261781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279604Inst : IEnumerable<long>
{
public static readonly long[] Value=A279604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279604.Bytes);
public long this[int i]=>Value[i];

public static A279604Inst Instance=new A279604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279765
{
public static readonly long[] Value={ 5L,13L,19L,23L,59L,79L,83L,89L,103L,149L,233L,269L,283L,349L,373L,409L,419L,439L,443L,499L,523L,569L,593L,653L,709L,773L,829L,839L,859L,863L,929L,1039L,1069L,1259L,1279L,1399L,1423L,1559L,1699L,1753L,1823L,1949L,1979L,2039L,2063L,2089L,2113L,2309L,2333L,2393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279765Inst : IEnumerable<long>
{
public static readonly long[] Value=A279765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279765.Bytes);
public long this[int i]=>Value[i];

public static A279765Inst Instance=new A279765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279766
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,8L,9L,11L,12L,14L,15L,17L,18L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,26L,28L,29L,31L,32L,34L,35L,37L,38L,40L,40L,41L,41L,42L,42L,43L,43L,44L,44L,45L,46L,48L,49L,51L,52L,54L,55L,57L,58L,60L,60L,61L,61L,62L,62L,63L,63L,64L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279766Inst : IEnumerable<long>
{
public static readonly long[] Value=A279766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279766.Bytes);
public long this[int i]=>Value[i];

public static A279766Inst Instance=new A279766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279767
{
public static readonly long[] Value={ 3L,5L,11L,17L,18L,29L,33L,41L,50L,54L,55L,59L,71L,85L,91L,93L,101L,107L,137L,141L,143L,149L,159L,179L,183L,185L,191L,197L,201L,203L,213L,215L,217L,219L,227L,235L,239L,242L,247L,248L,265L,269L,281L,299L,301L,303L,306L,311L,319L,321L,327L,339L,340L,347L,348L,391L,393L,411L,413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279767Inst : IEnumerable<long>
{
public static readonly long[] Value=A279767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279767.Bytes);
public long this[int i]=>Value[i];

public static A279767Inst Instance=new A279767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279768
{
public static readonly long[] Value={ 11L,47L,56L,74L,83L,92L,101L,110L,119L,137L,146L,173L,182L,191L,209L,218L,227L,245L,272L,281L,299L,308L,317L,326L,335L,344L,353L,398L,407L,416L,434L,443L,452L,470L,479L,488L,506L,524L,533L,542L,551L,560L,569L,578L,605L,614L,632L,641L,659L,668L,677L,695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279768Inst : IEnumerable<long>
{
public static readonly long[] Value=A279768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279768.Bytes);
public long this[int i]=>Value[i];

public static A279768Inst Instance=new A279768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279769
{
public static readonly long[] Value={ 11L,21L,22L,31L,32L,33L,41L,42L,43L,44L,51L,52L,53L,54L,55L,61L,62L,63L,64L,65L,66L,71L,72L,73L,74L,75L,76L,77L,81L,82L,83L,84L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,97L,98L,99L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,121L,122L,131L,132L,133L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279769Inst : IEnumerable<long>
{
public static readonly long[] Value=A279769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279769.Bytes);
public long this[int i]=>Value[i];

public static A279769Inst Instance=new A279769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279770
{
public static readonly long[] Value={ 11L,38L,47L,56L,65L,74L,83L,92L,101L,110L,119L,155L,164L,182L,191L,209L,218L,236L,245L,263L,272L,299L,308L,317L,326L,335L,344L,353L,362L,380L,389L,416L,434L,452L,461L,470L,479L,488L,506L,515L,533L,560L,578L,587L,596L,605L,623L,632L,650L,659L,686L,722L,731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279770Inst : IEnumerable<long>
{
public static readonly long[] Value=A279770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279770.Bytes);
public long this[int i]=>Value[i];

public static A279770Inst Instance=new A279770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279771
{
public static readonly long[] Value={ 19L,28L,37L,46L,55L,64L,73L,82L,190L,280L,370L,460L,550L,640L,730L,820L,919L,928L,937L,946L,955L,964L,973L,982L,991L,1819L,1828L,1837L,1846L,1855L,1864L,1873L,1882L,1891L,1900L,2728L,2737L,2746L,2755L,2764L,2773L,2782L,2791L,2800L,3637L,3646L,3655L,3664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279771Inst : IEnumerable<long>
{
public static readonly long[] Value=A279771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279771.Bytes);
public long this[int i]=>Value[i];

public static A279771Inst Instance=new A279771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279772
{
public static readonly long[] Value={ 2L,11L,20L,56L,65L,101L,110L,155L,200L,506L,515L,551L,560L,605L,650L,1001L,1010L,1055L,1100L,1505L,1550L,2000L,5006L,5015L,5051L,5060L,5105L,5150L,5501L,5510L,5555L,5600L,6005L,6050L,6500L,10001L,10010L,10055L,10100L,10505L,10550L,11000L,15005L,15050L,15500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279772Inst : IEnumerable<long>
{
public static readonly long[] Value=A279772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279772.Bytes);
public long this[int i]=>Value[i];

public static A279772Inst Instance=new A279772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279773
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,35L,38L,41L,44L,47L,50L,68L,71L,74L,77L,80L,101L,104L,107L,110L,134L,137L,140L,167L,170L,200L,335L,338L,341L,344L,347L,350L,368L,371L,374L,377L,380L,401L,404L,407L,410L,434L,437L,440L,467L,470L,500L,668L,671L,674L,677L,680L,701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279773Inst : IEnumerable<long>
{
public static readonly long[] Value=A279773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279773.Bytes);
public long this[int i]=>Value[i];

public static A279773Inst Instance=new A279773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279774
{
public static readonly long[] Value={ 2L,11L,20L,29L,38L,56L,65L,83L,101L,110L,128L,155L,200L,254L,263L,281L,290L,308L,326L,335L,353L,380L,425L,506L,515L,533L,551L,560L,578L,605L,650L,758L,776L,785L,803L,830L,875L,1001L,1010L,1028L,1055L,1100L,1253L,1280L,1325L,1505L,1550L,1775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279774Inst : IEnumerable<long>
{
public static readonly long[] Value=A279774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279774.Bytes);
public long this[int i]=>Value[i];

public static A279774Inst Instance=new A279774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279775
{
public static readonly long[] Value={ 11L,29L,38L,47L,56L,65L,74L,83L,92L,101L,110L,128L,146L,164L,182L,209L,218L,227L,236L,245L,254L,263L,272L,281L,290L,308L,326L,344L,362L,380L,407L,416L,425L,434L,443L,452L,461L,470L,488L,506L,524L,542L,560L,605L,614L,623L,632L,641L,650L,668L,686L,704L,722L,740L,803L,812L,821L,830L,848L,866L,884L,902L,920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279775Inst : IEnumerable<long>
{
public static readonly long[] Value=A279775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279775.Bytes);
public long this[int i]=>Value[i];

public static A279775Inst Instance=new A279775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279776
{
public static readonly long[] Value={ 8L,11L,14L,23L,26L,29L,32L,38L,41L,44L,47L,53L,56L,59L,62L,65L,68L,71L,74L,77L,80L,86L,89L,92L,95L,101L,104L,107L,110L,119L,122L,125L,134L,137L,140L,152L,155L,173L,176L,179L,182L,188L,191L,194L,197L,203L,206L,209L,212L,215L,218L,221L,224L,227L,230L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279776Inst : IEnumerable<long>
{
public static readonly long[] Value=A279776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279776.Bytes);
public long this[int i]=>Value[i];

public static A279776Inst Instance=new A279776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279777
{
public static readonly long[] Value={ 111L,211L,221L,222L,311L,321L,322L,331L,332L,333L,411L,421L,422L,431L,432L,433L,441L,442L,443L,444L,511L,521L,522L,531L,532L,533L,541L,542L,543L,544L,551L,552L,553L,554L,555L,611L,621L,622L,631L,632L,633L,641L,642L,643L,644L,651L,652L,653L,654L,655L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279777Inst : IEnumerable<long>
{
public static readonly long[] Value=A279777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279777.Bytes);
public long this[int i]=>Value[i];

public static A279777Inst Instance=new A279777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279778
{
public static readonly long[] Value={ 1L,-2L,1L,0L,-1L,3L,-3L,1L,1L,-5L,9L,-7L,1L,7L,-19L,25L,-15L,-5L,33L,-63L,65L,-25L,-43L,129L,-191L,155L,-7L,-215L,449L,-537L,317L,201L,-879L,1435L,-1391L,433L,1281L,-3193L,4261L,-3215L,-415L,5755L,-10647L,11737L,-6015L,-6585L,22157L,-33031L,29489L,-5445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279778Inst : IEnumerable<long>
{
public static readonly long[] Value=A279778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279778.Bytes);
public long this[int i]=>Value[i];

public static A279778Inst Instance=new A279778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279779
{
public static readonly long[] Value={ 1L,-2L,0L,3L,-3L,0L,4L,-7L,5L,5L,-16L,15L,2L,-26L,39L,-19L,-37L,88L,-73L,-28L,160L,-207L,61L,249L,-484L,339L,258L,-950L,1063L,-99L,-1593L,2628L,-1469L,-1996L,5492L,-5287L,-763L,9837L,-14008L,5671L,14034L,-31042L,25319L,11389L,-59053L,73040L,-16961L,-92844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279779Inst : IEnumerable<long>
{
public static readonly long[] Value=A279779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279779.Bytes);
public long this[int i]=>Value[i];

public static A279779Inst Instance=new A279779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279780
{
public static readonly long[] Value={ 1L,-3L,5L,-9L,17L,-30L,52L,-90L,154L,-262L,446L,-758L,1286L,-2182L,3702L,-6278L,10646L,-18054L,30614L,-51910L,88022L,-149254L,253078L,-429126L,727638L,-1233798L,2092054L,-3547334L,6014934L,-10199046L,17293718L,-29323590L,49721686L,-84309126L,142956310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279780Inst : IEnumerable<long>
{
public static readonly long[] Value=A279780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279780.Bytes);
public long this[int i]=>Value[i];

public static A279780Inst Instance=new A279780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279813
{
public static readonly long[] Value={ 2L,3L,3L,1L,3L,2L,1L,4L,2L,3L,2L,5L,5L,6L,3L,5L,4L,1L,3L,3L,2L,1L,2L,3L,3L,1L,4L,1L,2L,3L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279813Inst : IEnumerable<long>
{
public static readonly long[] Value=A279813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279813.Bytes);
public long this[int i]=>Value[i];

public static A279813Inst Instance=new A279813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279814
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,9L,10L,11L,13L,14L,17L,19L,22L,23L,25L,26L,29L,31L,34L,35L,37L,38L,41L,43L,46L,47L,49L,50L,53L,55L,58L,59L,61L,62L,65L,67L,71L,73L,74L,75L,77L,79L,80L,81L,82L,83L,85L,86L,89L,91L,94L,95L,97L,101L,103L,106L,107L,109L,113L,115L,118L,119L,121L,122L,125L,127L,131L,133L,134L,137L,139L,140L,142L,143L,145L,146L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279814Inst : IEnumerable<long>
{
public static readonly long[] Value=A279814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279814.Bytes);
public long this[int i]=>Value[i];

public static A279814Inst Instance=new A279814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279815
{
public static readonly long[] Value={ 3L,4L,7L,13L,16L,19L,20L,31L,37L,43L,61L,67L,73L,79L,97L,103L,109L,127L,139L,151L,157L,163L,181L,188L,193L,199L,211L,223L,229L,241L,271L,277L,283L,307L,313L,331L,337L,349L,367L,373L,379L,397L,409L,421L,433L,439L,457L,463L,487L,499L,523L,541L,547L,571L,577L,601L,607L,613L,619L,631L,643L,661L,673L,691L,709L,727L,733L,739L,751L,757L,769L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279815Inst : IEnumerable<long>
{
public static readonly long[] Value=A279815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279815.Bytes);
public long this[int i]=>Value[i];

public static A279815Inst Instance=new A279815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279816
{
public static readonly long[] Value={ 0L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,9L,9L,9L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,9L,9L,9L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,9L,9L,9L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279816Inst : IEnumerable<long>
{
public static readonly long[] Value=A279816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279816.Bytes);
public long this[int i]=>Value[i];

public static A279816Inst Instance=new A279816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279817
{
public static readonly long[] Value={ -1L,1L,1L,0L,1L,0L,1L,-1L,0L,1L,1L,-2L,1L,1L,-1L,1L,1L,-3L,1L,-3L,1L,2L,1L,-6L,0L,0L,0L,0L,1L,-2L,1L,-2L,-1L,5L,-1L,-4L,1L,3L,0L,3L,1L,-3L,1L,-7L,-3L,10L,1L,-9L,0L,-10L,2L,-4L,1L,-7L,2L,6L,-1L,4L,1L,-25L,1L,2L,-2L,4L,-1L,-11L,1L,6L,-1L,13L,1L,-20L,1L,-3L,-4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279817Inst : IEnumerable<long>
{
public static readonly long[] Value=A279817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279817.Bytes);
public long this[int i]=>Value[i];

public static A279817Inst Instance=new A279817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279818
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,8L,8L,16L,9L,9L,18L,28L,38L,43L,18L,53L,14L,22L,10L,7L,7L,14L,28L,68L,76L,39L,39L,51L,19L,55L,20L,14L,35L,43L,49L,86L,96L,93L,96L,117L,41L,50L,30L,27L,51L,50L,40L,40L,44L,52L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279818Inst : IEnumerable<long>
{
public static readonly long[] Value=A279818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279818.Bytes);
public long this[int i]=>Value[i];

public static A279818Inst Instance=new A279818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279819
{
public static readonly BigInteger[] Value={ 1L,0L,2L,5L,23L,106L,537L,3143L,20485L,143747L,1078660L,8680687L,74914773L,690204588L,6749661220L,69732043730L,758671016406L,8674112392913L,104037242257509L,1306629414101911L,17148719951169617L,234689253311285406L,3342159005325362828L,BigInteger.Parse("49430840838485256475") };
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
public class A279819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279819Inst Instance=new A279819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279820
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,5L,2L,5L,1L,2L,6L,1L,3L,7L,1L,3L,7L,2L,4L,8L,2L,1L,3L,9L,2L,1L,4L,9L,3L,1L,4L,10L,3L,1L,5L,11L,3L,2L,4L,11L,3L,1L,2L,5L,12L,3L,1L,2L,5L,13L,3L,1L,2L,6L,13L,4L,1L,3L,5L,14L,4L,1L,3L,6L,15L,3L,2L,3L,6L,15L,4L,2L,1L,2L,7L,16L,4L,2L,1L,3L,6L,17L,4L,2L,1L,3L,7L,17L,5L,2L,1L,3L,7L,18L,4L,3L,1L,3L,8L,19L,4L,3L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279820Inst : IEnumerable<long>
{
public static readonly long[] Value=A279820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279820.Bytes);
public long this[int i]=>Value[i];

public static A279820Inst Instance=new A279820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279821
{
public static readonly long[] Value={ 12L,30L,902L,1360L,2450L,3730L,21475L,74945L,82208L,88282L,254677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279821Inst : IEnumerable<long>
{
public static readonly long[] Value=A279821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279821.Bytes);
public long this[int i]=>Value[i];

public static A279821Inst Instance=new A279821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279822
{
public static readonly BigInteger[] Value={ 1L,10L,10L,1100L,111L,111100L,111L,11111100L,111L,1111111100L,111L,111111001100L,1111111L,11111111000000L,1100111L,1111111111111100L,111L,111111111111011100L,1010111L,11111111111010000100UL,1001011011L,BigInteger.Parse("1111111111110110011010"),10111111000L };
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
public class A279822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279822Inst Instance=new A279822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279823
{
public static readonly BigInteger[] Value={ 1L,1L,10L,11L,11100L,1111L,1110000L,111111L,111000000L,11111111L,11100000000L,1100111111L,1111111000000L,11111111L,111001100000000L,11111111111111L,11100000000000000L,1110111111111111L,1110101000000000000L,100001011111111111L,BigInteger.Parse("110110100100000000000") };
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
public class A279823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279823Inst Instance=new A279823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279824
{
public static readonly long[] Value={ 1L,2L,2L,12L,7L,60L,7L,252L,7L,1020L,7L,4044L,127L,16320L,103L,65532L,7L,262108L,87L,1048196L,603L,4193690L,1528L,16775439L,3768L,67107375L,2376L,268424759L,18292L,1073720659L,35854L,4294934362L,82200L,17179750079L,215584L,68719423835L,130586L,274877580152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279824Inst : IEnumerable<long>
{
public static readonly long[] Value=A279824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279824.Bytes);
public long this[int i]=>Value[i];

public static A279824Inst Instance=new A279824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279825
{
public static readonly long[] Value={ 1L,1L,2L,3L,28L,15L,112L,63L,448L,255L,1792L,831L,8128L,255L,29440L,16383L,114688L,61439L,479232L,137215L,1787904L,1470463L,1036288L,15769599L,3858432L,64061439L,9732096L,247906303L,98320384L,850231295L,941129728L,1526661119L,822411264L,17009082367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279825Inst : IEnumerable<long>
{
public static readonly long[] Value=A279825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279825.Bytes);
public long this[int i]=>Value[i];

public static A279825Inst Instance=new A279825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279826
{
public static readonly ulong[] Value={ 1L,11L,110L,1110L,11010L,111010L,1101010L,11100010L,110110110L,1110110110L,11010110110L,111000110110L,1101101110110L,11101101010110L,110101101010110L,1110001101010110L,11011011100010110L,111011010110110110L,1101011010110110110L,11100011010110110110UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279826Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279826.Bytes);
public ulong this[int i]=>Value[i];

public static A279826Inst Instance=new A279826Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279827
{
public static readonly ulong[] Value={ 1L,11L,11L,111L,1011L,10111L,101011L,1000111L,11011011L,110110111L,1101101011L,11011000111L,110111011011L,1101010110111L,11010101101011L,110101011000111L,1101000111011011L,11011011010110111L,110110110101101011L,1101101101011000111L,11011011000111011011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279827Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279827.Bytes);
public ulong this[int i]=>Value[i];

public static A279827Inst Instance=new A279827Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279828
{
public static readonly long[] Value={ 1L,3L,6L,14L,26L,58L,106L,226L,438L,950L,1718L,3638L,7030L,15190L,27478L,58198L,112406L,243126L,439734L,931254L,1798582L,3890102L,7035574L,14899382L,28777910L,62240182L,112571830L,238400950L,460436918L,995866038L,1801106870L,3814208950L,7367062966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A279828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279828Inst : IEnumerable<long>
{
public static readonly long[] Value=A279828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279828.Bytes);
public long this[int i]=>Value[i];

public static A279828Inst Instance=new A279828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280341
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,16L,26L,41L,53L,64L,74L,85L,101L,118L,128L,144L,157L,174L,195L,217L,238L,261L,281L,309L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280341Inst : IEnumerable<long>
{
public static readonly long[] Value=A280341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280341.Bytes);
public long this[int i]=>Value[i];

public static A280341Inst Instance=new A280341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280342
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,6L,6L,6L,12L,9L,9L,18L,18L,18L,18L,18L,18L,18L,18L,36L,36L,36L,36L,45L,45L,36L,36L,27L,27L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,72L,72L,81L,81L,81L,81L,72L,72L,90L,90L,90L,90L,99L,99L,99L,99L,99L,99L,99L,99L,90L,90L,90L,99L,99L,99L,117L,117L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280342Inst : IEnumerable<long>
{
public static readonly long[] Value=A280342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280342.Bytes);
public long this[int i]=>Value[i];

public static A280342Inst Instance=new A280342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280343
{
public static readonly long[] Value={ 1L,25L,81L,233L,401L,585L,1009L,1289L,1681L,2377L,2913L,3353L,4497L,5033L,5793L,7097L,8065L,8761L,10721L,11513L,12961L,14873L,16113L,17065L,19873L,21225L,22689L,25465L,27585L,28793L,32561L,33865L,36113L,39177L,41121L,43481L,48801L,50361L,52529L,56201L,59793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280343Inst : IEnumerable<long>
{
public static readonly long[] Value=A280343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280343.Bytes);
public long this[int i]=>Value[i];

public static A280343Inst Instance=new A280343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280344
{
public static readonly long[] Value={ 0L,12L,30L,56L,90L,132L,182L,240L,306L,380L,462L,552L,650L,756L,870L,992L,1122L,1260L,1406L,1560L,1722L,1892L,2070L,2256L,2450L,2652L,2862L,3080L,3306L,3540L,3782L,4032L,4290L,4556L,4830L,5112L,5402L,5700L,6006L,6320L,6642L,6972L,7310L,7656L,8010L,8372L,8742L,9120L,9506L,9900L,10302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280344Inst : IEnumerable<long>
{
public static readonly long[] Value=A280344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280344.Bytes);
public long this[int i]=>Value[i];

public static A280344Inst Instance=new A280344Inst();

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