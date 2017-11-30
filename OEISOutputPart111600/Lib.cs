using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A191515
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,0L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,3L,1L,2L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,1L,1L,1L,2L,1L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191515Inst : IEnumerable<long>
{
public static readonly long[] Value=A191515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191515.Bytes);
public long this[int i]=>Value[i];

public static A191515Inst Instance=new A191515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191660
{
public static readonly long[] Value={ 2L,1L,4L,4L,13L,14L,36L,48L,96L,141L,261L,386L,676L,1030L,1706L,2619L,4230L,6462L,10219L,15568L,24165L,36627L,56103L,84428L,127873L,191201L,286663L,425802L,632973L,933995L,1377774L,2020424L,2959438L,4314109L,6278824L,9100908L,13167388L,18983295L,27313916L,39177636L,56080228L,80048942L,114030110L,162018938L,229741517L,325000341L,458854803L,646409612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191660Inst : IEnumerable<long>
{
public static readonly long[] Value=A191660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191660.Bytes);
public long this[int i]=>Value[i];

public static A191660Inst Instance=new A191660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191661
{
public static readonly long[] Value={ -1L,3L,0L,9L,1L,22L,12L,48L,45L,120L,125L,290L,354L,676L,913L,1611L,2232L,3757L,5349L,8597L,12462L,19476L,28325L,43445L,63328L,95462L,139139L,207171L,301022L,443779L,642650L,939014L,1354671L,1964715L,2822084L,4066480L,5815907L,8330621L,11863720L,16902592L,23968714L,33981168L,47988828L,67722579L,95258824L,133854462L,187554809L,262483024L,366425586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191661Inst : IEnumerable<long>
{
public static readonly long[] Value=A191661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191661.Bytes);
public long this[int i]=>Value[i];

public static A191661Inst Instance=new A191661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191662
{
public static readonly BigInteger[] Value={ 1L,1L,6L,12L,120L,360L,5040L,20160L,362880L,1814400L,39916800L,239500800L,6227020800L,43589145600L,1307674368000L,10461394944000L,355687428096000L,3201186852864000L,121645100408832000L,1216451004088320000L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("562000363888803840000") };
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
public class A191662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191662Inst Instance=new A191662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191663
{
public static readonly long[] Value={ 1L,4L,2L,9L,5L,3L,20L,12L,8L,6L,41L,25L,17L,13L,7L,84L,52L,36L,28L,16L,10L,169L,105L,73L,57L,33L,21L,11L,340L,212L,148L,116L,68L,44L,24L,14L,681L,425L,297L,233L,137L,89L,49L,29L,15L,1364L,852L,596L,468L,276L,180L,100L,60L,32L,18L,2729L,1705L,1193L,937L,553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191663Inst : IEnumerable<long>
{
public static readonly long[] Value=A191663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191663.Bytes);
public long this[int i]=>Value[i];

public static A191663Inst Instance=new A191663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191664
{
public static readonly long[] Value={ 1L,3L,2L,7L,4L,5L,15L,8L,11L,6L,31L,16L,23L,12L,9L,63L,32L,47L,24L,19L,10L,127L,64L,95L,48L,39L,20L,13L,255L,128L,191L,96L,79L,40L,27L,14L,511L,256L,383L,192L,159L,80L,55L,28L,17L,1023L,512L,767L,384L,319L,160L,111L,56L,35L,18L,2047L,1024L,1535L,768L,639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191664Inst : IEnumerable<long>
{
public static readonly long[] Value=A191664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191664.Bytes);
public long this[int i]=>Value[i];

public static A191664Inst Instance=new A191664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191665
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,10L,13L,9L,7L,21L,26L,18L,14L,8L,42L,53L,37L,29L,17L,11L,85L,106L,74L,58L,34L,22L,12L,170L,213L,149L,117L,69L,45L,25L,15L,341L,426L,298L,234L,138L,90L,50L,30L,16L,682L,853L,597L,469L,277L,181L,101L,61L,33L,19L,1365L,1706L,1194L,938L,554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191665Inst : IEnumerable<long>
{
public static readonly long[] Value=A191665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191665.Bytes);
public long this[int i]=>Value[i];

public static A191665Inst Instance=new A191665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191666
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,5L,6L,14L,10L,8L,11L,27L,19L,15L,9L,22L,54L,38L,30L,18L,12L,43L,107L,75L,59L,35L,23L,13L,86L,214L,150L,118L,70L,46L,26L,16L,171L,427L,299L,235L,139L,91L,51L,31L,17L,342L,854L,598L,470L,278L,182L,102L,62L,34L,20L,683L,1707L,1195L,939L,555L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191666Inst : IEnumerable<long>
{
public static readonly long[] Value=A191666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191666.Bytes);
public long this[int i]=>Value[i];

public static A191666Inst Instance=new A191666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191667
{
public static readonly long[] Value={ 1L,5L,2L,21L,9L,3L,85L,37L,13L,4L,341L,149L,53L,17L,6L,1365L,597L,213L,69L,25L,7L,5461L,2389L,853L,277L,101L,29L,8L,21845L,9557L,3413L,1109L,405L,117L,33L,10L,87381L,38229L,13653L,4437L,1621L,469L,133L,41L,11L,349525L,152917L,54613L,17749L,6485L,1877L,533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191667Inst : IEnumerable<long>
{
public static readonly long[] Value=A191667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191667.Bytes);
public long this[int i]=>Value[i];

public static A191667Inst Instance=new A191667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191668
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,4L,22L,38L,14L,5L,86L,150L,54L,18L,7L,342L,598L,214L,70L,26L,8L,1366L,2390L,854L,278L,102L,30L,9L,5462L,9558L,3414L,1110L,406L,118L,34L,11L,21846L,38230L,13654L,4438L,1622L,470L,134L,42L,12L,87382L,152918L,54614L,17750L,6486L,1878L,534L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191668Inst : IEnumerable<long>
{
public static readonly long[] Value=A191668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191668.Bytes);
public long this[int i]=>Value[i];

public static A191668Inst Instance=new A191668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191669
{
public static readonly long[] Value={ 1L,3L,2L,11L,7L,4L,43L,27L,15L,5L,171L,107L,59L,19L,6L,683L,427L,235L,75L,23L,8L,2731L,1707L,939L,299L,91L,31L,9L,10923L,6827L,3755L,1195L,363L,123L,35L,10L,43691L,27307L,15019L,4779L,1451L,491L,139L,39L,12L,174763L,109227L,60075L,19115L,5803L,1963L,555L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191669Inst : IEnumerable<long>
{
public static readonly long[] Value=A191669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191669.Bytes);
public long this[int i]=>Value[i];

public static A191669Inst Instance=new A191669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191670
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,9L,11L,12L,7L,13L,15L,17L,16L,10L,18L,21L,23L,22L,20L,14L,25L,29L,31L,30L,27L,24L,19L,34L,39L,42L,41L,37L,33L,28L,26L,46L,53L,57L,55L,50L,45L,38L,32L,35L,62L,71L,77L,74L,67L,61L,51L,43L,36L,47L,83L,95L,103L,99L,90L,82L,69L,58L,49L,40L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191670Inst : IEnumerable<long>
{
public static readonly long[] Value=A191670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191670.Bytes);
public long this[int i]=>Value[i];

public static A191670Inst Instance=new A191670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191671
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,9L,4L,10L,12L,13L,6L,14L,16L,18L,17L,8L,19L,22L,24L,23L,21L,11L,26L,30L,32L,31L,28L,25L,15L,35L,40L,43L,42L,38L,34L,29L,20L,47L,54L,58L,56L,51L,46L,39L,33L,27L,63L,72L,78L,75L,68L,62L,52L,44L,37L,36L,84L,96L,104L,100L,91L,83L,70L,59L,50L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191671Inst : IEnumerable<long>
{
public static readonly long[] Value=A191671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191671.Bytes);
public long this[int i]=>Value[i];

public static A191671Inst Instance=new A191671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191672
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,8L,7L,9L,10L,12L,11L,13L,15L,14L,17L,16L,19L,21L,20L,18L,24L,23L,27L,29L,28L,25L,22L,33L,32L,37L,40L,39L,35L,31L,26L,45L,44L,51L,55L,53L,48L,43L,36L,30L,61L,60L,69L,75L,72L,65L,59L,49L,41L,34L,83L,81L,93L,101L,97L,88L,80L,67L,56L,47L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191672Inst : IEnumerable<long>
{
public static readonly long[] Value=A191672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191672.Bytes);
public long this[int i]=>Value[i];

public static A191672Inst Instance=new A191672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191673
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,10L,11L,9L,12L,14L,16L,15L,13L,17L,20L,22L,21L,19L,18L,24L,28L,30L,29L,26L,23L,25L,33L,38L,41L,40L,36L,32L,27L,34L,45L,52L,56L,54L,49L,44L,37L,31L,46L,61L,70L,76L,73L,66L,60L,50L,42L,35L,62L,82L,94L,102L,98L,89L,81L,68L,57L,48L,39L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191673Inst : IEnumerable<long>
{
public static readonly long[] Value=A191673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191673.Bytes);
public long this[int i]=>Value[i];

public static A191673Inst Instance=new A191673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191674
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,2L,4L,8L,14L,6L,14L,5L,14L,5L,7L,16L,30L,14L,30L,12L,24L,14L,30L,11L,30L,14L,18L,11L,30L,9L,12L,32L,62L,30L,62L,28L,62L,30L,62L,24L,62L,24L,62L,28L,43L,30L,45L,23L,62L,30L,41L,28L,62L,21L,41L,23L,62L,30L,41L,18L,45L,16L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191674Inst : IEnumerable<long>
{
public static readonly long[] Value=A191674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191674.Bytes);
public long this[int i]=>Value[i];

public static A191674Inst Instance=new A191674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191675
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,9L,18L,2L,18L,18L,18L,18L,18L,18L,18L,90L,18L,18L,4L,18L,18L,18L,18L,18L,18L,90L,18L,18L,18L,6L,18L,18L,18L,18L,18L,90L,18L,18L,18L,18L,8L,18L,18L,18L,18L,90L,18L,18L,18L,18L,18L,10L,18L,18L,18L,90L,18L,18L,18L,18L,18L,18L,12L,18L,18L,90L,18L,18L,18L,18L,18L,18L,18L,14L,18L,90L,18L,18L,18L,18L,18L,18L,18L,18L,16L,90L,90L,90L,90L,90L,90L,90L,90L,90L,90L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191675Inst : IEnumerable<long>
{
public static readonly long[] Value=A191675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191675.Bytes);
public long this[int i]=>Value[i];

public static A191675Inst Instance=new A191675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191724
{
public static readonly long[] Value={ 1L,3L,2L,8L,5L,4L,20L,13L,10L,6L,50L,33L,25L,15L,7L,125L,83L,63L,38L,18L,9L,313L,208L,158L,95L,45L,23L,11L,783L,520L,395L,238L,113L,58L,28L,12L,1958L,1300L,988L,595L,283L,145L,70L,30L,14L,4895L,3250L,2470L,1488L,708L,363L,175L,75L,35L,16L,12238L,8125L,6175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191724Inst : IEnumerable<long>
{
public static readonly long[] Value=A191724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191724.Bytes);
public long this[int i]=>Value[i];

public static A191724Inst Instance=new A191724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191725
{
public static readonly long[] Value={ 1L,4L,2L,10L,5L,3L,25L,14L,9L,6L,64L,35L,24L,15L,7L,160L,89L,60L,39L,19L,8L,400L,224L,150L,99L,49L,20L,11L,1000L,560L,375L,249L,124L,50L,29L,12L,2500L,1400L,939L,624L,310L,125L,74L,30L,13L,6250L,3500L,2349L,1560L,775L,314L,185L,75L,34L,16L,15625L,8750L,5874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191725Inst : IEnumerable<long>
{
public static readonly long[] Value=A191725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191725.Bytes);
public long this[int i]=>Value[i];

public static A191725Inst Instance=new A191725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191726
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,4L,16L,17L,11L,5L,41L,42L,27L,12L,8L,102L,106L,67L,31L,21L,9L,256L,266L,167L,77L,52L,22L,10L,641L,666L,417L,192L,131L,56L,26L,13L,1602L,1666L,1042L,481L,327L,141L,66L,32L,14L,4006L,4166L,2606L,1202L,817L,352L,166L,81L,36L,15L,10016L,10416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191726Inst : IEnumerable<long>
{
public static readonly long[] Value=A191726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191726.Bytes);
public long this[int i]=>Value[i];

public static A191726Inst Instance=new A191726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191727
{
public static readonly long[] Value={ 1L,3L,2L,8L,6L,4L,21L,16L,11L,5L,53L,41L,28L,13L,7L,133L,103L,71L,33L,18L,9L,333L,258L,178L,83L,46L,23L,10L,833L,646L,446L,208L,116L,58L,26L,12L,2083L,1616L,1116L,521L,291L,146L,66L,31L,14L,5208L,4041L,2791L,1303L,728L,366L,166L,78L,36L,15L,13021L,10103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191727Inst : IEnumerable<long>
{
public static readonly long[] Value=A191727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191727.Bytes);
public long this[int i]=>Value[i];

public static A191727Inst Instance=new A191727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191728
{
public static readonly long[] Value={ 1L,4L,2L,11L,6L,3L,29L,16L,9L,5L,74L,41L,24L,14L,7L,186L,104L,61L,36L,19L,8L,466L,261L,154L,91L,49L,21L,10L,1166L,654L,386L,229L,124L,54L,26L,12L,2916L,1636L,966L,574L,311L,136L,66L,31L,13L,7291L,4091L,2416L,1436L,779L,341L,166L,79L,34L,15L,18229L,10229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191728Inst : IEnumerable<long>
{
public static readonly long[] Value=A191728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191728.Bytes);
public long this[int i]=>Value[i];

public static A191728Inst Instance=new A191728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191729
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,5L,7L,18L,12L,6L,17L,43L,28L,13L,9L,42L,107L,68L,32L,22L,10L,103L,267L,168L,78L,53L,23L,11L,257L,667L,418L,193L,132L,57L,27L,14L,642L,1667L,1043L,482L,328L,142L,67L,33L,15L,1603L,4167L,2607L,1203L,818L,353L,167L,82L,37L,16L,4007L,10417L,6517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191729Inst : IEnumerable<long>
{
public static readonly long[] Value=A191729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191729.Bytes);
public long this[int i]=>Value[i];

public static A191729Inst Instance=new A191729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191730
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,5L,9L,17L,12L,6L,22L,42L,29L,14L,8L,54L,104L,72L,34L,19L,10L,134L,259L,179L,84L,47L,24L,11L,334L,647L,447L,209L,117L,59L,27L,13L,834L,1617L,1117L,522L,292L,147L,67L,32L,15L,2084L,4042L,2792L,1304L,729L,367L,167L,79L,37L,16L,5209L,10104L,6979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191730Inst : IEnumerable<long>
{
public static readonly long[] Value=A191730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191730.Bytes);
public long this[int i]=>Value[i];

public static A191730Inst Instance=new A191730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191731
{
public static readonly long[] Value={ 1L,3L,2L,8L,4L,5L,19L,9L,13L,6L,48L,23L,33L,14L,7L,119L,58L,83L,34L,18L,10L,298L,144L,208L,84L,44L,24L,11L,744L,359L,519L,209L,109L,59L,28L,12L,1859L,898L,1298L,523L,273L,148L,69L,29L,15L,4648L,2244L,3244L,1308L,683L,369L,173L,73L,38L,16L,11619L,5609L,8109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191731Inst : IEnumerable<long>
{
public static readonly long[] Value=A191731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191731.Bytes);
public long this[int i]=>Value[i];

public static A191731Inst Instance=new A191731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191732
{
public static readonly long[] Value={ 1L,2L,5L,3L,8L,6L,4L,13L,9L,10L,7L,22L,14L,17L,11L,12L,37L,23L,28L,18L,15L,19L,62L,38L,47L,29L,24L,16L,32L,103L,63L,78L,48L,39L,27L,20L,53L,172L,104L,129L,79L,64L,44L,33L,21L,88L,287L,173L,214L,132L,107L,73L,54L,34L,25L,147L,478L,288L,357L,219L,178L,122L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191732Inst : IEnumerable<long>
{
public static readonly long[] Value=A191732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191732.Bytes);
public long this[int i]=>Value[i];

public static A191732Inst Instance=new A191732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191733
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,11L,8L,9L,7L,19L,14L,16L,13L,10L,33L,24L,28L,23L,18L,12L,56L,41L,48L,39L,31L,21L,15L,94L,69L,81L,66L,53L,36L,26L,17L,158L,116L,136L,111L,89L,61L,44L,29L,20L,264L,194L,228L,186L,149L,103L,74L,49L,34L,22L,441L,324L,381L,311L,249L,173L,124L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191733Inst : IEnumerable<long>
{
public static readonly long[] Value=A191733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191733.Bytes);
public long this[int i]=>Value[i];

public static A191733Inst Instance=new A191733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191734
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,11L,9L,8L,12L,19L,16L,14L,10L,21L,32L,27L,24L,17L,13L,36L,54L,46L,41L,29L,22L,15L,61L,91L,77L,69L,49L,37L,26L,18L,102L,152L,129L,116L,82L,62L,44L,31L,20L,171L,254L,216L,194L,137L,104L,74L,52L,34L,23L,286L,424L,361L,324L,229L,174L,124L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191734Inst : IEnumerable<long>
{
public static readonly long[] Value=A191734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191734.Bytes);
public long this[int i]=>Value[i];

public static A191734Inst Instance=new A191734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191735
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,5L,6L,12L,8L,9L,11L,21L,13L,16L,10L,18L,36L,22L,27L,17L,14L,31L,61L,37L,46L,28L,23L,15L,52L,102L,62L,77L,47L,38L,26L,19L,87L,171L,103L,128L,78L,63L,43L,32L,20L,146L,286L,172L,213L,131L,106L,72L,53L,33L,24L,243L,477L,287L,356L,218L,177L,121L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191735Inst : IEnumerable<long>
{
public static readonly long[] Value=A191735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191735.Bytes);
public long this[int i]=>Value[i];

public static A191735Inst Instance=new A191735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191736
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,6L,9L,8L,10L,7L,15L,14L,18L,13L,11L,25L,24L,30L,23L,19L,12L,43L,40L,50L,39L,33L,20L,16L,73L,68L,84L,65L,55L,34L,28L,17L,123L,114L,140L,109L,93L,58L,48L,29L,21L,205L,190L,234L,183L,155L,98L,80L,49L,35L,22L,343L,318L,390L,305L,259L,164L,134L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191736Inst : IEnumerable<long>
{
public static readonly long[] Value=A191736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191736.Bytes);
public long this[int i]=>Value[i];

public static A191736Inst Instance=new A191736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191737
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,8L,12L,15L,17L,14L,11L,20L,25L,29L,24L,19L,13L,34L,42L,49L,40L,32L,22L,16L,57L,70L,82L,67L,54L,37L,27L,18L,95L,117L,137L,112L,90L,62L,45L,30L,21L,159L,195L,229L,187L,150L,104L,75L,50L,35L,23L,265L,325L,382L,312L,250L,174L,125L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191737Inst : IEnumerable<long>
{
public static readonly long[] Value=A191737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191737.Bytes);
public long this[int i]=>Value[i];

public static A191737Inst Instance=new A191737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191738
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,6L,5L,12L,10L,9L,8L,20L,17L,15L,11L,13L,33L,28L,25L,18L,14L,22L,55L,47L,42L,30L,23L,16L,37L,92L,78L,70L,50L,38L,27L,19L,62L,153L,130L,117L,83L,63L,45L,32L,21L,103L,255L,217L,195L,138L,105L,75L,53L,35L,24L,172L,425L,362L,325L,230L,175L,125L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191738Inst : IEnumerable<long>
{
public static readonly long[] Value=A191738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191738.Bytes);
public long this[int i]=>Value[i];

public static A191738Inst Instance=new A191738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191739
{
public static readonly long[] Value={ 1L,4L,2L,9L,5L,3L,16L,10L,6L,7L,29L,19L,11L,14L,8L,50L,34L,20L,25L,15L,12L,85L,59L,35L,44L,26L,21L,13L,144L,100L,60L,75L,45L,36L,24L,17L,241L,169L,101L,126L,76L,61L,41L,30L,18L,404L,284L,170L,211L,129L,104L,70L,51L,31L,22L,675L,475L,285L,354L,216L,175L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191739Inst : IEnumerable<long>
{
public static readonly long[] Value=A191739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191739.Bytes);
public long this[int i]=>Value[i];

public static A191739Inst Instance=new A191739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191788
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,1L,6L,3L,1L,11L,5L,3L,1L,21L,9L,4L,1L,40L,17L,8L,4L,1L,76L,31L,13L,5L,1L,146L,62L,26L,12L,5L,1L,279L,113L,45L,18L,6L,1L,539L,228L,94L,39L,17L,6L,1L,1036L,419L,165L,64L,24L,7L,1L,2011L,845L,348L,140L,57L,23L,7L,1L,3883L,1568L,618L,237L,89L,31L,8L,1L,7566L,3160L,1298L,521L,205L,81L,30L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191788Inst : IEnumerable<long>
{
public static readonly long[] Value=A191788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191788.Bytes);
public long this[int i]=>Value[i];

public static A191788Inst Instance=new A191788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191789
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,11L,21L,40L,76L,146L,279L,539L,1036L,2011L,3883L,7566L,14662L,28654L,55692L,109098L,212564L,417210L,814568L,1601366L,3132078L,6165732L,12077905L,23803827L,46691096L,92113651L,180893091L,357183430L,702169718L,1387539542L,2730236900L,5398831722L,10632066436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191789Inst : IEnumerable<long>
{
public static readonly long[] Value=A191789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191789.Bytes);
public long this[int i]=>Value[i];

public static A191789Inst Instance=new A191789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191790
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,5L,14L,20L,49L,76L,175L,286L,637L,1078L,2353L,4081L,8788L,15521L,33098L,59279L,125476L,227239L,478192L,873885L,1830270L,3370029L,7030570L,13027729L,27088870L,50469889L,104647630L,195892564L,405187825L,761615284L,1571990935L,2965576714L,6109558585L,11563073314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191790Inst : IEnumerable<long>
{
public static readonly long[] Value=A191790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191790.Bytes);
public long this[int i]=>Value[i];

public static A191790Inst Instance=new A191790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191791
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,1L,8L,2L,15L,4L,1L,25L,8L,2L,46L,19L,4L,1L,79L,36L,9L,2L,147L,76L,24L,4L,1L,256L,146L,48L,10L,2L,477L,304L,109L,29L,4L,1L,841L,578L,224L,60L,11L,2L,1570L,1180L,499L,144L,34L,4L,1L,2791L,2244L,1002L,312L,72L,12L,2L,5217L,4525L,2172L,731L,181L,39L,4L,1L,9336L,8588L,4347L,1530L,410L,84L,13L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191791Inst : IEnumerable<long>
{
public static readonly long[] Value=A191791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191791.Bytes);
public long this[int i]=>Value[i];

public static A191791Inst Instance=new A191791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191792
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,15L,25L,46L,79L,147L,256L,477L,841L,1570L,2791L,5217L,9336L,17467L,31421L,58830L,106279L,199103L,360960L,676545L,1230185L,2306642L,4204931L,7887045L,14409480L,27035135L,49487641L,92872062L,170289575L,319647235L,586983680L,1102027213L,2026422689L,3805138290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191792Inst : IEnumerable<long>
{
public static readonly long[] Value=A191792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191792.Bytes);
public long this[int i]=>Value[i];

public static A191792Inst Instance=new A191792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191793
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,1L,8L,2L,14L,6L,23L,12L,41L,28L,1L,69L,54L,3L,124L,116L,12L,212L,220L,30L,383L,453L,87L,1L,662L,852L,198L,4L,1200L,1712L,500L,20L,2091L,3204L,1080L,60L,3799L,6338L,2526L,206L,1L,6661L,11824L,5280L,540L,5L,12122L,23136L,11772L,1560L,30L,21359L,43068L,24066L,3780L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191793Inst : IEnumerable<long>
{
public static readonly long[] Value=A191793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191793.Bytes);
public long this[int i]=>Value[i];

public static A191793Inst Instance=new A191793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191794
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,14L,23L,41L,69L,124L,212L,383L,662L,1200L,2091L,3799L,6661L,12122L,21359L,38919L,68850L,125578L,222892L,406865L,724175L,1322772L,2360010L,4313155L,7711148L,14099524L,25252819L,46192483L,82863807L,151628090L,272385447L,498578411L,896774552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191794Inst : IEnumerable<long>
{
public static readonly long[] Value=A191794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191794.Bytes);
public long this[int i]=>Value[i];

public static A191794Inst Instance=new A191794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191795
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,1L,7L,3L,11L,9L,15L,19L,1L,23L,42L,5L,31L,77L,18L,47L,150L,54L,1L,63L,255L,137L,7L,95L,464L,333L,32L,127L,753L,720L,115L,1L,191L,1314L,1558L,360L,9L,255L,2067L,3067L,996L,50L,383L,3508L,6167L,2597L,214L,1L,511L,5397L,11410L,6207L,774L,11L,767L,8982L,21820L,14485L,2494L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191795Inst : IEnumerable<long>
{
public static readonly long[] Value=A191795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191795.Bytes);
public long this[int i]=>Value[i];

public static A191795Inst Instance=new A191795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191796
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,9L,21L,52L,113L,261L,550L,1226L,2542L,5546L,11389L,24494L,49989L,106413L,216258L,456826L,925586L,1943550L,3929090L,8210896L,16571018L,34494114L,69523116L,144246532L,290424604L,600907508L,1208835421L,2495229602L,5016122029L,10332784253L,20759855626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191796Inst : IEnumerable<long>
{
public static readonly long[] Value=A191796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191796.Bytes);
public long this[int i]=>Value[i];

public static A191796Inst Instance=new A191796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191797
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,10L,28L,78L,210L,561L,1485L,3916L,10296L,27028L,70876L,185745L,486591L,1274406L,3337236L,8738290L,22879230L,59901985L,156830905L,410597496L,1074972528L,2814337800L,7368069528L,19289917153L,50501756955L,132215475106L,346144864780L,906219437046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191797Inst : IEnumerable<long>
{
public static readonly long[] Value=A191797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191797.Bytes);
public long this[int i]=>Value[i];

public static A191797Inst Instance=new A191797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191798
{
public static readonly BigInteger[] Value={ 0L,2L,58L,2474L,180480L,19895936L,3105348340L,652948189204L,177662757810868L,60772232945639507L,BigInteger.Parse("25533219938917963508"),BigInteger.Parse("12921764841857675170314"),BigInteger.Parse("7754002391777621430686566") };
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
public class A191798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191798Inst Instance=new A191798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191799
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,17L,83L,686L,12702L,618670L,86594397L,34022042977L,39695020615741L,145648823360677102L,BigInteger.Parse("1642319452761786618544"),BigInteger.Parse("65668928064214050537574257"),BigInteger.Parse("8555753375062844432074207650070"),BigInteger.Parse("4182704217109744221309611775526547951") };
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
public class A191799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191799Inst Instance=new A191799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191800
{
public static readonly long[] Value={ 1L,1L,3L,16L,109L,851L,7275L,66393L,637239L,6371848L,65961782L,703953599L,7722738071L,86924392498L,1002603956938L,11842465020207L,143208130730229L,1773099186411938L,22483740028949531L,292129222113885503L,3891268435685371911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191800Inst : IEnumerable<long>
{
public static readonly long[] Value=A191800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191800.Bytes);
public long this[int i]=>Value[i];

public static A191800Inst Instance=new A191800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191801
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,251L,2573L,28813L,343833L,4308210L,56154805L,756731761L,10499096630L,149551069156L,2182935186698L,32613646656198L,498420592612153L,7790219357236805L,124545937719356873L,2037614647316548891L,BigInteger.Parse("34134979366157116560") };
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
public class A191801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191801Inst Instance=new A191801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191802
{
public static readonly BigInteger[] Value={ 1L,1L,5L,43L,473L,5942L,81393L,1186342L,18132473L,287948903L,4722077279L,79636530163L,1377304530677L,24382127678100L,441294262119031L,8160739579770316L,154169018332135841L,2975846752734820345L,BigInteger.Parse("58718914018159811186") };
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
public class A191802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191802Inst Instance=new A191802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191803
{
public static readonly BigInteger[] Value={ 1L,1L,6L,61L,791L,11701L,188462L,3225915L,57840755L,1076423857L,20666351126L,407645638428L,8237858879315L,170229866493435L,3592746391559133L,77393340642273491L,1701286171473636404L,BigInteger.Parse("38169860244429063080") };
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
public class A191803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191803Inst Instance=new A191803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191916
{
public static readonly long[] Value={ 3L,5L,6L,7L,9L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,23L,24L,25L,26L,29L,31L,32L,33L,35L,37L,39L,40L,43L,47L,49L,51L,53L,54L,55L,59L,61L,62L,65L,69L,76L,78L,82L,83L,84L,87L,90L,95L,97L,98L,101L,105L,112L,123L,125L,129L,131L,134L,137L,141L,145L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191916Inst : IEnumerable<long>
{
public static readonly long[] Value=A191916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191916.Bytes);
public long this[int i]=>Value[i];

public static A191916Inst Instance=new A191916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191917
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,9L,10L,11L,12L,15L,16L,18L,21L,23L,25L,27L,29L,33L,39L,40L,41L,45L,47L,54L,62L,65L,68L,70L,74L,76L,87L,101L,105L,109L,115L,117L,121L,123L,141L,163L,170L,177L,185L,191L,193L,197L,199L,228L,264L,275L,286L,300L,308L,314L,316L,320L,322L,369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191917Inst : IEnumerable<long>
{
public static readonly long[] Value=A191917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191917.Bytes);
public long this[int i]=>Value[i];

public static A191917Inst Instance=new A191917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191918
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,10L,11L,13L,15L,18L,19L,21L,25L,29L,32L,33L,35L,40L,47L,51L,54L,55L,57L,65L,76L,83L,87L,90L,91L,93L,105L,123L,134L,141L,145L,148L,149L,151L,170L,199L,217L,228L,235L,239L,242L,243L,245L,275L,322L,351L,369L,380L,387L,391L,394L,395L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191918Inst : IEnumerable<long>
{
public static readonly long[] Value=A191918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191918.Bytes);
public long this[int i]=>Value[i];

public static A191918Inst Instance=new A191918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191919
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,9L,10L,11L,12L,13L,15L,16L,18L,19L,21L,23L,25L,27L,29L,32L,33L,35L,39L,40L,41L,45L,47L,51L,54L,55L,57L,62L,65L,68L,70L,74L,76L,83L,87L,90L,91L,93L,101L,105L,109L,115L,117L,121L,123L,134L,141L,145L,148L,149L,151L,163L,170L,177L,185L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191919Inst : IEnumerable<long>
{
public static readonly long[] Value=A191919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191919.Bytes);
public long this[int i]=>Value[i];

public static A191919Inst Instance=new A191919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191920
{
public static readonly long[] Value={ 4L,6L,7L,10L,12L,13L,14L,15L,16L,19L,20L,21L,22L,23L,24L,25L,27L,28L,30L,32L,34L,36L,37L,38L,39L,40L,41L,44L,50L,51L,55L,56L,57L,58L,59L,61L,62L,65L,68L,72L,79L,80L,83L,85L,88L,90L,91L,94L,97L,98L,101L,105L,109L,116L,126L,130L,132L,134L,135L,142L,144L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191920Inst : IEnumerable<long>
{
public static readonly long[] Value=A191920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191920.Bytes);
public long this[int i]=>Value[i];

public static A191920Inst Instance=new A191920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191921
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,9L,14L,15L,17L,20L,22L,26L,35L,36L,38L,43L,44L,55L,58L,64L,67L,69L,73L,90L,94L,102L,111L,112L,114L,120L,145L,152L,166L,178L,181L,187L,190L,196L,235L,246L,268L,289L,293L,301L,310L,313L,319L,380L,398L,434L,467L,474L,488L,500L,509L,512L,518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191921Inst : IEnumerable<long>
{
public static readonly long[] Value=A191921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191921.Bytes);
public long this[int i]=>Value[i];

public static A191921Inst Instance=new A191921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191922
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,14L,15L,17L,18L,20L,22L,25L,26L,29L,30L,32L,36L,40L,43L,47L,50L,51L,53L,58L,65L,69L,76L,80L,83L,84L,86L,94L,105L,112L,123L,130L,134L,137L,138L,140L,152L,170L,181L,199L,210L,217L,221L,224L,225L,227L,246L,275L,293L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191922Inst : IEnumerable<long>
{
public static readonly long[] Value=A191922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191922.Bytes);
public long this[int i]=>Value[i];

public static A191922Inst Instance=new A191922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191923
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,14L,15L,17L,18L,20L,22L,25L,26L,29L,30L,32L,35L,36L,38L,40L,43L,44L,47L,50L,51L,53L,55L,58L,64L,65L,67L,69L,73L,76L,80L,83L,84L,86L,90L,94L,102L,105L,111L,112L,114L,120L,123L,130L,134L,137L,138L,140L,145L,152L,166L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191923Inst : IEnumerable<long>
{
public static readonly long[] Value=A191923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191923.Bytes);
public long this[int i]=>Value[i];

public static A191923Inst Instance=new A191923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191924
{
public static readonly long[] Value={ 5L,9L,11L,14L,15L,17L,18L,20L,23L,25L,26L,27L,29L,31L,34L,35L,39L,41L,43L,45L,47L,48L,55L,56L,57L,60L,61L,62L,67L,68L,69L,70L,76L,79L,89L,90L,91L,93L,95L,97L,101L,103L,106L,109L,112L,115L,123L,127L,143L,145L,147L,148L,149L,155L,161L,163L,164L,173L,177L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191924Inst : IEnumerable<long>
{
public static readonly long[] Value=A191924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191924.Bytes);
public long this[int i]=>Value[i];

public static A191924Inst Instance=new A191924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191925
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,10L,11L,13L,15L,18L,19L,24L,25L,27L,29L,33L,37L,40L,46L,47L,49L,55L,61L,65L,73L,76L,82L,85L,91L,98L,105L,119L,123L,131L,140L,143L,149L,159L,170L,192L,199L,213L,225L,234L,237L,243L,257L,275L,311L,322L,344L,365L,377L,386L,389L,395L,416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191925Inst : IEnumerable<long>
{
public static readonly long[] Value=A191925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191925.Bytes);
public long this[int i]=>Value[i];

public static A191925Inst Instance=new A191925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191926
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,10L,11L,13L,15L,18L,19L,25L,27L,29L,31L,32L,40L,46L,47L,48L,51L,52L,65L,73L,76L,79L,81L,83L,85L,105L,119L,123L,127L,133L,134L,135L,139L,170L,192L,199L,206L,214L,217L,220L,222L,226L,275L,311L,322L,333L,347L,351L,355L,361L,363L,367L,445L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191926Inst : IEnumerable<long>
{
public static readonly long[] Value=A191926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191926.Bytes);
public long this[int i]=>Value[i];

public static A191926Inst Instance=new A191926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191927
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,10L,11L,13L,15L,18L,19L,24L,25L,27L,29L,31L,32L,33L,37L,40L,46L,47L,48L,49L,51L,52L,55L,61L,65L,73L,76L,79L,81L,82L,83L,85L,91L,98L,105L,119L,123L,127L,131L,133L,134L,135L,139L,140L,143L,149L,159L,170L,192L,199L,206L,213L,214L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191927Inst : IEnumerable<long>
{
public static readonly long[] Value=A191927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191927.Bytes);
public long this[int i]=>Value[i];

public static A191927Inst Instance=new A191927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191928
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,4L,4L,4L,0L,0L,0L,0L,0L,0L,6L,8L,8L,6L,0L,0L,0L,0L,0L,0L,9L,12L,16L,12L,9L,0L,0L,0L,0L,0L,0L,12L,18L,24L,24L,18L,12L,0L,0L,0L,0L,0L,0L,16L,24L,36L,36L,36L,24L,16L,0L,0L,0L,0L,0L,0L,20L,32L,48L,54L,54L,48L,32L,20L,0L,0L,0L,0L,0L,0L,25L,40L,64L,72L,81L,72L,64L,40L,25L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191928Inst : IEnumerable<long>
{
public static readonly long[] Value=A191928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191928.Bytes);
public long this[int i]=>Value[i];

public static A191928Inst Instance=new A191928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191929
{
public static readonly long[] Value={ 5L,7L,8L,11L,13L,15L,16L,17L,19L,20L,22L,23L,27L,29L,30L,31L,32L,33L,34L,35L,39L,41L,45L,46L,47L,48L,51L,55L,57L,59L,62L,63L,73L,75L,76L,79L,80L,83L,88L,90L,91L,92L,101L,104L,117L,119L,120L,123L,127L,134L,135L,139L,145L,148L,151L,163L,167L,189L,191L,192L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191929Inst : IEnumerable<long>
{
public static readonly long[] Value=A191929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191929.Bytes);
public long this[int i]=>Value[i];

public static A191929Inst Instance=new A191929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191930
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,11L,13L,14L,17L,18L,19L,25L,29L,31L,32L,35L,43L,47L,48L,51L,60L,64L,72L,76L,79L,83L,95L,107L,111L,119L,123L,127L,134L,155L,171L,183L,187L,195L,199L,206L,217L,250L,278L,294L,306L,310L,318L,322L,333L,351L,405L,449L,477L,493L,505L,509L,517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191930Inst : IEnumerable<long>
{
public static readonly long[] Value=A191930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191930.Bytes);
public long this[int i]=>Value[i];

public static A191930Inst Instance=new A191930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191931
{
public static readonly long[] Value={ 0L,1L,3L,5L,8L,9L,10L,11L,12L,13L,15L,17L,21L,24L,25L,26L,27L,33L,37L,40L,41L,43L,54L,61L,65L,68L,69L,71L,87L,98L,105L,109L,112L,113L,115L,141L,159L,170L,177L,181L,184L,185L,187L,228L,257L,275L,286L,293L,297L,300L,301L,303L,369L,416L,445L,463L,474L,481L,485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191931Inst : IEnumerable<long>
{
public static readonly long[] Value=A191931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191931.Bytes);
public long this[int i]=>Value[i];

public static A191931Inst Instance=new A191931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191964
{
public static readonly long[] Value={ 1L,1L,17L,15649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191964Inst : IEnumerable<long>
{
public static readonly long[] Value=A191964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191964.Bytes);
public long this[int i]=>Value[i];

public static A191964Inst Instance=new A191964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191965
{
public static readonly long[] Value={ 0L,2L,6L,8L,12L,14L,18L,22L,26L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191965Inst : IEnumerable<long>
{
public static readonly long[] Value=A191965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191965.Bytes);
public long this[int i]=>Value[i];

public static A191965Inst Instance=new A191965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191966
{
public static readonly long[] Value={ 1L,1L,1L,12L,15L,900L,6615L,90720L,1995840L,1360800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191966Inst : IEnumerable<long>
{
public static readonly long[] Value=A191966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191966.Bytes);
public long this[int i]=>Value[i];

public static A191966Inst Instance=new A191966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191967
{
public static readonly long[] Value={ 0L,1L,4L,12L,20L,35L,48L,70L,88L,117L,140L,176L,204L,247L,280L,330L,368L,425L,468L,532L,580L,651L,704L,782L,840L,925L,988L,1080L,1148L,1247L,1320L,1426L,1504L,1617L,1700L,1820L,1908L,2035L,2128L,2262L,2360L,2501L,2604L,2752L,2860L,3015L,3128L,3290L,3408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191967Inst : IEnumerable<long>
{
public static readonly long[] Value=A191967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191967.Bytes);
public long this[int i]=>Value[i];

public static A191967Inst Instance=new A191967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191968
{
public static readonly BigInteger[] Value={ 29L,1364L,64079L,3010349L,141422324L,6643838879L,312119004989L,14662949395604L,688846502588399L,32361122672259149L,1520283919093591604L,BigInteger.Parse("71420983074726546239"),BigInteger.Parse("3355265920593054081629"),BigInteger.Parse("157626077284798815290324"),BigInteger.Parse("7405070366464951264563599"),BigInteger.Parse("347880681146567910619198829") };
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
public class A191968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191968Inst Instance=new A191968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191969
{
public static readonly long[] Value={ 1L,10L,13L,22L,37L,43L,46L,52L,58L,61L,67L,73L,82L,85L,94L,97L,106L,109L,118L,121L,130L,133L,136L,142L,145L,148L,151L,157L,163L,166L,172L,178L,181L,190L,193L,202L,205L,211L,214L,217L,226L,229L,232L,238L,241L,250L,253L,262L,268L,277L,283L,289L,292L,298L,301L,310L,313L,316L,322L,331L,334L,337L,346L,358L,361L,373L,382L,388L,394L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191969Inst : IEnumerable<long>
{
public static readonly long[] Value=A191969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191969.Bytes);
public long this[int i]=>Value[i];

public static A191969Inst Instance=new A191969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191970
{
public static readonly long[] Value={ 1L,2L,2L,6L,12L,33L,93L,287L,940L,3309L,12183L,47133L,190061L,796405L,3456405L,15501183L,71681170L,341209173L,1669411182L,8384579797L,43180474608L,227797465130L,1229915324579L,6790642656907L,38311482445514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191970Inst : IEnumerable<long>
{
public static readonly long[] Value=A191970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191970.Bytes);
public long this[int i]=>Value[i];

public static A191970Inst Instance=new A191970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191971
{
public static readonly long[] Value={ 2L,2L,1L,2L,1L,2L,2L,1L,3L,3L,2L,1L,4L,4L,2L,2L,1L,5L,5L,7L,5L,2L,1L,6L,6L,14L,11L,2L,2L,1L,7L,7L,23L,19L,18L,7L,2L,1L,8L,8L,34L,29L,52L,29L,2L,2L,1L,9L,9L,47L,41L,110L,71L,47L,9L,2L,1L,10L,10L,62L,55L,198L,139L,194L,76L,2L,2L,1L,11L,11L,79L,71L,322L,239L,527L,265L,123L,11L,2L,1L,12L,12L,98L,89L,488L,377L,1154L,666L,724L,199L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191971Inst : IEnumerable<long>
{
public static readonly long[] Value=A191971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191971.Bytes);
public long this[int i]=>Value[i];

public static A191971Inst Instance=new A191971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191972
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,-4L,4L,-16L,3056L,-1856L,181312L,-35853056L,1670556928L,-39832634368L,545273832448L,-19385421824L,53026545299456L,-2753673793480966144L,BigInteger.Parse("68423881271489019904"),BigInteger.Parse("-22654998127210332160") };
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
public class A191972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191972Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191972.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191972Inst Instance=new A191972Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191973
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,4L,6L,2L,3L,4L,6L,12L,2L,3L,4L,5L,6L,8L,12L,20L,4L,5L,6L,10L,30L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,15L,18L,24L,42L,6L,7L,8L,14L,56L,4L,6L,7L,8L,9L,10L,12L,16L,24L,40L,72L,6L,8L,9L,10L,12L,18L,36L,90L,5L,6L,8L,9L,10L,11L,12L,14L,15L,20L,30L,35L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191973Inst : IEnumerable<long>
{
public static readonly long[] Value=A191973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191973.Bytes);
public long this[int i]=>Value[i];

public static A191973Inst Instance=new A191973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191974
{
public static readonly long[] Value={ 1L,3L,7L,13L,41L,99L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191974Inst : IEnumerable<long>
{
public static readonly long[] Value=A191974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191974.Bytes);
public long this[int i]=>Value[i];

public static A191974Inst Instance=new A191974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191975
{
public static readonly BigInteger[] Value={ 1L,2L,6L,42L,330L,235290L,310800L,BigInteger.Parse("1863851053628494074457830") };
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
public class A191975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191975Inst Instance=new A191975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191976
{
public static readonly long[] Value={ 7L,13L,15L,16L,19L,21L,24L,25L,28L,31L,33L,37L,40L,45L,47L,49L,53L,56L,58L,61L,65L,66L,70L,75L,77L,81L,82L,84L,91L,93L,98L,99L,103L,105L,115L,119L,125L,126L,128L,131L,137L,145L,149L,153L,157L,159L,169L,170L,185L,191L,197L,200L,203L,209L,213L,221L,232L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191976Inst : IEnumerable<long>
{
public static readonly long[] Value=A191976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191976.Bytes);
public long this[int i]=>Value[i];

public static A191976Inst Instance=new A191976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191977
{
public static readonly long[] Value={ 0L,5L,8L,9L,10L,15L,17L,21L,25L,26L,29L,38L,40L,42L,43L,50L,59L,65L,69L,71L,75L,83L,97L,105L,112L,113L,125L,129L,137L,156L,170L,181L,184L,200L,212L,216L,224L,253L,275L,293L,297L,325L,341L,353L,357L,365L,409L,445L,474L,481L,525L,553L,569L,581L,585L,593L,662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191977Inst : IEnumerable<long>
{
public static readonly long[] Value=A191977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191977.Bytes);
public long this[int i]=>Value[i];

public static A191977Inst Instance=new A191977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191978
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,9L,11L,13L,16L,18L,19L,23L,25L,29L,32L,35L,39L,41L,47L,51L,60L,62L,63L,69L,76L,83L,95L,101L,104L,107L,113L,123L,134L,155L,163L,167L,176L,179L,185L,199L,217L,250L,264L,271L,283L,292L,295L,301L,322L,351L,405L,427L,438L,459L,471L,480L,483L,489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191978Inst : IEnumerable<long>
{
public static readonly long[] Value=A191978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191978.Bytes);
public long this[int i]=>Value[i];

public static A191978Inst Instance=new A191978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191979
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,8L,9L,10L,11L,13L,15L,16L,17L,18L,19L,21L,23L,25L,26L,29L,32L,35L,38L,39L,40L,41L,42L,43L,47L,50L,51L,59L,60L,62L,63L,65L,69L,71L,75L,76L,83L,95L,97L,101L,104L,105L,107L,112L,113L,123L,125L,129L,134L,137L,155L,156L,163L,167L,170L,176L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191979Inst : IEnumerable<long>
{
public static readonly long[] Value=A191979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191979.Bytes);
public long this[int i]=>Value[i];

public static A191979Inst Instance=new A191979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192012
{
public static readonly BigInteger[] Value={ 1L,4L,35L,877L,46173L,4108044L,550917287L,103674052788L,26046619272535L,8420151470990221L,3404266960229749907L,BigInteger.Parse("1682802564587905472500"),BigInteger.Parse("998472258682783813839141"),BigInteger.Parse("700281698972322460184258208"),BigInteger.Parse("573086115189070229131370358179"),BigInteger.Parse("541208343386984031504989621465925") };
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
public class A192012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192012Inst Instance=new A192012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192013
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,0L,2L,2L,1L,0L,1L,0L,2L,2L,2L,0L,1L,3L,0L,1L,2L,2L,2L,2L,1L,2L,0L,4L,1L,0L,0L,0L,2L,0L,2L,0L,2L,2L,0L,0L,1L,3L,3L,0L,0L,2L,1L,4L,2L,0L,2L,2L,2L,0L,2L,2L,1L,0L,2L,0L,0L,0L,4L,0L,1L,2L,0L,3L,0L,4L,0L,2L,2L,1L,0L,2L,2L,0L,0L,2L,2L,0L,2L,0L,0L,2L,0L,0L,1L,2L,3L,2L,3L,2L,0L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192013Inst : IEnumerable<long>
{
public static readonly long[] Value=A192013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192013.Bytes);
public long this[int i]=>Value[i];

public static A192013Inst Instance=new A192013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192014
{
public static readonly long[] Value={ 0L,4L,1L,8L,8L,3L,6L,8L,0L,8L,3L,1L,5L,0L,2L,9L,8L,5L,0L,7L,1L,2L,5L,2L,8L,9L,8L,6L,2L,4L,5L,7L,1L,6L,8L,2L,4L,2L,6L,0L,9L,6L,7L,5L,8L,4L,6L,5L,4L,8L,5L,7L,5L,3L,5L,1L,8L,2L,8L,9L,2L,1L,9L,5L,4L,2L,0L,5L,0L,0L,6L,7L,2L,8L,9L,6L,6L,7L,1L,0L,6L,4L,5L,1L,8L,6L,5L,5L,7L,0L,7L,4L,2L,2L,6L,8L,1L,6L,8L,7L,0L,1L,4L,8L,1L,7L,3L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192014Inst : IEnumerable<long>
{
public static readonly long[] Value=A192014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192014.Bytes);
public long this[int i]=>Value[i];

public static A192014Inst Instance=new A192014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192015
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,1L,12L,6L,1L,1L,32L,1L,1L,1L,10L,27L,1L,1L,80L,1L,1L,1L,1L,14L,1L,1L,1L,192L,1L,1L,1L,1L,108L,1L,1L,1L,1L,1L,1L,1L,1L,22L,75L,1L,448L,1L,1L,1L,1L,1L,1L,1L,1L,26L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,405L,1L,1024L,1L,1L,1L,1L,1L,1L,1L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192015Inst : IEnumerable<long>
{
public static readonly long[] Value=A192015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192015.Bytes);
public long this[int i]=>Value[i];

public static A192015Inst Instance=new A192015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192016
{
public static readonly long[] Value={ 0L,0L,0L,4L,0L,0L,16L,5L,0L,0L,80L,0L,0L,0L,7L,27L,0L,0L,176L,0L,0L,0L,0L,9L,0L,0L,0L,640L,0L,0L,0L,0L,216L,0L,0L,0L,0L,0L,0L,0L,0L,13L,55L,0L,1408L,0L,0L,0L,0L,0L,0L,0L,0L,15L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,621L,0L,5120L,0L,0L,0L,0L,0L,0L,0L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192016Inst : IEnumerable<long>
{
public static readonly long[] Value=A192016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192016.Bytes);
public long this[int i]=>Value[i];

public static A192016Inst Instance=new A192016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192017
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,2L,7L,10L,9L,2L,12L,21L,27L,15L,3L,20L,40L,65L,57L,25L,3L,33L,72L,138L,163L,114L,37L,4L,54L,125L,270L,394L,378L,206L,54L,4L,88L,212L,500L,854L,1033L,796L,354L,74L,5L,143L,354L,891L,1716L,2479L,2463L,1571L,574L,100L,5L,232L,585L,1545L,3265L,5424L,6559L,5469L,2917L,896L,130L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192017Inst : IEnumerable<long>
{
public static readonly long[] Value=A192017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192017.Bytes);
public long this[int i]=>Value[i];

public static A192017Inst Instance=new A192017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192018
{
public static readonly long[] Value={ 1L,3L,2L,1L,6L,6L,5L,3L,1L,11L,13L,14L,12L,10L,5L,1L,19L,24L,30L,31L,31L,28L,19L,7L,1L,32L,42L,56L,66L,74L,78L,77L,61L,32L,9L,1L,53L,71L,98L,124L,152L,175L,196L,203L,180L,118L,49L,11L,1L,87L,118L,166L,218L,284L,349L,419L,485L,525L,502L,384L,207L,70L,13L,1L,142L,194L,276L,370L,499L,645L,812L,998L,1189L,1331L,1349L,1152L,749L,336L,95L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192018Inst : IEnumerable<long>
{
public static readonly long[] Value=A192018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192018.Bytes);
public long this[int i]=>Value[i];

public static A192018Inst Instance=new A192018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192019
{
public static readonly long[] Value={ 1L,10L,50L,214L,802L,2802L,9275L,29580L,91668L,277924L,828092L,2433140L,7067885L,20337318L,58054534L,164602410L,463990190L,1301338150L,3633753815L,10107239160L,28016346216L,77419909800L,213349801560L,586471432104L,1608485221177L,4402406713762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192019Inst : IEnumerable<long>
{
public static readonly long[] Value=A192019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192019.Bytes);
public long this[int i]=>Value[i];

public static A192019Inst Instance=new A192019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192020
{
public static readonly long[] Value={ 1L,3L,2L,1L,7L,8L,8L,4L,1L,15L,22L,31L,28L,17L,6L,1L,31L,52L,90L,112L,104L,68L,30L,8L,1L,63L,114L,225L,344L,418L,388L,270L,136L,47L,10L,1L,127L,240L,516L,908L,1331L,1568L,1464L,1064L,589L,240L,68L,12L,1L,255L,494L,1123L,2180L,3663L,5138L,5931L,5560L,4181L,2482L,1137L,388L,93L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192020Inst : IEnumerable<long>
{
public static readonly long[] Value=A192020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192020.Bytes);
public long this[int i]=>Value[i];

public static A192020Inst Instance=new A192020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192021
{
public static readonly long[] Value={ 1L,10L,68L,392L,2064L,10272L,49216L,229504L,1048832L,4719104L,20972544L,92276736L,402657280L,1744838656L,7516209152L,32212287488L,137439019008L,584115683328L,2473901424640L,10445360988160L,43980466159616L,184717955563520L,774056190148608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192021Inst : IEnumerable<long>
{
public static readonly long[] Value=A192021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192021.Bytes);
public long this[int i]=>Value[i];

public static A192021Inst Instance=new A192021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192022
{
public static readonly long[] Value={ 1L,0L,3L,2L,1L,5L,5L,4L,1L,7L,8L,8L,4L,1L,9L,11L,12L,8L,4L,1L,11L,14L,16L,12L,8L,4L,1L,13L,17L,20L,16L,12L,8L,4L,1L,15L,20L,24L,20L,16L,12L,8L,4L,1L,17L,23L,28L,24L,20L,16L,12L,8L,4L,1L,19L,26L,32L,28L,24L,20L,16L,12L,8L,4L,1L,21L,29L,36L,32L,28L,24L,20L,16L,12L,8L,4L,1L,23L,32L,40L,36L,32L,28L,24L,20L,16L,12L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192022Inst : IEnumerable<long>
{
public static readonly long[] Value=A192022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192022.Bytes);
public long this[int i]=>Value[i];

public static A192022Inst Instance=new A192022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192023
{
public static readonly long[] Value={ 1L,10L,31L,68L,125L,206L,315L,456L,633L,850L,1111L,1420L,1781L,2198L,2675L,3216L,3825L,4506L,5263L,6100L,7021L,8030L,9131L,10328L,11625L,13026L,14535L,16156L,17893L,19750L,21731L,23840L,26081L,28458L,30975L,33636L,36445L,39406L,42523L,45800L,49241L,52850L,56631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192023Inst : IEnumerable<long>
{
public static readonly long[] Value=A192023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192023.Bytes);
public long this[int i]=>Value[i];

public static A192023Inst Instance=new A192023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192024
{
public static readonly long[] Value={ 2L,1L,5L,6L,4L,8L,12L,12L,4L,11L,18L,21L,12L,4L,14L,24L,30L,21L,12L,4L,17L,30L,39L,30L,21L,12L,4L,20L,36L,48L,39L,30L,21L,12L,4L,23L,42L,57L,48L,39L,30L,21L,12L,4L,26L,48L,66L,57L,48L,39L,30L,21L,12L,4L,29L,54L,75L,66L,57L,48L,39L,30L,21L,12L,4L,32L,60L,84L,75L,66L,57L,48L,39L,30L,21L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192024Inst : IEnumerable<long>
{
public static readonly long[] Value=A192024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192024.Bytes);
public long this[int i]=>Value[i];

public static A192024Inst Instance=new A192024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192025
{
public static readonly long[] Value={ 4L,29L,84L,178L,320L,519L,784L,1124L,1548L,2065L,2684L,3414L,4264L,5243L,6360L,7624L,9044L,10629L,12388L,14330L,16464L,18799L,21344L,24108L,27100L,30329L,33804L,37534L,41528L,45795L,50344L,55184L,60324L,65773L,71540L,77634L,84064L,90839L,97968L,105460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192025Inst : IEnumerable<long>
{
public static readonly long[] Value=A192025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192025.Bytes);
public long this[int i]=>Value[i];

public static A192025Inst Instance=new A192025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192026
{
public static readonly long[] Value={ 36L,72L,90L,120L,180L,168L,180L,300L,336L,270L,252L,450L,560L,540L,396L,336L,630L,840L,900L,792L,546L,432L,840L,1176L,1350L,1320L,1092L,720L,540L,1080L,1568L,1890L,1980L,1820L,1440L,918L,660L,1350L,2016L,2520L,2772L,2730L,2400L,1836L,1140L,792L,1650L,2520L,3240L,3696L,3822L,3600L,3060L,2280L,1386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192026Inst : IEnumerable<long>
{
public static readonly long[] Value=A192026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192026.Bytes);
public long this[int i]=>Value[i];

public static A192026Inst Instance=new A192026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192027
{
public static readonly long[] Value={ 1L,10L,4L,27L,29L,9L,60L,75L,58L,16L,105L,160L,147L,97L,25L,174L,275L,308L,243L,146L,36L,259L,447L,525L,504L,363L,205L,49L,376L,658L,846L,855L,748L,507L,274L,64L,513L,944L,1239L,1371L,1265L,1040L,675L,353L,81L,690L,1278L,1768L,2002L,2022L,1755L,1380L,867L,442L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192027Inst : IEnumerable<long>
{
public static readonly long[] Value=A192027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192027.Bytes);
public long this[int i]=>Value[i];

public static A192027Inst Instance=new A192027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192044
{
public static readonly long[] Value={ 3L,7L,0L,8L,2L,2L,8L,3L,1L,9L,6L,1L,1L,8L,1L,5L,4L,4L,6L,2L,2L,7L,9L,5L,6L,9L,7L,6L,0L,4L,7L,6L,2L,9L,0L,3L,1L,4L,1L,4L,4L,4L,7L,8L,0L,1L,5L,1L,4L,7L,0L,4L,6L,7L,1L,2L,4L,7L,2L,4L,0L,2L,3L,9L,9L,5L,4L,0L,8L,0L,1L,9L,6L,5L,8L,7L,3L,7L,9L,3L,6L,4L,3L,9L,8L,5L,9L,4L,2L,2L,6L,1L,1L,6L,1L,6L,0L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192044Inst : IEnumerable<long>
{
public static readonly long[] Value=A192044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192044.Bytes);
public long this[int i]=>Value[i];

public static A192044Inst Instance=new A192044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192045
{
public static readonly long[] Value={ 8L,14L,17L,18L,23L,24L,26L,27L,29L,32L,36L,38L,41L,44L,47L,48L,53L,56L,58L,59L,64L,67L,68L,69L,74L,76L,88L,89L,92L,93L,99L,102L,107L,109L,111L,122L,123L,142L,144L,146L,148L,154L,156L,157L,161L,166L,176L,177L,178L,196L,199L,231L,232L,233L,238L,243L,244L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192045Inst : IEnumerable<long>
{
public static readonly long[] Value=A192045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192045.Bytes);
public long this[int i]=>Value[i];

public static A192045Inst Instance=new A192045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192046
{
public static readonly long[] Value={ 0L,1L,4L,6L,7L,13L,16L,18L,19L,28L,32L,34L,39L,49L,51L,52L,67L,72L,82L,83L,86L,106L,121L,126L,134L,136L,138L,173L,193L,208L,213L,217L,223L,224L,279L,314L,334L,349L,351L,354L,362L,364L,452L,507L,542L,562L,568L,577L,582L,586L,592L,731L,821L,876L,911L,919L,931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192046Inst : IEnumerable<long>
{
public static readonly long[] Value=A192046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192046.Bytes);
public long this[int i]=>Value[i];

public static A192046Inst Instance=new A192046Inst();

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