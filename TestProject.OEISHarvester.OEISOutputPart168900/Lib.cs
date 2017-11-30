using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199357
{
public static readonly BigInteger[] Value={ 1L,12L,112L,102L,11112L,123L,1111112L,10002L,1012L,11122L,11111111112L,1123L,1111111111112L,10000002L,111122L,10112L,11111111111111112L,1023L,1111111111111111112L,11123L,1111122L,100000000002L,BigInteger.Parse("11111111111111111111112") };
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
public class A199357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199357Inst Instance=new A199357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199358
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,4L,6L,4L,1L,10L,45L,105L,105L,735L,1935L,2270L,1001L,8854L,30961L,50669L,32706L,268440L,834720L,1164240L,614040L,5334840L,17805870L,27047395L,15771356L,135370824L,441296296L,646979039L,359653541L,3137738964L,10425704337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199358Inst : IEnumerable<long>
{
public static readonly long[] Value=A199358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199358.Bytes);
public long this[int i]=>Value[i];

public static A199358Inst Instance=new A199358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199359
{
public static readonly long[] Value={ 0L,0L,0L,5L,35L,11L,455L,2645L,32075L,21689L,904145L,2158685L,43508750L,36780344L,1476986472L,2347455892L,64539882234L,62222755553L,2415617534402L,3140426826416L,101999195453788L,105327949061765L,4032779888481758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199359Inst : IEnumerable<long>
{
public static readonly long[] Value=A199359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199359.Bytes);
public long this[int i]=>Value[i];

public static A199359Inst Instance=new A199359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199360
{
public static readonly long[] Value={ 0L,0L,20L,23L,1655L,39597L,336788L,2130707L,97253704L,2328983293L,27777628803L,109663812046L,7330508486557L,181851333483598L,2032109646360324L,8979878533633165L,588003317861300327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199360Inst : IEnumerable<long>
{
public static readonly long[] Value=A199360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199360.Bytes);
public long this[int i]=>Value[i];

public static A199360Inst Instance=new A199360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199361
{
public static readonly long[] Value={ 0L,5L,23L,2857L,37995L,2838998L,76784986L,4127669738L,153225233815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199361Inst : IEnumerable<long>
{
public static readonly long[] Value=A199361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199361.Bytes);
public long this[int i]=>Value[i];

public static A199361Inst Instance=new A199361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199362
{
public static readonly long[] Value={ 0L,35L,1655L,37995L,21988792L,3215936151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199362Inst : IEnumerable<long>
{
public static readonly long[] Value=A199362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199362.Bytes);
public long this[int i]=>Value[i];

public static A199362Inst Instance=new A199362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199363
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,20L,5L,0L,0L,35L,23L,23L,35L,0L,0L,11L,1655L,2857L,1655L,11L,0L,1L,455L,39597L,37995L,37995L,39597L,455L,1L,4L,2645L,336788L,2838998L,21988792L,2838998L,336788L,2645L,4L,6L,32075L,2130707L,76784986L,3215936151L,3215936151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199363Inst : IEnumerable<long>
{
public static readonly long[] Value=A199363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199363.Bytes);
public long this[int i]=>Value[i];

public static A199363Inst Instance=new A199363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199364
{
public static readonly long[] Value={ 0L,1L,5L,10L,14L,20L,28L,34L,38L,49L,55L,59L,61L,80L,98L,103L,118L,133L,145L,146L,154L,160L,185L,196L,206L,224L,229L,241L,245L,250L,251L,320L,325L,334L,376L,383L,385L,388L,398L,416L,418L,440L,451L,454L,475L,476L,481L,488L,490L,493L,496L,500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199364Inst : IEnumerable<long>
{
public static readonly long[] Value=A199364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199364.Bytes);
public long this[int i]=>Value[i];

public static A199364Inst Instance=new A199364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199365
{
public static readonly long[] Value={ 3L,7L,503L,4003L,10979L,32003L,87811L,157219L,219491L,470599L,665503L,821519L,907927L,2048003L,3764771L,4370911L,6572131L,9410551L,12194503L,12448547L,14609059L,16384003L,25326503L,30118147L,34967267L,44957699L,48035959L,55990087L,58824503L,62500003L,63253007L,131072003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199365Inst : IEnumerable<long>
{
public static readonly long[] Value=A199365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199365.Bytes);
public long this[int i]=>Value[i];

public static A199365Inst Instance=new A199365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199366
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,11L,12L,15L,18L,30L,32L,45L,48L,51L,63L,66L,87L,90L,98L,101L,113L,116L,122L,125L,132L,150L,153L,155L,156L,161L,170L,171L,173L,183L,195L,198L,203L,213L,233L,237L,243L,246L,260L,266L,282L,288L,291L,297L,300L,302L,305L,308L,321L,335L,341L,342L,347L,366L,371L,377L,381L,386L,393L,398L,401L,402L,407L,408L,411L,423L,425L,426L,437L,443L,452L,455L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199366Inst : IEnumerable<long>
{
public static readonly long[] Value=A199366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199366.Bytes);
public long this[int i]=>Value[i];

public static A199366Inst Instance=new A199366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199367
{
public static readonly long[] Value={ 3L,31L,107L,499L,863L,5323L,6911L,13499L,23327L,107999L,131071L,364499L,442367L,530603L,1000187L,1149983L,2634011L,2915999L,3764767L,4121203L,5771587L,6243583L,7263391L,7812499L,9199871L,13499999L,14326307L,14895499L,15185663L,16693123L,19651999L,20000843L,20710867L,24513947L,29659499L,31049567L,33461707L,38654387L,50597347L,53248211L,57395627L,59547743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199367Inst : IEnumerable<long>
{
public static readonly long[] Value=A199367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199367.Bytes);
public long this[int i]=>Value[i];

public static A199367Inst Instance=new A199367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199368
{
public static readonly long[] Value={ 2L,14L,16L,22L,25L,29L,49L,64L,74L,77L,86L,91L,112L,121L,127L,134L,137L,140L,151L,161L,179L,197L,214L,221L,226L,254L,259L,284L,287L,296L,302L,305L,310L,347L,361L,364L,365L,380L,382L,392L,394L,401L,406L,407L,415L,469L,497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199368Inst : IEnumerable<long>
{
public static readonly long[] Value=A199368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199368.Bytes);
public long this[int i]=>Value[i];

public static A199368Inst Instance=new A199368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199369
{
public static readonly long[] Value={ 29L,10973L,16381L,42589L,62497L,97553L,470593L,1048573L,1620893L,1826129L,2544221L,3014281L,5619709L,7086241L,8193529L,9624413L,10285409L,10975997L,13771801L,16693121L,22941353L,30581489L,39201373L,43175441L,46172701L,65548253L,69495913L,91625213L,94559609L,103737341L,110174429L,113490497L,119163997L,167127689L,188183521L,192914173L,194508497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199369Inst : IEnumerable<long>
{
public static readonly long[] Value=A199369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199369.Bytes);
public long this[int i]=>Value[i];

public static A199369Inst Instance=new A199369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199370
{
public static readonly long[] Value={ 7L,2L,2L,5L,8L,7L,5L,4L,9L,9L,2L,2L,5L,2L,4L,7L,6L,8L,3L,5L,5L,9L,3L,2L,8L,7L,2L,8L,7L,7L,1L,9L,6L,7L,5L,5L,1L,5L,9L,6L,4L,5L,9L,2L,1L,1L,4L,3L,9L,4L,2L,6L,9L,8L,0L,7L,7L,6L,5L,1L,4L,7L,6L,0L,2L,5L,9L,0L,9L,4L,2L,5L,0L,7L,3L,1L,6L,0L,1L,8L,3L,0L,3L,4L,3L,5L,6L,2L,9L,4L,1L,8L,7L,2L,7L,9L,8L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199370Inst : IEnumerable<long>
{
public static readonly long[] Value=A199370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199370.Bytes);
public long this[int i]=>Value[i];

public static A199370Inst Instance=new A199370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199371
{
public static readonly long[] Value={ 1L,0L,4L,6L,1L,8L,6L,2L,2L,9L,5L,0L,6L,2L,9L,1L,9L,7L,7L,8L,9L,9L,6L,4L,8L,5L,7L,8L,3L,5L,9L,6L,9L,6L,3L,7L,9L,0L,8L,6L,7L,8L,8L,1L,2L,4L,8L,0L,0L,3L,0L,3L,7L,2L,5L,6L,6L,4L,1L,1L,9L,8L,6L,7L,3L,7L,8L,8L,6L,9L,9L,0L,5L,9L,2L,4L,3L,7L,8L,2L,2L,0L,8L,9L,8L,6L,0L,4L,9L,1L,9L,9L,0L,1L,1L,4L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199371Inst : IEnumerable<long>
{
public static readonly long[] Value=A199371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199371.Bytes);
public long this[int i]=>Value[i];

public static A199371Inst Instance=new A199371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199372
{
public static readonly long[] Value={ 1L,3L,1L,4L,6L,3L,4L,1L,7L,1L,9L,8L,5L,6L,7L,8L,9L,4L,9L,0L,3L,3L,6L,4L,1L,2L,8L,2L,5L,8L,7L,7L,6L,6L,9L,2L,2L,1L,4L,3L,0L,4L,9L,5L,3L,4L,9L,4L,1L,8L,8L,2L,4L,9L,3L,6L,9L,2L,4L,1L,0L,2L,5L,7L,2L,5L,6L,5L,9L,9L,6L,9L,1L,5L,4L,7L,0L,9L,3L,7L,1L,3L,2L,9L,1L,9L,7L,5L,0L,1L,1L,2L,7L,8L,7L,8L,8L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199372Inst : IEnumerable<long>
{
public static readonly long[] Value=A199372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199372.Bytes);
public long this[int i]=>Value[i];

public static A199372Inst Instance=new A199372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199373
{
public static readonly long[] Value={ 5L,8L,8L,5L,9L,1L,4L,1L,0L,8L,1L,7L,1L,5L,4L,5L,0L,6L,4L,3L,1L,7L,7L,3L,6L,2L,3L,7L,1L,2L,7L,8L,6L,7L,0L,5L,4L,4L,1L,7L,7L,2L,9L,6L,6L,5L,6L,1L,2L,7L,9L,9L,0L,6L,4L,8L,0L,6L,0L,5L,9L,6L,1L,9L,5L,6L,4L,5L,9L,4L,8L,1L,3L,4L,2L,1L,9L,5L,0L,8L,3L,2L,0L,1L,2L,6L,3L,1L,4L,5L,2L,9L,6L,9L,4L,7L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199373Inst : IEnumerable<long>
{
public static readonly long[] Value=A199373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199373.Bytes);
public long this[int i]=>Value[i];

public static A199373Inst Instance=new A199373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199374
{
public static readonly long[] Value={ 8L,5L,0L,0L,7L,4L,7L,5L,9L,9L,6L,3L,1L,0L,1L,7L,0L,7L,4L,5L,0L,5L,8L,0L,6L,1L,6L,8L,2L,6L,7L,8L,1L,3L,9L,4L,1L,9L,9L,6L,6L,9L,7L,0L,2L,3L,0L,0L,2L,6L,2L,7L,3L,2L,3L,7L,6L,5L,4L,3L,7L,7L,7L,1L,4L,3L,0L,3L,2L,7L,6L,0L,1L,5L,6L,8L,7L,3L,9L,4L,2L,2L,2L,3L,9L,8L,9L,3L,2L,7L,4L,6L,7L,9L,5L,3L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199374Inst : IEnumerable<long>
{
public static readonly long[] Value=A199374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199374.Bytes);
public long this[int i]=>Value[i];

public static A199374Inst Instance=new A199374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199375
{
public static readonly long[] Value={ 1L,0L,6L,5L,5L,0L,3L,7L,7L,3L,5L,3L,6L,3L,2L,9L,2L,2L,3L,6L,9L,1L,1L,4L,3L,4L,0L,4L,8L,5L,4L,4L,2L,5L,6L,2L,5L,6L,6L,8L,6L,9L,5L,5L,7L,6L,1L,8L,5L,7L,2L,9L,5L,2L,6L,5L,9L,0L,5L,8L,5L,7L,6L,4L,6L,6L,5L,2L,5L,5L,9L,4L,7L,3L,1L,0L,7L,4L,9L,3L,7L,0L,2L,6L,5L,5L,6L,3L,9L,7L,0L,9L,8L,3L,9L,9L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199375Inst : IEnumerable<long>
{
public static readonly long[] Value=A199375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199375.Bytes);
public long this[int i]=>Value[i];

public static A199375Inst Instance=new A199375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199376
{
public static readonly long[] Value={ 5L,0L,8L,1L,6L,1L,6L,5L,6L,9L,6L,8L,3L,9L,1L,9L,1L,8L,1L,2L,7L,7L,6L,7L,6L,2L,9L,3L,4L,0L,9L,9L,2L,4L,4L,6L,1L,3L,6L,4L,6L,2L,2L,3L,5L,6L,6L,3L,4L,8L,5L,0L,7L,9L,3L,7L,3L,5L,3L,6L,0L,4L,4L,1L,9L,7L,0L,5L,4L,8L,3L,2L,4L,5L,5L,9L,7L,4L,7L,6L,4L,0L,3L,1L,3L,4L,8L,5L,0L,1L,5L,8L,1L,2L,5L,5L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199376Inst : IEnumerable<long>
{
public static readonly long[] Value=A199376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199376.Bytes);
public long this[int i]=>Value[i];

public static A199376Inst Instance=new A199376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199377
{
public static readonly long[] Value={ 7L,3L,1L,3L,0L,6L,0L,7L,2L,6L,9L,9L,4L,8L,0L,6L,1L,6L,8L,6L,0L,5L,5L,7L,1L,0L,6L,4L,2L,2L,8L,8L,1L,9L,4L,9L,9L,4L,3L,4L,4L,4L,5L,0L,8L,8L,9L,0L,1L,4L,8L,9L,2L,6L,0L,2L,0L,0L,4L,4L,3L,1L,9L,6L,9L,7L,5L,9L,7L,8L,8L,3L,8L,1L,3L,5L,6L,3L,5L,4L,1L,3L,4L,6L,0L,2L,2L,8L,2L,9L,3L,8L,5L,0L,1L,6L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199377Inst : IEnumerable<long>
{
public static readonly long[] Value=A199377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199377.Bytes);
public long this[int i]=>Value[i];

public static A199377Inst Instance=new A199377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199378
{
public static readonly long[] Value={ 9L,1L,2L,8L,2L,0L,7L,1L,7L,4L,4L,6L,3L,9L,5L,3L,5L,1L,1L,5L,3L,5L,0L,7L,0L,7L,9L,7L,7L,8L,2L,2L,8L,0L,5L,2L,8L,8L,3L,9L,3L,5L,5L,9L,6L,6L,5L,9L,6L,1L,3L,6L,7L,9L,3L,7L,1L,5L,5L,7L,9L,9L,2L,1L,9L,4L,8L,9L,3L,1L,3L,7L,9L,3L,5L,6L,0L,7L,1L,4L,5L,1L,6L,7L,8L,4L,2L,9L,4L,0L,6L,2L,2L,6L,8L,3L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199378Inst : IEnumerable<long>
{
public static readonly long[] Value=A199378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199378.Bytes);
public long this[int i]=>Value[i];

public static A199378Inst Instance=new A199378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199379
{
public static readonly long[] Value={ 5L,8L,2L,7L,8L,1L,0L,7L,2L,5L,1L,9L,8L,0L,9L,7L,6L,1L,0L,6L,7L,1L,4L,0L,6L,0L,6L,2L,2L,3L,0L,5L,7L,2L,5L,4L,5L,3L,9L,9L,5L,2L,7L,7L,4L,4L,8L,6L,2L,8L,8L,8L,0L,0L,5L,1L,3L,3L,2L,8L,7L,1L,9L,4L,1L,4L,4L,6L,5L,4L,3L,9L,2L,8L,8L,0L,3L,9L,7L,3L,8L,7L,4L,7L,5L,6L,2L,2L,5L,0L,7L,1L,4L,6L,4L,3L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199379Inst : IEnumerable<long>
{
public static readonly long[] Value=A199379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199379.Bytes);
public long this[int i]=>Value[i];

public static A199379Inst Instance=new A199379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199380
{
public static readonly long[] Value={ 8L,3L,2L,1L,0L,1L,8L,4L,8L,7L,9L,2L,1L,4L,9L,1L,5L,3L,6L,4L,7L,9L,4L,0L,4L,7L,8L,9L,1L,7L,9L,8L,7L,1L,6L,5L,2L,1L,5L,6L,1L,9L,1L,3L,8L,1L,9L,9L,0L,3L,3L,1L,5L,2L,9L,0L,9L,5L,2L,5L,9L,1L,2L,4L,9L,4L,2L,7L,0L,0L,7L,6L,9L,6L,8L,7L,1L,5L,1L,3L,4L,9L,5L,0L,5L,4L,6L,6L,2L,5L,8L,1L,3L,1L,9L,4L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199380Inst : IEnumerable<long>
{
public static readonly long[] Value=A199380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199380.Bytes);
public long this[int i]=>Value[i];

public static A199380Inst Instance=new A199380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199381
{
public static readonly long[] Value={ 1L,0L,2L,9L,1L,2L,4L,9L,2L,1L,9L,6L,6L,9L,0L,6L,9L,8L,6L,1L,7L,1L,3L,5L,9L,2L,3L,7L,7L,8L,9L,1L,1L,6L,4L,0L,8L,4L,8L,1L,1L,7L,1L,1L,8L,4L,1L,1L,8L,6L,4L,2L,6L,8L,0L,4L,2L,9L,8L,1L,5L,5L,2L,1L,4L,5L,3L,3L,8L,7L,2L,1L,8L,6L,1L,3L,6L,2L,0L,6L,4L,7L,3L,3L,0L,4L,8L,4L,2L,2L,9L,1L,5L,4L,8L,2L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199381Inst : IEnumerable<long>
{
public static readonly long[] Value=A199381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199381.Bytes);
public long this[int i]=>Value[i];

public static A199381Inst Instance=new A199381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199382
{
public static readonly long[] Value={ 5L,0L,5L,3L,3L,6L,8L,3L,9L,3L,7L,9L,1L,7L,2L,1L,1L,8L,3L,1L,9L,6L,2L,7L,1L,0L,4L,7L,5L,9L,3L,7L,9L,6L,8L,7L,2L,8L,0L,4L,2L,3L,4L,0L,6L,0L,2L,0L,5L,9L,7L,6L,5L,5L,8L,4L,6L,7L,0L,4L,0L,0L,5L,3L,8L,1L,2L,5L,4L,7L,0L,3L,2L,7L,6L,7L,1L,7L,8L,6L,7L,3L,0L,2L,4L,6L,5L,9L,5L,2L,3L,9L,4L,4L,6L,4L,8L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199382Inst : IEnumerable<long>
{
public static readonly long[] Value=A199382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199382.Bytes);
public long this[int i]=>Value[i];

public static A199382Inst Instance=new A199382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199383
{
public static readonly long[] Value={ 8L,9L,5L,2L,1L,9L,7L,4L,4L,4L,3L,5L,8L,2L,0L,0L,1L,2L,9L,7L,0L,8L,7L,2L,7L,4L,6L,3L,6L,1L,9L,6L,5L,9L,6L,7L,4L,8L,9L,0L,5L,6L,5L,3L,0L,4L,3L,5L,7L,4L,1L,0L,0L,1L,8L,6L,6L,7L,9L,3L,6L,9L,1L,0L,6L,5L,5L,4L,5L,5L,2L,3L,7L,6L,2L,5L,2L,8L,2L,2L,5L,9L,2L,7L,6L,5L,9L,5L,5L,5L,9L,1L,4L,5L,1L,6L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199383Inst : IEnumerable<long>
{
public static readonly long[] Value=A199383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199383.Bytes);
public long this[int i]=>Value[i];

public static A199383Inst Instance=new A199383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199384
{
public static readonly long[] Value={ 4L,5L,1L,8L,0L,1L,2L,3L,4L,3L,3L,3L,7L,3L,7L,4L,0L,6L,1L,3L,1L,3L,3L,7L,2L,4L,2L,9L,8L,3L,0L,8L,1L,3L,6L,6L,9L,8L,9L,3L,2L,6L,6L,9L,2L,4L,2L,7L,1L,7L,1L,5L,3L,1L,1L,3L,6L,6L,5L,4L,2L,3L,3L,9L,6L,9L,5L,4L,6L,0L,8L,2L,7L,9L,8L,0L,4L,3L,6L,4L,6L,3L,1L,9L,3L,2L,6L,5L,7L,0L,6L,5L,5L,1L,7L,3L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199384Inst : IEnumerable<long>
{
public static readonly long[] Value=A199384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199384.Bytes);
public long this[int i]=>Value[i];

public static A199384Inst Instance=new A199384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199385
{
public static readonly long[] Value={ 6L,4L,5L,7L,8L,0L,5L,7L,5L,3L,1L,6L,3L,3L,7L,5L,4L,1L,7L,5L,6L,0L,6L,6L,8L,8L,8L,2L,6L,2L,7L,3L,6L,3L,2L,4L,5L,9L,5L,5L,7L,5L,1L,7L,5L,0L,0L,8L,6L,3L,8L,1L,5L,8L,4L,9L,0L,3L,0L,0L,1L,1L,7L,0L,8L,5L,0L,7L,0L,8L,3L,3L,8L,9L,5L,0L,9L,6L,7L,1L,2L,3L,4L,0L,1L,1L,4L,6L,0L,4L,0L,3L,0L,2L,4L,5L,8L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199385Inst : IEnumerable<long>
{
public static readonly long[] Value=A199385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199385.Bytes);
public long this[int i]=>Value[i];

public static A199385Inst Instance=new A199385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199386
{
public static readonly long[] Value={ 7L,9L,9L,7L,6L,4L,4L,1L,3L,6L,2L,7L,4L,4L,7L,3L,8L,5L,1L,1L,7L,6L,8L,7L,7L,1L,4L,9L,9L,8L,7L,4L,4L,7L,2L,1L,3L,0L,0L,1L,3L,2L,8L,8L,2L,8L,7L,3L,6L,7L,3L,5L,9L,6L,3L,8L,0L,2L,4L,5L,1L,9L,5L,3L,5L,3L,9L,0L,5L,9L,8L,6L,2L,2L,6L,4L,6L,1L,3L,3L,4L,5L,2L,3L,0L,0L,1L,4L,8L,8L,9L,4L,4L,3L,6L,8L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199386Inst : IEnumerable<long>
{
public static readonly long[] Value=A199386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199386.Bytes);
public long this[int i]=>Value[i];

public static A199386Inst Instance=new A199386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199387
{
public static readonly long[] Value={ 5L,0L,2L,6L,1L,8L,9L,1L,1L,5L,3L,2L,6L,5L,2L,2L,1L,2L,7L,7L,8L,6L,8L,6L,3L,1L,1L,9L,2L,1L,3L,7L,4L,4L,6L,1L,3L,0L,5L,5L,0L,5L,5L,8L,8L,6L,4L,4L,9L,4L,2L,7L,4L,3L,4L,1L,1L,0L,2L,1L,8L,2L,9L,2L,9L,4L,8L,6L,1L,1L,7L,0L,0L,3L,5L,3L,1L,0L,1L,2L,7L,1L,2L,5L,7L,8L,9L,6L,0L,5L,6L,6L,4L,9L,7L,3L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199387Inst : IEnumerable<long>
{
public static readonly long[] Value=A199387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199387.Bytes);
public long this[int i]=>Value[i];

public static A199387Inst Instance=new A199387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199388
{
public static readonly long[] Value={ 7L,1L,4L,5L,5L,4L,7L,9L,9L,6L,0L,8L,4L,7L,7L,0L,3L,9L,1L,2L,2L,3L,9L,8L,5L,6L,4L,7L,7L,0L,8L,2L,5L,9L,8L,4L,8L,5L,7L,5L,9L,8L,7L,4L,4L,8L,9L,5L,1L,3L,0L,5L,0L,9L,4L,8L,9L,7L,4L,0L,9L,6L,9L,5L,1L,4L,8L,1L,0L,8L,3L,3L,4L,8L,3L,1L,3L,5L,9L,7L,9L,9L,8L,9L,5L,1L,3L,1L,2L,7L,8L,0L,0L,9L,6L,2L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199388Inst : IEnumerable<long>
{
public static readonly long[] Value=A199388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199388.Bytes);
public long this[int i]=>Value[i];

public static A199388Inst Instance=new A199388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199389
{
public static readonly long[] Value={ 8L,7L,9L,7L,8L,0L,6L,2L,6L,6L,2L,1L,0L,3L,3L,4L,8L,6L,7L,1L,5L,9L,0L,0L,2L,7L,0L,5L,5L,5L,0L,2L,6L,6L,9L,9L,6L,2L,3L,7L,9L,2L,8L,8L,5L,5L,9L,9L,9L,1L,1L,9L,2L,4L,8L,0L,8L,0L,5L,6L,6L,2L,1L,7L,2L,3L,9L,3L,9L,6L,7L,2L,7L,6L,5L,3L,0L,3L,1L,7L,7L,6L,4L,8L,1L,1L,9L,1L,5L,2L,1L,3L,8L,9L,2L,1L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199389Inst : IEnumerable<long>
{
public static readonly long[] Value=A199389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199389.Bytes);
public long this[int i]=>Value[i];

public static A199389Inst Instance=new A199389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199390
{
public static readonly long[] Value={ 4L,5L,0L,2L,3L,5L,3L,1L,6L,4L,0L,0L,3L,2L,0L,4L,4L,6L,9L,8L,0L,7L,5L,5L,7L,4L,5L,3L,7L,6L,0L,7L,5L,4L,9L,5L,0L,4L,8L,6L,0L,6L,9L,0L,2L,8L,4L,7L,2L,6L,6L,4L,8L,6L,1L,4L,5L,6L,6L,2L,4L,1L,2L,5L,1L,3L,8L,1L,4L,5L,4L,2L,4L,3L,0L,1L,2L,2L,0L,7L,1L,4L,4L,5L,5L,7L,5L,2L,8L,3L,1L,8L,7L,5L,1L,0L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199390Inst : IEnumerable<long>
{
public static readonly long[] Value=A199390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199390.Bytes);
public long this[int i]=>Value[i];

public static A199390Inst Instance=new A199390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199391
{
public static readonly long[] Value={ 6L,4L,1L,1L,1L,9L,3L,6L,3L,7L,7L,9L,7L,5L,0L,6L,6L,4L,3L,8L,3L,1L,3L,2L,0L,4L,6L,0L,5L,7L,2L,6L,0L,2L,2L,8L,8L,3L,8L,4L,5L,3L,4L,0L,9L,1L,0L,2L,7L,9L,8L,9L,6L,9L,2L,1L,4L,9L,7L,2L,2L,8L,3L,0L,1L,0L,5L,9L,6L,2L,4L,7L,5L,3L,4L,4L,2L,4L,2L,2L,8L,0L,4L,3L,2L,1L,4L,8L,2L,2L,9L,0L,0L,4L,0L,0L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199391Inst : IEnumerable<long>
{
public static readonly long[] Value=A199391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199391.Bytes);
public long this[int i]=>Value[i];

public static A199391Inst Instance=new A199391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199392
{
public static readonly long[] Value={ 7L,9L,0L,7L,3L,4L,2L,1L,0L,9L,6L,7L,2L,3L,6L,9L,7L,8L,3L,5L,7L,1L,7L,1L,8L,5L,1L,4L,6L,1L,2L,8L,7L,9L,3L,6L,3L,0L,0L,4L,6L,6L,3L,7L,0L,0L,7L,4L,8L,1L,3L,2L,5L,9L,5L,0L,2L,2L,1L,8L,1L,4L,6L,0L,8L,0L,7L,7L,1L,0L,5L,2L,8L,4L,8L,5L,2L,2L,5L,1L,2L,9L,7L,5L,1L,2L,2L,2L,4L,0L,5L,8L,3L,4L,7L,2L,0L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199392Inst : IEnumerable<long>
{
public static readonly long[] Value=A199392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199392.Bytes);
public long this[int i]=>Value[i];

public static A199392Inst Instance=new A199392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199393
{
public static readonly long[] Value={ 4L,1L,1L,1L,2L,9L,5L,2L,1L,5L,0L,2L,6L,0L,0L,4L,6L,8L,5L,7L,4L,2L,7L,8L,6L,4L,7L,1L,6L,9L,1L,8L,4L,1L,2L,8L,9L,3L,0L,9L,8L,1L,1L,2L,5L,5L,0L,7L,1L,2L,2L,7L,4L,1L,7L,5L,8L,5L,2L,4L,4L,6L,1L,2L,1L,6L,6L,6L,4L,7L,8L,7L,4L,1L,2L,2L,8L,7L,3L,0L,2L,7L,3L,8L,5L,2L,1L,0L,2L,4L,3L,7L,7L,3L,6L,1L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199393Inst : IEnumerable<long>
{
public static readonly long[] Value=A199393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199393.Bytes);
public long this[int i]=>Value[i];

public static A199393Inst Instance=new A199393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199394
{
public static readonly long[] Value={ 11L,90L,357L,996L,2255L,4446L,7945L,13192L,20691L,31010L,44781L,62700L,85527L,114086L,149265L,192016L,243355L,304362L,376181L,460020L,557151L,668910L,796697L,941976L,1106275L,1291186L,1498365L,1729532L,1986471L,2271030L,2585121L,2930720L,3309867L,3724666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199394Inst : IEnumerable<long>
{
public static readonly long[] Value=A199394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199394.Bytes);
public long this[int i]=>Value[i];

public static A199394Inst Instance=new A199394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199395
{
public static readonly long[] Value={ 5L,8L,5L,6L,3L,5L,4L,7L,6L,4L,9L,1L,1L,1L,7L,7L,7L,8L,2L,0L,0L,5L,9L,9L,5L,4L,4L,5L,5L,9L,5L,9L,2L,3L,2L,4L,9L,0L,9L,9L,8L,7L,7L,8L,4L,7L,4L,5L,6L,3L,3L,2L,8L,8L,2L,7L,8L,4L,2L,1L,7L,7L,4L,8L,8L,1L,2L,4L,5L,4L,0L,1L,1L,4L,7L,5L,5L,0L,2L,1L,7L,2L,6L,1L,5L,7L,1L,7L,0L,6L,6L,5L,0L,2L,1L,1L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199395Inst : IEnumerable<long>
{
public static readonly long[] Value=A199395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199395.Bytes);
public long this[int i]=>Value[i];

public static A199395Inst Instance=new A199395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199396
{
public static readonly long[] Value={ 1L,5L,8L,32L,89L,309L,1392L,2464L,12241L,23685L,66936L,329856L,598377L,2972885L,4204000L,17321536L,47254689L,156943365L,737779176L,1276350496L,6369950073L,12290868597L,35051319632L,175157734688L,319624706161L,1569854375813L,2311734655064L,9333158201280L,25600877525257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199396Inst : IEnumerable<long>
{
public static readonly long[] Value=A199396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199396.Bytes);
public long this[int i]=>Value[i];

public static A199396Inst Instance=new A199396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199397
{
public static readonly long[] Value={ 1L,2L,11L,16L,65L,178L,619L,2784L,4929L,24482L,47371L,133872L,659713L,1196754L,5945771L,8408000L,34643073L,94509378L,313886731L,1475558352L,2552700993L,12739900146L,24581737195L,70102639264L,350315469377L,639249412322L,3139708751627L,4623469310128L,18666316402561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199397Inst : IEnumerable<long>
{
public static readonly long[] Value=A199397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199397.Bytes);
public long this[int i]=>Value[i];

public static A199397Inst Instance=new A199397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199398
{
public static readonly long[] Value={ 1L,2L,7L,0L,9L,2L,15L,0L,17L,2L,23L,0L,25L,2L,31L,0L,33L,2L,39L,0L,41L,2L,47L,0L,49L,2L,55L,0L,57L,2L,63L,0L,65L,2L,71L,0L,73L,2L,79L,0L,81L,2L,87L,0L,89L,2L,95L,0L,97L,2L,103L,0L,105L,2L,111L,0L,113L,2L,119L,0L,121L,2L,127L,0L,129L,2L,135L,0L,137L,2L,143L,0L,145L,2L,151L,0L,153L,2L,159L,0L,161L,2L,167L,0L,169L,2L,175L,0L,177L,2L,183L,0L,185L,2L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199398Inst : IEnumerable<long>
{
public static readonly long[] Value=A199398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199398.Bytes);
public long this[int i]=>Value[i];

public static A199398Inst Instance=new A199398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199399
{
public static readonly long[] Value={ 1L,4L,29L,96L,529L,3620L,13101L,66048L,325601L,1653380L,9189501L,40187552L,216562929L,1143607140L,5098589837L,26660767488L,161932208321L,635945960964L,4313170161629L,20567937335008L,74804061006033L,551572049610276L,2689136522898669L,10088864973699328L,67578042506892449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199399Inst : IEnumerable<long>
{
public static readonly long[] Value=A199399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199399.Bytes);
public long this[int i]=>Value[i];

public static A199399Inst Instance=new A199399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199400
{
public static readonly long[] Value={ 1L,2L,2L,4L,10L,6L,8L,38L,54L,24L,16L,130L,330L,336L,120L,32L,422L,1710L,3000L,2400L,720L,64L,1330L,8106L,21840L,29400L,19440L,5040L,128L,4118L,36414L,141624L,285600L,312480L,176400L,40320L,256L,12610L,158010L,853776L,2421720L,3900960L,3598560L,1774080L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199400Inst : IEnumerable<long>
{
public static readonly long[] Value=A199400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199400.Bytes);
public long this[int i]=>Value[i];

public static A199400Inst Instance=new A199400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199401
{
public static readonly long[] Value={ 1L,3L,7L,2L,8L,1L,3L,4L,6L,2L,8L,1L,8L,2L,4L,6L,0L,0L,9L,1L,1L,2L,1L,9L,2L,6L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199401Inst : IEnumerable<long>
{
public static readonly long[] Value=A199401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199401.Bytes);
public long this[int i]=>Value[i];

public static A199401Inst Instance=new A199401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199402
{
public static readonly long[] Value={ 3L,0L,9L,6L,39L,24L,153L,102L,615L,408L,2457L,1638L,9831L,6552L,39321L,26214L,157287L,104856L,629145L,419430L,2516583L,1677720L,10066329L,6710886L,40265319L,26843544L,161061273L,107374182L,644245095L,429496728L,2576980377L,1717986918L,10307921511L,6871947672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199402Inst : IEnumerable<long>
{
public static readonly long[] Value=A199402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199402.Bytes);
public long this[int i]=>Value[i];

public static A199402Inst Instance=new A199402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199403
{
public static readonly long[] Value={ 1L,0L,3L,6L,13L,24L,51L,102L,205L,408L,819L,1638L,3277L,6552L,13107L,26214L,52429L,104856L,209715L,419430L,838861L,1677720L,3355443L,6710886L,13421773L,26843544L,53687091L,107374182L,214748365L,429496728L,858993459L,1717986918L,3435973837L,6871947672L,13743895347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199403Inst : IEnumerable<long>
{
public static readonly long[] Value=A199403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199403.Bytes);
public long this[int i]=>Value[i];

public static A199403Inst Instance=new A199403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199404
{
public static readonly long[] Value={ 1L,4L,7L,43L,76L,469L,829L,5116L,9043L,55807L,98644L,608761L,1076041L,6640564L,11737807L,72437443L,128039836L,790171309L,1396700389L,8619446956L,15235664443L,94023745207L,166195608484L,1025641750321L,1812916028881L,11188035508324L,19775880709207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199404Inst : IEnumerable<long>
{
public static readonly long[] Value=A199404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199404.Bytes);
public long this[int i]=>Value[i];

public static A199404Inst Instance=new A199404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199405
{
public static readonly long[] Value={ 1L,14L,25L,155L,274L,1691L,2989L,18446L,32605L,201215L,355666L,2194919L,3879721L,23942894L,42321265L,261176915L,461654194L,2849003171L,5035874869L,31077857966L,54932969365L,339007434455L,599226788146L,3698003921039L,6536561700241L,40339035696974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199405Inst : IEnumerable<long>
{
public static readonly long[] Value=A199405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199405.Bytes);
public long this[int i]=>Value[i];

public static A199405Inst Instance=new A199405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199406
{
public static readonly long[] Value={ 1L,144L,12111L,358120L,5131650L,45528756L,288936634L,1433251296L,5887880415L,20842168600L,65402344161L,185788177224L,485443851256L,1181242399260L,2703252560100L,5864398969216L,12138503871789L,24101498435616L,46112016365155L,85335258695400L,153249227870046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199406Inst : IEnumerable<long>
{
public static readonly long[] Value=A199406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199406.Bytes);
public long this[int i]=>Value[i];

public static A199406Inst Instance=new A199406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199407
{
public static readonly long[] Value={ 3L,5L,9L,11L,15L,21L,23L,29L,33L,35L,39L,45L,51L,114L,183L,243L,4895L,5247L,9588L,12188L,48503L,48504L,89175L,179328L,290783L,4604093L,4775623L,7778968L,13711516L,56075700L,104257956L,165309438L,1913253201L,9905967078L,17096261103L,121153257533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199407Inst : IEnumerable<long>
{
public static readonly long[] Value=A199407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199407.Bytes);
public long this[int i]=>Value[i];

public static A199407Inst Instance=new A199407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199408
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,4L,4L,6L,4L,5L,6L,7L,8L,5L,6L,6L,6L,8L,10L,6L,7L,8L,9L,10L,11L,12L,7L,8L,8L,10L,8L,12L,12L,14L,8L,9L,10L,9L,12L,13L,12L,15L,16L,9L,10L,10L,12L,12L,10L,14L,16L,16L,18L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,11L,12L,12L,12L,12L,16L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199408Inst : IEnumerable<long>
{
public static readonly long[] Value=A199408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199408.Bytes);
public long this[int i]=>Value[i];

public static A199408Inst Instance=new A199408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199409
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,37L,82L,184L,417L,954L,2200L,5109L,11937L,28040L,66179L,156857L,373205L,891034L,2134072L,5125944L,12344835L,29802478L,72109852L,174839832L,424742526L,1033697149L,2519947080L,6152807700L,15045156972L,36840289213L,90326900587L,221741403579L,544982530105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199409Inst : IEnumerable<long>
{
public static readonly long[] Value=A199409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199409.Bytes);
public long this[int i]=>Value[i];

public static A199409Inst Instance=new A199409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199410
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,50L,122L,303L,763L,1943L,4996L,12953L,33824L,88877L,234824L,623474L,1662618L,4451171L,11959159L,32235236L,87145035L,236226761L,641942519L,1748479813L,4772529625L,13052515077L,35763350619L,98158386548L,269844628977L,742940020480L,2048366903124L,5655092015428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199410Inst : IEnumerable<long>
{
public static readonly long[] Value=A199410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199410.Bytes);
public long this[int i]=>Value[i];

public static A199410Inst Instance=new A199410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199411
{
public static readonly long[] Value={ 9L,49L,289L,1729L,10369L,62209L,373249L,2239489L,13436929L,80621569L,483729409L,2902376449L,17414258689L,104485552129L,626913312769L,3761479876609L,22568879259649L,135413275557889L,812479653347329L,4874877920083969L,29249267520503809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199411Inst : IEnumerable<long>
{
public static readonly long[] Value=A199411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199411.Bytes);
public long this[int i]=>Value[i];

public static A199411Inst Instance=new A199411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199412
{
public static readonly long[] Value={ 2L,11L,65L,389L,2333L,13997L,83981L,503885L,3023309L,18139853L,108839117L,653034701L,3918208205L,23509249229L,141055495373L,846332972237L,5077997833421L,30467987000525L,182807922003149L,1096847532018893L,6581085192113357L,39486511152680141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199412Inst : IEnumerable<long>
{
public static readonly long[] Value=A199412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199412.Bytes);
public long this[int i]=>Value[i];

public static A199412Inst Instance=new A199412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199413
{
public static readonly long[] Value={ 10L,55L,325L,1945L,11665L,69985L,419905L,2519425L,15116545L,90699265L,544195585L,3265173505L,19591041025L,117546246145L,705277476865L,4231664861185L,25389989167105L,152339935002625L,914039610015745L,5484237660094465L,32905425960566785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199413Inst : IEnumerable<long>
{
public static readonly long[] Value=A199413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199413.Bytes);
public long this[int i]=>Value[i];

public static A199413Inst Instance=new A199413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199414
{
public static readonly long[] Value={ 11L,61L,361L,2161L,12961L,77761L,466561L,2799361L,16796161L,100776961L,604661761L,3627970561L,21767823361L,130606940161L,783641640961L,4701849845761L,28211099074561L,169266594447361L,1015599566684161L,6093597400104961L,36561584400629761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199414Inst : IEnumerable<long>
{
public static readonly long[] Value=A199414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199414.Bytes);
public long this[int i]=>Value[i];

public static A199414Inst Instance=new A199414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199415
{
public static readonly long[] Value={ 12L,67L,397L,2377L,14257L,85537L,513217L,3079297L,18475777L,110854657L,665127937L,3990767617L,23944605697L,143667634177L,862005805057L,5172034830337L,31032208982017L,186193253892097L,1117159523352577L,6702957140115457L,40217742840692737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199415Inst : IEnumerable<long>
{
public static readonly long[] Value=A199415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199415.Bytes);
public long this[int i]=>Value[i];

public static A199415Inst Instance=new A199415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199416
{
public static readonly long[] Value={ 3L,15L,99L,687L,4803L,33615L,235299L,1647087L,11529603L,80707215L,564950499L,3954653487L,27682574403L,193778020815L,1356446145699L,9495123019887L,66465861139203L,465261027974415L,3256827195820899L,22797790370746287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199416Inst : IEnumerable<long>
{
public static readonly long[] Value=A199416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199416.Bytes);
public long this[int i]=>Value[i];

public static A199416Inst Instance=new A199416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199417
{
public static readonly long[] Value={ 2L,11L,74L,515L,3602L,25211L,176474L,1235315L,8647202L,60530411L,423712874L,2965990115L,20761930802L,145333515611L,1017334609274L,7121342264915L,49849395854402L,348945770980811L,2442620396865674L,17098342778059715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199417Inst : IEnumerable<long>
{
public static readonly long[] Value=A199417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199417.Bytes);
public long this[int i]=>Value[i];

public static A199417Inst Instance=new A199417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199418
{
public static readonly long[] Value={ 4L,22L,148L,1030L,7204L,50422L,352948L,2470630L,17294404L,121060822L,847425748L,5931980230L,41523861604L,290667031222L,2034669218548L,14242684529830L,99698791708804L,697891541961622L,4885240793731348L,34196685556119430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199418Inst : IEnumerable<long>
{
public static readonly long[] Value=A199418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199418.Bytes);
public long this[int i]=>Value[i];

public static A199418Inst Instance=new A199418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199419
{
public static readonly long[] Value={ 5L,29L,197L,1373L,9605L,67229L,470597L,3294173L,23059205L,161414429L,1129900997L,7909306973L,55365148805L,387556041629L,2712892291397L,18990246039773L,132931722278405L,930522055948829L,6513654391641797L,45595580741492573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199419Inst : IEnumerable<long>
{
public static readonly long[] Value=A199419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199419.Bytes);
public long this[int i]=>Value[i];

public static A199419Inst Instance=new A199419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199420
{
public static readonly long[] Value={ 2L,12L,82L,572L,4002L,28012L,196082L,1372572L,9608002L,67256012L,470792082L,3295544572L,23068812002L,161481684012L,1130371788082L,7912602516572L,55388217616002L,387717523312012L,2714022663184082L,18998158642288572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199420Inst : IEnumerable<long>
{
public static readonly long[] Value=A199420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199420.Bytes);
public long this[int i]=>Value[i];

public static A199420Inst Instance=new A199420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199421
{
public static readonly long[] Value={ 3L,18L,123L,858L,6003L,42018L,294123L,2058858L,14412003L,100884018L,706188123L,4943316858L,34603218003L,242222526018L,1695557682123L,11868903774858L,83082326424003L,581576284968018L,4071033994776123L,28497237963432858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199421Inst : IEnumerable<long>
{
public static readonly long[] Value=A199421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199421.Bytes);
public long this[int i]=>Value[i];

public static A199421Inst Instance=new A199421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199422
{
public static readonly long[] Value={ 6L,36L,246L,1716L,12006L,84036L,588246L,4117716L,28824006L,201768036L,1412376246L,9886633716L,69206436006L,484445052036L,3391115364246L,23737807549716L,166164652848006L,1163152569936036L,8142067989552246L,56994475926865716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199422Inst : IEnumerable<long>
{
public static readonly long[] Value=A199422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199422.Bytes);
public long this[int i]=>Value[i];

public static A199422Inst Instance=new A199422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199423
{
public static readonly long[] Value={ 3L,5L,7L,3L,11L,13L,7L,17L,19L,7L,23L,5L,13L,29L,31L,11L,17L,37L,19L,41L,43L,11L,47L,7L,17L,53L,11L,19L,59L,61L,31L,13L,67L,23L,71L,73L,37L,19L,79L,5L,83L,17L,43L,89L,13L,31L,47L,97L,11L,101L,103L,13L,107L,109L,37L,113L,23L,29L,59L,11L,61L,31L,127L,43L,131L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199423Inst : IEnumerable<long>
{
public static readonly long[] Value=A199423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199423.Bytes);
public long this[int i]=>Value[i];

public static A199423Inst Instance=new A199423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199424
{
public static readonly long[] Value={ 2L,3L,4L,4L,6L,5L,8L,9L,6L,6L,12L,7L,14L,15L,16L,7L,18L,19L,20L,9L,22L,23L,24L,25L,8L,27L,28L,8L,30L,31L,11L,33L,34L,35L,36L,9L,12L,39L,40L,41L,42L,43L,13L,45L,46L,47L,9L,10L,50L,14L,52L,53L,54L,55L,56L,57L,58L,15L,60L,61L,62L,63L,64L,65L,66L,16L,11L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199424Inst : IEnumerable<long>
{
public static readonly long[] Value=A199424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199424.Bytes);
public long this[int i]=>Value[i];

public static A199424Inst Instance=new A199424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199425
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,5L,8L,10L,13L,17L,20L,24L,30L,35L,42L,49L,57L,63L,71L,80L,90L,99L,110L,121L,133L,145L,157L,170L,184L,197L,212L,227L,242L,258L,275L,292L,310L,327L,345L,364L,384L,404L,425L,446L,467L,489L,512L,535L,558L,581L,606L,630L,656L,682L,709L,736L,764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199425Inst : IEnumerable<long>
{
public static readonly long[] Value=A199425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199425.Bytes);
public long this[int i]=>Value[i];

public static A199425Inst Instance=new A199425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199426
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,9L,8L,11L,12L,13L,14L,15L,18L,17L,16L,19L,20L,21L,22L,23L,24L,25L,30L,29L,28L,27L,26L,31L,32L,33L,36L,35L,34L,37L,38L,39L,40L,41L,42L,43L,48L,47L,46L,45L,44L,49L,50L,51L,54L,53L,52L,55L,56L,57L,58L,59L,60L,61L,62L,63L,70L,69L,68L,67L,66L,65L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199426Inst : IEnumerable<long>
{
public static readonly long[] Value=A199426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199426.Bytes);
public long this[int i]=>Value[i];

public static A199426Inst Instance=new A199426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199427
{
public static readonly long[] Value={ 1L,7L,10L,13L,22L,28L,43L,58L,70L,73L,127L,148L,160L,163L,190L,202L,238L,253L,262L,307L,322L,352L,370L,400L,433L,472L,475L,493L,517L,532L,535L,568L,598L,637L,673L,685L,688L,742L,832L,847L,853L,862L,898L,940L,955L,1018L,1087L,1093L,1102L,1120L,1183L,1198L,1270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199427Inst : IEnumerable<long>
{
public static readonly long[] Value=A199427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199427.Bytes);
public long this[int i]=>Value[i];

public static A199427Inst Instance=new A199427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199428
{
public static readonly long[] Value={ 40144044691L,58058453543L,89797181359L,185113489357L,213022025663L,222498988079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199428Inst : IEnumerable<long>
{
public static readonly long[] Value=A199428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199428.Bytes);
public long this[int i]=>Value[i];

public static A199428Inst Instance=new A199428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199429
{
public static readonly long[] Value={ 6L,4L,3L,4L,3L,6L,3L,6L,4L,1L,3L,8L,0L,2L,6L,1L,5L,8L,6L,4L,2L,0L,9L,8L,9L,1L,4L,3L,0L,4L,0L,1L,3L,1L,8L,2L,6L,8L,7L,4L,4L,6L,7L,2L,4L,1L,9L,4L,5L,7L,8L,5L,1L,6L,3L,2L,3L,8L,7L,4L,9L,1L,9L,8L,5L,8L,8L,7L,5L,2L,2L,9L,2L,2L,2L,7L,2L,5L,9L,4L,1L,7L,6L,4L,1L,7L,8L,8L,8L,7L,0L,7L,8L,5L,2L,7L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199429Inst : IEnumerable<long>
{
public static readonly long[] Value=A199429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199429.Bytes);
public long this[int i]=>Value[i];

public static A199429Inst Instance=new A199429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199430
{
public static readonly long[] Value={ 8L,4L,0L,8L,5L,4L,5L,9L,1L,7L,1L,7L,3L,3L,2L,8L,3L,4L,5L,4L,4L,0L,8L,8L,1L,0L,8L,4L,9L,9L,8L,3L,6L,3L,3L,2L,7L,1L,4L,6L,7L,7L,0L,4L,4L,2L,2L,4L,1L,4L,9L,1L,2L,8L,3L,0L,8L,5L,4L,5L,0L,1L,9L,1L,4L,0L,6L,9L,5L,5L,9L,6L,1L,8L,0L,7L,7L,1L,7L,8L,4L,3L,4L,2L,2L,6L,1L,1L,6L,7L,5L,2L,1L,3L,2L,4L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199430Inst : IEnumerable<long>
{
public static readonly long[] Value=A199430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199430.Bytes);
public long this[int i]=>Value[i];

public static A199430Inst Instance=new A199430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199431
{
public static readonly long[] Value={ 9L,6L,2L,1L,7L,9L,5L,0L,5L,1L,0L,9L,3L,2L,7L,0L,9L,1L,3L,6L,7L,2L,6L,2L,7L,5L,4L,4L,1L,0L,8L,5L,1L,4L,7L,3L,3L,2L,1L,7L,9L,1L,7L,9L,2L,7L,5L,3L,1L,4L,6L,2L,3L,2L,0L,8L,9L,1L,7L,3L,6L,1L,0L,9L,6L,5L,9L,2L,9L,2L,6L,7L,6L,7L,3L,3L,9L,1L,6L,4L,7L,0L,7L,2L,3L,6L,8L,1L,3L,5L,7L,6L,6L,0L,3L,4L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199431Inst : IEnumerable<long>
{
public static readonly long[] Value=A199431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199431.Bytes);
public long this[int i]=>Value[i];

public static A199431Inst Instance=new A199431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199432
{
public static readonly long[] Value={ 5L,4L,3L,0L,4L,7L,6L,2L,4L,4L,0L,7L,4L,0L,1L,0L,3L,7L,9L,6L,0L,7L,3L,5L,5L,9L,0L,1L,4L,3L,7L,6L,5L,2L,9L,5L,6L,0L,7L,0L,7L,4L,5L,4L,3L,6L,8L,2L,9L,8L,9L,9L,8L,0L,8L,1L,3L,6L,3L,3L,6L,4L,1L,0L,3L,9L,8L,4L,8L,2L,0L,5L,8L,1L,0L,2L,1L,9L,5L,6L,8L,7L,9L,5L,4L,5L,8L,4L,9L,5L,2L,0L,3L,1L,5L,2L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199432Inst : IEnumerable<long>
{
public static readonly long[] Value=A199432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199432.Bytes);
public long this[int i]=>Value[i];

public static A199432Inst Instance=new A199432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199433
{
public static readonly long[] Value={ 7L,2L,6L,8L,9L,2L,4L,0L,7L,8L,5L,4L,3L,3L,6L,1L,9L,4L,4L,6L,0L,0L,2L,4L,4L,2L,9L,5L,3L,5L,9L,5L,5L,4L,1L,6L,7L,1L,9L,6L,6L,2L,1L,6L,2L,2L,0L,9L,2L,1L,9L,2L,4L,4L,9L,3L,6L,0L,6L,5L,3L,8L,0L,7L,7L,8L,3L,9L,8L,5L,4L,9L,1L,8L,8L,7L,6L,5L,2L,9L,7L,9L,1L,8L,1L,5L,7L,2L,9L,8L,1L,4L,5L,9L,1L,1L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199433Inst : IEnumerable<long>
{
public static readonly long[] Value=A199433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199433.Bytes);
public long this[int i]=>Value[i];

public static A199433Inst Instance=new A199433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199434
{
public static readonly long[] Value={ 8L,4L,6L,9L,9L,7L,5L,3L,0L,0L,4L,5L,2L,4L,5L,5L,8L,9L,4L,0L,0L,8L,1L,0L,6L,3L,7L,5L,7L,0L,2L,2L,8L,6L,7L,9L,5L,2L,5L,1L,7L,8L,6L,7L,7L,4L,2L,8L,1L,1L,7L,7L,3L,5L,3L,1L,0L,2L,2L,1L,4L,9L,1L,7L,2L,9L,1L,9L,7L,2L,9L,1L,9L,6L,2L,6L,5L,0L,3L,5L,1L,8L,5L,4L,7L,1L,9L,9L,4L,4L,4L,2L,9L,3L,5L,3L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199434Inst : IEnumerable<long>
{
public static readonly long[] Value=A199434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199434.Bytes);
public long this[int i]=>Value[i];

public static A199434Inst Instance=new A199434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199435
{
public static readonly long[] Value={ 4L,7L,7L,9L,4L,7L,5L,5L,4L,1L,2L,1L,6L,8L,7L,3L,5L,6L,5L,1L,9L,7L,2L,3L,3L,4L,5L,9L,4L,0L,4L,1L,4L,5L,3L,0L,7L,3L,8L,9L,7L,9L,5L,8L,2L,3L,4L,9L,4L,4L,2L,7L,6L,5L,2L,2L,0L,6L,4L,1L,4L,3L,8L,0L,0L,6L,5L,8L,9L,7L,3L,8L,7L,1L,7L,2L,3L,1L,9L,7L,8L,3L,0L,5L,1L,3L,0L,5L,2L,4L,2L,6L,6L,3L,6L,2L,4L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199435Inst : IEnumerable<long>
{
public static readonly long[] Value=A199435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199435.Bytes);
public long this[int i]=>Value[i];

public static A199435Inst Instance=new A199435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199436
{
public static readonly long[] Value={ 6L,4L,8L,2L,2L,1L,0L,3L,5L,8L,8L,3L,4L,3L,2L,4L,1L,0L,9L,8L,1L,7L,3L,0L,3L,9L,3L,9L,2L,1L,2L,7L,8L,5L,4L,3L,0L,6L,0L,1L,9L,0L,7L,2L,8L,5L,5L,2L,6L,9L,3L,0L,4L,4L,6L,3L,8L,9L,3L,4L,9L,2L,8L,4L,9L,8L,8L,4L,0L,7L,4L,9L,7L,7L,4L,6L,5L,1L,3L,1L,6L,8L,3L,3L,7L,6L,2L,7L,4L,9L,3L,8L,7L,2L,7L,0L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199436Inst : IEnumerable<long>
{
public static readonly long[] Value=A199436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199436.Bytes);
public long this[int i]=>Value[i];

public static A199436Inst Instance=new A199436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199437
{
public static readonly long[] Value={ 7L,6L,3L,5L,7L,5L,4L,4L,7L,3L,0L,8L,3L,7L,7L,0L,5L,4L,7L,7L,9L,3L,3L,8L,9L,0L,7L,5L,5L,9L,2L,8L,4L,4L,3L,4L,1L,0L,5L,1L,9L,0L,3L,6L,2L,8L,0L,6L,7L,1L,1L,5L,4L,4L,4L,5L,8L,7L,1L,1L,6L,3L,1L,2L,9L,9L,3L,1L,2L,1L,8L,0L,0L,5L,0L,0L,6L,8L,3L,0L,1L,0L,8L,1L,2L,9L,9L,9L,8L,7L,4L,3L,6L,7L,0L,1L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199437Inst : IEnumerable<long>
{
public static readonly long[] Value=A199437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199437.Bytes);
public long this[int i]=>Value[i];

public static A199437Inst Instance=new A199437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199438
{
public static readonly long[] Value={ 5L,3L,9L,1L,4L,3L,6L,0L,7L,0L,3L,1L,4L,0L,4L,1L,0L,6L,4L,8L,7L,9L,4L,6L,0L,7L,0L,9L,9L,5L,5L,2L,3L,7L,2L,1L,2L,7L,0L,6L,0L,6L,8L,1L,4L,6L,9L,8L,9L,7L,5L,3L,8L,4L,0L,5L,8L,1L,4L,4L,5L,3L,7L,7L,4L,9L,3L,8L,0L,5L,3L,0L,3L,9L,4L,5L,6L,7L,7L,4L,0L,0L,7L,3L,5L,7L,8L,1L,4L,2L,0L,5L,3L,3L,4L,9L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199438Inst : IEnumerable<long>
{
public static readonly long[] Value=A199438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199438.Bytes);
public long this[int i]=>Value[i];

public static A199438Inst Instance=new A199438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199439
{
public static readonly long[] Value={ 7L,1L,8L,5L,2L,7L,1L,4L,8L,7L,1L,1L,1L,8L,8L,8L,2L,1L,1L,4L,5L,3L,1L,2L,5L,7L,9L,7L,1L,8L,2L,6L,8L,8L,4L,7L,6L,3L,1L,0L,1L,6L,9L,4L,2L,9L,3L,9L,1L,3L,0L,8L,5L,1L,0L,4L,8L,5L,2L,5L,6L,4L,0L,5L,7L,1L,5L,5L,6L,0L,6L,3L,8L,0L,0L,9L,5L,5L,5L,5L,9L,1L,5L,1L,2L,3L,8L,8L,4L,6L,9L,0L,7L,1L,0L,9L,5L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199439Inst : IEnumerable<long>
{
public static readonly long[] Value=A199439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199439.Bytes);
public long this[int i]=>Value[i];

public static A199439Inst Instance=new A199439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199440
{
public static readonly long[] Value={ 8L,3L,5L,0L,1L,4L,6L,3L,2L,3L,2L,3L,7L,3L,2L,8L,8L,8L,3L,8L,6L,2L,0L,6L,1L,1L,2L,3L,1L,6L,9L,7L,4L,4L,2L,1L,8L,5L,3L,4L,3L,5L,9L,0L,1L,0L,7L,3L,3L,8L,3L,2L,1L,8L,0L,9L,7L,2L,5L,0L,1L,0L,3L,1L,8L,9L,3L,2L,9L,4L,0L,0L,1L,3L,3L,6L,0L,9L,5L,6L,6L,3L,5L,6L,8L,9L,4L,6L,6L,1L,4L,6L,7L,9L,2L,1L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199440Inst : IEnumerable<long>
{
public static readonly long[] Value=A199440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199440.Bytes);
public long this[int i]=>Value[i];

public static A199440Inst Instance=new A199440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199441
{
public static readonly long[] Value={ 4L,7L,5L,8L,6L,6L,7L,2L,9L,0L,6L,6L,6L,2L,1L,5L,0L,2L,4L,7L,2L,6L,1L,5L,9L,3L,5L,6L,1L,9L,9L,6L,7L,8L,8L,9L,6L,8L,0L,2L,4L,4L,2L,6L,3L,8L,8L,7L,0L,0L,4L,2L,3L,3L,5L,0L,8L,3L,9L,5L,3L,4L,2L,6L,5L,5L,1L,3L,6L,2L,4L,0L,7L,5L,2L,8L,5L,1L,4L,0L,3L,7L,9L,4L,5L,4L,5L,3L,1L,3L,0L,6L,4L,7L,2L,6L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199441Inst : IEnumerable<long>
{
public static readonly long[] Value=A199441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199441.Bytes);
public long this[int i]=>Value[i];

public static A199441Inst Instance=new A199441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199442
{
public static readonly long[] Value={ 7L,5L,6L,3L,2L,1L,4L,3L,2L,0L,9L,5L,2L,5L,4L,7L,4L,4L,3L,7L,8L,7L,9L,7L,4L,2L,5L,2L,5L,0L,7L,5L,4L,2L,5L,4L,9L,5L,3L,9L,8L,0L,4L,4L,8L,3L,7L,6L,1L,6L,3L,1L,2L,5L,4L,6L,4L,8L,6L,0L,0L,5L,0L,0L,8L,1L,7L,4L,1L,7L,7L,2L,2L,0L,3L,0L,1L,6L,9L,9L,9L,8L,4L,2L,9L,2L,7L,4L,2L,5L,0L,0L,5L,3L,6L,1L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199442Inst : IEnumerable<long>
{
public static readonly long[] Value=A199442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199442.Bytes);
public long this[int i]=>Value[i];

public static A199442Inst Instance=new A199442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199443
{
public static readonly long[] Value={ 4L,3L,0L,3L,0L,7L,4L,4L,1L,9L,2L,1L,5L,3L,5L,2L,9L,7L,9L,2L,1L,6L,4L,5L,9L,0L,1L,9L,0L,4L,2L,7L,5L,9L,0L,4L,5L,0L,1L,3L,7L,8L,7L,7L,7L,3L,6L,0L,7L,0L,8L,5L,0L,2L,8L,9L,8L,9L,6L,3L,5L,9L,6L,2L,9L,6L,3L,7L,0L,1L,6L,3L,0L,0L,9L,0L,4L,2L,3L,8L,5L,7L,6L,1L,4L,2L,2L,2L,2L,4L,1L,0L,0L,1L,5L,5L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199443Inst : IEnumerable<long>
{
public static readonly long[] Value=A199443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199443.Bytes);
public long this[int i]=>Value[i];

public static A199443Inst Instance=new A199443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199444
{
public static readonly long[] Value={ 5L,8L,7L,1L,0L,8L,8L,2L,9L,4L,7L,9L,1L,6L,5L,5L,3L,0L,5L,6L,0L,6L,1L,9L,9L,2L,5L,3L,0L,3L,2L,0L,0L,3L,5L,5L,8L,1L,1L,5L,8L,5L,2L,3L,3L,6L,9L,5L,9L,3L,2L,8L,8L,8L,3L,0L,8L,9L,7L,5L,8L,8L,4L,3L,9L,1L,3L,1L,8L,9L,8L,2L,0L,2L,9L,7L,1L,0L,2L,9L,6L,9L,9L,6L,6L,2L,0L,4L,7L,9L,2L,3L,6L,0L,2L,9L,9L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199444Inst : IEnumerable<long>
{
public static readonly long[] Value=A199444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199444.Bytes);
public long this[int i]=>Value[i];

public static A199444Inst Instance=new A199444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199445
{
public static readonly long[] Value={ 6L,9L,5L,3L,5L,3L,4L,7L,3L,9L,9L,3L,8L,2L,9L,9L,4L,0L,1L,2L,0L,3L,8L,1L,3L,8L,5L,2L,4L,6L,4L,8L,8L,6L,1L,9L,3L,2L,8L,9L,2L,6L,7L,7L,1L,6L,8L,1L,8L,4L,6L,9L,4L,6L,1L,2L,9L,3L,2L,9L,7L,7L,9L,6L,6L,6L,2L,5L,2L,9L,3L,7L,6L,5L,8L,5L,1L,6L,6L,9L,6L,1L,8L,0L,6L,1L,9L,2L,6L,4L,7L,0L,0L,7L,1L,0L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199445Inst : IEnumerable<long>
{
public static readonly long[] Value=A199445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199445.Bytes);
public long this[int i]=>Value[i];

public static A199445Inst Instance=new A199445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199446
{
public static readonly long[] Value={ 4L,7L,3L,8L,4L,7L,9L,7L,1L,2L,6L,3L,7L,7L,7L,4L,3L,0L,9L,9L,9L,8L,0L,1L,5L,8L,7L,1L,1L,4L,4L,2L,5L,9L,8L,5L,9L,1L,1L,6L,7L,1L,8L,0L,1L,2L,0L,4L,5L,3L,1L,8L,9L,1L,0L,6L,3L,0L,9L,0L,7L,5L,6L,5L,3L,7L,7L,8L,9L,0L,7L,4L,6L,2L,3L,3L,8L,7L,8L,0L,8L,9L,0L,8L,2L,9L,1L,7L,4L,3L,0L,2L,8L,8L,7L,9L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199446Inst : IEnumerable<long>
{
public static readonly long[] Value=A199446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199446.Bytes);
public long this[int i]=>Value[i];

public static A199446Inst Instance=new A199446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199447
{
public static readonly long[] Value={ 6L,3L,8L,8L,9L,0L,3L,0L,3L,9L,5L,0L,9L,5L,0L,8L,0L,9L,1L,6L,4L,7L,9L,2L,9L,1L,3L,6L,6L,3L,0L,6L,3L,4L,3L,6L,9L,0L,5L,9L,3L,9L,2L,3L,0L,0L,6L,9L,9L,8L,6L,1L,7L,0L,6L,8L,2L,8L,4L,0L,4L,4L,3L,9L,0L,8L,5L,1L,5L,8L,5L,4L,8L,0L,4L,3L,6L,7L,2L,4L,3L,8L,6L,4L,8L,3L,1L,5L,1L,4L,6L,7L,8L,6L,7L,0L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199447Inst : IEnumerable<long>
{
public static readonly long[] Value=A199447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199447.Bytes);
public long this[int i]=>Value[i];

public static A199447Inst Instance=new A199447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199448
{
public static readonly long[] Value={ 7L,4L,9L,5L,2L,8L,8L,3L,2L,5L,0L,9L,1L,1L,5L,4L,7L,8L,6L,4L,9L,5L,3L,7L,8L,3L,1L,0L,3L,3L,4L,6L,3L,1L,7L,1L,3L,6L,5L,2L,4L,9L,8L,5L,0L,3L,1L,1L,3L,0L,4L,2L,5L,7L,6L,8L,4L,2L,6L,4L,2L,7L,0L,0L,4L,6L,5L,2L,3L,5L,5L,0L,0L,5L,3L,2L,7L,0L,3L,9L,9L,2L,0L,8L,6L,6L,1L,6L,5L,7L,0L,7L,0L,3L,7L,6L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199448Inst : IEnumerable<long>
{
public static readonly long[] Value=A199448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199448.Bytes);
public long this[int i]=>Value[i];

public static A199448Inst Instance=new A199448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199449
{
public static readonly long[] Value={ 4L,2L,9L,0L,7L,9L,1L,0L,6L,0L,8L,7L,8L,3L,9L,2L,4L,1L,1L,8L,7L,9L,9L,4L,9L,9L,5L,0L,7L,0L,2L,2L,0L,1L,7L,4L,7L,0L,2L,3L,1L,8L,6L,4L,2L,1L,7L,4L,4L,6L,4L,3L,2L,1L,6L,4L,7L,4L,8L,7L,5L,3L,4L,6L,1L,9L,6L,5L,0L,4L,0L,8L,3L,3L,2L,8L,4L,8L,9L,7L,7L,1L,7L,7L,9L,3L,6L,3L,6L,5L,5L,8L,9L,1L,2L,9L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199449Inst : IEnumerable<long>
{
public static readonly long[] Value=A199449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199449.Bytes);
public long this[int i]=>Value[i];

public static A199449Inst Instance=new A199449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199450
{
public static readonly long[] Value={ 5L,8L,4L,2L,0L,4L,1L,8L,3L,7L,6L,3L,3L,2L,1L,1L,3L,9L,9L,0L,6L,5L,5L,9L,3L,7L,9L,9L,7L,4L,7L,1L,2L,6L,8L,1L,4L,8L,0L,4L,2L,0L,6L,1L,0L,9L,6L,9L,9L,9L,8L,8L,8L,6L,3L,9L,4L,0L,9L,4L,5L,9L,0L,8L,3L,3L,8L,4L,6L,3L,9L,4L,8L,7L,2L,4L,4L,0L,2L,6L,8L,3L,1L,6L,8L,1L,7L,8L,2L,0L,9L,2L,5L,4L,9L,5L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199450Inst : IEnumerable<long>
{
public static readonly long[] Value=A199450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199450.Bytes);
public long this[int i]=>Value[i];

public static A199450Inst Instance=new A199450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199451
{
public static readonly long[] Value={ 6L,9L,0L,8L,3L,6L,1L,8L,1L,2L,0L,5L,4L,2L,6L,4L,8L,1L,3L,6L,8L,3L,7L,1L,5L,5L,8L,7L,3L,1L,9L,7L,3L,1L,2L,7L,4L,9L,6L,3L,1L,7L,6L,2L,9L,0L,5L,1L,7L,7L,2L,6L,9L,6L,9L,9L,9L,9L,2L,6L,6L,9L,0L,0L,6L,5L,4L,7L,4L,7L,4L,8L,3L,7L,0L,3L,4L,7L,7L,9L,3L,0L,9L,1L,1L,6L,8L,6L,1L,4L,0L,5L,0L,8L,2L,7L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199451Inst : IEnumerable<long>
{
public static readonly long[] Value=A199451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199451.Bytes);
public long this[int i]=>Value[i];

public static A199451Inst Instance=new A199451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199452
{
public static readonly long[] Value={ 3L,9L,4L,7L,8L,4L,8L,4L,4L,9L,4L,1L,2L,8L,5L,9L,9L,7L,8L,1L,5L,2L,7L,3L,5L,3L,6L,2L,8L,9L,9L,5L,7L,0L,2L,5L,5L,3L,4L,7L,1L,7L,2L,2L,1L,1L,6L,4L,9L,7L,3L,5L,0L,5L,2L,6L,6L,8L,5L,5L,6L,4L,1L,3L,7L,6L,8L,4L,4L,6L,5L,8L,6L,5L,5L,8L,9L,7L,3L,3L,3L,9L,0L,7L,3L,6L,7L,8L,6L,9L,9L,1L,4L,1L,7L,4L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199452Inst : IEnumerable<long>
{
public static readonly long[] Value=A199452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199452.Bytes);
public long this[int i]=>Value[i];

public static A199452Inst Instance=new A199452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199453
{
public static readonly long[] Value={ 5L,4L,1L,0L,7L,0L,8L,3L,0L,7L,2L,2L,7L,3L,2L,2L,4L,3L,2L,7L,3L,6L,4L,5L,7L,3L,9L,1L,0L,9L,5L,1L,7L,7L,2L,9L,9L,2L,7L,9L,0L,2L,7L,8L,5L,3L,7L,8L,9L,3L,0L,7L,7L,8L,6L,2L,0L,3L,7L,6L,2L,3L,2L,0L,6L,0L,7L,7L,0L,4L,4L,8L,6L,7L,9L,0L,1L,2L,5L,4L,9L,1L,3L,9L,6L,1L,9L,8L,4L,5L,5L,8L,5L,1L,3L,6L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199453Inst : IEnumerable<long>
{
public static readonly long[] Value=A199453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199453.Bytes);
public long this[int i]=>Value[i];

public static A199453Inst Instance=new A199453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199454
{
public static readonly long[] Value={ 1L,2L,2L,0L,4L,6L,8L,4L,6L,5L,9L,1L,1L,2L,9L,9L,5L,8L,8L,6L,8L,2L,8L,1L,4L,3L,1L,2L,2L,1L,1L,2L,4L,4L,8L,2L,9L,8L,7L,5L,1L,6L,2L,5L,1L,9L,6L,7L,0L,1L,4L,4L,6L,3L,5L,8L,3L,2L,4L,1L,6L,1L,0L,3L,8L,3L,6L,4L,4L,7L,5L,8L,8L,3L,2L,1L,1L,9L,0L,4L,7L,3L,2L,1L,1L,2L,0L,0L,1L,3L,7L,5L,9L,7L,2L,5L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199454Inst : IEnumerable<long>
{
public static readonly long[] Value=A199454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199454.Bytes);
public long this[int i]=>Value[i];

public static A199454Inst Instance=new A199454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199455
{
public static readonly long[] Value={ 1L,3L,2L,9L,9L,0L,3L,2L,6L,8L,4L,6L,9L,0L,4L,8L,0L,2L,6L,9L,8L,8L,7L,7L,9L,6L,5L,8L,0L,8L,0L,4L,0L,6L,0L,8L,2L,5L,3L,7L,3L,3L,2L,0L,9L,4L,4L,6L,9L,6L,2L,1L,6L,6L,3L,3L,6L,6L,8L,3L,2L,7L,7L,4L,0L,2L,8L,2L,5L,2L,8L,7L,9L,9L,5L,4L,5L,8L,0L,5L,7L,4L,9L,0L,3L,8L,8L,7L,5L,3L,9L,9L,4L,7L,3L,3L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199455Inst : IEnumerable<long>
{
public static readonly long[] Value=A199455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199455.Bytes);
public long this[int i]=>Value[i];

public static A199455Inst Instance=new A199455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199456
{
public static readonly long[] Value={ 1L,3L,8L,4L,3L,5L,8L,2L,8L,9L,1L,3L,5L,1L,7L,5L,4L,3L,2L,1L,7L,1L,1L,4L,0L,9L,2L,1L,1L,2L,3L,7L,8L,6L,4L,7L,7L,9L,8L,9L,4L,3L,2L,7L,1L,7L,7L,2L,0L,4L,0L,1L,9L,5L,6L,2L,7L,5L,3L,6L,0L,1L,8L,6L,6L,4L,4L,5L,4L,4L,2L,0L,7L,7L,0L,4L,3L,4L,1L,4L,9L,3L,4L,2L,3L,3L,8L,3L,1L,6L,7L,3L,8L,6L,7L,7L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199456Inst : IEnumerable<long>
{
public static readonly long[] Value=A199456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199456.Bytes);
public long this[int i]=>Value[i];

public static A199456Inst Instance=new A199456Inst();

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