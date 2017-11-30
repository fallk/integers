using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A272678
{
public static readonly long[] Value={ 0L,2L,5L,35L,296L,2600L,25317L,251416L,2504474L,25010000L,250044723L,2500100000L,25000316228L,250002000003L,2500004472137L,25000010000000L,250000044721361L,2500000141421358L,25000000316227767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272678Inst : IEnumerable<long>
{
public static readonly long[] Value=A272678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272678.Bytes);
public long this[int i]=>Value[i];

public static A272678Inst Instance=new A272678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272679
{
public static readonly long[] Value={ 0L,1L,2L,5L,2L,9L,5L,11L,4L,3L,9L,19L,5L,21L,15L,11L,4L,33L,6L,25L,9L,13L,19L,39L,7L,5L,29L,21L,15L,61L,11L,45L,8L,23L,33L,67L,6L,49L,35L,25L,9L,73L,13L,53L,107L,19L,77L,39L,79L,7L,10L,81L,29L,83L,59L,21L,15L,43L,61L,87L,11L,89L,63L,45L,8L,129L,23L,93L,33L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272679Inst : IEnumerable<long>
{
public static readonly long[] Value=A272679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272679.Bytes);
public long this[int i]=>Value[i];

public static A272679Inst Instance=new A272679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272680
{
public static readonly long[] Value={ 0L,1L,4L,25L,4L,81L,25L,121L,16L,9L,81L,361L,25L,441L,225L,121L,16L,1089L,36L,625L,81L,169L,361L,1521L,49L,25L,841L,441L,225L,3721L,121L,2025L,64L,529L,1089L,4489L,36L,2401L,1225L,625L,81L,5329L,169L,2809L,11449L,361L,5929L,1521L,6241L,49L,100L,6561L,841L,6889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272680Inst : IEnumerable<long>
{
public static readonly long[] Value=A272680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272680.Bytes);
public long this[int i]=>Value[i];

public static A272680Inst Instance=new A272680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272681
{
public static readonly long[] Value={ 0L,1L,100L,11001L,100L,1010001L,11001L,1111001L,10000L,1001L,1010001L,101101001L,11001L,110111001L,11100001L,1111001L,10000L,10001000001L,100100L,1001110001L,1010001L,10101001L,101101001L,10111110001L,110001L,11001L,1101001001L,110111001L,11100001L,111010001001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272681Inst : IEnumerable<long>
{
public static readonly long[] Value=A272681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272681.Bytes);
public long this[int i]=>Value[i];

public static A272681Inst Instance=new A272681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272682
{
public static readonly BigInteger[] Value={ 15L,4L,145L,6L,65L,7741915625L,825L,85L,905L,30245625L,325L,1090619453125L,36L,37L,38L,39L,402484375L,414731890625L,135L,14L,456875L,46901578125L,475L,4885L,1575L,16L,1625L,165L,5375L,170759375L,54893244140625L,17638317373046875L,BigInteger.Parse("1795516819326995849609375"),BigInteger.Parse("57642802733386962890625"),185L };
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
public class A272682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272682Inst Instance=new A272682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272683
{
public static readonly BigInteger[] Value={ 35L,4L,105L,4L,35L,4465115625L,425L,35L,345L,10714375L,125L,435259453125L,14L,13L,12L,11L,109515625L,109556109375L,35L,4L,136875L,14133578125L,125L,1365L,425L,4L,375L,35L,1375L,34040625L,10642755859375L,3333202626953125L,BigInteger.Parse("351966828673004150390625"),BigInteger.Parse("11076674002613037109375"),35L,351172546875L,33875L,11L,12L,13L };
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
public class A272683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272683Inst Instance=new A272683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272684
{
public static readonly long[] Value={ 6L,21L,44L,69L,96L,156L,225L,296L,369L,444L,521L,681L,764L,849L,936L,1025L,1236L,1449L,1664L,1881L,2321L,2544L,2769L,2996L,3225L,3456L,3689L,3924L,4161L,4641L,4884L,5129L,5376L,5625L,5876L,6129L,6384L,6641L,7161L,7424L,7689L,7956L,8225L,8496L,8769L,9044L,9321L,9881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272684Inst : IEnumerable<long>
{
public static readonly long[] Value=A272684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272684.Bytes);
public long this[int i]=>Value[i];

public static A272684Inst Instance=new A272684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272685
{
public static readonly long[] Value={ 1L,15L,14L,13L,12L,217L,0L,215L,45L,213L,44L,43L,209L,42L,207L,2L,573L,1327L,572L,130L,185L,570L,1492L,569L,78L,568L,128L,567L,1318L,1498L,565L,188L,564L,10L,563L,1312L,562L,1504L,1309L,560L,1507L,693L,74L,558L,1510L,557L,192L,2360L,6085L,350L,1480L,708L,6083L,3643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272685Inst : IEnumerable<long>
{
public static readonly long[] Value=A272685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272685.Bytes);
public long this[int i]=>Value[i];

public static A272685Inst Instance=new A272685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272686
{
public static readonly long[] Value={ 0L,3L,10L,36L,134L,510L,1976L,7770L,30934L,124456L,505254L,2067250L,8516028L,35292978L,147045490L,615572172L,2587970166L,10922249958L,46257477232L,196532215226L,837432161710L,3577882539792L,15323984114822L,65781749593002L,282979540332660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272686Inst : IEnumerable<long>
{
public static readonly long[] Value=A272686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272686.Bytes);
public long this[int i]=>Value[i];

public static A272686Inst Instance=new A272686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272687
{
public static readonly long[] Value={ 1L,1L,4L,14L,50L,184L,694L,2670L,10440L,41374L,165830L,671084L,2738334L,11254362L,46547340L,193592830L,809165002L,3397135168L,14319385126L,60576862358L,257109077584L,1094541239294L,4672423779086L,19996407893908L,85778157486910L,368757697819570L,1588465839532628L,6855304750273902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272687Inst : IEnumerable<long>
{
public static readonly long[] Value=A272687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272687.Bytes);
public long this[int i]=>Value[i];

public static A272687Inst Instance=new A272687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272688
{
public static readonly long[] Value={ 1L,1L,6L,72L,1120L,21600L,498960L,13453440L,415134720L,14435366400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272688Inst : IEnumerable<long>
{
public static readonly long[] Value=A272688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272688.Bytes);
public long this[int i]=>Value[i];

public static A272688Inst Instance=new A272688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272689
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,1L,1L,3L,5L,6L,5L,2L,1L,4L,9L,15L,20L,22L,19L,11L,1L,5L,14L,29L,49L,71L,90L,100L,96L,76L,42L,1L,6L,20L,49L,98L,169L,259L,359L,454L,525L,553L,524L,433L,286L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272689Inst : IEnumerable<long>
{
public static readonly long[] Value=A272689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272689.Bytes);
public long this[int i]=>Value[i];

public static A272689Inst Instance=new A272689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272690
{
public static readonly BigInteger[] Value={ 1L,24L,1060L,48672L,2238736L,102981504L,4737148480L,217908828672L,10023806116096L,461095081334784L,21210373741388800L,975677192103862272L,BigInteger.Parse("44881150836777619456"),BigInteger.Parse("2064532938491770404864"),BigInteger.Parse("94968515170621438443520"),BigInteger.Parse("4368551697848586168041472"),BigInteger.Parse("200953378101034963729186816") };
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
public class A272690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272690Inst Instance=new A272690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272691
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,12L,16L,19L,21L,29L,30L,31L,38L,47L,52L,57L,64L,77L,98L,105L,109L,118L,171L,212L,289L,382L,392L,467L,484L,662L,719L,737L,783L,843L,907L,1097L,1261L,1386L,1397L,1713L,1768L,2116L,2179L,2343L,3079L,3444L,3681L,3930L,5288L,5413L,5447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272691Inst : IEnumerable<long>
{
public static readonly long[] Value=A272691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272691.Bytes);
public long this[int i]=>Value[i];

public static A272691Inst Instance=new A272691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272740
{
public static readonly long[] Value={ 1L,9L,29L,66L,126L,210L,339L,496L,712L,969L,1298L,1651L,2132L,2641L,3254L,3903L,4696L,5541L,6594L,7639L,8880L,10085L,11658L,13211L,14963L,16676L,18897L,21066L,23419L,25728L,28573L,31426L,34559L,37572L,41285L,45006L,48923L,52588L,57229L,61754L,66519L,71152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272740Inst : IEnumerable<long>
{
public static readonly long[] Value=A272740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272740.Bytes);
public long this[int i]=>Value[i];

public static A272740Inst Instance=new A272740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272741
{
public static readonly long[] Value={ 7L,12L,17L,23L,24L,45L,28L,59L,41L,72L,24L,128L,28L,104L,36L,144L,52L,208L,-8L,196L,-36L,368L,-20L,199L,-39L,508L,-52L,184L,-44L,536L,8L,280L,-120L,700L,8L,196L,-252L,976L,-116L,240L,-132L,924L,-4L,384L,-452L,1116L,-56L,240L,-152L,1320L,-165L,377L,-373L,1168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272741Inst : IEnumerable<long>
{
public static readonly long[] Value=A272741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272741.Bytes);
public long this[int i]=>Value[i];

public static A272741Inst Instance=new A272741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272742
{
public static readonly long[] Value={ 1L,5L,9L,17L,17L,33L,45L,69L,61L,85L,97L,121L,121L,169L,205L,277L,245L,293L,305L,329L,329L,377L,413L,485L,461L,533L,569L,641L,641L,785L,893L,1109L,1005L,1125L,1137L,1161L,1161L,1209L,1245L,1317L,1293L,1365L,1401L,1473L,1473L,1617L,1725L,1941L,1845L,1989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272742Inst : IEnumerable<long>
{
public static readonly long[] Value=A272742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272742.Bytes);
public long this[int i]=>Value[i];

public static A272742Inst Instance=new A272742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272743
{
public static readonly long[] Value={ 1L,5L,17L,69L,277L,1109L,4437L,17749L,70997L,283989L,1135957L,4543829L,18175317L,72701269L,290805077L,1163220309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272743Inst : IEnumerable<long>
{
public static readonly long[] Value=A272743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272743.Bytes);
public long this[int i]=>Value[i];

public static A272743Inst Instance=new A272743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272744
{
public static readonly long[] Value={ 1L,6L,15L,32L,49L,82L,127L,196L,257L,342L,439L,560L,681L,850L,1055L,1332L,1577L,1870L,2175L,2504L,2833L,3210L,3623L,4108L,4569L,5102L,5671L,6312L,6953L,7738L,8631L,9740L,10745L,11870L,13007L,14168L,15329L,16538L,17783L,19100L,20393L,21758L,23159L,24632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272744Inst : IEnumerable<long>
{
public static readonly long[] Value=A272744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272744.Bytes);
public long this[int i]=>Value[i];

public static A272744Inst Instance=new A272744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272745
{
public static readonly long[] Value={ 4L,4L,8L,0L,16L,12L,24L,-8L,24L,12L,24L,0L,48L,36L,72L,-32L,48L,12L,24L,0L,48L,36L,72L,-24L,72L,36L,72L,0L,144L,108L,216L,-104L,120L,12L,24L,0L,48L,36L,72L,-24L,72L,36L,72L,0L,144L,108L,216L,-96L,144L,36L,72L,0L,144L,108L,216L,-72L,216L,108L,216L,0L,432L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272745Inst : IEnumerable<long>
{
public static readonly long[] Value=A272745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272745.Bytes);
public long this[int i]=>Value[i];

public static A272745Inst Instance=new A272745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272746
{
public static readonly long[] Value={ 1L,4L,13L,28L,49L,77L,96L,149L,180L,257L,256L,373L,388L,513L,476L,709L,692L,857L,828L,1129L,1032L,1301L,1224L,1605L,1584L,1789L,1812L,2149L,2132L,2445L,2368L,2861L,2684L,3121L,3100L,3461L,3544L,3785L,3848L,4341L,4284L,4817L,4772L,5237L,5292L,5697L,5784L,6085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272746Inst : IEnumerable<long>
{
public static readonly long[] Value=A272746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272746.Bytes);
public long this[int i]=>Value[i];

public static A272746Inst Instance=new A272746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272747
{
public static readonly long[] Value={ 1L,4L,28L,149L,709L,2861L,11109L,43661L,174645L,703089L,2808797L,11242321L,44965633L,179830033L,719326977L,2877573801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272747Inst : IEnumerable<long>
{
public static readonly long[] Value=A272747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272747.Bytes);
public long this[int i]=>Value[i];

public static A272747Inst Instance=new A272747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272748
{
public static readonly long[] Value={ 1L,5L,18L,46L,95L,172L,268L,417L,597L,854L,1110L,1483L,1871L,2384L,2860L,3569L,4261L,5118L,5946L,7075L,8107L,9408L,10632L,12237L,13821L,15610L,17422L,19571L,21703L,24148L,26516L,29377L,32061L,35182L,38282L,41743L,45287L,49072L,52920L,57261L,61545L,66362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272748Inst : IEnumerable<long>
{
public static readonly long[] Value=A272748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272748.Bytes);
public long this[int i]=>Value[i];

public static A272748Inst Instance=new A272748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272749
{
public static readonly long[] Value={ 3L,9L,15L,21L,28L,19L,53L,31L,77L,-1L,117L,15L,125L,-37L,233L,-17L,165L,-29L,301L,-97L,269L,-77L,381L,-21L,205L,23L,337L,-17L,313L,-77L,493L,-177L,437L,-21L,361L,83L,241L,63L,493L,-57L,533L,-45L,465L,55L,405L,87L,301L,215L,313L,155L,629L,-161L,605L,15L,665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272749Inst : IEnumerable<long>
{
public static readonly long[] Value=A272749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272749.Bytes);
public long this[int i]=>Value[i];

public static A272749Inst Instance=new A272749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272750
{
public static readonly long[] Value={ 1L,5L,13L,29L,49L,89L,97L,165L,177L,273L,277L,385L,389L,545L,549L,701L,697L,889L,917L,1057L,1097L,1301L,1409L,1557L,1681L,1925L,1821L,2213L,2173L,2465L,2601L,2821L,2853L,3193L,3253L,3541L,3481L,3989L,4057L,4437L,4493L,4853L,4797L,5557L,5381L,5933L,5749L,6589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272750Inst : IEnumerable<long>
{
public static readonly long[] Value=A272750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272750.Bytes);
public long this[int i]=>Value[i];

public static A272750Inst Instance=new A272750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272751
{
public static readonly long[] Value={ 1L,5L,29L,165L,701L,2821L,11221L,45225L,181317L,722121L,2888609L,11543381L,46174777L,184657933L,738478713L,2953868917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272751Inst : IEnumerable<long>
{
public static readonly long[] Value=A272751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272751.Bytes);
public long this[int i]=>Value[i];

public static A272751Inst Instance=new A272751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272752
{
public static readonly long[] Value={ 1L,6L,19L,48L,97L,186L,283L,448L,625L,898L,1175L,1560L,1949L,2494L,3043L,3744L,4441L,5330L,6247L,7304L,8401L,9702L,11111L,12668L,14349L,16274L,18095L,20308L,22481L,24946L,27547L,30368L,33221L,36414L,39667L,43208L,46689L,50678L,54735L,59172L,63665L,68518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272752Inst : IEnumerable<long>
{
public static readonly long[] Value=A272752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272752.Bytes);
public long this[int i]=>Value[i];

public static A272752Inst Instance=new A272752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272753
{
public static readonly long[] Value={ 4L,8L,16L,20L,40L,8L,68L,12L,96L,4L,108L,4L,156L,4L,152L,-4L,192L,28L,140L,40L,204L,108L,148L,124L,244L,-104L,392L,-40L,292L,136L,220L,32L,340L,60L,288L,-60L,508L,68L,380L,56L,360L,-56L,760L,-176L,552L,-184L,840L,-216L,632L,-52L,724L,-288L,832L,-124L,584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272753Inst : IEnumerable<long>
{
public static readonly long[] Value=A272753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272753.Bytes);
public long this[int i]=>Value[i];

public static A272753Inst Instance=new A272753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272754
{
public static readonly long[] Value={ 1103L,2819L,6599L,29339L,41039L,52631L,62743L,172079L,188459L,278543L,340559L,488879L,656599L,670031L,1033667L,2100899L,3146219L,5048999L,6049679L,8719307L,10024559L,10402559L,10877579L,11119103L,12261059L,14913989L,15247619L,15829631L,15888311L,17315999L,17812079L,18900971L,25603199L,26921087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272754Inst : IEnumerable<long>
{
public static readonly long[] Value=A272754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272754.Bytes);
public long this[int i]=>Value[i];

public static A272754Inst Instance=new A272754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272755
{
public static readonly BigInteger[] Value={ 1L,1L,5L,1L,143L,19L,1153L,583L,1616353L,132809L,134926369L,46840699L,67545496213157L,4068990560161L,411124285571171L,1204567303451311L,BigInteger.Parse("73419800947733963069"),4146897304424408411L,BigInteger.Parse("86773346866163284480799923"),BigInteger.Parse("18814360006695807527868793"),BigInteger.Parse("539741515875650532056045666422369") };
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
public class A272755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272755Inst Instance=new A272755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272788
{
public static readonly long[] Value={ 1L,6L,15L,36L,53L,102L,131L,208L,253L,390L,451L,592L,685L,934L,1075L,1352L,1513L,1914L,2099L,2516L,2749L,3322L,3611L,4224L,4529L,5326L,5659L,6432L,6817L,7938L,8371L,9440L,10021L,11470L,11943L,13116L,13949L,15654L,16459L,18108L,19009L,20978L,21843L,23732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272788Inst : IEnumerable<long>
{
public static readonly long[] Value=A272788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272788.Bytes);
public long this[int i]=>Value[i];

public static A272788Inst Instance=new A272788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272789
{
public static readonly long[] Value={ 4L,4L,12L,-4L,32L,-20L,48L,-32L,92L,-76L,80L,-48L,156L,-108L,136L,-116L,240L,-216L,232L,-184L,340L,-284L,324L,-308L,492L,-464L,440L,-388L,736L,-688L,636L,-488L,868L,-976L,700L,-340L,872L,-900L,844L,-748L,1068L,-1104L,1024L,-948L,1536L,-1412L,1324L,-1080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272789Inst : IEnumerable<long>
{
public static readonly long[] Value=A272789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272789.Bytes);
public long this[int i]=>Value[i];

public static A272789Inst Instance=new A272789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272790
{
public static readonly long[] Value={ 1L,4L,13L,28L,49L,81L,88L,173L,193L,253L,248L,397L,408L,533L,512L,741L,749L,897L,857L,1152L,1176L,1325L,1289L,1721L,1549L,1960L,1825L,2197L,2220L,2573L,2316L,2993L,2936L,3293L,3048L,3781L,3656L,4252L,3969L,4733L,4437L,5157L,4785L,5680L,5313L,6165L,5753L,6661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272790Inst : IEnumerable<long>
{
public static readonly long[] Value=A272790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272790.Bytes);
public long this[int i]=>Value[i];

public static A272790Inst Instance=new A272790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272791
{
public static readonly long[] Value={ 1L,4L,28L,173L,741L,2993L,11993L,47025L,187164L,745536L,2979693L,11916417L,47647817L,190538997L,762243257L,3048866261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272791Inst : IEnumerable<long>
{
public static readonly long[] Value=A272791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272791.Bytes);
public long this[int i]=>Value[i];

public static A272791Inst Instance=new A272791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272792
{
public static readonly long[] Value={ 1L,5L,18L,46L,95L,176L,264L,437L,630L,883L,1131L,1528L,1936L,2469L,2981L,3722L,4471L,5368L,6225L,7377L,8553L,9878L,11167L,12888L,14437L,16397L,18222L,20419L,22639L,25212L,27528L,30521L,33457L,36750L,39798L,43579L,47235L,51487L,55456L,60189L,64626L,69783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272792Inst : IEnumerable<long>
{
public static readonly long[] Value=A272792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272792.Bytes);
public long this[int i]=>Value[i];

public static A272792Inst Instance=new A272792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272793
{
public static readonly long[] Value={ 3L,9L,15L,21L,32L,7L,85L,20L,60L,-5L,149L,11L,125L,-21L,229L,8L,148L,-40L,295L,24L,149L,-36L,432L,-172L,411L,-135L,372L,23L,353L,-257L,677L,-57L,357L,-245L,733L,-125L,596L,-283L,764L,-296L,720L,-372L,895L,-367L,852L,-412L,908L,-308L,880L,-517L,1161L,-112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272793Inst : IEnumerable<long>
{
public static readonly long[] Value=A272793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272793.Bytes);
public long this[int i]=>Value[i];

public static A272793Inst Instance=new A272793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272794
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,5L,13L,27L,74L,198L,508L,1371L,3809L,10477L,29116L,82419L,233748L,666201L,1914668L,5528622L,16019330L,46642245L,136326126L,399652720L,1175422931L,3467251920L,10258152021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272794Inst : IEnumerable<long>
{
public static readonly long[] Value=A272794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272794.Bytes);
public long this[int i]=>Value[i];

public static A272794Inst Instance=new A272794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272795
{
public static readonly long[] Value={ 9L,5L,8L,8L,5L,1L,0L,7L,7L,2L,0L,8L,4L,0L,6L,0L,0L,0L,5L,4L,6L,5L,7L,5L,8L,7L,0L,4L,3L,1L,1L,4L,2L,7L,7L,6L,1L,6L,3L,6L,0L,6L,7L,3L,5L,8L,8L,1L,2L,0L,1L,3L,5L,0L,3L,7L,7L,2L,3L,3L,2L,2L,6L,2L,5L,1L,0L,7L,0L,0L,0L,0L,5L,7L,5L,6L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272795Inst : IEnumerable<long>
{
public static readonly long[] Value=A272795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272795.Bytes);
public long this[int i]=>Value[i];

public static A272795Inst Instance=new A272795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272796
{
public static readonly BigInteger[] Value={ 23L,223L,22273L,2222273L,22222222223L,2222222222273L,22222222222223557L,2222222222222222327L,BigInteger.Parse("22222222222222222222327"),BigInteger.Parse("22222222222222222222222222577"),BigInteger.Parse("2222222222222222222222222223223"),BigInteger.Parse("2222222222222222222222222222222222527"),BigInteger.Parse("22222222222222222222222222222222222223333") };
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
public class A272796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272796Inst Instance=new A272796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272797
{
public static readonly long[] Value={ 13L,1L,27L,23L,891L,4795L,125201L,3253303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272797Inst : IEnumerable<long>
{
public static readonly long[] Value=A272797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272797.Bytes);
public long this[int i]=>Value[i];

public static A272797Inst Instance=new A272797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272798
{
public static readonly long[] Value={ 1729L,63973L,75361L,172081L,278545L,340561L,658801L,997633L,1773289L,3224065L,5310721L,8719309L,8719921L,12945745L,13187665L,15888313L,17586361L,27402481L,29020321L,39353665L,40430401L,49333201L,67371265L,84417985L,120981601L,128697361L,129255841L,130032865L,151530401L,151813201L,158864833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272798Inst : IEnumerable<long>
{
public static readonly long[] Value=A272798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272798.Bytes);
public long this[int i]=>Value[i];

public static A272798Inst Instance=new A272798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272799
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,9L,10L,11L,15L,16L,17L,18L,19L,20L,21L,26L,27L,28L,29L,30L,33L,34L,35L,36L,39L,42L,43L,44L,45L,46L,47L,48L,51L,52L,53L,54L,55L,56L,57L,64L,65L,66L,69L,70L,71L,72L,75L,78L,79L,80L,81L,82L,83L,89L,90L,91L,92L,93L,96L,97L,98L,99L,100L,101L,102L,105L,106L,107L,108L,109L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272799Inst : IEnumerable<long>
{
public static readonly long[] Value=A272799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272799.Bytes);
public long this[int i]=>Value[i];

public static A272799Inst Instance=new A272799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272800
{
public static readonly long[] Value={ 0L,2L,0L,2L,3L,2L,0L,2L,4L,2L,3L,2L,0L,2L,5L,2L,3L,2L,0L,2L,4L,2L,3L,2L,6L,2L,0L,2L,3L,2L,7L,2L,4L,2L,3L,2L,5L,2L,0L,2L,3L,2L,8L,2L,4L,2L,3L,2L,0L,2L,6L,2L,3L,2L,5L,2L,4L,2L,3L,2L,9L,2L,0L,2L,3L,2L,10L,2L,4L,2L,3L,2L,7L,2L,5L,2L,3L,2L,0L,2L,4L,2L,3L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272800Inst : IEnumerable<long>
{
public static readonly long[] Value=A272800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272800.Bytes);
public long this[int i]=>Value[i];

public static A272800Inst Instance=new A272800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272801
{
public static readonly long[] Value={ 1L,5L,13L,29L,49L,89L,105L,173L,185L,301L,289L,421L,425L,553L,573L,725L,761L,965L,917L,1229L,1161L,1461L,1369L,1729L,1617L,2085L,1901L,2377L,2153L,2757L,2517L,3053L,2985L,3489L,3309L,3953L,3797L,4309L,4137L,4873L,4585L,5253L,5017L,5837L,5641L,6073L,6357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272801Inst : IEnumerable<long>
{
public static readonly long[] Value=A272801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272801.Bytes);
public long this[int i]=>Value[i];

public static A272801Inst Instance=new A272801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272802
{
public static readonly long[] Value={ 1L,5L,29L,173L,725L,3053L,12069L,48121L,194461L,780729L,3130485L,12549341L,50276057L,201270797L,805459873L,3222684429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272802Inst : IEnumerable<long>
{
public static readonly long[] Value=A272802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272802.Bytes);
public long this[int i]=>Value[i];

public static A272802Inst Instance=new A272802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272803
{
public static readonly long[] Value={ 1L,6L,19L,48L,97L,186L,291L,464L,649L,950L,1239L,1660L,2085L,2638L,3211L,3936L,4697L,5662L,6579L,7808L,8969L,10430L,11799L,13528L,15145L,17230L,19131L,21508L,23661L,26418L,28935L,31988L,34973L,38462L,41771L,45724L,49521L,53830L,57967L,62840L,67425L,72678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272803Inst : IEnumerable<long>
{
public static readonly long[] Value=A272803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272803.Bytes);
public long this[int i]=>Value[i];

public static A272803Inst Instance=new A272803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272836
{
public static readonly long[] Value={ 1L,5L,22L,50L,107L,191L,308L,448L,653L,917L,1234L,1634L,2099L,2611L,3192L,3844L,4593L,5521L,6494L,7698L,9011L,10399L,11944L,13616L,15433L,17477L,19570L,21890L,24331L,26815L,29424L,32148L,35117L,38501L,41930L,45762L,49771L,54043L,58520L,63360L,68453L,73797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272836Inst : IEnumerable<long>
{
public static readonly long[] Value=A272836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272836.Bytes);
public long this[int i]=>Value[i];

public static A272836Inst Instance=new A272836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272837
{
public static readonly long[] Value={ 3L,13L,11L,29L,27L,33L,23L,65L,59L,53L,83L,65L,47L,69L,71L,97L,179L,45L,231L,109L,75L,157L,127L,145L,227L,49L,227L,121L,43L,125L,115L,245L,415L,45L,403L,177L,263L,205L,363L,253L,251L,253L,331L,217L,231L,221L,219L,433L,515L,45L,475L,365L,251L,193L,387L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272837Inst : IEnumerable<long>
{
public static readonly long[] Value=A272837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272837.Bytes);
public long this[int i]=>Value[i];

public static A272837Inst Instance=new A272837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272838
{
public static readonly long[] Value={ 1L,5L,17L,29L,61L,89L,121L,149L,213L,273L,337L,397L,477L,537L,601L,661L,789L,913L,1041L,1165L,1309L,1433L,1561L,1685L,1861L,2017L,2169L,2309L,2453L,2537L,2633L,2757L,3013L,3265L,3521L,3773L,4045L,4297L,4553L,4805L,5109L,5393L,5673L,5941L,6213L,6425L,6649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272838Inst : IEnumerable<long>
{
public static readonly long[] Value=A272838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272838.Bytes);
public long this[int i]=>Value[i];

public static A272838Inst Instance=new A272838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272839
{
public static readonly long[] Value={ 1L,5L,29L,149L,661L,2757L,11229L,45285L,181837L,728693L,2917405L,11674821L,46709613L,186859029L,747477181L,2989990757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272839Inst : IEnumerable<long>
{
public static readonly long[] Value=A272839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272839.Bytes);
public long this[int i]=>Value[i];

public static A272839Inst Instance=new A272839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272840
{
public static readonly long[] Value={ 1L,6L,23L,52L,113L,202L,323L,472L,685L,958L,1295L,1692L,2169L,2706L,3307L,3968L,4757L,5670L,6711L,7876L,9185L,10618L,12179L,13864L,15725L,17742L,19911L,22220L,24673L,27210L,29843L,32600L,35613L,38878L,42399L,46172L,50217L,54514L,59067L,63872L,68981L,74374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272840Inst : IEnumerable<long>
{
public static readonly long[] Value=A272840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272840.Bytes);
public long this[int i]=>Value[i];

public static A272840Inst Instance=new A272840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272841
{
public static readonly long[] Value={ 4L,12L,12L,32L,28L,32L,28L,64L,60L,64L,60L,80L,60L,64L,60L,128L,124L,128L,124L,144L,124L,128L,124L,176L,156L,152L,140L,144L,84L,96L,124L,256L,252L,256L,252L,272L,252L,256L,252L,304L,284L,280L,268L,272L,212L,224L,252L,368L,348L,344L,332L,336L,276L,280L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272841Inst : IEnumerable<long>
{
public static readonly long[] Value=A272841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272841.Bytes);
public long this[int i]=>Value[i];

public static A272841Inst Instance=new A272841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272842
{
public static readonly long[] Value={ 1L,8L,20L,41L,60L,97L,132L,173L,212L,273L,332L,421L,484L,553L,644L,733L,764L,937L,1041L,1148L,1353L,1469L,1580L,1757L,1853L,2097L,2225L,2332L,2565L,2732L,2837L,2972L,3001L,3292L,3665L,3784L,4201L,4373L,4625L,4984L,5101L,5392L,5809L,6001L,6264L,6637L,6941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272842Inst : IEnumerable<long>
{
public static readonly long[] Value=A272842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272842.Bytes);
public long this[int i]=>Value[i];

public static A272842Inst Instance=new A272842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272843
{
public static readonly long[] Value={ 1L,8L,41L,173L,733L,2972L,12168L,47368L,190025L,760809L,3030988L,12106753L,48391164L,193311513L,772498916L,3088456925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272843Inst : IEnumerable<long>
{
public static readonly long[] Value=A272843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272843.Bytes);
public long this[int i]=>Value[i];

public static A272843Inst Instance=new A272843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272844
{
public static readonly long[] Value={ 1L,9L,29L,70L,130L,227L,359L,532L,744L,1017L,1349L,1770L,2254L,2807L,3451L,4184L,4948L,5885L,6926L,8074L,9427L,10896L,12476L,14233L,16086L,18183L,20408L,22740L,25305L,28037L,30874L,33846L,36847L,40139L,43804L,47588L,51789L,56162L,60787L,65771L,70872L,76264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272844Inst : IEnumerable<long>
{
public static readonly long[] Value=A272844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272844.Bytes);
public long this[int i]=>Value[i];

public static A272844Inst Instance=new A272844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272845
{
public static readonly long[] Value={ 7L,12L,21L,19L,37L,35L,41L,39L,61L,59L,89L,63L,69L,91L,89L,31L,173L,104L,107L,205L,116L,111L,177L,96L,244L,128L,107L,233L,167L,105L,135L,29L,291L,373L,119L,417L,172L,252L,359L,117L,291L,417L,192L,263L,373L,304L,111L,509L,76L,431L,165L,704L,-53L,665L,8L,419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272845Inst : IEnumerable<long>
{
public static readonly long[] Value=A272845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272845.Bytes);
public long this[int i]=>Value[i];

public static A272845Inst Instance=new A272845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272846
{
public static readonly long[] Value={ 1L,4L,17L,28L,57L,84L,125L,140L,193L,260L,325L,380L,457L,532L,613L,620L,689L,868L,949L,1116L,1209L,1396L,1493L,1612L,1705L,1956L,2053L,2236L,2337L,2548L,2629L,2604L,2577L,3108L,3093L,3612L,3609L,4148L,4149L,4620L,4617L,5220L,5221L,5756L,5761L,6324L,6309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272846Inst : IEnumerable<long>
{
public static readonly long[] Value=A272846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272846.Bytes);
public long this[int i]=>Value[i];

public static A272846Inst Instance=new A272846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272847
{
public static readonly long[] Value={ 1L,6L,15L,40L,77L,126L,183L,288L,405L,558L,719L,948L,1201L,1498L,1787L,2204L,2601L,3146L,3731L,4392L,5101L,5846L,6583L,7532L,8441L,9514L,10547L,11856L,13141L,14566L,15855L,17512L,19021L,20902L,22887L,25156L,27393L,29842L,32379L,35104L,37797L,40750L,43679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272847Inst : IEnumerable<long>
{
public static readonly long[] Value=A272847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272847.Bytes);
public long this[int i]=>Value[i];

public static A272847Inst Instance=new A272847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272848
{
public static readonly long[] Value={ 1L,5L,22L,50L,107L,191L,316L,456L,649L,909L,1234L,1614L,2071L,2603L,3216L,3836L,4525L,5393L,6342L,7458L,8667L,10063L,11556L,13168L,14873L,16829L,18882L,21118L,23455L,26003L,28632L,31236L,33813L,36921L,40014L,43626L,47235L,51383L,55532L,60152L,64769L,69989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272848Inst : IEnumerable<long>
{
public static readonly long[] Value=A272848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272848.Bytes);
public long this[int i]=>Value[i];

public static A272848Inst Instance=new A272848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272849
{
public static readonly long[] Value={ 3L,13L,11L,29L,27L,41L,15L,53L,67L,65L,55L,77L,75L,81L,7L,69L,179L,81L,167L,93L,187L,97L,119L,93L,251L,97L,183L,101L,211L,81L,-25L,-27L,531L,-15L,519L,-3L,539L,1L,471L,-3L,603L,1L,535L,5L,563L,-15L,327L,-99L,827L,-95L,759L,-91L,787L,-111L,551L,-155L,915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272849Inst : IEnumerable<long>
{
public static readonly long[] Value=A272849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272849.Bytes);
public long this[int i]=>Value[i];

public static A272849Inst Instance=new A272849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272850
{
public static readonly long[] Value={ 1L,45L,325L,1225L,3321L,7381L,14365L,25425L,41905L,65341L,97461L,140185L,195625L,266085L,354061L,462241L,593505L,750925L,937765L,1157481L,1413721L,1710325L,2051325L,2440945L,2883601L,3383901L,3946645L,4576825L,5279625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272850Inst : IEnumerable<long>
{
public static readonly long[] Value=A272850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272850.Bytes);
public long this[int i]=>Value[i];

public static A272850Inst Instance=new A272850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272851
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,2L,3L,2L,3L,4L,3L,5L,3L,2L,3L,3L,2L,3L,3L,4L,4L,4L,4L,3L,5L,5L,3L,5L,3L,2L,3L,3L,4L,4L,2L,3L,3L,3L,4L,3L,4L,5L,4L,5L,4L,4L,4L,4L,3L,3L,5L,6L,5L,6L,4L,3L,5L,5L,3L,5L,3L,2L,3L,3L,3L,4L,4L,5L,4L,4L,3L,2L,3L,4L,3L,5L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272851Inst : IEnumerable<long>
{
public static readonly long[] Value=A272851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272851.Bytes);
public long this[int i]=>Value[i];

public static A272851Inst Instance=new A272851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272884
{
public static readonly long[] Value={ 1L,4L,81L,121L,144L,441L,484L,841L,1444L,8281L,11881L,14884L,28224L,48841L,114244L,128881L,142884L,221841L,228484L,848241L,1121481L,1281424L,1418481L,2184484L,2214144L,8282884L,11142244L,11282881L,18241441L,18818244L,18844281L,21242881L,21818241L,28281124L,82428241L,121242121L,121484484L,124121881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272884Inst : IEnumerable<long>
{
public static readonly long[] Value=A272884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272884.Bytes);
public long this[int i]=>Value[i];

public static A272884Inst Instance=new A272884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272885
{
public static readonly long[] Value={ 1729L,20683L,40033L,149389L,195841L,327763L,443889L,684019L,704977L,1845649L,2048391L,2418271L,2691451L,3242197L,3375001L,4342914L,4931101L,5318677L,5772403L,5799339L,6058747L,7620661L,8872487L,9443761L,10702783L,10765603L,13623913L,16387189L,16776487L,16983854L,17045567L,18406603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272885Inst : IEnumerable<long>
{
public static readonly long[] Value=A272885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272885.Bytes);
public long this[int i]=>Value[i];

public static A272885Inst Instance=new A272885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272886
{
public static readonly long[] Value={ 1L,3L,2L,3L,4L,4L,2L,4L,3L,4L,5L,4L,6L,4L,2L,4L,4L,3L,4L,4L,5L,5L,5L,5L,4L,6L,6L,4L,6L,4L,2L,4L,4L,5L,5L,3L,4L,4L,4L,5L,4L,5L,6L,5L,6L,5L,5L,5L,5L,4L,4L,6L,7L,6L,7L,5L,4L,6L,6L,4L,6L,4L,2L,4L,4L,4L,5L,5L,6L,5L,5L,4L,3L,4L,5L,4L,6L,4L,4L,5L,5L,4L,5L,5L,5L,6L,6L,6L,6L,6L,6L,5L,6L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272886Inst : IEnumerable<long>
{
public static readonly long[] Value=A272886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272886.Bytes);
public long this[int i]=>Value[i];

public static A272886Inst Instance=new A272886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272887
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,2L,3L,2L,2L,4L,1L,2L,4L,2L,2L,4L,4L,2L,2L,3L,2L,2L,4L,6L,3L,4L,2L,4L,4L,4L,1L,4L,4L,4L,6L,2L,2L,2L,4L,4L,6L,4L,2L,2L,6L,3L,2L,2L,4L,4L,6L,4L,3L,6L,4L,4L,8L,2L,2L,4L,2L,6L,4L,4L,2L,4L,2L,3L,4L,6L,4L,6L,2L,4L,4L,2L,8L,2L,4L,4L,8L,2L,4L,4L,4L,4L,9L,2L,8L,2L,6L,4L,2L,4L,4L,6L,8L,6L,2L,2L,2L,6L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272887Inst : IEnumerable<long>
{
public static readonly long[] Value=A272887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272887.Bytes);
public long this[int i]=>Value[i];

public static A272887Inst Instance=new A272887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272888
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,5L,1L,2L,5L,5L,4L,4L,5L,8L,2L,2L,8L,6L,4L,6L,9L,5L,3L,4L,5L,12L,9L,1L,11L,8L,4L,2L,8L,9L,8L,7L,6L,12L,1L,5L,14L,10L,4L,8L,15L,9L,3L,4L,8L,14L,11L,5L,11L,16L,2L,6L,11L,6L,11L,4L,13L,13L,1L,1L,16L,17L,6L,9L,13L,9L,5L,7L,9L,19L,12L,6L,17L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272888Inst : IEnumerable<long>
{
public static readonly long[] Value=A272888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272888.Bytes);
public long this[int i]=>Value[i];

public static A272888Inst Instance=new A272888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272889
{
public static readonly long[] Value={ 40033L,443889L,1845649L,2048391L,4342914L,5799339L,26122131L,32973759L,41301953L,45882739L,53226297L,54269091L,65272753L,66763333L,70449093L,84637287L,86316741L,90527229L,91140435L,94100426L,104212017L,127396178L,128966383L,131126303L,131997229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272889Inst : IEnumerable<long>
{
public static readonly long[] Value=A272889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272889.Bytes);
public long this[int i]=>Value[i];

public static A272889Inst Instance=new A272889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272890
{
public static readonly long[] Value={ 9L,36L,441L,576L,1296L,1764L,2025L,7569L,10404L,17424L,23409L,34596L,41616L,51984L,56169L,74529L,88209L,90000L,103041L,140625L,181476L,194481L,219024L,236196L,239121L,269361L,324900L,367236L,404496L,480249L,540225L,571536L,576081L,627264L,783225L,842724L,904401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272890Inst : IEnumerable<long>
{
public static readonly long[] Value=A272890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272890.Bytes);
public long this[int i]=>Value[i];

public static A272890Inst Instance=new A272890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272891
{
public static readonly BigInteger[] Value={ 2L,1L,3L,5L,15L,56L,385L,4565L,124754L,9289091L,2552338241L,3646072432125L,42748078035954696L,BigInteger.Parse("7274403582551733377346"),BigInteger.Parse("37285884524590579748861394570"),BigInteger.Parse("14531841772646818920248481411605550560"),BigInteger.Parse("1400135408797883233268006240578157606704308520406") };
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
public class A272891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272891Inst Instance=new A272891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272892
{
public static readonly long[] Value={ 32832L,513000L,2101248L,8647128L,43570872L,46661832L,152275032L,166383000L,175959000L,351981000L,543449088L,610991208L,809557632L,970168752L,1710972648L,2250265752L,2262814272L,2560837032L,3222013032L,3308144112L,3582836712L,4505949000L,4543936488L,4674301632L,4868489178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272892Inst : IEnumerable<long>
{
public static readonly long[] Value=A272892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272892.Bytes);
public long this[int i]=>Value[i];

public static A272892Inst Instance=new A272892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272893
{
public static readonly long[] Value={ 3L,2L,2L,2L,2L,3L,3L,3L,4L,4L,1L,4L,4L,5L,5L,5L,2L,1L,2L,5L,5L,5L,6L,2L,6L,6L,6L,3L,6L,2L,2L,3L,3L,6L,6L,3L,6L,7L,7L,7L,3L,3L,7L,7L,7L,7L,7L,4L,7L,3L,3L,3L,3L,3L,4L,4L,4L,4L,7L,7L,7L,4L,4L,7L,8L,8L,8L,8L,4L,8L,4L,8L,8L,4L,8L,8L,8L,5L,8L,8L,8L,5L,8L,8L,8L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272893Inst : IEnumerable<long>
{
public static readonly long[] Value=A272893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272893.Bytes);
public long this[int i]=>Value[i];

public static A272893Inst Instance=new A272893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272894
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,0L,1L,3L,2L,0L,1L,1L,2L,2L,0L,4L,3L,0L,2L,1L,1L,2L,1L,2L,3L,3L,1L,1L,2L,0L,2L,5L,4L,2L,3L,0L,1L,1L,2L,2L,1L,3L,2L,3L,1L,0L,1L,0L,4L,4L,0L,2L,3L,2L,0L,1L,1L,2L,3L,2L,0L,3L,1L,6L,5L,0L,4L,1L,2L,1L,3L,1L,1L,2L,3L,3L,2L,2L,2L,3L,0L,4L,3L,4L,2L,1L,1L,0L,3L,0L,2L,1L,3L,2L,1L,1L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272894Inst : IEnumerable<long>
{
public static readonly long[] Value=A272894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272894.Bytes);
public long this[int i]=>Value[i];

public static A272894Inst Instance=new A272894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272895
{
public static readonly long[] Value={ 0L,3L,4L,5L,5L,2L,6L,7L,6L,4L,3L,4L,7L,1L,8L,9L,8L,6L,3L,4L,6L,5L,1L,6L,8L,2L,6L,3L,9L,4L,10L,11L,10L,8L,4L,6L,5L,5L,5L,9L,6L,7L,2L,3L,8L,7L,3L,8L,9L,4L,8L,4L,4L,6L,4L,9L,10L,6L,7L,4L,11L,3L,12L,13L,12L,10L,5L,8L,8L,6L,6L,6L,5L,6L,6L,7L,3L,5L,10L,4L,8L,9L,0L,4L,8L,4L,5L,11L,8L,8L,3L,6L,10L,9L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272895Inst : IEnumerable<long>
{
public static readonly long[] Value=A272895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272895.Bytes);
public long this[int i]=>Value[i];

public static A272895Inst Instance=new A272895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272896
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,0L,0L,-2L,-1L,-1L,1L,-2L,-4L,-2L,0L,-1L,-1L,1L,2L,-4L,-4L,-1L,1L,-1L,-5L,2L,2L,-4L,1L,-3L,1L,0L,-4L,-2L,2L,3L,3L,1L,4L,-2L,2L,5L,3L,-1L,-5L,-2L,-2L,-2L,1L,-1L,3L,-4L,0L,2L,2L,-1L,-1L,5L,2L,2L,-4L,-3L,1L,-5L,-1L,0L,0L,-6L,3L,5L,5L,2L,-10L,-8L,2L,-3L,7L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272896Inst : IEnumerable<long>
{
public static readonly long[] Value=A272896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272896.Bytes);
public long this[int i]=>Value[i];

public static A272896Inst Instance=new A272896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272897
{
public static readonly long[] Value={ 19L,19L,19L,43L,19L,13L,43L,19L,37L,79L,19L,19L,79L,79L,43L,61L,79L,127L,19L,19L,13L,43L,109L,19L,37L,139L,43L,19L,37L,31L,79L,43L,19L,139L,127L,127L,13L,19L,19L,61L,103L,151L,409L,73L,181L,13L,277L,79L,43L,79L,79L,19L,43L,139L,61L,19L,61L,79L,103L,127L,19L,37L,79L,163L,79L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272897Inst : IEnumerable<long>
{
public static readonly long[] Value=A272897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272897.Bytes);
public long this[int i]=>Value[i];

public static A272897Inst Instance=new A272897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272898
{
public static readonly long[] Value={ 4L,5L,13L,30L,51L,64L,65L,77L,78L,130L,144L,171L,185L,199L,210L,239L,259L,263L,271L,296L,312L,369L,389L,391L,429L,437L,449L,457L,483L,490L,496L,498L,502L,551L,582L,583L,628L,648L,677L,709L,721L,744L,750L,776L,796L,874L,923L,943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272898Inst : IEnumerable<long>
{
public static readonly long[] Value=A272898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272898.Bytes);
public long this[int i]=>Value[i];

public static A272898Inst Instance=new A272898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272899
{
public static readonly BigInteger[] Value={ 2L,15L,385L,5005L,323323L,7436429L,955049953L,35336848261L,1448810778701L,62298863484143L,14107860812636383L,832363787945546597L,BigInteger.Parse("261682369333342226303"),BigInteger.Parse("18579448222667298067513"),BigInteger.Parse("1356299720254712758928449") };
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
public class A272899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272899Inst Instance=new A272899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272900
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,2L,1L,3L,2L,1L,3L,4L,2L,1L,3L,4L,2L,1L,3L,5L,4L,2L,1L,3L,5L,4L,2L,1L,3L,5L,6L,4L,2L,1L,3L,5L,6L,4L,2L,1L,3L,5L,7L,6L,4L,2L,1L,3L,5L,7L,6L,4L,2L,1L,3L,5L,7L,8L,6L,4L,2L,1L,3L,5L,7L,8L,6L,4L,2L,1L,3L,5L,7L,9L,8L,6L,4L,2L,1L,3L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272900Inst : IEnumerable<long>
{
public static readonly long[] Value=A272900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272900.Bytes);
public long this[int i]=>Value[i];

public static A272900Inst Instance=new A272900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272901
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272901Inst : IEnumerable<long>
{
public static readonly long[] Value=A272901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272901.Bytes);
public long this[int i]=>Value[i];

public static A272901Inst Instance=new A272901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272902
{
public static readonly long[] Value={ 1L,5L,9L,10L,15L,16L,20L,21L,23L,25L,29L,30L,32L,35L,37L,40L,42L,43L,44L,45L,49L,50L,51L,54L,55L,58L,60L,61L,65L,66L,68L,70L,72L,75L,76L,79L,80L,81L,83L,85L,86L,87L,89L,90L,93L,94L,95L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272902Inst : IEnumerable<long>
{
public static readonly long[] Value=A272902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272902.Bytes);
public long this[int i]=>Value[i];

public static A272902Inst Instance=new A272902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272903
{
public static readonly long[] Value={ 2L,0L,1L,1L,1L,1L,5L,1L,1L,1L,1L,2L,1L,2L,1L,1L,5L,2L,1L,1L,1L,4L,5L,1L,17L,1L,3L,1L,13L,1L,1L,2L,3L,2L,1L,2L,5L,1L,1L,4L,1L,2L,5L,1L,1L,1L,13L,1L,11L,1L,3L,5L,1L,1L,1L,1L,5L,7L,1L,1L,11L,2L,3L,1L,1L,1L,7L,1L,3L,1L,11L,3L,5L,2L,3L,1L,17L,3L,7L,4L,3L,7L,1L,3L,1L,1L,3L,2L,1L,3L,11L,2L,1L,1L,7L,1L,17L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272903Inst : IEnumerable<long>
{
public static readonly long[] Value=A272903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272903.Bytes);
public long this[int i]=>Value[i];

public static A272903Inst Instance=new A272903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272904
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,9L,11L,15L,7L,12L,14L,19L,23L,10L,16L,18L,24L,28L,34L,13L,20L,22L,29L,33L,40L,46L,17L,25L,27L,35L,39L,47L,53L,61L,21L,30L,32L,41L,45L,54L,60L,69L,77L,26L,36L,38L,48L,52L,62L,68L,78L,86L,96L,31L,42L,44L,55L,59L,70L,76L,87L,95L,106L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272904Inst : IEnumerable<long>
{
public static readonly long[] Value=A272904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272904.Bytes);
public long this[int i]=>Value[i];

public static A272904Inst Instance=new A272904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272905
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,15L,465L,19355L,1024380L,66462480L,5188446900L,480413448900L,52113339432000L,6551243302804200L,945313572845842200L,BigInteger.Parse("155243683741953807000"),BigInteger.Parse("28797215441570535960000"),BigInteger.Parse("5993001571565164940784000"),BigInteger.Parse("1390759438984816084192008000") };
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
public class A272905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272905Inst Instance=new A272905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272906
{
public static readonly long[] Value={ 1L,1L,2L,5L,19L,130L,1814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272906Inst : IEnumerable<long>
{
public static readonly long[] Value=A272906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272906.Bytes);
public long this[int i]=>Value[i];

public static A272906Inst Instance=new A272906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272907
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,4L,2L,3L,1L,4L,2L,3L,5L,1L,4L,2L,3L,5L,1L,4L,2L,3L,5L,1L,6L,4L,2L,3L,5L,1L,6L,4L,2L,3L,5L,7L,1L,6L,4L,2L,3L,5L,7L,1L,6L,4L,2L,3L,5L,7L,1L,8L,6L,4L,2L,3L,5L,7L,1L,8L,6L,4L,2L,3L,5L,7L,9L,1L,8L,6L,4L,2L,3L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272907Inst : IEnumerable<long>
{
public static readonly long[] Value=A272907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272907.Bytes);
public long this[int i]=>Value[i];

public static A272907Inst Instance=new A272907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272908
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,8L,4L,10L,11L,16L,6L,13L,14L,20L,23L,9L,17L,18L,25L,28L,35L,12L,21L,22L,30L,33L,41L,46L,15L,26L,27L,36L,39L,48L,53L,62L,19L,31L,32L,42L,45L,55L,60L,70L,77L,24L,37L,38L,49L,52L,63L,68L,79L,86L,97L,29L,43L,44L,56L,59L,71L,76L,88L,95L,107L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272908Inst : IEnumerable<long>
{
public static readonly long[] Value=A272908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272908.Bytes);
public long this[int i]=>Value[i];

public static A272908Inst Instance=new A272908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272909
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,11L,12L,16L,18L,21L,28L,29L,33L,44L,47L,49L,54L,72L,76L,77L,87L,116L,121L,123L,126L,141L,188L,198L,199L,203L,228L,304L,319L,322L,324L,329L,369L,492L,517L,521L,522L,532L,597L,796L,836L,841L,843L,846L,861L,966L,1288L,1353L,1363L,1364L,1368L,1393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272909Inst : IEnumerable<long>
{
public static readonly long[] Value=A272909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272909.Bytes);
public long this[int i]=>Value[i];

public static A272909Inst Instance=new A272909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272910
{
public static readonly long[] Value={ 19L,32L,93L,124L,208L,243L,308L,395L,427L,471L,603L,672L,1057L,1568L,1892L,2181L,2223L,2587L,3040L,3049L,4037L,4336L,5232L,5556L,6196L,6305L,6643L,8288L,8748L,10161L,10185L,10612L,10985L,12352L,13741L,14807L,16021L,17568L,20352L,20653L,24080L,27216L,27867L,31113L,31869L,32032L,32500L,36593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272910Inst : IEnumerable<long>
{
public static readonly long[] Value=A272910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272910.Bytes);
public long this[int i]=>Value[i];

public static A272910Inst Instance=new A272910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272911
{
public static readonly long[] Value={ 2L,1L,3L,2L,2L,1L,4L,2L,3L,7L,1L,4L,11L,3L,2L,5L,18L,4L,1L,10L,29L,5L,2L,3L,15L,47L,10L,1L,4L,25L,76L,15L,3L,2L,5L,40L,123L,25L,4L,1L,10L,65L,199L,40L,5L,2L,3L,15L,105L,322L,65L,10L,1L,4L,25L,170L,521L,105L,15L,3L,2L,5L,40L,275L,843L,170L,25L,4L,1L,10L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272911Inst : IEnumerable<long>
{
public static readonly long[] Value=A272911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272911.Bytes);
public long this[int i]=>Value[i];

public static A272911Inst Instance=new A272911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272912
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,5L,3L,8L,5L,13L,8L,21L,13L,34L,21L,55L,34L,89L,55L,144L,89L,233L,144L,377L,233L,610L,377L,987L,610L,1597L,987L,2584L,1597L,4181L,2584L,6765L,4181L,10946L,6765L,17711L,10946L,28657L,17711L,46368L,28657L,75025L,46368L,121393L,75025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272912Inst : IEnumerable<long>
{
public static readonly long[] Value=A272912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272912.Bytes);
public long this[int i]=>Value[i];

public static A272912Inst Instance=new A272912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272913
{
public static readonly BigInteger[] Value={ 0L,0L,6912L,2073600L,361267200L,48771072000L,5665247723520L,595732271726592L,58357447026278400L,5420989989833932800L,BigInteger.Parse("483204292920999936000"),BigInteger.Parse("41671538221507034480640"),BigInteger.Parse("3497929581885972295974912"),BigInteger.Parse("287077554068924493987840000"),BigInteger.Parse("23115688495680026711162880000") };
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
public class A272913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272913Inst Instance=new A272913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272914
{
public static readonly long[] Value={ 4096L,46656L,7529536L,16777216L,191102976L,308915776L,1544804416L,2176782336L,7256313856L,9474296896L,24794911296L,30840979456L,68719476736L,82653950016L,164206490176L,192699928576L,351298031616L,404567235136L,689869781056L,782757789696L,1265319018496L,1418519112256L,2194972623936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272914Inst : IEnumerable<long>
{
public static readonly long[] Value=A272914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272914.Bytes);
public long this[int i]=>Value[i];

public static A272914Inst Instance=new A272914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272915
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,11L,12L,14L,16L,18L,20L,22L,23L,25L,27L,29L,31L,33L,34L,36L,38L,40L,42L,44L,45L,47L,49L,51L,53L,55L,56L,58L,60L,62L,64L,66L,67L,69L,71L,73L,75L,77L,78L,80L,82L,84L,86L,88L,89L,91L,93L,95L,97L,99L,100L,102L,104L,106L,108L,110L,111L,113L,115L,117L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272915Inst : IEnumerable<long>
{
public static readonly long[] Value=A272915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272915.Bytes);
public long this[int i]=>Value[i];

public static A272915Inst Instance=new A272915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272932
{
public static readonly long[] Value={ 892L,1375L,7555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272932Inst : IEnumerable<long>
{
public static readonly long[] Value=A272932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272932.Bytes);
public long this[int i]=>Value[i];

public static A272932Inst Instance=new A272932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272933
{
public static readonly long[] Value={ 0L,1L,4L,9L,12L,13L,16L,21L,25L,28L,36L,37L,48L,49L,52L,57L,61L,64L,73L,76L,81L,84L,93L,97L,100L,108L,109L,112L,117L,121L,124L,129L,133L,144L,148L,156L,157L,169L,172L,181L,189L,192L,193L,196L,201L,208L,217L,225L,228L,229L,237L,241L,244L,252L,256L,268L,273L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272933Inst : IEnumerable<long>
{
public static readonly long[] Value=A272933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272933.Bytes);
public long this[int i]=>Value[i];

public static A272933Inst Instance=new A272933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272934
{
public static readonly long[] Value={ 1L,2L,6L,18L,42L,126L,162L,378L,486L,882L,1458L,2646L,3078L,3942L,5418L,9198L,11826L,14406L,16758L,18522L,24966L,26406L,37338L,39366L,42462L,71442L,77658L,95922L,99078L,113778L,117306L,143262L,174762L,175446L,184842L,265482L,304038L,308826L,318402L,351918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272934Inst : IEnumerable<long>
{
public static readonly long[] Value=A272934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272934.Bytes);
public long this[int i]=>Value[i];

public static A272934Inst Instance=new A272934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272935
{
public static readonly long[] Value={ 1729L,20683L,149389L,195841L,327763L,2418271L,6058747L,7620661L,9443761L,10765603L,13623913L,18406603L,32114143L,68007673L,105997327L,106243219L,166560193L,216226981L,446686147L,584504191L,813357253L,959281759L,1098597061L,1736913439L,2072769211L,2460483307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272935Inst : IEnumerable<long>
{
public static readonly long[] Value=A272935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272935.Bytes);
public long this[int i]=>Value[i];

public static A272935Inst Instance=new A272935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272936
{
public static readonly long[] Value={ 1L,4L,28L,160L,664L,2824L,11584L,45740L,187948L,753044L,3015908L,12077340L,48308716L,193233132L,772949112L,3092203836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272936Inst : IEnumerable<long>
{
public static readonly long[] Value=A272936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272936.Bytes);
public long this[int i]=>Value[i];

public static A272936Inst Instance=new A272936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272937
{
public static readonly long[] Value={ 1L,5L,22L,50L,111L,200L,321L,481L,714L,991L,1348L,1765L,2254L,2787L,3412L,4076L,4921L,5846L,6907L,8160L,9485L,10938L,12495L,14132L,16009L,18066L,20259L,22540L,24993L,27574L,30335L,33159L,36372L,39777L,43486L,47407L,51548L,55905L,60358L,65007L,69900L,75169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272937Inst : IEnumerable<long>
{
public static readonly long[] Value=A272937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272937.Bytes);
public long this[int i]=>Value[i];

public static A272937Inst Instance=new A272937Inst();

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