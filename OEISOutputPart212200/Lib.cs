using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A262862
{
public static readonly long[] Value={ 1L,5L,17L,93L,273L,1501L,4369L,24029L,69905L,384477L,1118481L,6151645L,17895697L,98426333L,286331153L,1574821341L,4581298449L,25197141469L,73300775185L,403154263517L,1172812402961L,6450468216285L,18764998447377L,103207491460573L,300239975158033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262862Inst : IEnumerable<long>
{
public static readonly long[] Value=A262862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262862.Bytes);
public long this[int i]=>Value[i];

public static A262862Inst Instance=new A262862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262863
{
public static readonly ulong[] Value={ 1L,10L,100L,1001L,10011L,100110L,1001100L,10011001L,100110011L,1001100110L,10011001100L,100110011001L,1001100110011L,10011001100110L,100110011001100L,1001100110011001L,10011001100110011L,100110011001100110L,1001100110011001100L,10011001100110011001UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262863Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A262863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262863.Bytes);
public ulong this[int i]=>Value[i];

public static A262863Inst Instance=new A262863Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262864
{
public static readonly long[] Value={ 1L,2L,4L,9L,19L,38L,76L,153L,307L,614L,1228L,2457L,4915L,9830L,19660L,39321L,78643L,157286L,314572L,629145L,1258291L,2516582L,5033164L,10066329L,20132659L,40265318L,80530636L,161061273L,322122547L,644245094L,1288490188L,2576980377L,5153960755L,10307921510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262864Inst : IEnumerable<long>
{
public static readonly long[] Value=A262864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262864.Bytes);
public long this[int i]=>Value[i];

public static A262864Inst Instance=new A262864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262865
{
public static readonly BigInteger[] Value={ 1L,1L,1011L,111L,11101111L,110011111L,101010111111L,1111111L,1111111011111111L,11111100111111111L,10111110101111111111UL,1111000011111111111L,BigInteger.Parse("111011101110111111111111"),BigInteger.Parse("1100110011001111111111111"),BigInteger.Parse("1010101010101011111111111111"),111111111111111L };
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
public class A262865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262865Inst Instance=new A262865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262866
{
public static readonly long[] Value={ 1L,1L,11L,7L,239L,415L,2751L,127L,65279L,129535L,781311L,493567L,15659007L,26845183L,178962431L,32767L,4294901759L,8589541375L,51538296831L,34351874047L,1030774325247L,1786599440383L,11819393482751L,547616718847L,280371153338367L,556327013187583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262866Inst : IEnumerable<long>
{
public static readonly long[] Value=A262866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262866.Bytes);
public long this[int i]=>Value[i];

public static A262866Inst Instance=new A262866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262867
{
public static readonly long[] Value={ 1L,2L,5L,8L,15L,22L,31L,38L,53L,68L,85L,100L,121L,140L,161L,176L,207L,238L,271L,302L,339L,374L,411L,442L,487L,530L,575L,614L,663L,706L,751L,782L,845L,908L,973L,1036L,1105L,1172L,1241L,1304L,1381L,1456L,1533L,1604L,1685L,1760L,1837L,1900L,1993L,2084L,2177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262867Inst : IEnumerable<long>
{
public static readonly long[] Value=A262867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262867.Bytes);
public long this[int i]=>Value[i];

public static A262867Inst Instance=new A262867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262868
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,3L,3L,3L,3L,4L,3L,4L,4L,5L,5L,6L,6L,7L,6L,7L,7L,8L,8L,8L,8L,8L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,14L,14L,14L,15L,15L,15L,15L,16L,15L,16L,16L,17L,17L,18L,18L,19L,18L,19L,19L,19L,19L,20L,20L,21L,20L,21L,21L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262868Inst : IEnumerable<long>
{
public static readonly long[] Value=A262868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262868.Bytes);
public long this[int i]=>Value[i];

public static A262868Inst Instance=new A262868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262869
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,18L,18L,19L,19L,20L,20L,20L,20L,21L,21L,22L,22L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262869Inst : IEnumerable<long>
{
public static readonly long[] Value=A262869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262869.Bytes);
public long this[int i]=>Value[i];

public static A262869Inst Instance=new A262869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262870
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,8L,11L,18L,18L,18L,23L,34L,28L,41L,48L,63L,63L,80L,80L,99L,89L,110L,121L,144L,144L,144L,157L,157L,143L,172L,187L,218L,218L,251L,268L,303L,303L,340L,359L,398L,398L,439L,460L,503L,481L,481L,504L,551L,551L,551L,551L,602L,576L,629L,629L,684L,684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262870Inst : IEnumerable<long>
{
public static readonly long[] Value=A262870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262870.Bytes);
public long this[int i]=>Value[i];

public static A262870Inst Instance=new A262870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262871
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,6L,6L,6L,6L,11L,11L,17L,17L,24L,24L,24L,24L,24L,24L,34L,34L,45L,45L,45L,45L,58L,58L,72L,72L,87L,87L,87L,87L,104L,104L,104L,104L,123L,123L,123L,123L,144L,144L,166L,166L,189L,189L,189L,189L,189L,189L,215L,215L,215L,215L,215L,215L,244L,244L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262871Inst : IEnumerable<long>
{
public static readonly long[] Value=A262871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262871.Bytes);
public long this[int i]=>Value[i];

public static A262871Inst Instance=new A262871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262872
{
public static readonly long[] Value={ 1L,3L,4L,4L,5L,6L,6L,6L,7L,9L,10L,10L,11L,11L,11L,11L,12L,14L,14L,14L,14L,14L,14L,14L,15L,16L,17L,18L,19L,19L,19L,20L,20L,21L,21L,21L,23L,24L,24L,24L,24L,24L,24L,25L,26L,26L,26L,26L,26L,27L,28L,28L,29L,29L,29L,29L,29L,30L,30L,30L,30L,30L,30L,31L,32L,33L,33L,33L,34L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262872Inst : IEnumerable<long>
{
public static readonly long[] Value=A262872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262872.Bytes);
public long this[int i]=>Value[i];

public static A262872Inst Instance=new A262872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262873
{
public static readonly long[] Value={ 504L,756L,806L,868L,1008L,1148L,1176L,1209L,1472L,1475L,1512L,1638L,1708L,2016L,2184L,2208L,2418L,2548L,2730L,2772L,2924L,3024L,3388L,4416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262873Inst : IEnumerable<long>
{
public static readonly long[] Value=A262873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262873.Bytes);
public long this[int i]=>Value[i];

public static A262873Inst Instance=new A262873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262874
{
public static readonly long[] Value={ 1L,4L,7L,8L,9L,11L,12L,12L,13L,16L,19L,20L,21L,22L,22L,22L,24L,29L,32L,32L,33L,34L,34L,34L,36L,40L,43L,45L,48L,49L,49L,50L,52L,55L,56L,56L,58L,61L,62L,62L,63L,64L,65L,67L,70L,71L,71L,72L,72L,74L,76L,77L,80L,82L,82L,82L,82L,83L,84L,85L,86L,86L,86L,87L,89L,92L,94L,94L,96L,97L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262874Inst : IEnumerable<long>
{
public static readonly long[] Value=A262874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262874.Bytes);
public long this[int i]=>Value[i];

public static A262874Inst Instance=new A262874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262875
{
public static readonly long[] Value={ 0L,1L,4L,14L,41L,127L,400L,1297L,4520L,17064L,64857L,262286L,1156325L,5199261L,23835336L,117674608L,609741279L,3268286263L,18109939168L,102866828839L,620474818814L,4005211833858L,25747541532731L,166978138395205L,1168773990780772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262875Inst : IEnumerable<long>
{
public static readonly long[] Value=A262875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262875.Bytes);
public long this[int i]=>Value[i];

public static A262875Inst Instance=new A262875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262876
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,1L,2L,4L,2L,7L,6L,7L,12L,12L,16L,26L,22L,35L,44L,47L,68L,84L,88L,133L,146L,176L,238L,267L,324L,431L,468L,604L,746L,842L,1068L,1296L,1470L,1884L,2202L,2579L,3220L,3753L,4418L,5483L,6294L,7541L,9144L,10554L,12644L,15191L,17480L,21057L,24896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262876Inst : IEnumerable<long>
{
public static readonly long[] Value=A262876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262876.Bytes);
public long this[int i]=>Value[i];

public static A262876Inst Instance=new A262876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262877
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,3L,6L,9L,9L,13L,19L,23L,28L,42L,51L,62L,84L,108L,127L,170L,219L,261L,328L,427L,512L,632L,807L,987L,1190L,1504L,1838L,2214L,2744L,3374L,4036L,4950L,6060L,7260L,8793L,10748L,12853L,15459L,18766L,22473L,26834L,32425L,38768L,46136L,55376L,66168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262877Inst : IEnumerable<long>
{
public static readonly long[] Value=A262877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262877.Bytes);
public long this[int i]=>Value[i];

public static A262877Inst Instance=new A262877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262878
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,2L,3L,0L,4L,4L,1L,10L,5L,6L,16L,6L,14L,28L,10L,32L,40L,18L,63L,60L,42L,112L,83L,84L,187L,124L,172L,300L,186L,320L,456L,302L,581L,684L,507L,982L,1004L,874L,1624L,1476L,1508L,2566L,2174L,2582L,3981L,3262L,4338L,6002L,4945L,7138L,8947L,7660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262878Inst : IEnumerable<long>
{
public static readonly long[] Value=A262878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262878.Bytes);
public long this[int i]=>Value[i];

public static A262878Inst Instance=new A262878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262879
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,2L,0L,3L,4L,1L,4L,10L,6L,5L,16L,14L,9L,28L,32L,17L,40L,63L,41L,63L,112L,83L,94L,187L,171L,156L,301L,319L,260L,467L,580L,465L,713L,981L,818L,1095L,1627L,1452L,1682L,2584L,2510L,2632L,4047L,4266L,4162L,6181L,7054L,6685L,9396L,11423L,10753L,14132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262879Inst : IEnumerable<long>
{
public static readonly long[] Value=A262879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262879.Bytes);
public long this[int i]=>Value[i];

public static A262879Inst Instance=new A262879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262880
{
public static readonly long[] Value={ 1L,1L,3L,2L,3L,2L,2L,2L,2L,3L,3L,4L,2L,3L,2L,2L,5L,3L,6L,2L,4L,3L,4L,4L,3L,4L,2L,5L,3L,6L,7L,4L,5L,2L,3L,4L,5L,8L,6L,4L,1L,2L,2L,5L,7L,6L,6L,2L,3L,3L,1L,5L,5L,5L,5L,5L,8L,5L,4L,4L,5L,3L,6L,6L,7L,8L,3L,6L,6L,5L,9L,6L,9L,3L,7L,5L,7L,3L,5L,9L,3L,11L,6L,9L,5L,3L,7L,4L,4L,7L,9L,8L,5L,8L,7L,7L,2L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262880Inst : IEnumerable<long>
{
public static readonly long[] Value=A262880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262880.Bytes);
public long this[int i]=>Value[i];

public static A262880Inst Instance=new A262880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262881
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,4L,3L,0L,1L,2L,4L,3L,5L,0L,1L,2L,4L,3L,5L,6L,0L,1L,2L,4L,3L,5L,6L,7L,0L,1L,2L,4L,8L,3L,5L,6L,7L,0L,1L,2L,4L,8L,3L,5L,6L,9L,7L,0L,1L,2L,4L,8L,3L,5L,6L,9L,10L,7L,0L,1L,2L,4L,8L,3L,5L,6L,9L,10L,7L,11L,0L,1L,2L,4L,8L,3L,5L,6L,9L,10L,12L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262881Inst : IEnumerable<long>
{
public static readonly long[] Value=A262881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262881.Bytes);
public long this[int i]=>Value[i];

public static A262881Inst Instance=new A262881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262882
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,5L,6L,7L,7L,7L,7L,11L,11L,13L,14L,15L,15L,15L,15L,15L,15L,15L,15L,23L,23L,23L,23L,27L,27L,29L,30L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,47L,47L,47L,47L,47L,47L,47L,47L,55L,55L,55L,55L,59L,59L,61L,62L,63L,63L,63L,63L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262882Inst : IEnumerable<long>
{
public static readonly long[] Value=A262882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262882.Bytes);
public long this[int i]=>Value[i];

public static A262882Inst Instance=new A262882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262883
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,7L,10L,15L,24L,33L,49L,68L,100L,136L,193L,267L,370L,501L,690L,928L,1260L,1687L,2265L,3007L,4006L,5289L,6987L,9163L,12033L,15698L,20469L,26572L,34470L,44510L,57442L,73861L,94852L,121439L,155287L,198007L,252165L,320335L,406396L,514410L,650288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262883Inst : IEnumerable<long>
{
public static readonly long[] Value=A262883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262883.Bytes);
public long this[int i]=>Value[i];

public static A262883Inst Instance=new A262883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262884
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,4L,7L,9L,11L,16L,23L,31L,40L,53L,71L,91L,121L,161L,206L,264L,343L,441L,563L,725L,922L,1166L,1476L,1869L,2357L,2967L,3725L,4659L,5816L,7263L,9050L,11241L,13947L,17269L,21333L,26342L,32479L,39957L,49094L,60231L,73775L,90273L,110333L,134643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262884Inst : IEnumerable<long>
{
public static readonly long[] Value=A262884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262884.Bytes);
public long this[int i]=>Value[i];

public static A262884Inst Instance=new A262884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262885
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,3L,2L,1L,1L,2L,2L,3L,3L,2L,1L,1L,2L,2L,3L,4L,3L,1L,1L,1L,2L,2L,3L,4L,4L,3L,1L,1L,1L,2L,2L,3L,4L,5L,4L,3L,1L,1L,1L,2L,2L,3L,4L,5L,5L,5L,3L,1L,1L,2L,2L,3L,4L,5L,6L,6L,5L,2L,1L,1L,2L,2L,3L,4L,5L,6L,7L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262885Inst : IEnumerable<long>
{
public static readonly long[] Value=A262885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262885.Bytes);
public long this[int i]=>Value[i];

public static A262885Inst Instance=new A262885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262886
{
public static readonly long[] Value={ -2L,0L,6L,0L,0L,24L,0L,0L,4L,118L,0L,0L,0L,60L,696L,0L,0L,0L,12L,720L,4824L,0L,0L,0L,0L,336L,8288L,38240L,0L,0L,0L,0L,60L,6516L,95928L,336822L,0L,0L,0L,0L,0L,2520L,109872L,1131732L,3215544L,0L,0L,0L,0L,0L,392L,67904L,1735320L,13647840L,32651544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262886Inst : IEnumerable<long>
{
public static readonly long[] Value=A262886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262886.Bytes);
public long this[int i]=>Value[i];

public static A262886Inst Instance=new A262886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262887
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,4L,5L,3L,3L,3L,4L,2L,3L,5L,4L,3L,2L,4L,1L,2L,5L,6L,6L,3L,5L,3L,2L,4L,5L,8L,4L,5L,4L,4L,2L,2L,7L,5L,5L,4L,4L,3L,3L,5L,4L,5L,4L,4L,7L,5L,5L,1L,4L,3L,3L,8L,4L,5L,3L,4L,4L,7L,8L,5L,9L,7L,3L,1L,5L,8L,5L,4L,6L,5L,6L,4L,9L,8L,4L,2L,5L,6L,4L,4L,7L,8L,3L,9L,5L,5L,2L,6L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262887Inst : IEnumerable<long>
{
public static readonly long[] Value=A262887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262887.Bytes);
public long this[int i]=>Value[i];

public static A262887Inst Instance=new A262887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262888
{
public static readonly long[] Value={ 6L,0L,41L,0L,0L,5L,0L,16L,0L,2L,0L,0L,1L,24L,4L,0L,0L,0L,0L,0L,0L,0L,105L,2L,0L,0L,0L,3L,18L,7L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,13L,1L,0L,0L,0L,0L,6L,1L,0L,0L,0L,47L,0L,0L,0L,90L,0L,0L,5L,0L,0L,0L,1L,0L,0L,12L,0L,0L,3L,61L,0L,0L,0L,0L,0L,0L,1L,117L,7L,0L,2L,10L,0L,0L,1L,23L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,2L,2L,2L,568L,0L,1L,1L,4L,0L,5L,9L,0L,0L,0L,0L,0L,8L,0L,1L,1L,0L,2L,10L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262888Inst : IEnumerable<long>
{
public static readonly long[] Value=A262888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262888.Bytes);
public long this[int i]=>Value[i];

public static A262888Inst Instance=new A262888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262889
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,3L,0L,1L,13L,0L,0L,0L,1L,1L,2L,2L,0L,0L,0L,0L,0L,0L,2L,3L,0L,0L,5L,0L,4L,0L,1L,7L,0L,0L,7L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,5L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,3L,0L,22L,1L,0L,1L,2L,0L,6L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262889Inst : IEnumerable<long>
{
public static readonly long[] Value=A262889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262889.Bytes);
public long this[int i]=>Value[i];

public static A262889Inst Instance=new A262889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262890
{
public static readonly long[] Value={ 6L,0L,41L,0L,0L,5L,0L,16L,0L,2L,0L,1L,1L,26L,4L,0L,0L,3L,0L,1L,13L,0L,105L,2L,1L,1L,2L,5L,18L,7L,0L,0L,0L,1L,3L,3L,0L,0L,5L,0L,4L,13L,2L,7L,0L,0L,7L,6L,1L,0L,0L,0L,53L,0L,0L,0L,90L,1L,0L,5L,0L,2L,0L,1L,1L,0L,12L,1L,0L,3L,61L,0L,0L,0L,0L,0L,0L,2L,117L,7L,0L,2L,10L,0L,0L,1L,23L,1L,1L,1L,0L,0L,1L,0L,5L,1L,0L,3L,2L,2L,568L,1L,1L,1L,4L,1L,5L,9L,3L,0L,22L,1L,0L,9L,2L,1L,7L,0L,2L,10L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262890Inst : IEnumerable<long>
{
public static readonly long[] Value=A262890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262890.Bytes);
public long this[int i]=>Value[i];

public static A262890Inst Instance=new A262890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262891
{
public static readonly long[] Value={ 2L,1L,3L,1L,1L,4L,1L,2L,1L,3L,1L,2L,2L,4L,2L,1L,1L,3L,1L,2L,3L,1L,2L,3L,2L,2L,3L,4L,2L,2L,1L,1L,1L,2L,3L,2L,1L,1L,2L,1L,2L,2L,3L,3L,1L,1L,3L,2L,2L,1L,1L,1L,4L,1L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,3L,2L,1L,1L,1L,1L,1L,1L,3L,2L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,2L,1L,3L,2L,2L,4L,2L,2L,2L,3L,2L,2L,3L,2L,1L,2L,2L,1L,3L,2L,2L,3L,1L,2L,3L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262891Inst : IEnumerable<long>
{
public static readonly long[] Value=A262891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262891.Bytes);
public long this[int i]=>Value[i];

public static A262891Inst Instance=new A262891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262892
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,15L,16L,18L,21L,30L,31L,32L,36L,37L,39L,44L,45L,49L,50L,51L,53L,54L,55L,58L,60L,62L,65L,68L,71L,72L,73L,74L,75L,76L,80L,83L,84L,90L,91L,93L,96L,109L,112L,117L,122L,123L,124L,126L,127L,131L,134L,135L,137L,141L,142L,144L,145L,147L,149L,152L,154L,155L,161L,162L,165L,166L,170L,178L,187L,189L,190L,191L,193L,195L,199L,201L,203L,205L,211L,212L,213L,219L,223L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262892Inst : IEnumerable<long>
{
public static readonly long[] Value=A262892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262892.Bytes);
public long this[int i]=>Value[i];

public static A262892Inst Instance=new A262892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262893
{
public static readonly long[] Value={ 6L,6L,47L,47L,47L,52L,52L,68L,68L,70L,70L,71L,72L,98L,102L,102L,102L,105L,105L,106L,119L,119L,224L,226L,227L,228L,230L,235L,253L,260L,260L,260L,260L,261L,264L,267L,267L,267L,272L,272L,276L,289L,291L,298L,298L,298L,305L,311L,312L,312L,312L,312L,365L,365L,365L,365L,455L,456L,456L,461L,461L,463L,463L,464L,465L,465L,477L,478L,478L,481L,542L,542L,542L,542L,542L,542L,542L,544L,661L,668L,668L,670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262893Inst : IEnumerable<long>
{
public static readonly long[] Value=A262893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262893.Bytes);
public long this[int i]=>Value[i];

public static A262893Inst Instance=new A262893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262894
{
public static readonly long[] Value={ 6L,0L,41L,0L,0L,5L,0L,16L,0L,2L,0L,-1L,1L,22L,4L,0L,0L,-3L,0L,-1L,-13L,0L,105L,2L,-1L,-1L,-2L,1L,18L,7L,0L,0L,0L,1L,-1L,-3L,0L,0L,-5L,0L,-4L,13L,0L,-7L,0L,0L,-7L,6L,1L,0L,0L,0L,41L,0L,0L,0L,90L,-1L,0L,5L,0L,-2L,0L,1L,-1L,0L,12L,-1L,0L,3L,61L,0L,0L,0L,0L,0L,0L,0L,117L,7L,0L,2L,10L,0L,0L,1L,23L,-1L,1L,1L,0L,0L,1L,0L,-5L,-1L,0L,1L,2L,2L,568L,-1L,1L,1L,4L,-1L,5L,9L,-3L,0L,-22L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262894Inst : IEnumerable<long>
{
public static readonly long[] Value=A262894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262894.Bytes);
public long this[int i]=>Value[i];

public static A262894Inst Instance=new A262894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262895
{
public static readonly long[] Value={ 6L,6L,47L,47L,47L,52L,52L,68L,68L,70L,70L,69L,70L,92L,96L,96L,96L,93L,93L,92L,79L,79L,184L,186L,185L,184L,182L,183L,201L,208L,208L,208L,208L,209L,208L,205L,205L,205L,200L,200L,196L,209L,209L,202L,202L,202L,195L,201L,202L,202L,202L,202L,243L,243L,243L,243L,333L,332L,332L,337L,337L,335L,335L,336L,335L,335L,347L,346L,346L,349L,410L,410L,410L,410L,410L,410L,410L,410L,527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262895Inst : IEnumerable<long>
{
public static readonly long[] Value=A262895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262895.Bytes);
public long this[int i]=>Value[i];

public static A262895Inst Instance=new A262895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262896
{
public static readonly long[] Value={ 8L,2L,79L,12L,18L,40L,30L,140L,42L,52L,54L,66L,68L,123L,98L,90L,94L,116L,106L,126L,164L,121L,369L,133L,156L,168L,180L,184L,280L,229L,190L,194L,210L,218L,252L,246L,236L,242L,272L,254L,312L,324L,300L,364L,298L,302L,372L,356L,334L,342L,346L,354L,439L,366L,374L,390L,672L,414L,410L,438L,426L,460L,442L,452L,470L,466L,564L,496L,494L,524L,627L,530L,546L,558L,562L,566L,574L,592L,859L,660L,606L,642L,708L,650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262896Inst : IEnumerable<long>
{
public static readonly long[] Value=A262896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262896.Bytes);
public long this[int i]=>Value[i];

public static A262896Inst Instance=new A262896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262897
{
public static readonly long[] Value={ 2L,12L,18L,30L,42L,54L,90L,94L,106L,121L,190L,194L,210L,236L,242L,254L,298L,302L,342L,346L,354L,366L,374L,390L,410L,426L,442L,466L,494L,530L,546L,558L,562L,566L,574L,606L,650L,658L,710L,716L,730L,746L,914L,942L,986L,1030L,1038L,1042L,1052L,1058L,1090L,1114L,1134L,1146L,1240L,1250L,1266L,1278L,1286L,1310L,1354L,1370L,1378L,1418L,1426L,1450L,1454L,1490L,1562L,1650L,1662L,1670L,1676L,1694L,1706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262897Inst : IEnumerable<long>
{
public static readonly long[] Value=A262897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262897.Bytes);
public long this[int i]=>Value[i];

public static A262897Inst Instance=new A262897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262898
{
public static readonly long[] Value={ 7L,8L,5L,13L,4L,3L,19L,11L,1L,1L,20L,17L,9L,0L,0L,24L,14L,15L,6L,0L,0L,25L,16L,10L,11L,2L,0L,0L,28L,22L,11L,6L,9L,0L,0L,0L,33L,22L,18L,9L,2L,6L,0L,0L,0L,36L,29L,18L,12L,6L,0L,2L,0L,0L,0L,37L,27L,27L,12L,6L,2L,0L,0L,0L,0L,0L,40L,35L,23L,23L,6L,2L,0L,0L,0L,0L,0L,0L,43L,32L,31L,21L,21L,2L,0L,0L,0L,0L,0L,0L,0L,49L,41L,26L,29L,17L,17L,0L,0L,0L,0L,0L,0L,0L,0L,50L,46L,39L,22L,27L,15L,15L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262898Inst : IEnumerable<long>
{
public static readonly long[] Value=A262898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262898.Bytes);
public long this[int i]=>Value[i];

public static A262898Inst Instance=new A262898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262899
{
public static readonly long[] Value={ 7L,5L,8L,3L,4L,13L,1L,1L,11L,19L,0L,0L,9L,17L,20L,0L,0L,6L,15L,14L,24L,0L,0L,2L,11L,10L,16L,25L,0L,0L,0L,9L,6L,11L,22L,28L,0L,0L,0L,6L,2L,9L,18L,22L,33L,0L,0L,0L,2L,0L,6L,12L,18L,29L,36L,0L,0L,0L,0L,0L,2L,6L,12L,27L,27L,37L,0L,0L,0L,0L,0L,0L,2L,6L,23L,23L,35L,40L,0L,0L,0L,0L,0L,0L,0L,2L,21L,21L,31L,32L,43L,0L,0L,0L,0L,0L,0L,0L,0L,17L,17L,29L,26L,41L,49L,0L,0L,0L,0L,0L,0L,0L,0L,15L,15L,27L,22L,39L,46L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262899Inst : IEnumerable<long>
{
public static readonly long[] Value=A262899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262899.Bytes);
public long this[int i]=>Value[i];

public static A262899Inst Instance=new A262899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262900
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262900Inst : IEnumerable<long>
{
public static readonly long[] Value=A262900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262900.Bytes);
public long this[int i]=>Value[i];

public static A262900Inst Instance=new A262900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262901
{
public static readonly long[] Value={ 4L,5L,11L,14L,16L,17L,22L,27L,29L,32L,35L,41L,44L,46L,48L,51L,57L,58L,62L,65L,69L,70L,77L,80L,81L,91L,92L,96L,101L,102L,107L,110L,111L,114L,118L,119L,120L,128L,129L,130L,138L,139L,141L,144L,147L,148L,152L,155L,158L,161L,162L,165L,166L,169L,176L,181L,187L,191L,192L,199L,201L,214L,215L,216L,222L,224L,227L,231L,234L,238L,239L,247L,248L,249L,255L,258L,262L,264L,269L,277L,278L,282L,286L,291L,294L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262901Inst : IEnumerable<long>
{
public static readonly long[] Value=A262901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262901.Bytes);
public long this[int i]=>Value[i];

public static A262901Inst Instance=new A262901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262902
{
public static readonly long[] Value={ 5L,4L,11L,17L,14L,16L,22L,22L,29L,27L,35L,32L,41L,46L,44L,46L,51L,48L,57L,57L,58L,65L,62L,70L,69L,77L,81L,80L,92L,91L,101L,96L,107L,102L,111L,110L,111L,119L,118L,114L,129L,120L,129L,130L,128L,128L,139L,141L,138L,147L,144L,155L,148L,161L,158L,165L,152L,162L,166L,169L,162L,176L,181L,191L,187L,199L,192L,201L,214L,215L,222L,216L,227L,224L,231L,239L,238L,238L,249L,234L,249L,247L,255L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262902Inst : IEnumerable<long>
{
public static readonly long[] Value=A262902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262902.Bytes);
public long this[int i]=>Value[i];

public static A262902Inst Instance=new A262902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262903
{
public static readonly long[] Value={ 4L,5L,14L,16L,32L,41L,44L,77L,80L,92L,101L,110L,119L,128L,139L,148L,158L,161L,169L,176L,191L,192L,199L,215L,224L,227L,234L,238L,249L,262L,264L,277L,296L,311L,317L,327L,350L,351L,352L,360L,363L,382L,385L,389L,392L,395L,396L,411L,427L,430L,437L,448L,449L,461L,464L,483L,488L,518L,523L,531L,532L,542L,552L,561L,568L,570L,577L,579L,600L,601L,613L,619L,632L,634L,636L,645L,648L,659L,665L,666L,671L,682L,683L,696L,705L,723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262903Inst : IEnumerable<long>
{
public static readonly long[] Value=A262903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262903.Bytes);
public long this[int i]=>Value[i];

public static A262903Inst Instance=new A262903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262904
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,2L,0L,0L,2L,2L,2L,3L,2L,2L,2L,2L,2L,4L,2L,2L,2L,5L,2L,2L,5L,5L,2L,5L,2L,6L,2L,5L,2L,7L,2L,2L,2L,7L,2L,5L,2L,8L,2L,7L,2L,9L,2L,7L,9L,7L,2L,9L,2L,10L,2L,7L,2L,11L,2L,7L,2L,12L,2L,2L,2L,11L,2L,12L,2L,13L,2L,7L,2L,13L,2L,13L,2L,14L,2L,13L,13L,14L,13L,7L,13L,14L,13L,13L,13L,15L,13L,14L,13L,16L,13L,7L,13L,14L,13L,13L,13L,17L,13L,7L,13L,18L,13L,7L,13L,17L,13L,17L,13L,19L,13L,17L,13L,20L,13L,7L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262904Inst : IEnumerable<long>
{
public static readonly long[] Value=A262904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262904.Bytes);
public long this[int i]=>Value[i];

public static A262904Inst Instance=new A262904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262905
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,1L,3L,1L,1L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,3L,2L,3L,4L,3L,2L,3L,2L,3L,3L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,2L,4L,2L,3L,4L,3L,4L,3L,2L,3L,4L,3L,2L,3L,3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,4L,4L,4L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,2L,4L,4L,4L,4L,4L,4L,4L,2L,4L,3L,4L,2L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262905Inst : IEnumerable<long>
{
public static readonly long[] Value=A262905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262905.Bytes);
public long this[int i]=>Value[i];

public static A262905Inst Instance=new A262905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262906
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,5L,4L,7L,8L,7L,8L,9L,9L,11L,12L,13L,14L,15L,14L,17L,18L,19L,17L,21L,22L,20L,21L,25L,23L,27L,24L,29L,27L,31L,27L,33L,34L,35L,31L,37L,35L,39L,34L,41L,37L,43L,37L,45L,41L,40L,43L,49L,43L,51L,44L,53L,49L,55L,47L,57L,53L,59L,50L,61L,62L,63L,55L,65L,56L,67L,57L,69L,65L,71L,61L,73L,63L,75L,64L,77L,67L,68L,68L,70L,77L,72L,72L,74L,75L,76L,75L,78L,78L,80L,78L,82L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262906Inst : IEnumerable<long>
{
public static readonly long[] Value=A262906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262906.Bytes);
public long this[int i]=>Value[i];

public static A262906Inst Instance=new A262906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262907
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,4L,6L,5L,7L,6L,8L,7L,6L,8L,7L,9L,8L,8L,9L,8L,10L,8L,11L,9L,12L,10L,13L,12L,14L,9L,15L,13L,16L,13L,17L,15L,13L,16L,14L,16L,15L,14L,16L,14L,17L,18L,18L,16L,19L,17L,20L,18L,21L,17L,22L,15L,23L,18L,24L,22L,25L,20L,26L,21L,27L,19L,28L,23L,16L,16L,19L,28L,23L,23L,21L,27L,22L,27L,20L,20L,24L,20L,17L,23L,29L,29L,24L,22L,28L,24L,28L,30L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262907Inst : IEnumerable<long>
{
public static readonly long[] Value=A262907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262907.Bytes);
public long this[int i]=>Value[i];

public static A262907Inst Instance=new A262907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262908
{
public static readonly long[] Value={ 53L,49L,69L,55L,53L,31L,47L,39L,25L,35L,31L,39L,37L,51L,33L,43L,33L,69L,65L,57L,43L,41L,57L,49L,33L,33L,43L,41L,37L,33L,37L,39L,35L,27L,41L,27L,43L,75L,177L,171L,173L,155L,45L,133L,107L,121L,111L,139L,78L,119L,123L,47L,65L,79L,77L,97L,81L,151L,149L,145L,111L,197L,375L,71L,59L,81L,259L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262908Inst : IEnumerable<long>
{
public static readonly long[] Value=A262908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262908.Bytes);
public long this[int i]=>Value[i];

public static A262908Inst Instance=new A262908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262909
{
public static readonly long[] Value={ 5197L,5193L,5177L,5115L,5113L,4419L,4417L,4259L,4245L,4243L,4239L,4059L,4047L,3991L,3941L,3633L,3593L,3449L,3445L,3437L,3423L,3421L,2897L,2789L,2517L,2261L,2079L,2077L,2067L,2063L,1527L,1379L,1135L,1127L,1117L,1103L,1083L,575L,23457L,23451L,21689L,21671L,20241L,19003L,18977L,18649L,18063L,18019L,14853L,14159L,13659L,12707L,11681L,10993L,10991L,10297L,10281L,9151L,9149L,9145L,9111L,8897L,8535L,8147L,6835L,6813L,5539L,5537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262909Inst : IEnumerable<long>
{
public static readonly long[] Value=A262909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262909.Bytes);
public long this[int i]=>Value[i];

public static A262909Inst Instance=new A262909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262910
{
public static readonly long[] Value={ 1L,2L,10L,59L,366L,2337L,15205L,100235L,667222L,4474733L,30188335L,204646532L,1392850785L,9511878729L,65144238981L,447263887479L,3077459618886L,21215286546705L,146500755609415L,1013180180867125L,7016536189029551L,48650933146617728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262910Inst : IEnumerable<long>
{
public static readonly long[] Value=A262910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262910.Bytes);
public long this[int i]=>Value[i];

public static A262910Inst Instance=new A262910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262911
{
public static readonly long[] Value={ 1L,3L,15L,137L,18190L,1550557L,1282949605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262911Inst : IEnumerable<long>
{
public static readonly long[] Value=A262911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262911.Bytes);
public long this[int i]=>Value[i];

public static A262911Inst Instance=new A262911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262912
{
public static readonly long[] Value={ 1L,6L,15L,53L,318L,1207L,5797L,34782L,189135L,1089701L,6538206L,38547751L,229660021L,1377960126L,8242589055L,49395098933L,296370593598L,1777250964247L,10661181588037L,63967089528222L,383764138693935L,2302493636842181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262912Inst : IEnumerable<long>
{
public static readonly long[] Value=A262912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262912.Bytes);
public long this[int i]=>Value[i];

public static A262912Inst Instance=new A262912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262913
{
public static readonly long[] Value={ 1L,11L,33L,137L,1411L,7417L,51769L,529931L,4701201L,44632313L,454922851L,4573641865L,46374477961L,476430252011L,4902011719233L,50649718388009L,526357874613571L,5483464232074777L,57393678601087705L,603752064813378251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262913Inst : IEnumerable<long>
{
public static readonly long[] Value=A262913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262913.Bytes);
public long this[int i]=>Value[i];

public static A262913Inst Instance=new A262913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262914
{
public static readonly BigInteger[] Value={ 1L,22L,99L,853L,18190L,152587L,2045269L,42299374L,727767387L,13958567845L,286835405806L,5764350599731L,117817168320181L,2437382604831502L,50489841095677539L,1050381458044863253L,BigInteger.Parse("21936143744564786830") };
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
public class A262914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262914Inst Instance=new A262914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262915
{
public static readonly long[] Value={ 1L,43L,261L,2953L,121507L,1550557L,33948145L,1361585275L,42115306149L,1516528236361L,61572663026659L,2451674386383133L,100125715548126961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262915Inst : IEnumerable<long>
{
public static readonly long[] Value=A262915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262915.Bytes);
public long this[int i]=>Value[i];

public static A262915Inst Instance=new A262915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262916
{
public static readonly long[] Value={ 1L,86L,783L,17333L,1444558L,30497815L,1282949605L,102437680622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262916Inst : IEnumerable<long>
{
public static readonly long[] Value=A262916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262916.Bytes);
public long this[int i]=>Value[i];

public static A262916Inst Instance=new A262916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262917
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,6L,5L,5L,1L,11L,15L,9L,10L,1L,22L,33L,53L,27L,19L,1L,43L,99L,137L,318L,61L,37L,1L,86L,261L,853L,1411L,1207L,145L,74L,1L,171L,783L,2953L,18190L,7417L,5797L,435L,147L,1L,342L,2241L,17333L,121507L,152587L,51769L,34782L,1253L,293L,1L,683L,6723L,71721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262917Inst : IEnumerable<long>
{
public static readonly long[] Value=A262917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262917.Bytes);
public long this[int i]=>Value[i];

public static A262917Inst Instance=new A262917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262918
{
public static readonly long[] Value={ 5L,9L,53L,137L,853L,2953L,17333L,71721L,394325L,1791209L,9435253L,44924617L,230950613L,1126125513L,5713545653L,28200027881L,142082597845L,705663892009L,3542422689653L,17650591452297L,88436516562773L,441384307595273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262918Inst : IEnumerable<long>
{
public static readonly long[] Value=A262918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262918.Bytes);
public long this[int i]=>Value[i];

public static A262918Inst Instance=new A262918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262919
{
public static readonly long[] Value={ 10L,27L,318L,1411L,18190L,121507L,1444558L,12031011L,132033870L,1214394787L,12726094798L,122360994211L,1252258147150L,12289486776867L,124300598233038L,1231754978783011L,12386462076574030L,123317516595907747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262919Inst : IEnumerable<long>
{
public static readonly long[] Value=A262919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262919.Bytes);
public long this[int i]=>Value[i];

public static A262919Inst Instance=new A262919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262920
{
public static readonly long[] Value={ 19L,61L,1207L,7417L,152587L,1550557L,30497815L,420921961L,7895204299L,126160746301L,2313326012887L,39531526974937L,720265713036427L,12724622932131997L,232102910290030615L,4177632885527495881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262920Inst : IEnumerable<long>
{
public static readonly long[] Value=A262920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262920.Bytes);
public long this[int i]=>Value[i];

public static A262920Inst Instance=new A262920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262921
{
public static readonly BigInteger[] Value={ 37L,145L,5797L,51769L,2045269L,33948145L,1282949605L,32134185721L,1167936430357L,36073199081665L,1296185238921637L,44004551333065849L,1586887190270675029L,BigInteger.Parse("56226197936849068945"),BigInteger.Parse("2042436589392526147045"),BigInteger.Parse("73857813970541521390201") };
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
public class A262921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262921Inst Instance=new A262921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262922
{
public static readonly long[] Value={ 1L,5L,10L,5L,1L,9L,18L,9L,1L,13L,26L,13L,1L,17L,34L,17L,1L,21L,42L,21L,1L,25L,50L,25L,1L,29L,58L,29L,1L,33L,66L,33L,1L,37L,74L,37L,1L,41L,82L,41L,1L,45L,90L,45L,1L,49L,98L,49L,1L,53L,106L,53L,1L,57L,114L,57L,1L,61L,122L,61L,1L,65L,130L,65L,1L,69L,138L,69L,1L,73L,146L,73L,1L,77L,154L,77L,1L,81L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262922Inst : IEnumerable<long>
{
public static readonly long[] Value=A262922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262922.Bytes);
public long this[int i]=>Value[i];

public static A262922Inst Instance=new A262922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262923
{
public static readonly long[] Value={ 1L,1L,3L,3L,10L,15L,27L,44L,79L,128L,211L,331L,549L,843L,1338L,2061L,3195L,4851L,7384L,11104L,16696L,24774L,36817L,54173L,79560L,116067L,168880L,244293L,352480L,506012L,724531L,1032762L,1468271L,2079525L,2937102L,4134399L,5804795L,8124459L,11342952L,15791650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262923Inst : IEnumerable<long>
{
public static readonly long[] Value=A262923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262923.Bytes);
public long this[int i]=>Value[i];

public static A262923Inst Instance=new A262923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262924
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,10L,13L,25L,35L,57L,87L,134L,211L,306L,458L,684L,996L,1465L,2129L,3073L,4411L,6288L,8977L,12707L,17913L,25185L,35231L,49078L,68228L,94490L,130408L,179425L,246121L,336681L,459239L,624842L,847986L,1147728L,1549773L,2087972L,2806455L,3764136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262924Inst : IEnumerable<long>
{
public static readonly long[] Value=A262924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262924.Bytes);
public long this[int i]=>Value[i];

public static A262924Inst Instance=new A262924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262925
{
public static readonly long[] Value={ 0L,1L,97L,962L,4578L,14979L,38995L,86996L,173636L,318597L,547333L,891814L,1391270L,2092935L,3052791L,4336312L,6019208L,8188169L,10941609L,14390410L,18658666L,23884427L,30220443L,37834908L,46912204L,57653645L,70278221L,85023342L,102145582L,121921423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262925Inst : IEnumerable<long>
{
public static readonly long[] Value=A262925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262925.Bytes);
public long this[int i]=>Value[i];

public static A262925Inst Instance=new A262925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262926
{
public static readonly BigInteger[] Value={ 0L,1L,31L,3408L,873580L,405071029L,295716738515L,312086923732368L,449317984129326216L,BigInteger.Parse("846136323944158864793"),BigInteger.Parse("2018612200059553898143707"),BigInteger.Parse("5949463230586042065279268128"),BigInteger.Parse("21227845340442717633531647231668"),BigInteger.Parse("90172805592203250075964230466892813") };
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
public class A262926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262926Inst Instance=new A262926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262927
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,23L,30L,39L,49L,60L,72L,85L,99L,114L,132L,149L,168L,188L,209L,231L,254L,278L,303L,331L,358L,387L,417L,448L,480L,513L,547L,582L,620L,657L,696L,736L,777L,819L,862L,906L,951L,999L,1046L,1095L,1145L,1196L,1248L,1301L,1355L,1410L,1468L,1525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262927Inst : IEnumerable<long>
{
public static readonly long[] Value=A262927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262927.Bytes);
public long this[int i]=>Value[i];

public static A262927Inst Instance=new A262927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262928
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,2L,1L,1L,2L,1L,1L,3L,1L,2L,3L,1L,3L,4L,2L,4L,4L,2L,5L,5L,3L,7L,5L,4L,8L,6L,6L,10L,7L,7L,12L,8L,10L,14L,9L,12L,16L,11L,16L,19L,13L,19L,21L,16L,24L,25L,19L,28L,28L,23L,35L,32L,28L,40L,36L,34L,48L,42L,41L,55L,47L,49L,65L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262928Inst : IEnumerable<long>
{
public static readonly long[] Value=A262928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262928.Bytes);
public long this[int i]=>Value[i];

public static A262928Inst Instance=new A262928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262929
{
public static readonly long[] Value={ 1L,0L,0L,-2L,-1L,0L,0L,2L,1L,0L,0L,-2L,0L,0L,0L,4L,1L,0L,0L,-6L,-2L,0L,0L,8L,1L,0L,0L,-12L,-1L,0L,0L,16L,2L,0L,0L,-22L,-3L,0L,0L,30L,2L,0L,0L,-38L,-1L,0L,0L,50L,4L,0L,0L,-66L,-5L,0L,0L,84L,3L,0L,0L,-106L,-3L,0L,0L,136L,6L,0L,0L,-172L,-8L,0L,0L,214L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262929Inst : IEnumerable<long>
{
public static readonly long[] Value=A262929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262929.Bytes);
public long this[int i]=>Value[i];

public static A262929Inst Instance=new A262929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262930
{
public static readonly long[] Value={ 1L,-2L,1L,-4L,6L,-2L,12L,-16L,5L,-28L,36L,-12L,60L,-76L,24L,-120L,150L,-46L,228L,-280L,86L,-416L,504L,-152L,732L,-878L,262L,-1252L,1488L,-442L,2088L,-2464L,725L,-3408L,3996L,-1168L,5460L,-6364L,1852L,-8600L,9972L,-2886L,13344L,-15400L,4436L,-20424L,23472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262930Inst : IEnumerable<long>
{
public static readonly long[] Value=A262930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262930.Bytes);
public long this[int i]=>Value[i];

public static A262930Inst Instance=new A262930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262931
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,10L,15L,19L,23L,25L,29L,30L,38L,43L,46L,47L,50L,53L,57L,58L,67L,69L,71L,73L,75L,86L,87L,94L,95L,97L,101L,106L,114L,115L,125L,129L,134L,138L,139L,141L,142L,145L,146L,149L,150L,159L,163L,167L,173L,174L,190L,191L,193L,194L,197L,201L,202L,211L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262931Inst : IEnumerable<long>
{
public static readonly long[] Value=A262931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262931.Bytes);
public long this[int i]=>Value[i];

public static A262931Inst Instance=new A262931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262932
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,9L,14L,18L,19L,21L,27L,29L,31L,37L,38L,42L,47L,53L,54L,57L,58L,59L,62L,63L,74L,81L,83L,87L,93L,94L,103L,106L,109L,111L,113L,114L,118L,126L,131L,133L,137L,139L,141L,149L,159L,162L,166L,167L,171L,174L,177L,186L,189L,193L,197L,199L,203L,206L,217L,218L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262932Inst : IEnumerable<long>
{
public static readonly long[] Value=A262932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262932.Bytes);
public long this[int i]=>Value[i];

public static A262932Inst Instance=new A262932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262933
{
public static readonly long[] Value={ 1L,1L,-2L,0L,5L,-4L,-7L,12L,4L,-22L,7L,29L,-26L,-28L,52L,14L,-82L,21L,106L,-85L,-105L,175L,53L,-268L,70L,326L,-264L,-301L,505L,142L,-742L,189L,885L,-698L,-805L,1323L,374L,-1906L,483L,2205L,-1732L,-1946L,3185L,884L,-4486L,1120L,5119L,-3972L,-4473L,7229L,2004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262933Inst : IEnumerable<long>
{
public static readonly long[] Value=A262933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262933.Bytes);
public long this[int i]=>Value[i];

public static A262933Inst Instance=new A262933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262934
{
public static readonly long[] Value={ 2L,5L,13L,41L,89113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262934Inst : IEnumerable<long>
{
public static readonly long[] Value=A262934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262934.Bytes);
public long this[int i]=>Value[i];

public static A262934Inst Instance=new A262934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262935
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,12L,16L,18L,28L,30L,34L,42L,46L,48L,58L,88L,90L,94L,124L,130L,136L,154L,162L,168L,172L,178L,202L,216L,258L,264L,294L,342L,352L,354L,364L,366L,370L,378L,396L,408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262935Inst : IEnumerable<long>
{
public static readonly long[] Value=A262935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262935.Bytes);
public long this[int i]=>Value[i];

public static A262935Inst Instance=new A262935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262936
{
public static readonly long[] Value={ 3L,5L,11L,29L,419L,521L,1931L,6449L,10007L,28349L,107507L,173429L,569321L,913637L,1349531L,3593201L,18286391L,80528741L,83528411L,591792347L,1971409091L,2061246347L,8579208791L,13861166687L,15250041281L,27034148369L,27066034997L,54125499299L,315361055237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262936Inst : IEnumerable<long>
{
public static readonly long[] Value=A262936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262936.Bytes);
public long this[int i]=>Value[i];

public static A262936Inst Instance=new A262936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262937
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,10L,14L,17L,20L,33L,64L,80L,152L,158L,166L,194L,196L,198L,901L,971L,1289L,1595L,2921L,14390L,28781L,35840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262937Inst : IEnumerable<long>
{
public static readonly long[] Value=A262937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262937.Bytes);
public long this[int i]=>Value[i];

public static A262937Inst Instance=new A262937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262938
{
public static readonly long[] Value={ 1L,-2L,0L,0L,2L,0L,2L,-4L,0L,-2L,4L,0L,4L,-8L,0L,-4L,10L,0L,8L,-16L,0L,-8L,20L,0L,14L,-30L,0L,-16L,36L,0L,24L,-52L,0L,-28L,64L,0L,42L,-88L,0L,-48L,108L,0L,68L,-144L,0L,-80L,176L,0L,108L,-230L,0L,-128L,280L,0L,170L,-360L,0L,-200L,436L,0L,260L,-552L,0L,-308L,666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262938Inst : IEnumerable<long>
{
public static readonly long[] Value=A262938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262938.Bytes);
public long this[int i]=>Value[i];

public static A262938Inst Instance=new A262938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262939
{
public static readonly BigInteger[] Value={ 1L,3L,-21L,-255L,-478677L,-7152407L,1291535081L,21021866227L,-8367123104756933L,-125486744208053623L,BigInteger.Parse("22639240870533272321"),BigInteger.Parse("368298497943774746859"),BigInteger.Parse("1120119534438107659394201"),BigInteger.Parse("17585651607496479804464699"),BigInteger.Parse("-4001938301481614696345053989"),BigInteger.Parse("-68798954684172515260606005119"),BigInteger.Parse("-1021530045274545215678840405648561149029"),BigInteger.Parse("-15322943216340426957307389817178091600759"),BigInteger.Parse("2767316465763270287090903125069152428833649"),BigInteger.Parse("45031940338831118856335051343515754947640891") };
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
public class A262939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262939Inst Instance=new A262939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262940
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-3L,1L,3L,1L,21L,1L,-21L,1L,255L,1L,-255L,1L,478677L,1L,-478677L,1L,7152407L,1L,-7152407L,1L,-1291535081L,1L,1291535081L,1L,-21021866227L,1L,21021866227L,1L,8367123104756933L,1L,-8367123104756933L,1L,125486744208053623L,1L,-125486744208053623L,1L,BigInteger.Parse("-22639240870533272321"),1L,BigInteger.Parse("22639240870533272321"),1L,BigInteger.Parse("-368298497943774746859"),1L,BigInteger.Parse("368298497943774746859"),1L,BigInteger.Parse("-1120119534438107659394201"),1L,BigInteger.Parse("1120119534438107659394201") };
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
public class A262940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262940Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262940.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262940Inst Instance=new A262940Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262941
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,1L,2L,3L,1L,3L,3L,6L,3L,4L,4L,4L,4L,3L,4L,2L,3L,3L,4L,3L,2L,5L,3L,4L,3L,6L,5L,6L,4L,2L,3L,2L,4L,4L,4L,5L,3L,3L,1L,3L,5L,6L,6L,4L,3L,3L,4L,1L,5L,4L,3L,4L,3L,4L,3L,4L,4L,5L,3L,5L,4L,5L,4L,4L,3L,2L,4L,6L,3L,4L,6L,4L,5L,2L,7L,7L,4L,3L,3L,5L,4L,5L,6L,6L,5L,2L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262941Inst : IEnumerable<long>
{
public static readonly long[] Value=A262941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262941.Bytes);
public long this[int i]=>Value[i];

public static A262941Inst Instance=new A262941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262942
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,3L,7L,6L,10L,11L,14L,9L,16L,12L,13L,19L,15L,18L,20L,21L,26L,17L,22L,24L,25L,27L,31L,28L,23L,32L,29L,34L,37L,38L,40L,41L,35L,30L,42L,46L,47L,54L,36L,33L,45L,43L,49L,39L,48L,50L,55L,52L,53L,44L,59L,57L,51L,60L,56L,61L,62L,67L,58L,69L,64L,72L,66L,68L,76L,71L,73L,77L,65L,75L,63L,88L,89L,80L,78L,74L,83L,79L,70L,90L,94L,82L,81L,84L,85L,91L,87L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262942Inst : IEnumerable<long>
{
public static readonly long[] Value=A262942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262942.Bytes);
public long this[int i]=>Value[i];

public static A262942Inst Instance=new A262942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262943
{
public static readonly long[] Value={ 1L,2L,6L,3L,4L,8L,7L,5L,12L,9L,10L,14L,15L,11L,17L,13L,22L,18L,16L,19L,20L,23L,29L,24L,25L,21L,26L,28L,31L,38L,27L,30L,44L,32L,37L,43L,33L,34L,48L,35L,36L,39L,46L,54L,45L,40L,41L,49L,47L,50L,57L,52L,53L,42L,51L,59L,56L,63L,55L,58L,60L,61L,75L,65L,73L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262943Inst : IEnumerable<long>
{
public static readonly long[] Value=A262943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262943.Bytes);
public long this[int i]=>Value[i];

public static A262943Inst Instance=new A262943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262944
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,4L,3L,1L,3L,5L,3L,2L,2L,5L,5L,3L,3L,5L,5L,3L,6L,6L,3L,3L,8L,6L,5L,5L,3L,7L,5L,5L,3L,4L,4L,8L,9L,3L,5L,7L,6L,3L,5L,5L,7L,5L,3L,4L,5L,6L,6L,9L,4L,5L,7L,7L,5L,4L,4L,7L,6L,1L,5L,5L,7L,7L,7L,1L,6L,10L,8L,6L,3L,4L,3L,6L,4L,6L,9L,5L,7L,9L,3L,5L,8L,9L,8L,3L,3L,11L,10L,6L,6L,8L,12L,5L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262944Inst : IEnumerable<long>
{
public static readonly long[] Value=A262944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262944.Bytes);
public long this[int i]=>Value[i];

public static A262944Inst Instance=new A262944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262945
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,3L,2L,3L,3L,2L,2L,3L,3L,3L,3L,2L,2L,4L,5L,2L,5L,4L,5L,7L,3L,1L,1L,4L,4L,6L,4L,1L,4L,4L,3L,5L,6L,5L,6L,4L,1L,1L,2L,5L,4L,5L,3L,3L,2L,1L,5L,4L,7L,9L,5L,4L,2L,2L,2L,5L,3L,2L,5L,2L,1L,3L,4L,3L,8L,4L,4L,5L,6L,3L,3L,3L,2L,7L,6L,1L,3L,3L,4L,7L,4L,6L,6L,7L,5L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262945Inst : IEnumerable<long>
{
public static readonly long[] Value=A262945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262945.Bytes);
public long this[int i]=>Value[i];

public static A262945Inst Instance=new A262945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262946
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,5L,4L,10L,13L,15L,37L,31L,61L,87L,99L,178L,228L,286L,477L,552L,816L,1163L,1418L,2077L,2790L,3507L,5113L,6478L,8563L,11888L,15005L,20100L,27054L,34055L,46002L,59905L,76436L,102105L,130879L,168103L,221954L,281300L,363743L,472557L,597579L,772148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262946Inst : IEnumerable<long>
{
public static readonly long[] Value=A262946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262946.Bytes);
public long this[int i]=>Value[i];

public static A262946Inst Instance=new A262946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262947
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,5L,5L,12L,22L,22L,32L,60L,80L,93L,161L,231L,282L,404L,616L,775L,1041L,1535L,2037L,2600L,3708L,5029L,6411L,8710L,11968L,15315L,20189L,27444L,35619L,45939L,61605L,80422L,102932L,135481L,177391L,226263L,293561L,382984L,488826L,626558L,812750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262947Inst : IEnumerable<long>
{
public static readonly long[] Value=A262947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262947.Bytes);
public long this[int i]=>Value[i];

public static A262947Inst Instance=new A262947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262948
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,5L,0L,10L,8L,5L,26L,11L,28L,62L,24L,101L,111L,77L,260L,202L,268L,583L,382L,761L,1165L,847L,1940L,2198L,2061L,4346L,4084L,5078L,9039L,7844L,11978L,17620L,15721L,26648L,33219L,32894L,56000L,61494L,69653L,111884L,114265L,146557L,214864L,214967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262948Inst : IEnumerable<long>
{
public static readonly long[] Value=A262948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262948.Bytes);
public long this[int i]=>Value[i];

public static A262948Inst Instance=new A262948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262949
{
public static readonly long[] Value={ 1L,1L,0L,0L,4L,4L,0L,7L,13L,6L,10L,38L,32L,17L,74L,103L,59L,139L,266L,191L,247L,593L,581L,513L,1175L,1487L,1190L,2223L,3453L,2938L,4158L,7264L,7095L,8052L,14430L,16308L,16246L,27364L,35347L,34096L,50997L,72595L,72163L,94707L,142522L,151435L,178047L,270112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262949Inst : IEnumerable<long>
{
public static readonly long[] Value=A262949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262949.Bytes);
public long this[int i]=>Value[i];

public static A262949Inst Instance=new A262949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262950
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,4L,5L,6L,6L,7L,8L,9L,11L,12L,14L,15L,17L,20L,22L,25L,28L,31L,34L,38L,43L,48L,53L,58L,64L,71L,79L,88L,96L,105L,115L,127L,140L,154L,168L,183L,200L,219L,240L,262L,285L,310L,337L,367L,400L,435L,472L,511L,554L,601L,652L,707L,764L,825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262950Inst : IEnumerable<long>
{
public static readonly long[] Value=A262950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262950.Bytes);
public long this[int i]=>Value[i];

public static A262950Inst Instance=new A262950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262951
{
public static readonly long[] Value={ 1L,3L,4L,8L,5L,7L,0L,2L,9L,1L,2L,5L,8L,5L,8L,1L,4L,7L,2L,3L,2L,7L,2L,9L,8L,9L,6L,3L,8L,2L,3L,3L,8L,4L,5L,4L,3L,2L,9L,4L,5L,8L,7L,0L,5L,2L,7L,6L,5L,8L,9L,2L,9L,9L,0L,8L,7L,5L,0L,3L,8L,1L,2L,1L,4L,9L,4L,7L,0L,1L,8L,4L,3L,5L,2L,0L,7L,7L,4L,8L,9L,1L,8L,3L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262951Inst : IEnumerable<long>
{
public static readonly long[] Value=A262951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262951.Bytes);
public long this[int i]=>Value[i];

public static A262951Inst Instance=new A262951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262952
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,3L,3L,6L,5L,7L,9L,9L,12L,15L,16L,21L,24L,26L,33L,37L,42L,51L,57L,65L,78L,86L,99L,115L,128L,146L,168L,187L,213L,243L,269L,306L,345L,383L,433L,487L,539L,607L,678L,749L,842L,935L,1033L,1157L,1279L,1413L,1575L,1736L,1916L,2127L,2339L,2579L,2853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262952Inst : IEnumerable<long>
{
public static readonly long[] Value=A262952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262952.Bytes);
public long this[int i]=>Value[i];

public static A262952Inst Instance=new A262952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262953
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,4L,3L,4L,7L,7L,8L,11L,13L,15L,18L,21L,25L,31L,34L,38L,48L,56L,61L,72L,85L,95L,109L,126L,142L,163L,186L,207L,237L,272L,301L,339L,389L,433L,482L,547L,612L,680L,764L,851L,946L,1061L,1177L,1301L,1455L,1616L,1779L,1977L,2194L,2415L,2670L,2953L,3250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262953Inst : IEnumerable<long>
{
public static readonly long[] Value=A262953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262953.Bytes);
public long this[int i]=>Value[i];

public static A262953Inst Instance=new A262953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262954
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,3L,2L,1L,4L,5L,3L,1L,2L,4L,3L,3L,3L,5L,4L,2L,4L,5L,2L,3L,6L,4L,3L,4L,5L,5L,4L,3L,2L,5L,4L,7L,7L,3L,4L,3L,4L,2L,4L,6L,6L,6L,2L,2L,2L,4L,5L,9L,5L,4L,5L,2L,3L,2L,5L,5L,5L,2L,4L,5L,3L,4L,5L,4L,5L,7L,3L,3L,3L,6L,3L,4L,4L,5L,6L,3L,7L,7L,3L,4L,8L,7L,7L,1L,3L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262954Inst : IEnumerable<long>
{
public static readonly long[] Value=A262954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262954.Bytes);
public long this[int i]=>Value[i];

public static A262954Inst Instance=new A262954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262955
{
public static readonly long[] Value={ 1L,2L,3L,3L,2L,3L,3L,3L,2L,1L,4L,4L,3L,2L,3L,5L,4L,3L,3L,3L,4L,5L,5L,4L,3L,5L,6L,5L,5L,3L,6L,4L,4L,4L,1L,4L,5L,7L,6L,2L,6L,3L,3L,3L,5L,8L,5L,4L,3L,5L,4L,4L,4L,5L,5L,5L,7L,4L,3L,3L,7L,3L,3L,2L,2L,8L,5L,6L,2L,3L,5L,7L,6L,2L,1L,4L,4L,3L,6L,7L,6L,3L,5L,4L,3L,2L,6L,6L,6L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262955Inst : IEnumerable<long>
{
public static readonly long[] Value=A262955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262955.Bytes);
public long this[int i]=>Value[i];

public static A262955Inst Instance=new A262955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262956
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,2L,2L,5L,5L,3L,2L,3L,4L,4L,4L,5L,7L,5L,3L,6L,5L,3L,7L,8L,5L,4L,5L,7L,8L,6L,2L,4L,5L,5L,10L,7L,5L,7L,6L,4L,3L,5L,8L,10L,6L,2L,3L,5L,6L,10L,9L,5L,7L,6L,4L,4L,5L,6L,8L,5L,3L,8L,7L,5L,7L,5L,6L,11L,9L,5L,3L,5L,5L,4L,4L,3L,8L,9L,7L,10L,7L,5L,11L,10L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262956Inst : IEnumerable<long>
{
public static readonly long[] Value=A262956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262956.Bytes);
public long this[int i]=>Value[i];

public static A262956Inst Instance=new A262956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262957
{
public static readonly BigInteger[] Value={ 2L,3L,19L,64L,538L,2833L,29169L,210308L,2572158L,23595915L,334778571L,3732092084L,60305234822L,791741083537L,14359827157009L,217037153818264L,4366918714540522L,74685204276602819L,1651116684587556019L,BigInteger.Parse("31524723785455714840"),BigInteger.Parse("759659139498065625218"),BigInteger.Parse("16017463672140861567617") };
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
public class A262957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262957Inst Instance=new A262957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262958
{
public static readonly long[] Value={ 1L,5L,7L,13L,23L,53L,125L,215L,373L,1367L,1373L,1375L,3551L,4093L,5471L,5495L,5503L,30581L,30589L,32765L,32767L,56821L,56831L,89557L,96119L,96215L,96223L,97655L,98135L,98141L,98143L,98167L,98293L,98303L,351743L,352093L,521599L,521693L,521717L,521719L,524119L,524149L,875893L,875903L,884725L,884735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262958Inst : IEnumerable<long>
{
public static readonly long[] Value=A262958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262958.Bytes);
public long this[int i]=>Value[i];

public static A262958Inst Instance=new A262958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262959
{
public static readonly long[] Value={ 9L,34L,63L,89L,99L,139L,164L,174L,193L,204L,245L,314L,324L,399L,424L,454L,464L,489L,504L,524L,549L,714L,1049L,1089L,1149L,1174L,1439L,1504L,1539L,1639L,1714L,1799L,1814L,1919L,2164L,2239L,2313L,2374L,2414L,2439L,2764L,2789L,3079L,3319L,3414L,3669L,3774L,3814L,4019L,4114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262959Inst : IEnumerable<long>
{
public static readonly long[] Value=A262959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262959.Bytes);
public long this[int i]=>Value[i];

public static A262959Inst Instance=new A262959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262960
{
public static readonly BigInteger[] Value={ 1L,21L,661L,28941L,1678501L,124467021L,11484880261L,1290503997741L,173495416001701L,27499205820027021L,5075028072491665861L,BigInteger.Parse("1078923766195953890541"),BigInteger.Parse("261780612944688782844901"),BigInteger.Parse("71901410584558939807059021"),BigInteger.Parse("22195276604290979611365107461"),BigInteger.Parse("7651037112318147566092161607341") };
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
public class A262960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262960Inst Instance=new A262960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262961
{
public static readonly BigInteger[] Value={ 0L,1L,2L,15L,302L,12559L,900288L,98986140L,15459635718L,3251842717671L,885987204390450L,303482789415233775L,BigInteger.Parse("127643176985672421000"),BigInteger.Parse("64668997044706349592900"),BigInteger.Parse("38844990446097247188562800"),BigInteger.Parse("27296481783843922533011100000"),BigInteger.Parse("22184577644604207037479874293750") };
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
public class A262961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262961Inst Instance=new A262961Inst();

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