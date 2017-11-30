using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A191251
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,27L,29L,31L,33L,35L,37L,39L,40L,42L,44L,46L,48L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,68L,70L,72L,74L,76L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,115L,117L,119L,121L,123L,125L,127L,128L,130L,132L,134L,136L,137L,139L,141L,143L,145L,147L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191251Inst : IEnumerable<long>
{
public static readonly long[] Value=A191251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191251.Bytes);
public long this[int i]=>Value[i];

public static A191251Inst Instance=new A191251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191250
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191250Inst : IEnumerable<long>
{
public static readonly long[] Value=A191250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191250.Bytes);
public long this[int i]=>Value[i];

public static A191250Inst Instance=new A191250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191249
{
public static readonly long[] Value={ 2L,12L,4L,432L,72L,8L,61344L,3888L,288L,16L,32866560L,665280L,21600L,960L,32L,68307743232L,407306880L,4328640L,95040L,2880L,64L,561981464819712L,965518299648L,2948037120L,21893760L,362880L,8064L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191249Inst : IEnumerable<long>
{
public static readonly long[] Value=A191249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191249.Bytes);
public long this[int i]=>Value[i];

public static A191249Inst Instance=new A191249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191248
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,2L,5L,2L,6L,2L,3L,6L,3L,2L,7L,8L,7L,6L,3L,9L,3L,9L,3L,9L,3L,10L,3L,7L,2L,19L,2L,12L,12L,24L,13L,15L,14L,9L,2L,16L,3L,12L,13L,17L,38L,4L,38L,38L,4L,21L,39L,4L,19L,40L,4L,18L,41L,42L,23L,42L,23L,23L,45L,29L,47L,47L,34L,26L,47L,38L,21L,47L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191248Inst : IEnumerable<long>
{
public static readonly long[] Value=A191248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191248.Bytes);
public long this[int i]=>Value[i];

public static A191248Inst Instance=new A191248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191247
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,1L,3L,1L,0L,1L,3L,0L,3L,1L,2L,3L,2L,0L,2L,3L,0L,3L,2L,1L,4L,1L,2L,4L,2L,1L,0L,1L,2L,0L,2L,1L,4L,1L,0L,1L,4L,0L,4L,1L,2L,4L,2L,0L,2L,4L,0L,4L,2L,1L,3L,1L,4L,1L,3L,4L,3L,1L,0L,1L,3L,0L,3L,1L,4L,1L,0L,1L,4L,0L,4L,1L,3L,4L,3L,0L,3L,4L,0L,4L,3L,1L,2L,3L,2L,4L,2L,3L,4L,3L,2L,0L,2L,3L,0L,3L,2L,4L,2L,0L,2L,4L,0L,4L,2L,3L,4L,3L,0L,3L,4L,0L,4L,3L,2L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191247Inst : IEnumerable<long>
{
public static readonly long[] Value=A191247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191247.Bytes);
public long this[int i]=>Value[i];

public static A191247Inst Instance=new A191247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191246
{
public static readonly long[] Value={ 0L,2L,3L,3L,2L,3L,4L,2L,4L,2L,3L,3L,2L,3L,4L,3L,2L,4L,2L,3L,3L,2L,3L,4L,5L,2L,3L,3L,2L,3L,5L,2L,3L,3L,2L,3L,4L,2L,4L,2L,3L,3L,2L,3L,4L,3L,2L,4L,2L,3L,3L,2L,3L,4L,5L,2L,4L,2L,3L,3L,2L,3L,5L,2L,3L,3L,2L,3L,4L,2L,4L,2L,3L,3L,2L,3L,4L,3L,2L,4L,2L,3L,3L,2L,3L,4L,5L,3L,2L,4L,2L,3L,3L,2L,3L,5L,2L,3L,3L,2L,3L,4L,2L,4L,2L,3L,3L,2L,3L,4L,3L,2L,4L,2L,3L,3L,2L,3L,4L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191246Inst : IEnumerable<long>
{
public static readonly long[] Value=A191246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191246.Bytes);
public long this[int i]=>Value[i];

public static A191246Inst Instance=new A191246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191245
{
public static readonly long[] Value={ 3L,7L,11L,19L,53L,97L,103L,127L,131L,149L,179L,197L,227L,239L,277L,283L,337L,349L,409L,457L,463L,487L,499L,569L,599L,641L,659L,683L,701L,719L,743L,809L,839L,953L,971L,1013L,1019L,1051L,1093L,1201L,1213L,1237L,1291L,1297L,1303L,1321L,1381L,1423L,1543L,1597L,1621L,1747L,1753L,1783L,1801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191245Inst : IEnumerable<long>
{
public static readonly long[] Value=A191245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191245.Bytes);
public long this[int i]=>Value[i];

public static A191245Inst Instance=new A191245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191244
{
public static readonly BigInteger[] Value={ 1L,10110L,110100L,1011130L,3234210L,22142230L,123052510L,523053070L,2520607100L,11111111110L,479110292610L,19641010776330L,80101410369310L,210510130141118110L,1212103125891481260L,315281211715711270L,12138214138151315710UL,BigInteger.Parse("56015814091312161590"),BigInteger.Parse("1780471401817161317410"),BigInteger.Parse("6151213981715112481715110") };
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
public class A191244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191244Inst Instance=new A191244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191099
{
public static readonly long[] Value={ 11L,52L,255L,1335L,7432L,43833L,272947L,1788850L,12303997L,88586135L,666047210L,5218287687L,42518759887L,359651145332L,3152929344235L,28603584325827L,268159523175744L,2594608337127709L,25878365376280647L,265770087291261082L,2807571511844891521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191099Inst : IEnumerable<long>
{
public static readonly long[] Value=A191099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191099.Bytes);
public long this[int i]=>Value[i];

public static A191099Inst Instance=new A191099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191098
{
public static readonly long[] Value={ 1L,8L,120L,2248L,47636L,1088017L,26424957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191098Inst : IEnumerable<long>
{
public static readonly long[] Value=A191098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191098.Bytes);
public long this[int i]=>Value[i];

public static A191098Inst Instance=new A191098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191097
{
public static readonly long[] Value={ 1L,7L,91L,1463L,26460L,516691L,10654378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191097Inst : IEnumerable<long>
{
public static readonly long[] Value=A191097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191097.Bytes);
public long this[int i]=>Value[i];

public static A191097Inst Instance=new A191097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191096
{
public static readonly long[] Value={ 1L,6L,66L,886L,13281L,213978L,3630090L,64012932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191096Inst : IEnumerable<long>
{
public static readonly long[] Value=A191096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191096.Bytes);
public long this[int i]=>Value[i];

public static A191096Inst Instance=new A191096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191095
{
public static readonly long[] Value={ 1L,5L,45L,485L,5775L,73437L,979335L,13536225L,192393410L,2796392165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191095Inst : IEnumerable<long>
{
public static readonly long[] Value=A191095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191095.Bytes);
public long this[int i]=>Value[i];

public static A191095Inst Instance=new A191095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191094
{
public static readonly long[] Value={ 1L,4L,28L,228L,2018L,18892L,184400L,1857856L,19189675L,202214452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191094Inst : IEnumerable<long>
{
public static readonly long[] Value=A191094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191094.Bytes);
public long this[int i]=>Value[i];

public static A191094Inst Instance=new A191094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191093
{
public static readonly long[] Value={ 2L,1L,6L,1L,10L,1L,5L,1L,6L,3L,22L,3L,26L,1L,30L,0L,34L,2L,38L,5L,42L,3L,9L,3L,1L,7L,6L,7L,58L,1L,62L,1L,66L,3L,70L,3L,74L,5L,78L,5L,82L,11L,29L,11L,30L,3L,13L,1L,14L,3L,102L,1L,106L,1L,110L,7L,114L,15L,118L,15L,41L,1L,42L,1L,130L,17L,134L,17L,138L,3L,142L,3L,29L,19L,30L,19L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191093Inst : IEnumerable<long>
{
public static readonly long[] Value=A191093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191093.Bytes);
public long this[int i]=>Value[i];

public static A191093Inst Instance=new A191093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191092
{
public static readonly BigInteger[] Value={ 0L,1L,61L,2836L,129288L,6160640L,313921008L,17239040000L,1021644763392L,65244849242112L,4477975127425280L,329252714454974464L,BigInteger.Parse("25850313756000000000"),BigInteger.Parse("2160223055912342913024"),BigInteger.Parse("191558954408834121740288"),BigInteger.Parse("17973564914103712921681920") };
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
public class A191092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191092Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191092.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191092Inst Instance=new A191092Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191091
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,4L,2L,1L,2L,3L,3L,2L,3L,4L,1L,3L,2L,3L,2L,4L,3L,4L,3L,1L,4L,3L,4L,2L,5L,4L,2L,3L,2L,5L,1L,4L,3L,6L,2L,2L,4L,3L,3L,2L,5L,4L,3L,1L,2L,5L,2L,2L,3L,6L,3L,3L,2L,3L,4L,2L,3L,4L,1L,2L,3L,3L,3L,3L,3L,4L,2L,4L,2L,3L,4L,3L,3L,4L,2L,1L,4L,3L,4L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191091Inst : IEnumerable<long>
{
public static readonly long[] Value=A191091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191091.Bytes);
public long this[int i]=>Value[i];

public static A191091Inst Instance=new A191091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191090
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,2L,1L,1L,4L,2L,3L,1L,2L,2L,2L,1L,2L,5L,2L,3L,2L,2L,2L,2L,4L,2L,3L,2L,6L,2L,2L,2L,2L,4L,2L,3L,2L,3L,2L,2L,4L,7L,5L,2L,4L,2L,3L,2L,2L,4L,3L,3L,2L,5L,2L,3L,8L,4L,4L,3L,4L,2L,3L,2L,6L,4L,5L,5L,3L,4L,2L,3L,4L,9L,4L,3L,4L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191090Inst : IEnumerable<long>
{
public static readonly long[] Value=A191090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191090.Bytes);
public long this[int i]=>Value[i];

public static A191090Inst Instance=new A191090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191089
{
public static readonly long[] Value={ 3L,5L,43L,43L,67L,67L,163L,163L,163L,163L,163L,163L,74093L,170957L,360293L,679733L,2004917L,2004917L,51599563L,51599563L,96295483L,96295483L,146161723L,1408126003L,1728061733L,1728061733L,1728061733L,1728061733L,1728061733L,1728061733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191089Inst : IEnumerable<long>
{
public static readonly long[] Value=A191089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191089.Bytes);
public long this[int i]=>Value[i];

public static A191089Inst Instance=new A191089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191088
{
public static readonly long[] Value={ 3L,5L,43L,43L,67L,67L,163L,163L,163L,163L,163L,163L,74093L,77683L,214037L,214037L,214037L,2004917L,36254563L,51599563L,96295483L,96295483L,114148483L,163520117L,163520117L,261153653L,261153653L,585811843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191088Inst : IEnumerable<long>
{
public static readonly long[] Value=A191088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191088.Bytes);
public long this[int i]=>Value[i];

public static A191088Inst Instance=new A191088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191087
{
public static readonly long[] Value={ 7L,17L,23L,29L,31L,41L,43L,47L,59L,71L,73L,79L,83L,89L,109L,137L,151L,157L,163L,179L,181L,197L,211L,233L,241L,263L,269L,277L,281L,283L,313L,331L,347L,353L,367L,379L,397L,401L,409L,421L,431L,439L,443L,449L,457L,463L,467L,503L,509L,521L,557L,569L,577L,587L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191087Inst : IEnumerable<long>
{
public static readonly long[] Value=A191087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191087.Bytes);
public long this[int i]=>Value[i];

public static A191087Inst Instance=new A191087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191086
{
public static readonly long[] Value={ 3L,23L,31L,37L,41L,53L,59L,61L,73L,83L,101L,113L,127L,131L,137L,149L,151L,157L,167L,173L,193L,197L,199L,223L,233L,251L,257L,269L,277L,281L,283L,307L,311L,313L,331L,347L,359L,367L,379L,397L,409L,433L,449L,463L,491L,503L,523L,541L,569L,571L,577L,593L,599L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191086Inst : IEnumerable<long>
{
public static readonly long[] Value=A191086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191086.Bytes);
public long this[int i]=>Value[i];

public static A191086Inst Instance=new A191086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191085
{
public static readonly long[] Value={ 2L,3L,11L,17L,37L,61L,67L,71L,101L,103L,109L,131L,137L,139L,149L,151L,157L,163L,173L,181L,193L,197L,199L,239L,251L,257L,269L,281L,283L,311L,313L,317L,331L,359L,367L,379L,401L,419L,421L,431L,433L,439L,449L,457L,463L,467L,487L,499L,503L,521L,523L,541L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191085Inst : IEnumerable<long>
{
public static readonly long[] Value=A191085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191085.Bytes);
public long this[int i]=>Value[i];

public static A191085Inst Instance=new A191085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191084
{
public static readonly long[] Value={ 5L,19L,23L,31L,37L,43L,53L,59L,61L,71L,73L,79L,83L,97L,107L,127L,149L,157L,163L,167L,173L,179L,193L,197L,211L,227L,229L,233L,239L,257L,271L,281L,307L,331L,337L,347L,353L,367L,379L,383L,401L,409L,419L,421L,431L,433L,509L,521L,541L,557L,577L,587L,593L,601L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191084Inst : IEnumerable<long>
{
public static readonly long[] Value=A191084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191084.Bytes);
public long this[int i]=>Value[i];

public static A191084Inst Instance=new A191084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190731
{
public static readonly long[] Value={ 23L,37L,53L,73L,127L,131L,137L,139L,151L,157L,173L,179L,223L,229L,233L,239L,331L,337L,421L,431L,433L,457L,523L,631L,677L,733L,739L,751L,773L,823L,829L,839L,853L,859L,937L,977L,1117L,1171L,1193L,1213L,1279L,1433L,1471L,1493L,1579L,1637L,1697L,1733L,1873L,1879L,1997L,2131L,2137L,2239L,2293L,2437L,2539L,2593L,2731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190731Inst : IEnumerable<long>
{
public static readonly long[] Value=A190731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190731.Bytes);
public long this[int i]=>Value[i];

public static A190731Inst Instance=new A190731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190730
{
public static readonly long[] Value={ 3L,16L,53L,146L,367L,876L,2025L,4582L,10211L,22496L,49117L,106458L,229335L,491476L,1048529L,2228174L,4718539L,9961416L,20971461L,44040130L,92274623L,192937916L,402653113L,838860726L,1744830387L,3623878576L,7516192685L,15569256362L,32212254631L,66571992996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190730Inst : IEnumerable<long>
{
public static readonly long[] Value=A190730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190730.Bytes);
public long this[int i]=>Value[i];

public static A190730Inst Instance=new A190730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190729
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,16L,46L,176L,722L,2906L,13106L,66716L,345676L,1849992L,10802156L,66543296L,418075036L,2750329276L,19145683612L,137410493656L,1012831509736L,7785886770656L,62105849642376L,507682088621632L,4271236045340056L,37171085370443576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190729Inst : IEnumerable<long>
{
public static readonly long[] Value=A190729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190729.Bytes);
public long this[int i]=>Value[i];

public static A190729Inst Instance=new A190729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190728
{
public static readonly long[] Value={ 5L,4L,17L,26L,13L,18L,65L,28L,101L,122L,49L,22L,165L,76L,257L,290L,109L,68L,401L,67L,485L,530L,193L,626L,529L,244L,177L,842L,301L,439L,1025L,364L,1157L,226L,433L,581L,429L,22L,1601L,1682L,361L,423L,1937L,676L,2117L,2210L,769L,1047L,2501L,868L,529L,2810L,973L,3026L,961L,292L,3365L,3482L,1201L,1660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190728Inst : IEnumerable<long>
{
public static readonly long[] Value=A190728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190728.Bytes);
public long this[int i]=>Value[i];

public static A190728Inst Instance=new A190728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190727
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,1L,4L,7L,10L,13L,16L,19L,22L,25L,28L,2L,6L,10L,14L,18L,22L,26L,30L,34L,38L,3L,8L,13L,18L,23L,28L,33L,38L,43L,48L,4L,10L,16L,22L,28L,34L,40L,46L,52L,58L,5L,12L,19L,26L,33L,40L,47L,54L,61L,68L,6L,14L,22L,30L,38L,46L,54L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190727Inst : IEnumerable<long>
{
public static readonly long[] Value=A190727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190727.Bytes);
public long this[int i]=>Value[i];

public static A190727Inst Instance=new A190727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190726
{
public static readonly BigInteger[] Value={ 1L,6L,62L,720L,8806L,110916L,1423796L,18520788L,243289670L,3220011684L,42872967012L,573608356272L,7705343534716L,103857425975400L,1403902871946000L,19024773303675420L,258372666772083270L,3515644245559211172L,BigInteger.Parse("47918193512409831380") };
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
public class A190726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190726Inst Instance=new A190726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190725
{
public static readonly long[] Value={ 1L,3L,14L,69L,355L,1872L,10037L,54459L,298138L,1643565L,9111191L,50739120L,283635481L,1590648819L,8945090870L,50423423685L,284831065723L,1611918320688L,9137141645645L,51869777201595L,294843392318146L,1677980087882013L,9559901907126959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190725Inst : IEnumerable<long>
{
public static readonly long[] Value=A190725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190725.Bytes);
public long this[int i]=>Value[i];

public static A190725Inst Instance=new A190725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190724
{
public static readonly long[] Value={ 1L,4L,20L,106L,576L,3174L,17648L,98746L,555104L,3131854L,17720880L,100507554L,571179792L,3251459670L,18535914480L,105803208906L,604598535360L,3458315246238L,19799128470896L,113441876080306L,650450158678256L,3731985710892454L,21425304596140080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190724Inst : IEnumerable<long>
{
public static readonly long[] Value=A190724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190724.Bytes);
public long this[int i]=>Value[i];

public static A190724Inst Instance=new A190724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190723
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,11L,15L,19L,20L,22L,26L,27L,29L,33L,37L,38L,40L,44L,48L,49L,51L,55L,56L,58L,62L,66L,67L,69L,73L,74L,76L,80L,84L,85L,87L,91L,95L,96L,98L,102L,103L,105L,109L,113L,114L,116L,120L,124L,125L,127L,131L,132L,134L,138L,142L,143L,145L,149L,150L,152L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190723Inst : IEnumerable<long>
{
public static readonly long[] Value=A190723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190723.Bytes);
public long this[int i]=>Value[i];

public static A190723Inst Instance=new A190723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190722
{
public static readonly long[] Value={ 3L,45751L,149351L,171529L,223099L,434237L,678077L,706841L,1996297L,3993037L,6340457L,7199113L,7419761L,9000317L,13129271L,15052777L,17193217L,18436879L,18749881L,18998519L,23353469L,23689423L,33746663L,40985411L,41437751L,43547797L,51198097L,53773651L,56825687L,60207809L,62190113L,79778899L,81708353L,83019421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190722Inst : IEnumerable<long>
{
public static readonly long[] Value=A190722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190722.Bytes);
public long this[int i]=>Value[i];

public static A190722Inst Instance=new A190722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190721
{
public static readonly long[] Value={ 3L,5L,6L,10L,13L,14L,17L,21L,23L,24L,28L,31L,32L,35L,39L,42L,43L,46L,50L,52L,53L,57L,60L,61L,64L,68L,70L,71L,75L,78L,79L,82L,86L,89L,90L,93L,97L,99L,100L,104L,107L,108L,111L,115L,118L,119L,122L,126L,128L,129L,133L,136L,137L,140L,144L,146L,147L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190721Inst : IEnumerable<long>
{
public static readonly long[] Value=A190721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190721.Bytes);
public long this[int i]=>Value[i];

public static A190721Inst Instance=new A190721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190720
{
public static readonly long[] Value={ 7L,12L,16L,18L,25L,30L,34L,36L,41L,45L,47L,54L,59L,63L,65L,72L,77L,81L,83L,88L,92L,94L,101L,106L,110L,112L,117L,121L,123L,130L,135L,139L,141L,148L,153L,157L,159L,164L,168L,170L,177L,182L,186L,188L,195L,200L,204L,206L,211L,215L,217L,224L,229L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190720Inst : IEnumerable<long>
{
public static readonly long[] Value=A190720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190720.Bytes);
public long this[int i]=>Value[i];

public static A190720Inst Instance=new A190720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190719
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,8L,11L,12L,13L,15L,17L,19L,20L,23L,24L,25L,27L,29L,31L,32L,35L,36L,37L,39L,41L,43L,44L,47L,48L,49L,51L,53L,55L,56L,59L,60L,61L,63L,65L,67L,68L,71L,72L,73L,75L,77L,79L,80L,83L,84L,85L,87L,89L,91L,92L,95L,96L,97L,99L,101L,103L,104L,107L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190719Inst : IEnumerable<long>
{
public static readonly long[] Value=A190719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190719.Bytes);
public long this[int i]=>Value[i];

public static A190719Inst Instance=new A190719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190718
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,4L,4L,4L,10L,10L,10L,10L,20L,20L,20L,20L,35L,35L,35L,35L,56L,56L,56L,56L,84L,84L,84L,84L,120L,120L,120L,120L,165L,165L,165L,165L,220L,220L,220L,220L,286L,286L,286L,286L,364L,364L,364L,364L,455L,455L,455L,455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190718Inst : IEnumerable<long>
{
public static readonly long[] Value=A190718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190718.Bytes);
public long this[int i]=>Value[i];

public static A190718Inst Instance=new A190718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190717
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,4L,10L,10L,10L,20L,20L,20L,35L,35L,35L,56L,56L,56L,84L,84L,84L,120L,120L,120L,165L,165L,165L,220L,220L,220L,286L,286L,286L,364L,364L,364L,455L,455L,455L,560L,560L,560L,680L,680L,680L,816L,816L,816L,969L,969L,969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190717Inst : IEnumerable<long>
{
public static readonly long[] Value=A190717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190717.Bytes);
public long this[int i]=>Value[i];

public static A190717Inst Instance=new A190717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190716
{
public static readonly long[] Value={ 1L,2L,7L,4L,21L,6L,43L,8L,73L,10L,111L,12L,157L,14L,211L,16L,273L,18L,343L,20L,421L,22L,507L,24L,601L,26L,703L,28L,813L,30L,931L,32L,1057L,34L,1191L,36L,1333L,38L,1483L,40L,1641L,42L,1807L,44L,1981L,46L,2163L,48L,2353L,50L,2551L,52L,2757L,54L,2971L,56L,3193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190716Inst : IEnumerable<long>
{
public static readonly long[] Value=A190716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190716.Bytes);
public long this[int i]=>Value[i];

public static A190716Inst Instance=new A190716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190651
{
public static readonly long[] Value={ 1902L,1904L,1909L,1910L,1913L,1915L,1916L,1919L,1921L,1924L,1926L,1927L,1930L,1932L,1937L,1938L,1941L,1943L,1944L,1947L,1949L,1952L,1954L,1955L,1958L,1960L,1965L,1966L,1969L,1971L,1972L,1975L,1977L,1980L,1982L,1983L,1986L,1988L,1993L,1994L,1997L,1999L,2000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190651Inst : IEnumerable<long>
{
public static readonly long[] Value=A190651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190651.Bytes);
public long this[int i]=>Value[i];

public static A190651Inst Instance=new A190651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190650
{
public static readonly long[] Value={ 1L,2L,3L,8L,10L,12L,14L,16L,27L,30L,33L,36L,39L,42L,45L,128L,136L,144L,152L,160L,168L,176L,184L,192L,250L,260L,270L,280L,290L,300L,310L,320L,330L,340L,350L,432L,444L,456L,468L,480L,492L,504L,516L,528L,540L,552L,564L,576L,686L,700L,714L,728L,742L,756L,770L,784L,798L,812L,826L,840L,854L,868L,882L,1024L,1040L,1056L,1072L,1088L,1104L,1120L,1136L,1152L,1168L,1184L,1200L,1216L,1232L,1248L,1264L,1280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190650Inst : IEnumerable<long>
{
public static readonly long[] Value=A190650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190650.Bytes);
public long this[int i]=>Value[i];

public static A190650Inst Instance=new A190650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190649
{
public static readonly long[] Value={ 1L,1L,4L,1L,2L,3L,6L,2L,1L,3L,1L,189L,1L,3L,12L,1L,1L,2L,10L,3L,1L,2L,17L,124L,2L,2L,6L,1L,137L,5L,3L,1L,3L,1L,1L,9L,2L,1L,5L,13L,1L,13L,2L,7L,1L,2L,309L,1L,2L,1L,1L,2L,2L,2L,1L,1L,3L,8L,2L,21L,1L,1L,35L,6L,1L,2L,1L,3L,1L,50L,1L,6L,8L,2L,5L,2L,109L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,5L,1L,4L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190649Inst : IEnumerable<long>
{
public static readonly long[] Value=A190649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190649.Bytes);
public long this[int i]=>Value[i];

public static A190649Inst Instance=new A190649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190648
{
public static readonly long[] Value={ 1L,6L,7L,5L,3L,9L,2L,9L,8L,4L,5L,5L,6L,2L,5L,1L,1L,8L,3L,2L,4L,1L,3L,9L,8L,4L,1L,0L,0L,9L,1L,4L,4L,8L,3L,8L,5L,3L,7L,3L,6L,6L,8L,7L,1L,5L,9L,9L,2L,8L,3L,7L,9L,8L,4L,3L,3L,9L,0L,0L,0L,6L,9L,6L,0L,8L,6L,8L,0L,2L,7L,3L,3L,2L,2L,2L,3L,3L,7L,0L,4L,5L,0L,8L,9L,7L,7L,0L,8L,7L,2L,6L,5L,2L,9L,7L,4L,7L,2L,8L,2L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190648Inst : IEnumerable<long>
{
public static readonly long[] Value=A190648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190648.Bytes);
public long this[int i]=>Value[i];

public static A190648Inst Instance=new A190648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190647
{
public static readonly long[] Value={ -1L,1L,4L,1L,30L,1L,870L,1L,9L,5L,1L,12L,1L,14L,1L,1L,1L,1L,2L,4L,1L,40L,1L,9L,13L,8L,35L,1L,8L,3L,1L,1L,10L,4L,15L,3L,1L,6L,6L,1L,4L,1L,4L,1L,9L,6L,7L,1L,4L,20L,3L,2L,1L,3L,1L,9L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,3L,4L,2L,18L,3L,1L,1L,1L,1L,1L,4L,53L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190647Inst : IEnumerable<long>
{
public static readonly long[] Value=A190647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190647.Bytes);
public long this[int i]=>Value[i];

public static A190647Inst Instance=new A190647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190646
{
public static readonly long[] Value={ 4L,7L,19L,41L,127252L,199L,26890624L,919L,17299L,6641L,25269208984376L,3401L,3900566650390624L,640063L,8418574L,18089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190646Inst : IEnumerable<long>
{
public static readonly long[] Value=A190646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190646.Bytes);
public long this[int i]=>Value[i];

public static A190646Inst Instance=new A190646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190645
{
public static readonly long[] Value={ 350L,738L,1276L,1314L,2890L,5052L,6356L,9052L,9054L,9950L,14050L,15966L,16852L,17916L,17948L,19166L,19852L,22475L,23348L,23420L,24350L,25182L,25184L,25186L,30476L,32418L,41058L,41060L,47646L,47648L,54927L,56452L,57436L,59924L,61794L,61796L,66787L,68348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190645Inst : IEnumerable<long>
{
public static readonly long[] Value=A190645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190645.Bytes);
public long this[int i]=>Value[i];

public static A190645Inst Instance=new A190645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190644
{
public static readonly long[] Value={ 6L,34L,39L,7L,11L,19L,29L,41L,79L,71L,179L,199L,181L,239L,883L,419L,701L,839L,881L,1429L,2351L,1259L,1871L,2161L,4049L,3079L,3361L,2521L,6481L,4159L,6299L,5279L,11551L,5039L,20789L,7561L,25919L,10079L,16561L,13441L,38611L,13859L,23761L,21839L,100673L,20161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190644Inst : IEnumerable<long>
{
public static readonly long[] Value=A190644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190644.Bytes);
public long this[int i]=>Value[i];

public static A190644Inst Instance=new A190644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190643
{
public static readonly long[] Value={ 1L,5L,1L,7L,1L,1L,9L,8L,0L,6L,9L,9L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190643Inst : IEnumerable<long>
{
public static readonly long[] Value=A190643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190643.Bytes);
public long this[int i]=>Value[i];

public static A190643Inst Instance=new A190643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190642
{
public static readonly long[] Value={ 2L,12L,22L,102L,112L,122L,202L,212L,222L,1002L,1012L,1022L,1102L,1112L,1122L,1202L,1212L,1222L,2002L,2012L,2022L,2102L,2112L,2122L,2202L,2212L,2222L,10002L,10012L,10022L,10102L,10112L,10122L,10202L,10212L,10222L,11002L,11012L,11022L,11102L,11112L,11122L,11202L,11212L,11222L,12002L,12012L,12022L,12102L,12112L,12122L,12202L,12212L,12222L,20002L,20012L,20022L,20102L,20112L,20122L,20202L,20212L,20222L,21002L,21012L,21022L,21102L,21112L,21122L,21202L,21212L,21222L,22002L,22012L,22022L,22102L,22112L,22122L,22202L,22212L,22222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190642Inst : IEnumerable<long>
{
public static readonly long[] Value=A190642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190642.Bytes);
public long this[int i]=>Value[i];

public static A190642Inst Instance=new A190642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190641
{
public static readonly long[] Value={ 4L,8L,9L,12L,16L,18L,20L,24L,25L,27L,28L,32L,40L,44L,45L,48L,49L,50L,52L,54L,56L,60L,63L,64L,68L,75L,76L,80L,81L,84L,88L,90L,92L,96L,98L,99L,104L,112L,116L,117L,120L,121L,124L,125L,126L,128L,132L,135L,136L,140L,147L,148L,150L,152L,153L,156L,160L,162L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190641Inst : IEnumerable<long>
{
public static readonly long[] Value=A190641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190641.Bytes);
public long this[int i]=>Value[i];

public static A190641Inst Instance=new A190641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190640
{
public static readonly long[] Value={ 2L,8L,20L,26L,56L,62L,74L,80L,164L,170L,182L,188L,218L,224L,236L,242L,488L,494L,506L,512L,542L,548L,560L,566L,650L,656L,668L,674L,704L,710L,722L,728L,1460L,1466L,1478L,1484L,1514L,1520L,1532L,1538L,1622L,1628L,1640L,1646L,1676L,1682L,1694L,1700L,1946L,1952L,1964L,1970L,2000L,2006L,2018L,2024L,2108L,2114L,2126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190640Inst : IEnumerable<long>
{
public static readonly long[] Value=A190640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190640.Bytes);
public long this[int i]=>Value[i];

public static A190640Inst Instance=new A190640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190639
{
public static readonly long[] Value={ 473267L,726760L,1773439L,1808828L,1919128L,2131583L,2165420L,2339971L,2390652L,2518488L,2802591L,2844914L,2982584L,2996184L,3183263L,3193175L,3250986L,3418185L,3428241L,3633472L,3909324L,3953449L,4280455L,4303819L,4373399L,4658285L,4728653L,4978360L,5165402L,5254365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190639Inst : IEnumerable<long>
{
public static readonly long[] Value=A190639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190639.Bytes);
public long this[int i]=>Value[i];

public static A190639Inst Instance=new A190639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190638
{
public static readonly long[] Value={ 5L,41L,257L,2309L,14621L,48821L,125429L,177269L,1595417L,5278001L,10596137L,15146069L,21523361L,63993929L,83629517L,111321257L,363526421L,375805589L,427518041L,446072909L,552010829L,752665649L,1980098177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190638Inst : IEnumerable<long>
{
public static readonly long[] Value=A190638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190638.Bytes);
public long this[int i]=>Value[i];

public static A190638Inst Instance=new A190638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190637
{
public static readonly long[] Value={ 3L,43L,7639L,25703L,38371L,61291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190637Inst : IEnumerable<long>
{
public static readonly long[] Value=A190637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190637.Bytes);
public long this[int i]=>Value[i];

public static A190637Inst Instance=new A190637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190636
{
public static readonly long[] Value={ 1L,98L,1647L,12304L,58625L,210006L,617743L,1572992L,3587409L,7500250L,14615711L,26874288L,47061937L,79060814L,128145375L,201327616L,307755233L,459166482L,670405519L,960002000L,1350818721L,1870771078L,2553622127L,3439857024L,4577640625L,6023862026L,7845269823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190636Inst : IEnumerable<long>
{
public static readonly long[] Value=A190636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190636.Bytes);
public long this[int i]=>Value[i];

public static A190636Inst Instance=new A190636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190603
{
public static readonly BigInteger[] Value={ 37L,246L,2435L,36125L,815754L,27533597L,1385237002L,104775207569L,11774001696187L,1960966610305152L,486160565780600788L,BigInteger.Parse("179685877495264963185"),BigInteger.Parse("99104740635101570708266") };
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
public class A190603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190603Inst Instance=new A190603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190602
{
public static readonly BigInteger[] Value={ 42L,334L,4449L,97424L,3388130L,187160348L,16551136352L,2348378261899L,533921776093322L,194297764330364986L,BigInteger.Parse("113166821986252773490"),BigInteger.Parse("105535296084137818939844"),BigInteger.Parse("157606962038222415838019755") };
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
public class A190602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190602Inst Instance=new A190602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190601
{
public static readonly BigInteger[] Value={ 48L,576L,11520L,403200L,25401600L,2743372800L,526727577600L,176980466073600L,104064514051276800L,BigInteger.Parse("107810836557122764800"),BigInteger.Parse("195461046678063572582400"),BigInteger.Parse("622543433669632478674944000"),BigInteger.Parse("3480017794213245555792936960000") };
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
public class A190601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190601Inst Instance=new A190601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190600
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,2L,2L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,3L,3L,3L,4L,5L,6L,7L,8L,9L,10L,11L,4L,4L,4L,4L,4L,5L,6L,7L,8L,9L,10L,11L,5L,5L,5L,5L,5L,5L,6L,7L,8L,9L,10L,11L,6L,6L,6L,6L,6L,6L,6L,7L,8L,9L,10L,11L,7L,7L,7L,7L,7L,7L,7L,7L,8L,9L,10L,11L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190600Inst : IEnumerable<long>
{
public static readonly long[] Value=A190600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190600.Bytes);
public long this[int i]=>Value[i];

public static A190600Inst Instance=new A190600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190599
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,2L,2L,3L,4L,5L,6L,7L,8L,9L,10L,3L,3L,3L,3L,4L,5L,6L,7L,8L,9L,10L,4L,4L,4L,4L,4L,5L,6L,7L,8L,9L,10L,5L,5L,5L,5L,5L,5L,6L,7L,8L,9L,10L,6L,6L,6L,6L,6L,6L,6L,7L,8L,9L,10L,7L,7L,7L,7L,7L,7L,7L,7L,8L,9L,10L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,10L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190599Inst : IEnumerable<long>
{
public static readonly long[] Value=A190599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190599.Bytes);
public long this[int i]=>Value[i];

public static A190599Inst Instance=new A190599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190598
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,1L,1L,2L,3L,4L,5L,6L,7L,8L,2L,2L,2L,3L,4L,5L,6L,7L,8L,3L,3L,3L,3L,4L,5L,6L,7L,8L,4L,4L,4L,4L,4L,5L,6L,7L,8L,5L,5L,5L,5L,5L,5L,6L,7L,8L,6L,6L,6L,6L,6L,6L,6L,7L,8L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,1L,1L,2L,3L,4L,5L,6L,7L,8L,1L,1L,2L,3L,4L,5L,6L,7L,8L,2L,2L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190598Inst : IEnumerable<long>
{
public static readonly long[] Value=A190598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190598.Bytes);
public long this[int i]=>Value[i];

public static A190598Inst Instance=new A190598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190597
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,1L,1L,2L,3L,4L,5L,6L,7L,2L,2L,2L,3L,4L,5L,6L,7L,3L,3L,3L,3L,4L,5L,6L,7L,4L,4L,4L,4L,4L,5L,6L,7L,5L,5L,5L,5L,5L,5L,6L,7L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,1L,1L,2L,3L,4L,5L,6L,7L,1L,1L,2L,3L,4L,5L,6L,7L,2L,2L,2L,3L,4L,5L,6L,7L,3L,3L,3L,3L,4L,5L,6L,7L,4L,4L,4L,4L,4L,5L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190597Inst : IEnumerable<long>
{
public static readonly long[] Value=A190597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190597.Bytes);
public long this[int i]=>Value[i];

public static A190597Inst Instance=new A190597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190596
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,4L,5L,6L,2L,2L,2L,3L,4L,5L,6L,3L,3L,3L,3L,4L,5L,6L,4L,4L,4L,4L,4L,5L,6L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,1L,1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,4L,5L,6L,2L,2L,2L,3L,4L,5L,6L,3L,3L,3L,3L,4L,5L,6L,4L,4L,4L,4L,4L,5L,6L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,2L,2L,2L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190596Inst : IEnumerable<long>
{
public static readonly long[] Value=A190596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190596.Bytes);
public long this[int i]=>Value[i];

public static A190596Inst Instance=new A190596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190595
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,2L,2L,2L,3L,4L,5L,3L,3L,3L,3L,4L,5L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,1L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,2L,2L,2L,3L,4L,5L,3L,3L,3L,3L,4L,5L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,2L,2L,2L,3L,4L,5L,2L,2L,2L,3L,4L,5L,2L,2L,2L,3L,4L,5L,3L,3L,3L,3L,4L,5L,4L,4L,4L,4L,4L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190595Inst : IEnumerable<long>
{
public static readonly long[] Value=A190595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190595.Bytes);
public long this[int i]=>Value[i];

public static A190595Inst Instance=new A190595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190594
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,2L,2L,3L,4L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,1L,1L,2L,3L,4L,1L,1L,2L,3L,4L,2L,2L,2L,3L,4L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,2L,2L,2L,3L,4L,2L,2L,2L,3L,4L,2L,2L,2L,3L,4L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,3L,3L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190594Inst : IEnumerable<long>
{
public static readonly long[] Value=A190594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190594.Bytes);
public long this[int i]=>Value[i];

public static A190594Inst Instance=new A190594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190593
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,1L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,1L,1L,2L,3L,1L,1L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,1L,2L,3L,1L,1L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,1L,1L,2L,3L,1L,1L,2L,3L,2L,2L,2L,3L,3L,3L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190593Inst : IEnumerable<long>
{
public static readonly long[] Value=A190593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190593.Bytes);
public long this[int i]=>Value[i];

public static A190593Inst Instance=new A190593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190592
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190592Inst : IEnumerable<long>
{
public static readonly long[] Value=A190592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190592.Bytes);
public long this[int i]=>Value[i];

public static A190592Inst Instance=new A190592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190591
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,4L,7L,12L,23L,47L,96L,195L,402L,843L,1781L,3772L,8020L,17143L,36810L,79304L,171368L,371450L,807516L,1760145L,3845770L,8421528L,18480552L,40634154L,89507024L,197496651L,436469232L,966043263L,2141158866L,4751978668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190591Inst : IEnumerable<long>
{
public static readonly long[] Value=A190591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190591.Bytes);
public long this[int i]=>Value[i];

public static A190591Inst Instance=new A190591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190590
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,11L,31L,71L,157L,397L,1141L,3301L,9087L,24311L,66067L,185771L,532121L,1520889L,4316233L,12255913L,35079739L,101232419L,293236615L,849895311L,2465119669L,7167636741L,20909386941L,61162159501L,179214613111L,525803297743L,1544899158331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190590Inst : IEnumerable<long>
{
public static readonly long[] Value=A190590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190590.Bytes);
public long this[int i]=>Value[i];

public static A190590Inst Instance=new A190590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190589
{
public static readonly long[] Value={ 1L,4L,8L,20L,46L,110L,260L,616L,1456L,3442L,8134L,19218L,45394L,107204L,253140L,597666L,1410948L,3330622L,7861542L,18555092L,43792062L,103349390L,243895352L,575552060L,1358167086L,3204874310L,7562397040L,17844314546L,42104959766L,99348325696L,234413460808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190589Inst : IEnumerable<long>
{
public static readonly long[] Value=A190589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190589.Bytes);
public long this[int i]=>Value[i];

public static A190589Inst Instance=new A190589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190588
{
public static readonly long[] Value={ 1L,22L,33L,44L,55L,66L,77L,88L,99L,111L,123L,145L,167L,189L,246L,257L,347L,356L,1122L,1133L,1144L,1155L,1166L,1177L,1188L,1199L,1247L,1256L,1346L,1357L,2222L,2233L,2244L,2255L,2266L,2277L,2288L,2299L,2345L,2367L,2389L,3333L,3344L,3355L,3366L,3377L,3388L,3399L,4444L,4455L,4466L,4477L,4488L,4499L,4567L,4589L,5555L,5566L,5577L,5588L,5599L,6666L,6677L,6688L,6699L,6789L,7777L,7788L,7799L,8888L,8899L,9999L,11111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190588Inst : IEnumerable<long>
{
public static readonly long[] Value=A190588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190588.Bytes);
public long this[int i]=>Value[i];

public static A190588Inst Instance=new A190588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190555
{
public static readonly long[] Value={ 2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,2L,4L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,4L,2L,4L,1L,3L,1L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190555Inst : IEnumerable<long>
{
public static readonly long[] Value=A190555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190555.Bytes);
public long this[int i]=>Value[i];

public static A190555Inst Instance=new A190555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190554
{
public static readonly long[] Value={ 7L,12L,24L,36L,41L,53L,65L,70L,82L,94L,106L,111L,123L,135L,140L,152L,164L,176L,181L,193L,205L,210L,222L,234L,239L,246L,251L,263L,275L,280L,292L,304L,309L,321L,333L,345L,350L,362L,374L,379L,391L,403L,408L,415L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190554Inst : IEnumerable<long>
{
public static readonly long[] Value=A190554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190554.Bytes);
public long this[int i]=>Value[i];

public static A190554Inst Instance=new A190554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190553
{
public static readonly long[] Value={ 2L,4L,9L,14L,19L,21L,26L,31L,33L,38L,43L,48L,50L,55L,60L,62L,67L,72L,74L,77L,79L,84L,89L,91L,96L,101L,103L,108L,113L,118L,120L,125L,130L,132L,137L,142L,144L,147L,149L,154L,159L,161L,166L,171L,173L,178L,183L,188L,190L,195L,200L,202L,207L,212L,217L,219L,224L,229L,231L,236L,241L,243L,248L,253L,258L,260L,265L,270L,272L,277L,282L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190553Inst : IEnumerable<long>
{
public static readonly long[] Value=A190553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190553.Bytes);
public long this[int i]=>Value[i];

public static A190553Inst Instance=new A190553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190552
{
public static readonly long[] Value={ 1L,6L,11L,16L,18L,23L,28L,30L,35L,40L,42L,45L,47L,52L,57L,59L,64L,69L,71L,76L,81L,86L,88L,93L,98L,100L,105L,110L,115L,117L,122L,127L,129L,134L,139L,141L,146L,151L,156L,158L,163L,168L,170L,175L,180L,185L,187L,192L,197L,199L,204L,209L,211L,214L,216L,221L,226L,228L,233L,238L,240L,245L,250L,255L,257L,262L,267L,269L,274L,279L,284L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190552Inst : IEnumerable<long>
{
public static readonly long[] Value=A190552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190552.Bytes);
public long this[int i]=>Value[i];

public static A190552Inst Instance=new A190552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190551
{
public static readonly long[] Value={ 3L,8L,13L,15L,20L,25L,27L,32L,37L,39L,44L,49L,54L,56L,61L,66L,68L,73L,78L,83L,85L,90L,95L,97L,102L,107L,109L,112L,114L,119L,124L,126L,131L,136L,138L,143L,148L,153L,155L,160L,165L,167L,172L,177L,182L,184L,189L,194L,196L,201L,206L,208L,213L,218L,223L,225L,230L,235L,237L,242L,247L,252L,254L,259L,264L,266L,271L,276L,278L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190551Inst : IEnumerable<long>
{
public static readonly long[] Value=A190551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190551.Bytes);
public long this[int i]=>Value[i];

public static A190551Inst Instance=new A190551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190550
{
public static readonly long[] Value={ 5L,10L,17L,22L,29L,34L,46L,51L,58L,63L,75L,80L,87L,92L,99L,104L,116L,121L,128L,133L,145L,150L,157L,162L,169L,174L,179L,186L,191L,198L,203L,215L,220L,227L,232L,244L,249L,256L,261L,268L,273L,285L,290L,297L,302L,314L,319L,326L,331L,338L,343L,348L,355L,360L,367L,372L,384L,389L,396L,401L,413L,418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190550Inst : IEnumerable<long>
{
public static readonly long[] Value=A190550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190550.Bytes);
public long this[int i]=>Value[i];

public static A190550Inst Instance=new A190550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190549
{
public static readonly long[] Value={ 2L,3L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,2L,3L,1L,3L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190549Inst : IEnumerable<long>
{
public static readonly long[] Value=A190549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190549.Bytes);
public long this[int i]=>Value[i];

public static A190549Inst Instance=new A190549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190548
{
public static readonly long[] Value={ 2L,7L,12L,14L,19L,24L,26L,31L,36L,41L,43L,48L,53L,55L,60L,65L,67L,70L,72L,77L,82L,84L,89L,94L,96L,101L,106L,111L,113L,118L,123L,125L,130L,135L,140L,142L,147L,152L,154L,159L,164L,166L,171L,176L,181L,183L,188L,193L,195L,200L,205L,210L,212L,217L,222L,224L,229L,234L,236L,239L,241L,246L,251L,253L,258L,263L,265L,270L,275L,280L,282L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190548Inst : IEnumerable<long>
{
public static readonly long[] Value=A190548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190548.Bytes);
public long this[int i]=>Value[i];

public static A190548Inst Instance=new A190548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190547
{
public static readonly long[] Value={ 4L,9L,11L,16L,21L,23L,28L,33L,38L,40L,45L,50L,52L,57L,62L,64L,69L,74L,79L,81L,86L,91L,93L,98L,103L,108L,110L,115L,120L,122L,127L,132L,134L,137L,139L,144L,149L,151L,156L,161L,163L,168L,173L,178L,180L,185L,190L,192L,197L,202L,207L,209L,214L,219L,221L,226L,231L,233L,238L,243L,248L,250L,255L,260L,262L,267L,272L,277L,279L,284L,289L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190547Inst : IEnumerable<long>
{
public static readonly long[] Value=A190547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190547.Bytes);
public long this[int i]=>Value[i];

public static A190547Inst Instance=new A190547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190546
{
public static readonly long[] Value={ 1L,6L,8L,13L,18L,20L,25L,30L,32L,35L,37L,42L,47L,49L,54L,59L,61L,66L,71L,76L,78L,83L,88L,90L,95L,100L,105L,107L,112L,117L,119L,124L,129L,131L,136L,141L,146L,148L,153L,158L,160L,165L,170L,175L,177L,182L,187L,189L,194L,199L,201L,204L,206L,211L,216L,218L,223L,228L,230L,235L,240L,245L,247L,252L,257L,259L,264L,269L,271L,274L,276L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190546Inst : IEnumerable<long>
{
public static readonly long[] Value=A190546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190546.Bytes);
public long this[int i]=>Value[i];

public static A190546Inst Instance=new A190546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190545
{
public static readonly long[] Value={ 3L,5L,10L,15L,17L,22L,27L,29L,34L,39L,44L,46L,51L,56L,58L,63L,68L,73L,75L,80L,85L,87L,92L,97L,99L,102L,104L,109L,114L,116L,121L,126L,128L,133L,138L,143L,145L,150L,155L,157L,162L,167L,169L,172L,174L,179L,184L,186L,191L,196L,198L,203L,208L,213L,215L,220L,225L,227L,232L,237L,242L,244L,249L,254L,256L,261L,266L,268L,273L,278L,283L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190545Inst : IEnumerable<long>
{
public static readonly long[] Value=A190545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190545.Bytes);
public long this[int i]=>Value[i];

public static A190545Inst Instance=new A190545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190544
{
public static readonly long[] Value={ 1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190544Inst : IEnumerable<long>
{
public static readonly long[] Value=A190544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190544.Bytes);
public long this[int i]=>Value[i];

public static A190544Inst Instance=new A190544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190543
{
public static readonly long[] Value={ 0L,5L,55L,485L,4015L,32525L,261415L,2094965L,16770655L,134198045L,1073682775L,8589757445L,68718945295L,549754219565L,4398041728135L,35184357739925L,281474933663935L,2251799684545085L,18014398122061495L,144115186913594405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190543Inst : IEnumerable<long>
{
public static readonly long[] Value=A190543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190543.Bytes);
public long this[int i]=>Value[i];

public static A190543Inst Instance=new A190543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190542
{
public static readonly long[] Value={ 0L,3L,33L,279L,2145L,15783L,113553L,807159L,5699265L,40091463L,281426673L,1973132439L,13824509985L,96821901543L,677954637393L,4746487768119L,33228635602305L,232613334118023L,1628344878433713L,11398620307466199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190542Inst : IEnumerable<long>
{
public static readonly long[] Value=A190542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190542.Bytes);
public long this[int i]=>Value[i];

public static A190542Inst Instance=new A190542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190541
{
public static readonly long[] Value={ 0L,4L,40L,316L,2320L,16564L,116920L,821356L,5758240L,40333924L,282416200L,1977149596L,13840755760L,96887416084L,678218289880L,4747547161036L,33232887522880L,232630384847044L,1628413210489960L,11398894023111676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190541Inst : IEnumerable<long>
{
public static readonly long[] Value=A190541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190541.Bytes);
public long this[int i]=>Value[i];

public static A190541Inst Instance=new A190541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190540
{
public static readonly long[] Value={ 0L,5L,45L,335L,2385L,16775L,117585L,823415L,5764545L,40353095L,282474225L,1977324695L,13841283105L,96889002215L,678223056465L,4747561477175L,33232930504065L,232630513856135L,1628413597648305L,11398895184848855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190540Inst : IEnumerable<long>
{
public static readonly long[] Value=A190540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190540.Bytes);
public long this[int i]=>Value[i];

public static A190540Inst Instance=new A190540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190507
{
public static readonly long[] Value={ 1L,4L,7L,10L,11L,15L,17L,20L,24L,25L,28L,31L,34L,35L,39L,42L,44L,48L,49L,53L,55L,58L,62L,63L,66L,69L,72L,73L,77L,80L,82L,86L,87L,90L,93L,96L,97L,101L,104L,107L,110L,111L,115L,117L,120L,124L,125L,128L,131L,134L,135L,139L,142L,144L,148L,149L,152L,155L,158L,162L,163L,166L,169L,172L,173L,177L,179L,182L,186L,187L,190L,193L,196L,197L,201L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190507Inst : IEnumerable<long>
{
public static readonly long[] Value=A190507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190507.Bytes);
public long this[int i]=>Value[i];

public static A190507Inst Instance=new A190507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190506
{
public static readonly long[] Value={ 2L,5L,9L,12L,16L,19L,23L,26L,30L,33L,36L,40L,43L,47L,50L,54L,57L,61L,64L,67L,71L,74L,78L,81L,85L,88L,92L,95L,98L,102L,105L,109L,112L,116L,119L,123L,126L,129L,133L,136L,140L,143L,147L,150L,154L,157L,161L,164L,167L,171L,174L,178L,181L,185L,188L,192L,195L,198L,202L,205L,209L,212L,216L,219L,223L,226L,229L,233L,236L,240L,243L,247L,250L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190506Inst : IEnumerable<long>
{
public static readonly long[] Value=A190506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190506.Bytes);
public long this[int i]=>Value[i];

public static A190506Inst Instance=new A190506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190505
{
public static readonly long[] Value={ 3L,8L,13L,18L,22L,27L,32L,37L,41L,46L,51L,56L,60L,65L,70L,75L,79L,84L,89L,94L,99L,103L,108L,113L,118L,122L,127L,132L,137L,141L,146L,151L,156L,160L,165L,170L,175L,180L,184L,189L,194L,199L,203L,208L,213L,218L,222L,227L,232L,237L,241L,246L,251L,256L,261L,265L,270L,275L,280L,284L,289L,294L,299L,303L,308L,313L,318L,322L,327L,332L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190505Inst : IEnumerable<long>
{
public static readonly long[] Value=A190505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190505.Bytes);
public long this[int i]=>Value[i];

public static A190505Inst Instance=new A190505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190504
{
public static readonly long[] Value={ 6L,14L,21L,29L,38L,45L,52L,59L,68L,76L,83L,91L,100L,106L,114L,121L,130L,138L,145L,153L,159L,168L,176L,183L,191L,200L,207L,214L,221L,230L,238L,245L,253L,262L,268L,276L,283L,291L,300L,307L,315L,321L,330L,338L,345L,353L,362L,368L,376L,383L,392L,400L,407L,415L,421L,430L,438L,445L,453L,462L,469L,476L,483L,492L,500L,507L,515L,524L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190504Inst : IEnumerable<long>
{
public static readonly long[] Value=A190504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190504.Bytes);
public long this[int i]=>Value[i];

public static A190504Inst Instance=new A190504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190503
{
public static readonly long[] Value={ 1L,2L,6L,12L,14L,22L,24L,28L,44L,46L,48L,56L,68L,87L,88L,92L,94L,96L,112L,118L,166L,174L,176L,184L,188L,192L,214L,224L,236L,332L,334L,352L,358L,362L,368L,376L,384L,390L,410L,428L,448L,454L,472L,526L,664L,668L,694L,704L,716L,718L,736L,752L,766L,768L,856L,896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190503Inst : IEnumerable<long>
{
public static readonly long[] Value=A190503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190503.Bytes);
public long this[int i]=>Value[i];

public static A190503Inst Instance=new A190503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190502
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,4L,7L,13L,23L,42L,75L,137L,255L,463L,872L,1612L,3030L,5706L,10749L,20387L,38635L,73584L,140336L,268216L,513705L,985818L,1894120L,3645744L,7027290L,13561906L,26207278L,50697533L,98182656L,190335585L,369323301L,717267167L,1394192236L,2712103833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190502Inst : IEnumerable<long>
{
public static readonly long[] Value=A190502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190502.Bytes);
public long this[int i]=>Value[i];

public static A190502Inst Instance=new A190502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190501
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,2L,3L,6L,10L,19L,33L,62L,118L,208L,409L,740L,1418L,2676L,5043L,9638L,18248L,34949L,66752L,127880L,245489L,472113L,908302L,1751624L,3381546L,6534616L,12645372L,24490255L,47485123L,92152929L,178987716L,347943866L,676925069L,1317911597L,2567659990L,5005877954L,9765539069L,19062301793L,37230980158L,72756216207L,142253989491L,278275735952L,544621563320L,1066382258001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190501Inst : IEnumerable<long>
{
public static readonly long[] Value=A190501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190501.Bytes);
public long this[int i]=>Value[i];

public static A190501Inst Instance=new A190501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190500
{
public static readonly long[] Value={ 2L,7L,9L,12L,14L,19L,24L,26L,31L,36L,38L,41L,43L,48L,53L,55L,60L,65L,67L,70L,72L,77L,82L,84L,89L,94L,96L,101L,106L,108L,111L,113L,118L,123L,125L,130L,135L,137L,140L,142L,147L,152L,154L,159L,164L,166L,171L,176L,178L,181L,183L,188L,193L,195L,200L,205L,207L,210L,212L,217L,222L,224L,229L,234L,236L,239L,241L,246L,248L,251L,253L,258L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190500Inst : IEnumerable<long>
{
public static readonly long[] Value=A190500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190500.Bytes);
public long this[int i]=>Value[i];

public static A190500Inst Instance=new A190500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190499
{
public static readonly long[] Value={ 1L,4L,6L,11L,16L,18L,21L,23L,28L,30L,33L,35L,40L,42L,45L,47L,50L,52L,57L,59L,62L,64L,69L,71L,74L,76L,79L,81L,86L,88L,91L,93L,98L,100L,103L,105L,110L,112L,115L,117L,120L,122L,127L,129L,132L,134L,139L,141L,144L,146L,149L,151L,156L,158L,161L,163L,168L,170L,173L,175L,180L,185L,187L,190L,192L,197L,199L,202L,204L,209L,211L,214L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190499Inst : IEnumerable<long>
{
public static readonly long[] Value=A190499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190499.Bytes);
public long this[int i]=>Value[i];

public static A190499Inst Instance=new A190499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190498
{
public static readonly long[] Value={ 3L,5L,8L,10L,13L,15L,20L,22L,25L,27L,32L,34L,37L,39L,44L,49L,51L,54L,56L,61L,63L,66L,68L,73L,75L,78L,80L,83L,85L,90L,92L,95L,97L,102L,104L,107L,109L,114L,119L,121L,124L,126L,131L,133L,136L,138L,143L,145L,148L,150L,153L,155L,160L,162L,165L,167L,172L,174L,177L,179L,182L,184L,189L,191L,194L,196L,201L,203L,206L,208L,213L,218L,220L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190498Inst : IEnumerable<long>
{
public static readonly long[] Value=A190498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190498.Bytes);
public long this[int i]=>Value[i];

public static A190498Inst Instance=new A190498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190497
{
public static readonly long[] Value={ 17L,29L,46L,58L,87L,99L,116L,128L,157L,169L,186L,198L,215L,227L,256L,268L,285L,297L,326L,338L,355L,367L,396L,425L,437L,454L,466L,495L,507L,524L,536L,565L,577L,594L,606L,623L,635L,664L,676L,693L,705L,734L,746L,763L,775L,792L,804L,833L,845L,862L,874L,903L,915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190497Inst : IEnumerable<long>
{
public static readonly long[] Value=A190497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190497.Bytes);
public long this[int i]=>Value[i];

public static A190497Inst Instance=new A190497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190496
{
public static readonly long[] Value={ 2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,2L,3L,1L,2L,0L,2L,3L,1L,2L,1L,2L,3L,1L,3L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190496Inst : IEnumerable<long>
{
public static readonly long[] Value=A190496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190496.Bytes);
public long this[int i]=>Value[i];

public static A190496Inst Instance=new A190496Inst();

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