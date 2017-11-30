using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A105079
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,4L,2L,2L,4L,3L,3L,4L,5L,5L,5L,5L,5L,2L,2L,4L,3L,3L,6L,3L,6L,4L,3L,5L,6L,6L,5L,8L,5L,6L,3L,6L,4L,6L,2L,3L,5L,8L,3L,3L,2L,4L,5L,4L,5L,3L,6L,6L,5L,7L,4L,7L,4L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105079Inst : IEnumerable<long>
{
public static readonly long[] Value=A105079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105079.Bytes);
public long this[int i]=>Value[i];

public static A105079Inst Instance=new A105079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105080
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,2L,3L,4L,4L,5L,4L,5L,4L,4L,4L,4L,5L,3L,5L,4L,5L,3L,4L,8L,4L,3L,6L,5L,5L,3L,7L,5L,3L,5L,1L,4L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105080Inst : IEnumerable<long>
{
public static readonly long[] Value=A105080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105080.Bytes);
public long this[int i]=>Value[i];

public static A105080Inst Instance=new A105080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105081
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,8L,6L,5L,13L,14L,16L,15L,11L,12L,10L,9L,25L,26L,28L,27L,31L,32L,30L,29L,21L,22L,24L,23L,19L,20L,18L,17L,49L,50L,52L,51L,55L,56L,54L,53L,61L,62L,64L,63L,59L,60L,58L,57L,41L,42L,44L,43L,47L,48L,46L,45L,37L,38L,40L,39L,35L,36L,34L,33L,97L,98L,100L,99L,103L,104L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105081Inst : IEnumerable<long>
{
public static readonly long[] Value=A105081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105081.Bytes);
public long this[int i]=>Value[i];

public static A105081Inst Instance=new A105081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105082
{
public static readonly long[] Value={ 5L,14L,33L,80L,193L,466L,1125L,2716L,6557L,15830L,38217L,92264L,222745L,537754L,1298253L,3134260L,7566773L,18267806L,44102385L,106472576L,257047537L,620567650L,1498182837L,3616933324L,8732049485L,21081032294L,50894114073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105082Inst : IEnumerable<long>
{
public static readonly long[] Value=A105082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105082.Bytes);
public long this[int i]=>Value[i];

public static A105082Inst Instance=new A105082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105083
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,1L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,1L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,1L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,1L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105083Inst : IEnumerable<long>
{
public static readonly long[] Value=A105083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105083.Bytes);
public long this[int i]=>Value[i];

public static A105083Inst Instance=new A105083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105084
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,2L,1L,11L,6L,2L,1L,21L,16L,7L,2L,1L,36L,36L,22L,8L,2L,1L,57L,71L,57L,29L,9L,2L,1L,85L,127L,127L,85L,37L,10L,2L,1L,121L,211L,253L,211L,121L,46L,11L,2L,1L,166L,331L,463L,463L,331L,166L,56L,12L,2L,1L,221L,496L,793L,925L,793L,496L,221L,67L,13L,2L,1L,287L,716L,1288L,1717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105084Inst : IEnumerable<long>
{
public static readonly long[] Value=A105084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105084.Bytes);
public long this[int i]=>Value[i];

public static A105084Inst Instance=new A105084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105085
{
public static readonly long[] Value={ 6L,7L,12L,13L,10L,11L,8L,9L,30L,31L,20L,21L,18L,19L,16L,17L,22L,23L,28L,29L,26L,27L,56L,57L,46L,47L,36L,37L,34L,35L,32L,33L,38L,39L,44L,45L,42L,43L,40L,41L,62L,63L,52L,53L,50L,51L,48L,49L,54L,55L,60L,61L,122L,123L,88L,89L,78L,79L,68L,69L,66L,67L,64L,65L,70L,71L,76L,77L,74L,75L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105085Inst : IEnumerable<long>
{
public static readonly long[] Value=A105085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105085.Bytes);
public long this[int i]=>Value[i];

public static A105085Inst Instance=new A105085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105086
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,10L,1L,13L,10L,16L,1L,26L,1L,22L,21L,29L,1L,37L,1L,40L,29L,34L,1L,58L,26L,40L,37L,54L,1L,70L,1L,61L,45L,52L,43L,89L,1L,58L,53L,88L,1L,94L,1L,82L,75L,70L,1L,122L,50L,91L,69L,96L,1L,118L,67L,118L,77L,88L,1L,166L,1L,94L,101L,125L,79L,142L,1L,124L,93L,142L,1L,193L,1L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105086Inst : IEnumerable<long>
{
public static readonly long[] Value=A105086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105086.Bytes);
public long this[int i]=>Value[i];

public static A105086Inst Instance=new A105086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105087
{
public static readonly long[] Value={ 1L,0L,0L,4L,2L,0L,0L,0L,0L,0L,0L,10L,4L,4L,2L,6L,2L,4L,2L,0L,0L,4L,10L,0L,6L,4L,0L,4L,8L,2L,6L,0L,2L,2L,2L,6L,6L,0L,0L,6L,2L,0L,2L,8L,4L,0L,0L,12L,4L,6L,10L,14L,2L,2L,28L,4L,4L,2L,6L,8L,2L,2L,0L,4L,14L,20L,10L,4L,0L,8L,6L,0L,4L,2L,14L,0L,4L,8L,0L,4L,4L,16L,10L,12L,2L,2L,0L,0L,2L,6L,8L,20L,6L,20L,6L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105087Inst : IEnumerable<long>
{
public static readonly long[] Value=A105087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105087.Bytes);
public long this[int i]=>Value[i];

public static A105087Inst Instance=new A105087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105088
{
public static readonly long[] Value={ 34L,120L,240L,368L,516L,648L,816L,960L,1152L,1320L,1488L,1660L,1856L,2024L,2196L,2388L,2596L,2816L,3004L,3192L,3408L,3576L,3740L,3960L,4188L,4472L,4656L,4840L,5016L,5204L,5388L,5640L,5884L,6076L,6332L,6564L,6756L,6960L,7176L,7452L,7676L,7896L,8124L,8304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105088Inst : IEnumerable<long>
{
public static readonly long[] Value=A105088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105088.Bytes);
public long this[int i]=>Value[i];

public static A105088Inst Instance=new A105088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105089
{
public static readonly long[] Value={ 100L,401L,763L,1163L,1601L,2053L,2501L,3017L,3517L,3997L,4479L,5105L,5571L,6045L,6639L,7217L,7741L,8331L,8927L,9417L,9949L,10613L,11201L,11711L,12467L,13063L,13559L,14159L,14653L,15311L,15937L,16661L,17253L,17959L,18531L,19093L,19813L,20461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105089Inst : IEnumerable<long>
{
public static readonly long[] Value=A105089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105089.Bytes);
public long this[int i]=>Value[i];

public static A105089Inst Instance=new A105089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105090
{
public static readonly long[] Value={ 36L,133L,253L,389L,533L,679L,841L,1007L,1175L,1327L,1489L,1703L,1859L,2021L,2209L,2405L,2571L,2769L,2977L,3139L,3319L,3545L,3733L,3905L,4135L,4361L,4525L,4721L,4891L,5099L,5319L,5549L,5743L,5987L,6177L,6361L,6599L,6813L,7021L,7193L,7425L,7675L,7927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105090Inst : IEnumerable<long>
{
public static readonly long[] Value=A105090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105090.Bytes);
public long this[int i]=>Value[i];

public static A105090Inst Instance=new A105090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105091
{
public static readonly long[] Value={ 33L,133L,253L,383L,537L,691L,829L,1003L,1169L,1333L,1495L,1703L,1855L,2015L,2217L,2417L,2589L,2781L,2977L,3143L,3313L,3537L,3725L,3899L,4157L,4349L,4511L,4713L,4871L,5113L,5317L,5563L,5747L,5987L,6183L,6377L,6607L,6827L,7025L,7187L,7391L,7673L,7927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105091Inst : IEnumerable<long>
{
public static readonly long[] Value=A105091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105091.Bytes);
public long this[int i]=>Value[i];

public static A105091Inst Instance=new A105091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105092
{
public static readonly long[] Value={ 20L,62L,118L,194L,262L,346L,422L,502L,602L,658L,790L,878L,974L,1066L,1162L,1266L,1378L,1462L,1578L,1658L,1766L,1882L,2030L,2122L,2238L,2338L,2458L,2570L,2662L,2762L,2866L,2986L,3106L,3290L,3406L,3514L,3614L,3698L,3830L,3918L,4022L,4150L,4310L,4430L,4538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105092Inst : IEnumerable<long>
{
public static readonly long[] Value=A105092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105092.Bytes);
public long this[int i]=>Value[i];

public static A105092Inst Instance=new A105092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105093
{
public static readonly long[] Value={ 18L,24L,30L,36L,60L,84L,120L,162L,204L,210L,216L,240L,288L,330L,372L,390L,456L,520L,540L,624L,726L,762L,798L,840L,852L,882L,924L,978L,990L,1104L,1140L,1164L,1200L,1392L,1410L,1428L,1530L,1632L,1650L,1716L,1740L,1764L,1794L,1848L,1974L,2052L,2100L,2112L,2184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105093Inst : IEnumerable<long>
{
public static readonly long[] Value=A105093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105093.Bytes);
public long this[int i]=>Value[i];

public static A105093Inst Instance=new A105093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105094
{
public static readonly long[] Value={ 8L,128L,1152L,7680L,42112L,200448L,855552L,3345408L,12166272L,41609856L,134973184L,418023936L,1242729984L,3561814784L,9877810176L,26587137024L,69636039808L,177877244160L,443991342720L,1084762764800L,2598075516672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105094Inst : IEnumerable<long>
{
public static readonly long[] Value=A105094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105094.Bytes);
public long this[int i]=>Value[i];

public static A105094Inst Instance=new A105094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105095
{
public static readonly long[] Value={ 1L,36L,402L,3064L,18351L,93300L,419150L,1708632L,6432867L,22659976L,75404754L,238825344L,724242492L,2113022844L,5954784540L,16263489048L,43168780485L,111630095424L,281807843656L,695783026296L,1682813702136L,3992563842088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105095Inst : IEnumerable<long>
{
public static readonly long[] Value=A105095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105095.Bytes);
public long this[int i]=>Value[i];

public static A105095Inst Instance=new A105095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105096
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105096Inst : IEnumerable<long>
{
public static readonly long[] Value=A105096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105096.Bytes);
public long this[int i]=>Value[i];

public static A105096Inst Instance=new A105096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105097
{
public static readonly BigInteger[] Value={ 1L,-504L,180252L,-56364992L,16415391870L,-4574618335008L,1237162549543256L,-327377686829760000L,BigInteger.Parse("85212608926827807477"),BigInteger.Parse("-21894492009015306942480"),BigInteger.Parse("5567179862617316105012532"),BigInteger.Parse("-1403483985988949037403977984") };
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
public class A105097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105097Inst Instance=new A105097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105098
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,2L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105098Inst : IEnumerable<long>
{
public static readonly long[] Value=A105098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105098.Bytes);
public long this[int i]=>Value[i];

public static A105098Inst Instance=new A105098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105099
{
public static readonly BigInteger[] Value={ 0L,335L,815L,772320L,1877280L,1777881455L,4321498895L,4092682338240L,9948088580160L,9421352964748175L,22900495590030575L,BigInteger.Parse("21687950432167961760"),BigInteger.Parse("52716930900161804640"),BigInteger.Parse("49925652473497683224495"),BigInteger.Parse("121354352031676884251855") };
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
public class A105099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105099Inst Instance=new A105099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105100
{
public static readonly long[] Value={ 41L,156L,304L,462L,630L,834L,1020L,1214L,1420L,1618L,1824L,2076L,2288L,2514L,2712L,2926L,3198L,3460L,3656L,3874L,4086L,4370L,4598L,4888L,5100L,5346L,5626L,5886L,6126L,6332L,6580L,6836L,7146L,7386L,7678L,7848L,8208L,8560L,8762L,8962L,9258L,9498L,9696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105100Inst : IEnumerable<long>
{
public static readonly long[] Value=A105100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105100.Bytes);
public long this[int i]=>Value[i];

public static A105100Inst Instance=new A105100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105101
{
public static readonly long[] Value={ 22L,83L,155L,235L,317L,417L,511L,613L,717L,809L,911L,1039L,1147L,1255L,1359L,1461L,1607L,1733L,1831L,1937L,2045L,2185L,2307L,2445L,2549L,2675L,2813L,2947L,3063L,3169L,3293L,3431L,3577L,3697L,3833L,3925L,4099L,4277L,4387L,4487L,4631L,4751L,4853L,4997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105101Inst : IEnumerable<long>
{
public static readonly long[] Value=A105101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105101.Bytes);
public long this[int i]=>Value[i];

public static A105101Inst Instance=new A105101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105102
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,5L,4L,1L,2L,2L,3L,2L,3L,3L,5L,4L,2L,3L,3L,5L,4L,3L,5L,4L,5L,4L,6L,5L,1L,2L,2L,3L,2L,3L,3L,5L,4L,2L,3L,3L,5L,4L,3L,5L,4L,5L,4L,6L,5L,2L,3L,3L,5L,4L,3L,5L,4L,5L,4L,6L,5L,3L,5L,4L,5L,4L,6L,5L,5L,4L,6L,5L,6L,5L,2L,1L,6L,1L,2L,2L,3L,2L,3L,3L,5L,4L,2L,3L,3L,5L,4L,3L,5L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105102Inst : IEnumerable<long>
{
public static readonly long[] Value=A105102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105102.Bytes);
public long this[int i]=>Value[i];

public static A105102Inst Instance=new A105102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105103
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,6L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,6L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,6L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,6L,1L,2L,1L,3L,1L,2L,6L,1L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105103Inst : IEnumerable<long>
{
public static readonly long[] Value=A105103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105103.Bytes);
public long this[int i]=>Value[i];

public static A105103Inst Instance=new A105103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105104
{
public static readonly long[] Value={ 0L,3L,3L,5L,1L,15L,5L,9L,1L,13L,7L,11L,7L,29L,9L,17L,1L,25L,13L,21L,5L,31L,11L,19L,3L,27L,15L,47L,13L,57L,17L,33L,1L,49L,25L,41L,9L,61L,21L,37L,5L,53L,29L,45L,15L,59L,35L,3L,51L,27L,43L,11L,63L,23L,39L,7L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105104Inst : IEnumerable<long>
{
public static readonly long[] Value=A105104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105104.Bytes);
public long this[int i]=>Value[i];

public static A105104Inst Instance=new A105104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105105
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,6L,5L,4L,1L,2L,2L,3L,2L,3L,3L,6L,5L,4L,2L,3L,3L,6L,5L,4L,3L,6L,5L,4L,6L,5L,4L,3L,2L,1L,6L,5L,1L,2L,2L,3L,2L,3L,3L,6L,5L,4L,2L,3L,3L,6L,5L,4L,3L,6L,5L,4L,6L,5L,4L,3L,2L,1L,6L,5L,2L,3L,3L,6L,5L,4L,3L,6L,5L,4L,6L,5L,4L,3L,2L,1L,6L,5L,3L,6L,5L,4L,6L,5L,4L,3L,2L,1L,6L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105105Inst : IEnumerable<long>
{
public static readonly long[] Value=A105105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105105.Bytes);
public long this[int i]=>Value[i];

public static A105105Inst Instance=new A105105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105106
{
public static readonly long[] Value={ 0L,5L,6L,8L,12L,15L,20L,21L,29L,42L,50L,53L,54L,56L,60L,65L,72L,74L,77L,78L,81L,83L,89L,95L,98L,102L,107L,116L,117L,119L,125L,131L,135L,138L,141L,149L,170L,174L,177L,182L,194L,197L,201L,204L,210L,221L,224L,230L,240L,242L,243L,252L,258L,261L,263L,264L,282L,285L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105106Inst : IEnumerable<long>
{
public static readonly long[] Value=A105106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105106.Bytes);
public long this[int i]=>Value[i];

public static A105106Inst Instance=new A105106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105107
{
public static readonly long[] Value={ 2L,5L,6L,8L,12L,18L,23L,36L,38L,41L,48L,50L,51L,54L,57L,68L,69L,71L,74L,75L,80L,86L,87L,89L,92L,95L,101L,102L,116L,120L,123L,129L,131L,137L,144L,146L,149L,155L,159L,183L,186L,204L,215L,216L,219L,225L,227L,228L,239L,246L,249L,251L,254L,257L,261L,269L,278L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105107Inst : IEnumerable<long>
{
public static readonly long[] Value=A105107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105107.Bytes);
public long this[int i]=>Value[i];

public static A105107Inst Instance=new A105107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105108
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,4L,8L,6L,7L,16L,11L,9L,10L,14L,12L,13L,17L,15L,25L,20L,18L,19L,23L,21L,22L,26L,24L,51L,34L,29L,27L,28L,32L,30L,31L,35L,33L,43L,38L,36L,37L,41L,39L,40L,44L,42L,52L,47L,45L,46L,50L,48L,49L,53L,78L,61L,56L,54L,55L,59L,57L,58L,62L,60L,70L,65L,63L,64L,68L,66L,67L,71L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105108Inst : IEnumerable<long>
{
public static readonly long[] Value=A105108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105108.Bytes);
public long this[int i]=>Value[i];

public static A105108Inst Instance=new A105108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105109
{
public static readonly long[] Value={ 0L,1L,4L,3L,2L,11L,7L,6L,5L,8L,10L,9L,24L,19L,14L,13L,12L,15L,18L,17L,16L,26L,22L,21L,20L,23L,25L,56L,39L,34L,29L,28L,27L,30L,33L,32L,31L,42L,37L,36L,35L,38L,41L,40L,55L,50L,45L,44L,43L,46L,49L,48L,47L,57L,53L,52L,51L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105109Inst : IEnumerable<long>
{
public static readonly long[] Value=A105109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105109.Bytes);
public long this[int i]=>Value[i];

public static A105109Inst Instance=new A105109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105110
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,6L,0L,12L,12L,156L,0L,20L,20L,420L,820L,0L,30L,30L,930L,1830L,29730L,0L,42L,42L,1806L,3570L,79422L,229362L,0L,56L,56L,3192L,6328L,185080L,539448L,10903928L,0L,72L,72L,5256L,10440L,388872L,1140552L,29139336L,111259080L,0L,90L,90L,8190L,16290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105110Inst : IEnumerable<long>
{
public static readonly long[] Value=A105110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105110.Bytes);
public long this[int i]=>Value[i];

public static A105110Inst Instance=new A105110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105111
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,3L,5L,4L,1L,2L,2L,3L,2L,3L,3L,3L,5L,4L,2L,3L,3L,3L,5L,4L,3L,3L,5L,4L,3L,5L,4L,3L,5L,4L,6L,5L,1L,2L,2L,3L,2L,3L,3L,3L,5L,4L,2L,3L,3L,3L,5L,4L,3L,3L,5L,4L,3L,5L,4L,3L,5L,4L,6L,5L,2L,3L,3L,3L,5L,4L,3L,3L,5L,4L,3L,5L,4L,3L,5L,4L,6L,5L,3L,3L,5L,4L,3L,5L,4L,3L,5L,4L,6L,5L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105111Inst : IEnumerable<long>
{
public static readonly long[] Value=A105111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105111.Bytes);
public long this[int i]=>Value[i];

public static A105111Inst Instance=new A105111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105112
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,3L,5L,5L,4L,1L,2L,2L,3L,2L,3L,3L,3L,5L,5L,4L,2L,3L,3L,3L,5L,5L,4L,3L,3L,5L,5L,4L,3L,5L,5L,4L,3L,5L,5L,4L,6L,6L,5L,1L,2L,2L,3L,2L,3L,3L,3L,5L,5L,4L,2L,3L,3L,3L,5L,5L,4L,3L,3L,5L,5L,4L,3L,5L,5L,4L,3L,5L,5L,4L,6L,6L,5L,2L,3L,3L,3L,5L,5L,4L,3L,3L,5L,5L,4L,3L,5L,5L,4L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105112Inst : IEnumerable<long>
{
public static readonly long[] Value=A105112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105112.Bytes);
public long this[int i]=>Value[i];

public static A105112Inst Instance=new A105112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105113
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,3L,5L,5L,5L,4L,1L,2L,2L,3L,2L,3L,3L,3L,5L,5L,5L,4L,2L,3L,3L,3L,5L,5L,5L,4L,3L,3L,5L,5L,5L,4L,3L,5L,5L,5L,4L,3L,5L,5L,5L,4L,6L,6L,6L,5L,1L,2L,2L,3L,2L,3L,3L,3L,5L,5L,5L,4L,2L,3L,3L,3L,5L,5L,5L,4L,3L,3L,5L,5L,5L,4L,3L,5L,5L,5L,4L,3L,5L,5L,5L,4L,6L,6L,6L,5L,2L,3L,3L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105113Inst : IEnumerable<long>
{
public static readonly long[] Value=A105113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105113.Bytes);
public long this[int i]=>Value[i];

public static A105113Inst Instance=new A105113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105114
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,4L,3L,1L,7L,6L,3L,12L,13L,6L,1L,21L,26L,13L,4L,37L,50L,30L,10L,1L,65L,96L,66L,24L,5L,114L,184L,139L,59L,15L,1L,200L,350L,288L,140L,40L,6L,351L,661L,591L,318L,105L,21L,1L,616L,1242L,1199L,704L,266L,62L,7L,1081L,2324L,2406L,1533L,645L,174L,28L,1L,1897L,4332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105114Inst : IEnumerable<long>
{
public static readonly long[] Value=A105114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105114.Bytes);
public long this[int i]=>Value[i];

public static A105114Inst Instance=new A105114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105115
{
public static readonly long[] Value={ 6L,12L,14L,15L,18L,22L,24L,26L,28L,30L,34L,35L,36L,38L,42L,44L,45L,46L,48L,52L,54L,55L,56L,58L,60L,62L,65L,66L,68L,70L,72L,74L,75L,76L,78L,82L,84L,85L,86L,88L,90L,92L,94L,95L,96L,98L,102L,104L,105L,106L,108L,110L,112L,114L,115L,116L,118L,120L,122L,124L,126L,130L,132L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105115Inst : IEnumerable<long>
{
public static readonly long[] Value=A105115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105115.Bytes);
public long this[int i]=>Value[i];

public static A105115Inst Instance=new A105115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105116
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,20L,21L,100L,101L,102L,110L,111L,120L,121L,200L,201L,202L,210L,211L,212L,1000L,1001L,1010L,1011L,1012L,1020L,1021L,1100L,1101L,1102L,1110L,1111L,1120L,1121L,1200L,1201L,1202L,1210L,1211L,1212L,2000L,2001L,2010L,2011L,2012L,2020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105116Inst : IEnumerable<long>
{
public static readonly long[] Value=A105116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105116.Bytes);
public long this[int i]=>Value[i];

public static A105116Inst Instance=new A105116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105117
{
public static readonly long[] Value={ 2L,3L,2L,4L,3L,2L,2L,3L,4L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,3L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,3L,2L,3L,2L,3L,4L,2L,3L,2L,3L,2L,2L,3L,3L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,2L,2L,3L,3L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105117Inst : IEnumerable<long>
{
public static readonly long[] Value=A105117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105117.Bytes);
public long this[int i]=>Value[i];

public static A105117Inst Instance=new A105117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105118
{
public static readonly long[] Value={ 2L,0L,2L,0L,2L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,1L,1L,2L,0L,2L,0L,2L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,2L,0L,0L,2L,2L,0L,0L,1L,0L,2L,1L,0L,0L,0L,2L,2L,0L,0L,1L,2L,0L,2L,0L,2L,2L,0L,0L,0L,1L,0L,0L,0L,1L,1L,2L,1L,2L,0L,0L,0L,0L,0L,1L,1L,2L,0L,0L,1L,1L,2L,1L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105118Inst : IEnumerable<long>
{
public static readonly long[] Value=A105118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105118.Bytes);
public long this[int i]=>Value[i];

public static A105118Inst Instance=new A105118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105119
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,18L,13L,14L,15L,16L,17L,12L,19L,50L,21L,22L,23L,54L,25L,26L,27L,98L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,250L,41L,42L,43L,242L,75L,46L,47L,162L,49L,20L,51L,338L,53L,24L,55L,686L,57L,58L,59L,90L,61L,62L,147L,64L,65L,66L,67L,578L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105119Inst : IEnumerable<long>
{
public static readonly long[] Value=A105119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105119.Bytes);
public long this[int i]=>Value[i];

public static A105119Inst Instance=new A105119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105120
{
public static readonly long[] Value={ 2L,5L,11L,23L,47L,97L,197L,397L,797L,1597L,3203L,6421L,12889L,25841L,51749L,103567L,207227L,414553L,829211L,1658533L,3317177L,6634469L,13269059L,26538257L,53076679L,106153547L,212307299L,424614829L,849229907L,1698460067L,3396920419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105120Inst : IEnumerable<long>
{
public static readonly long[] Value=A105120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105120.Bytes);
public long this[int i]=>Value[i];

public static A105120Inst Instance=new A105120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105121
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,3L,3L,3L,3L,9L,15L,47L,63L,67L,69L,93L,99L,105L,111L,111L,115L,121L,139L,165L,189L,205L,231L,249L,253L,285L,291L,309L,323L,363L,367L,369L,377L,395L,401L,465L,501L,533L,587L,591L,609L,629L,657L,693L,729L,735L,783L,787L,825L,863L,863L,869L,917L,981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105121Inst : IEnumerable<long>
{
public static readonly long[] Value=A105121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105121.Bytes);
public long this[int i]=>Value[i];

public static A105121Inst Instance=new A105121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105122
{
public static readonly long[] Value={ 2L,6L,12L,232L,262L,280L,330L,430L,508L,772L,786L,852L,1012L,1522L,1566L,1626L,1810L,2346L,2556L,2676L,3658L,3888L,3910L,4018L,4048L,4258L,4830L,5188L,5322L,5478L,5848L,6090L,6366L,6568L,7018L,7458L,7602L,7606L,7822L,8178L,8928L,9420L,9618L,9676L,10398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105122Inst : IEnumerable<long>
{
public static readonly long[] Value=A105122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105122.Bytes);
public long this[int i]=>Value[i];

public static A105122Inst Instance=new A105122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105123
{
public static readonly long[] Value={ 1L,1L,1L,6L,3L,1L,1L,1L,6L,3L,1L,1L,6L,3L,1L,1L,6L,3L,1L,6L,8L,1L,6L,3L,1L,2L,4L,1L,6L,3L,1L,1L,1L,6L,3L,1L,1L,6L,3L,1L,1L,6L,3L,1L,6L,8L,1L,6L,3L,1L,2L,4L,1L,6L,3L,1L,1L,6L,3L,1L,1L,6L,3L,1L,6L,8L,1L,6L,3L,1L,2L,4L,1L,6L,3L,1L,1L,6L,3L,1L,6L,8L,1L,6L,3L,1L,2L,4L,1L,6L,3L,1L,1L,6L,3L,1L,6L,8L,1L,6L,3L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105123Inst : IEnumerable<long>
{
public static readonly long[] Value=A105123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105123.Bytes);
public long this[int i]=>Value[i];

public static A105123Inst Instance=new A105123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105124
{
public static readonly BigInteger[] Value={ 1L,1L,11L,197L,4593L,126289L,3888343L,130016393L,4629617873L,173225211953L,6746427428131L,271578345652109L,11240106619304609L,476332107976984545L,BigInteger.Parse("20601333127791572143"),BigInteger.Parse("906951532759564554769"),BigInteger.Parse("40554743852511698293601") };
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
public class A105124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105124Inst Instance=new A105124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105125
{
public static readonly long[] Value={ 0L,1L,2L,8L,9L,16L,27L,28L,35L,54L,64L,65L,72L,91L,128L,125L,126L,133L,152L,189L,250L,216L,217L,224L,243L,280L,341L,432L,343L,344L,351L,370L,407L,468L,559L,686L,512L,513L,520L,539L,576L,637L,728L,855L,1024L,729L,730L,737L,756L,793L,854L,945L,1072L,1241L,1458L,1000L,1001L,1008L,1027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105125Inst : IEnumerable<long>
{
public static readonly long[] Value=A105125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105125.Bytes);
public long this[int i]=>Value[i];

public static A105125Inst Instance=new A105125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105126
{
public static readonly long[] Value={ 41L,73L,89L,137L,233L,281L,313L,409L,457L,521L,569L,601L,617L,761L,809L,857L,937L,953L,1033L,1049L,1097L,1129L,1193L,1289L,1321L,1433L,1481L,1609L,1657L,1721L,1753L,1801L,1913L,1993L,2089L,2137L,2153L,2281L,2297L,2377L,2393L,2441L,2473L,2521L,2617L,2633L,2713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105126Inst : IEnumerable<long>
{
public static readonly long[] Value=A105126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105126.Bytes);
public long this[int i]=>Value[i];

public static A105126Inst Instance=new A105126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105127
{
public static readonly long[] Value={ 17L,113L,241L,337L,401L,433L,593L,881L,977L,1009L,1201L,1297L,1361L,1489L,1553L,1777L,1873L,2129L,2161L,2417L,2609L,2801L,2833L,2897L,3089L,3121L,3217L,3313L,3697L,3761L,3793L,3889L,4049L,4177L,4241L,4273L,4337L,4561L,4657L,4721L,4817L,5009L,5233L,5297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105127Inst : IEnumerable<long>
{
public static readonly long[] Value=A105127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105127.Bytes);
public long this[int i]=>Value[i];

public static A105127Inst Instance=new A105127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105128
{
public static readonly long[] Value={ 97L,353L,673L,929L,1249L,1697L,1889L,2017L,2081L,2273L,2593L,2657L,3041L,3169L,3361L,3617L,4001L,4129L,4513L,5153L,5281L,5857L,6113L,6689L,7393L,7457L,7649L,7841L,8161L,8353L,8609L,8737L,8929L,9377L,9697L,10273L,10337L,10529L,10657L,11489L,11617L,11681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105128Inst : IEnumerable<long>
{
public static readonly long[] Value=A105128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105128.Bytes);
public long this[int i]=>Value[i];

public static A105128Inst Instance=new A105128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105129
{
public static readonly long[] Value={ 193L,449L,577L,1217L,1601L,2113L,2753L,3137L,4289L,4673L,4801L,5441L,5569L,5953L,6337L,6977L,7489L,7873L,8513L,8641L,9281L,10177L,10433L,11329L,11969L,12097L,13121L,13249L,13633L,14401L,14657L,15809L,15937L,16193L,17729L,19009L,19777L,20161L,20929L,21313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105129Inst : IEnumerable<long>
{
public static readonly long[] Value=A105129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105129.Bytes);
public long this[int i]=>Value[i];

public static A105129Inst Instance=new A105129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105130
{
public static readonly long[] Value={ 641L,1153L,1409L,2689L,3457L,4481L,4993L,6529L,7297L,9601L,9857L,10369L,11393L,12161L,13441L,13697L,15233L,16001L,18049L,19073L,19841L,20353L,21121L,21377L,26497L,28289L,29569L,30593L,31873L,33409L,35201L,35969L,38273L,39041L,40577L,43649L,44417L,45697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105130Inst : IEnumerable<long>
{
public static readonly long[] Value=A105130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105130.Bytes);
public long this[int i]=>Value[i];

public static A105130Inst Instance=new A105130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105131
{
public static readonly long[] Value={ 257L,769L,3329L,7937L,9473L,14081L,14593L,22273L,23297L,26881L,30977L,31489L,36097L,37633L,40193L,41729L,43777L,46337L,49409L,49921L,57089L,57601L,60161L,70913L,75521L,77569L,78593L,84737L,88321L,91393L,96001L,98561L,100609L,103681L,106753L,107777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105131Inst : IEnumerable<long>
{
public static readonly long[] Value=A105131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105131.Bytes);
public long this[int i]=>Value[i];

public static A105131Inst Instance=new A105131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105132
{
public static readonly long[] Value={ 7681L,10753L,11777L,17921L,23041L,26113L,32257L,36353L,45569L,51713L,67073L,76289L,81409L,84481L,87553L,96769L,102913L,112129L,113153L,115201L,118273L,119297L,125441L,133633L,143873L,153089L,155137L,158209L,159233L,161281L,168449L,170497L,176641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105132Inst : IEnumerable<long>
{
public static readonly long[] Value=A105132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105132.Bytes);
public long this[int i]=>Value[i];

public static A105132Inst Instance=new A105132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105133
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,12L,13L,18L,19L,21L,22L,24L,28L,33L,34L,36L,39L,43L,46L,48L,49L,52L,57L,63L,67L,69L,76L,81L,82L,84L,87L,88L,91L,94L,96L,99L,102L,103L,106L,109L,117L,124L,126L,127L,132L,133L,136L,138L,139L,147L,151L,153L,154L,159L,162L,171L,172L,178L,181L,186L,193L,199L,201L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105133Inst : IEnumerable<long>
{
public static readonly long[] Value=A105133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105133.Bytes);
public long this[int i]=>Value[i];

public static A105133Inst Instance=new A105133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105134
{
public static readonly long[] Value={ 2L,4L,5L,8L,14L,17L,19L,25L,28L,32L,35L,37L,38L,47L,50L,53L,58L,59L,64L,65L,68L,70L,74L,80L,82L,89L,92L,100L,103L,107L,109L,112L,119L,124L,130L,133L,134L,142L,143L,148L,149L,152L,154L,157L,163L,164L,169L,170L,173L,178L,184L,185L,187L,190L,200L,203L,214L,215L,220L,224L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105134Inst : IEnumerable<long>
{
public static readonly long[] Value=A105134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105134.Bytes);
public long this[int i]=>Value[i];

public static A105134Inst Instance=new A105134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105135
{
public static readonly long[] Value={ 0L,3L,7L,10L,12L,13L,18L,27L,30L,31L,37L,40L,42L,46L,48L,55L,58L,66L,67L,75L,81L,87L,88L,90L,96L,97L,100L,103L,115L,117L,118L,121L,126L,130L,132L,133L,135L,142L,145L,147L,150L,156L,163L,165L,168L,172L,195L,198L,201L,202L,205L,208L,210L,213L,217L,220L,222L,235L,243L,250L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105135Inst : IEnumerable<long>
{
public static readonly long[] Value=A105135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105135.Bytes);
public long this[int i]=>Value[i];

public static A105135Inst Instance=new A105135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105136
{
public static readonly long[] Value={ 1L,5L,10L,14L,19L,26L,29L,31L,32L,35L,40L,41L,47L,49L,52L,56L,62L,64L,70L,80L,82L,91L,95L,104L,115L,116L,119L,122L,127L,130L,134L,136L,139L,146L,151L,160L,161L,164L,166L,179L,181L,182L,196L,197L,206L,211L,214L,217L,221L,224L,227L,230L,235L,236L,239L,244L,250L,251L,256L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105136Inst : IEnumerable<long>
{
public static readonly long[] Value=A105136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105136.Bytes);
public long this[int i]=>Value[i];

public static A105136Inst Instance=new A105136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105137
{
public static readonly long[] Value={ 1L,3L,4L,9L,12L,16L,21L,24L,33L,36L,37L,42L,43L,46L,49L,54L,58L,61L,66L,67L,72L,79L,81L,88L,93L,94L,102L,103L,106L,112L,114L,123L,124L,126L,138L,148L,154L,157L,163L,166L,168L,177L,186L,187L,196L,198L,199L,201L,204L,207L,211L,213L,214L,219L,231L,232L,238L,252L,256L,262L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105137Inst : IEnumerable<long>
{
public static readonly long[] Value=A105137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105137.Bytes);
public long this[int i]=>Value[i];

public static A105137Inst Instance=new A105137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105138
{
public static readonly long[] Value={ 2L,4L,5L,10L,13L,17L,19L,25L,28L,37L,38L,40L,44L,47L,52L,53L,59L,62L,70L,74L,77L,79L,82L,83L,103L,110L,115L,119L,124L,130L,137L,140L,149L,152L,158L,170L,173L,178L,179L,193L,200L,205L,208L,209L,212L,217L,230L,235L,238L,242L,247L,248L,257L,268L,269L,272L,275L,280L,283L,299L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105138Inst : IEnumerable<long>
{
public static readonly long[] Value=A105138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105138.Bytes);
public long this[int i]=>Value[i];

public static A105138Inst Instance=new A105138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105139
{
public static readonly long[] Value={ 0L,1L,6L,15L,18L,27L,28L,43L,45L,52L,60L,61L,70L,73L,78L,81L,85L,90L,96L,97L,111L,112L,117L,138L,147L,151L,153L,165L,172L,178L,187L,192L,196L,202L,208L,210L,211L,213L,216L,222L,228L,231L,235L,243L,250L,252L,253L,255L,262L,265L,270L,280L,291L,298L,301L,312L,325L,328L,330L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105139Inst : IEnumerable<long>
{
public static readonly long[] Value=A105139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105139.Bytes);
public long this[int i]=>Value[i];

public static A105139Inst Instance=new A105139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105140
{
public static readonly long[] Value={ 7L,10L,11L,17L,22L,25L,31L,35L,44L,50L,65L,74L,79L,82L,85L,94L,100L,109L,110L,112L,115L,116L,122L,130L,140L,149L,151L,154L,155L,157L,164L,166L,172L,179L,206L,211L,214L,215L,221L,227L,229L,232L,245L,254L,256L,259L,269L,271L,277L,280L,281L,292L,295L,296L,299L,316L,322L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105140Inst : IEnumerable<long>
{
public static readonly long[] Value=A105140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105140.Bytes);
public long this[int i]=>Value[i];

public static A105140Inst Instance=new A105140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105141
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105141Inst : IEnumerable<long>
{
public static readonly long[] Value=A105141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105141.Bytes);
public long this[int i]=>Value[i];

public static A105141Inst Instance=new A105141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105142
{
public static readonly long[] Value={ 2L,6L,34L,46L,142L,174L,204L,238L,312L,466L,550L,616L,690L,730L,1136L,1280L,1302L,1330L,1486L,1586L,1610L,1638L,1644L,1652L,1688L,1706L,1772L,1934L,1952L,1972L,2040L,2102L,2108L,2142L,2192L,2238L,2250L,2376L,2400L,2554L,2612L,2646L,3006L,3094L,3550L,3642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105142Inst : IEnumerable<long>
{
public static readonly long[] Value=A105142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105142.Bytes);
public long this[int i]=>Value[i];

public static A105142Inst Instance=new A105142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105143
{
public static readonly long[] Value={ 1L,4L,8L,14L,24L,45L,94L,205L,440L,912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105143Inst : IEnumerable<long>
{
public static readonly long[] Value=A105143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105143.Bytes);
public long this[int i]=>Value[i];

public static A105143Inst Instance=new A105143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105144
{
public static readonly long[] Value={ 1L,0L,8L,4L,9L,9L,8L,7L,7L,8L,2L,2L,7L,8L,7L,1L,9L,3L,3L,5L,8L,3L,3L,3L,8L,8L,6L,4L,4L,6L,6L,5L,0L,7L,8L,0L,5L,2L,8L,7L,7L,6L,1L,1L,4L,0L,2L,7L,5L,6L,5L,7L,3L,9L,8L,6L,8L,9L,4L,7L,7L,9L,5L,8L,3L,3L,8L,2L,9L,3L,7L,9L,7L,2L,8L,3L,8L,1L,6L,2L,9L,7L,2L,8L,1L,4L,3L,0L,8L,1L,9L,0L,6L,5L,8L,4L,6L,9L,4L,6L,8L,4L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105144Inst : IEnumerable<long>
{
public static readonly long[] Value=A105144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105144.Bytes);
public long this[int i]=>Value[i];

public static A105144Inst Instance=new A105144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105145
{
public static readonly long[] Value={ 18L,21L,30L,32L,39L,71L,72L,78L,84L,86L,89L,93L,95L,98L,107L,108L,135L,143L,150L,152L,159L,161L,165L,170L,173L,177L,179L,180L,192L,198L,203L,221L,243L,245L,248L,261L,269L,281L,282L,294L,302L,306L,315L,320L,329L,336L,338L,347L,369L,374L,378L,395L,399L,423L,425L,443L,446L,449L,456L,458L,471L,500L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105145Inst : IEnumerable<long>
{
public static readonly long[] Value=A105145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105145.Bytes);
public long this[int i]=>Value[i];

public static A105145Inst Instance=new A105145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105146
{
public static readonly long[] Value={ 2L,6L,17L,23L,26L,38L,39L,42L,59L,63L,83L,89L,96L,102L,107L,117L,135L,144L,146L,153L,159L,174L,179L,182L,185L,189L,191L,192L,194L,201L,206L,230L,233L,237L,240L,245L,248L,249L,251L,252L,270L,279L,285L,287L,293L,299L,300L,318L,321L,329L,335L,339L,345L,350L,354L,356L,378L,387L,392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105146Inst : IEnumerable<long>
{
public static readonly long[] Value=A105146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105146.Bytes);
public long this[int i]=>Value[i];

public static A105146Inst Instance=new A105146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105147
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,1L,6L,1L,0L,1L,13L,2L,0L,0L,1L,27L,3L,1L,0L,0L,1L,56L,5L,2L,0L,0L,0L,1L,115L,9L,2L,1L,0L,0L,0L,1L,235L,15L,3L,2L,0L,0L,0L,0L,1L,478L,25L,5L,2L,1L,0L,0L,0L,0L,1L,969L,42L,8L,2L,2L,0L,0L,0L,0L,0L,1L,1959L,70L,12L,3L,2L,1L,0L,0L,0L,0L,0L,1L,3952L,116L,18L,5L,2L,2L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105147Inst : IEnumerable<long>
{
public static readonly long[] Value=A105147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105147.Bytes);
public long this[int i]=>Value[i];

public static A105147Inst Instance=new A105147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105148
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,10L,9L,14L,14L,19L,19L,24L,27L,32L,30L,41L,36L,44L,47L,55L,56L,62L,64L,69L,78L,77L,85L,90L,95L,107L,103L,109L,122L,118L,138L,133L,149L,142L,157L,168L,171L,177L,178L,193L,201L,214L,211L,220L,231L,243L,241L,253L,262L,272L,294L,288L,286L,308L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105148Inst : IEnumerable<long>
{
public static readonly long[] Value=A105148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105148.Bytes);
public long this[int i]=>Value[i];

public static A105148Inst Instance=new A105148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105149
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,2L,1L,3L,2L,3L,3L,2L,4L,2L,3L,3L,4L,5L,1L,6L,3L,5L,3L,4L,4L,5L,4L,6L,5L,5L,3L,6L,5L,7L,6L,4L,6L,5L,7L,6L,5L,6L,6L,8L,8L,5L,6L,8L,7L,6L,5L,9L,9L,7L,10L,6L,7L,8L,5L,10L,6L,10L,9L,8L,8L,10L,8L,11L,5L,9L,9L,13L,10L,9L,9L,9L,8L,8L,10L,12L,7L,11L,12L,12L,10L,10L,12L,10L,12L,10L,10L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105149Inst : IEnumerable<long>
{
public static readonly long[] Value=A105149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105149.Bytes);
public long this[int i]=>Value[i];

public static A105149Inst Instance=new A105149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105150
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L,5L,8L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105150Inst : IEnumerable<long>
{
public static readonly long[] Value=A105150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105150.Bytes);
public long this[int i]=>Value[i];

public static A105150Inst Instance=new A105150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105151
{
public static readonly BigInteger[] Value={ 1L,3L,11L,48L,253L,1576L,11331L,92467L,845064L,8554195L,95032146L,1149773923L,15050556403L,211951761735L,3195468293093L,51354400809456L,876431092504915L,15830294577832786L,301703171661686235L,6050766978392127541L,BigInteger.Parse("127383588868883838996"),BigInteger.Parse("2808790552014917701633") };
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
public class A105151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105151Inst Instance=new A105151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105152
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,9L,13L,25L,52L,94L,195L,354L,691L,1341L,2514L,4746L,8984L,16639L,31031L,57421L,105091L,192266L,349765L,632223L,1138114L,2043082L,3642712L,6474196L,11462149L,20189285L,35427948L,61987644L,107928280L,187336851L,324080969L,558451251L,959214488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105152Inst : IEnumerable<long>
{
public static readonly long[] Value=A105152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105152.Bytes);
public long this[int i]=>Value[i];

public static A105152Inst Instance=new A105152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105153
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,1L,2L,4L,2L,2L,4L,4L,2L,2L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105153Inst : IEnumerable<long>
{
public static readonly long[] Value=A105153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105153.Bytes);
public long this[int i]=>Value[i];

public static A105153Inst Instance=new A105153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105154
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,2L,1L,4L,2L,2L,4L,4L,2L,2L,4L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,1L,4L,4L,4L,1L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,8L,4L,4L,4L,4L,8L,4L,4L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L,8L,16L,2L,16L,8L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105154Inst : IEnumerable<long>
{
public static readonly long[] Value=A105154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105154.Bytes);
public long this[int i]=>Value[i];

public static A105154Inst Instance=new A105154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105155
{
public static readonly long[] Value={ 10L,6L,9L,4L,6L,10L,14L,21L,35L,49L,22L,33L,55L,77L,121L,26L,39L,65L,91L,143L,169L,34L,51L,85L,119L,187L,221L,289L,38L,57L,95L,133L,209L,247L,323L,361L,46L,69L,115L,161L,253L,299L,391L,437L,529L,58L,87L,145L,203L,319L,377L,493L,551L,667L,841L,62L,93L,155L,217L,341L,403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105155Inst : IEnumerable<long>
{
public static readonly long[] Value=A105155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105155.Bytes);
public long this[int i]=>Value[i];

public static A105155Inst Instance=new A105155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105156
{
public static readonly long[] Value={ 10L,15L,20L,119L,308L,533L,986L,1463L,2300L,3741L,4960L,7289L,9758L,12083L,15416L,20193L,25960L,30561L,38056L,45369L,51976L,62489L,72542L,85707L,102820L,117261L,130192L,146697L,161320L,180009L,218440L,242481L,272356L,295653L,339124L,366477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105156Inst : IEnumerable<long>
{
public static readonly long[] Value=A105156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105156.Bytes);
public long this[int i]=>Value[i];

public static A105156Inst Instance=new A105156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105157
{
public static readonly long[] Value={ 6L,10L,70L,85L,364L,451L,1102L,1309L,2900L,2967L,5920L,6107L,10234L,11521L,17384L,17907L,26840L,29559L,40328L,42813L,56248L,57743L,77786L,79929L,107060L,112617L,135248L,141213L,167240L,173637L,225320L,235077L,276332L,291399L,343676L,361623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105157Inst : IEnumerable<long>
{
public static readonly long[] Value=A105157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105157.Bytes);
public long this[int i]=>Value[i];

public static A105157Inst Instance=new A105157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105158
{
public static readonly long[] Value={ 0L,3L,3L,6L,2L,6L,5L,5L,5L,15L,4L,8L,4L,28L,15L,7L,7L,9L,23L,61L,10L,6L,10L,8L,18L,44L,126L,9L,17L,9L,11L,17L,39L,93L,251L,8L,12L,8L,14L,16L,34L,76L,190L,504L,11L,11L,19L,13L,19L,33L,71L,157L,379L,1017L,14L,10L,14L,12L,22L,32L,66L,140L,318L,760L,2042L,13L,13L,13L,23L,21L,35L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105158Inst : IEnumerable<long>
{
public static readonly long[] Value=A105158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105158.Bytes);
public long this[int i]=>Value[i];

public static A105158Inst Instance=new A105158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105159
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,3L,3L,3L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,3L,1L,9L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105159Inst : IEnumerable<long>
{
public static readonly long[] Value=A105159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105159.Bytes);
public long this[int i]=>Value[i];

public static A105159Inst Instance=new A105159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105160
{
public static readonly long[] Value={ 6L,4L,6L,14L,21L,35L,10L,15L,25L,35L,26L,39L,65L,91L,143L,22L,33L,55L,77L,121L,143L,38L,57L,95L,133L,209L,247L,323L,34L,51L,85L,119L,187L,221L,289L,323L,58L,87L,145L,203L,319L,377L,493L,551L,667L,46L,69L,115L,161L,253L,299L,391L,437L,529L,667L,74L,111L,185L,259L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105160Inst : IEnumerable<long>
{
public static readonly long[] Value=A105160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105160.Bytes);
public long this[int i]=>Value[i];

public static A105160Inst Instance=new A105160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105161
{
public static readonly long[] Value={ 3L,2L,3L,4L,3L,6L,5L,6L,5L,4L,3L,6L,5L,6L,5L,4L,3L,6L,5L,10L,9L,8L,7L,8L,7L,6L,5L,4L,3L,8L,7L,10L,9L,8L,7L,6L,5L,6L,5L,4L,3L,6L,5L,10L,9L,8L,7L,12L,11L,10L,9L,8L,7L,8L,7L,6L,5L,4L,3L,8L,7L,10L,9L,8L,7L,6L,5L,6L,5L,4L,3L,8L,7L,10L,9L,8L,7L,6L,5L,10L,9L,8L,7L,14L,13L,12L,11L,10L,9L,12L,11L,10L,9L,8L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105161Inst : IEnumerable<long>
{
public static readonly long[] Value=A105161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105161.Bytes);
public long this[int i]=>Value[i];

public static A105161Inst Instance=new A105161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105162
{
public static readonly long[] Value={ 10L,1L,8L,27L,40L,55L,228L,175L,336L,455L,450L,741L,770L,861L,1274L,1377L,2080L,1595L,2622L,2145L,2840L,3315L,3564L,4275L,5148L,4655L,5454L,5777L,6440L,6327L,9030L,7625L,10564L,9135L,13330L,9425L,14628L,11431L,16224L,13167L,18870L,13825L,20720L,15471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105162Inst : IEnumerable<long>
{
public static readonly long[] Value=A105162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105162.Bytes);
public long this[int i]=>Value[i];

public static A105162Inst Instance=new A105162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105163
{
public static readonly long[] Value={ 1L,1L,3L,8L,17L,31L,51L,78L,113L,157L,211L,276L,353L,443L,547L,666L,801L,953L,1123L,1312L,1521L,1751L,2003L,2278L,2577L,2901L,3251L,3628L,4033L,4467L,4931L,5426L,5953L,6513L,7107L,7736L,8401L,9103L,9843L,10622L,11441L,12301L,13203L,14148L,15137L,16171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105163Inst : IEnumerable<long>
{
public static readonly long[] Value=A105163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105163.Bytes);
public long this[int i]=>Value[i];

public static A105163Inst Instance=new A105163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105164
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,4L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,2L,3L,3L,4L,3L,4L,4L,5L,3L,4L,4L,5L,4L,5L,5L,5L,9L,7L,6L,1L,2L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,4L,5L,2L,3L,3L,4L,3L,4L,4L,5L,3L,4L,4L,5L,4L,5L,5L,5L,9L,7L,6L,2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105164Inst : IEnumerable<long>
{
public static readonly long[] Value=A105164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105164.Bytes);
public long this[int i]=>Value[i];

public static A105164Inst Instance=new A105164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105165
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105165Inst : IEnumerable<long>
{
public static readonly long[] Value=A105165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105165.Bytes);
public long this[int i]=>Value[i];

public static A105165Inst Instance=new A105165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105166
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,2L,0L,1L,2L,1L,1L,1L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,2L,0L,1L,2L,0L,0L,1L,1L,1L,0L,0L,1L,2L,0L,1L,0L,1L,0L,0L,0L,1L,0L,2L,0L,1L,1L,1L,2L,1L,0L,0L,0L,2L,0L,2L,1L,1L,0L,1L,1L,2L,0L,2L,0L,2L,0L,1L,0L,2L,1L,0L,1L,2L,1L,2L,0L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,1L,0L,0L,0L,2L,1L,1L,2L,1L,2L,0L,2L,0L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105166Inst : IEnumerable<long>
{
public static readonly long[] Value=A105166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105166.Bytes);
public long this[int i]=>Value[i];

public static A105166Inst Instance=new A105166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105167
{
public static readonly long[] Value={ 7L,7L,0L,0L,5L,9L,8L,5L,6L,5L,3L,3L,7L,9L,4L,0L,1L,4L,2L,9L,7L,8L,6L,1L,8L,7L,7L,4L,5L,0L,3L,5L,8L,4L,8L,4L,6L,1L,4L,3L,0L,4L,8L,8L,3L,8L,6L,3L,4L,5L,9L,1L,0L,5L,4L,4L,2L,4L,1L,1L,4L,0L,4L,2L,2L,5L,7L,1L,9L,2L,1L,8L,4L,6L,9L,7L,3L,0L,7L,8L,8L,1L,2L,4L,0L,9L,5L,2L,2L,1L,4L,4L,0L,2L,5L,9L,8L,9L,6L,8L,2L,1L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105167Inst : IEnumerable<long>
{
public static readonly long[] Value=A105167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105167.Bytes);
public long this[int i]=>Value[i];

public static A105167Inst Instance=new A105167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105168
{
public static readonly long[] Value={ 1L,7L,3L,9L,8L,9L,8L,9L,4L,9L,6L,8L,1L,8L,0L,9L,0L,0L,4L,9L,1L,1L,4L,7L,5L,8L,6L,9L,9L,7L,8L,1L,1L,1L,5L,1L,9L,3L,2L,9L,6L,8L,0L,0L,9L,3L,5L,6L,2L,4L,7L,5L,7L,4L,6L,9L,5L,8L,8L,1L,7L,1L,4L,7L,5L,6L,3L,6L,2L,7L,0L,2L,0L,6L,5L,4L,3L,7L,3L,0L,0L,1L,8L,2L,7L,4L,5L,4L,3L,4L,1L,8L,9L,5L,0L,8L,6L,9L,2L,2L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105168Inst : IEnumerable<long>
{
public static readonly long[] Value=A105168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105168.Bytes);
public long this[int i]=>Value[i];

public static A105168Inst Instance=new A105168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105169
{
public static readonly long[] Value={ 1L,1L,4L,7L,9L,6L,5L,3L,8L,5L,5L,2L,7L,7L,5L,5L,0L,3L,2L,9L,2L,9L,5L,6L,5L,8L,6L,8L,6L,8L,0L,9L,3L,5L,1L,0L,3L,0L,3L,9L,0L,8L,0L,7L,9L,5L,5L,8L,2L,9L,7L,1L,9L,7L,9L,7L,6L,3L,2L,6L,1L,1L,4L,5L,6L,0L,2L,1L,8L,0L,1L,5L,9L,0L,7L,7L,6L,4L,3L,8L,8L,9L,0L,0L,6L,4L,2L,1L,4L,9L,2L,1L,7L,9L,5L,2L,0L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105169Inst : IEnumerable<long>
{
public static readonly long[] Value=A105169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105169.Bytes);
public long this[int i]=>Value[i];

public static A105169Inst Instance=new A105169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105170
{
public static readonly long[] Value={ 11L,17L,29L,41L,59L,67L,71L,73L,89L,97L,103L,127L,137L,149L,151L,163L,173L,179L,181L,191L,193L,197L,223L,227L,229L,233L,239L,241L,257L,263L,271L,277L,311L,317L,331L,347L,349L,353L,359L,367L,373L,379L,389L,397L,409L,419L,433L,443L,461L,463L,467L,479L,487L,499L,503L,541L,547L,557L,563L,571L,577L,587L,593L,599L,607L,613L,617L,619L,631L,641L,647L,653L,659L,661L,677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105170Inst : IEnumerable<long>
{
public static readonly long[] Value=A105170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105170.Bytes);
public long this[int i]=>Value[i];

public static A105170Inst Instance=new A105170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105171
{
public static readonly long[] Value={ 1L,1L,0L,0L,9L,3L,2L,6L,6L,5L,1L,9L,3L,6L,2L,6L,6L,0L,7L,6L,5L,4L,9L,7L,5L,8L,8L,0L,2L,6L,1L,4L,0L,8L,3L,6L,0L,8L,4L,1L,1L,8L,4L,8L,2L,8L,0L,1L,9L,4L,6L,5L,1L,6L,1L,8L,1L,3L,6L,2L,0L,7L,4L,5L,6L,8L,5L,9L,9L,6L,8L,1L,4L,5L,2L,0L,6L,2L,4L,9L,7L,6L,1L,7L,1L,2L,5L,2L,1L,4L,4L,8L,5L,7L,0L,5L,0L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105171Inst : IEnumerable<long>
{
public static readonly long[] Value=A105171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105171.Bytes);
public long this[int i]=>Value[i];

public static A105171Inst Instance=new A105171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105172
{
public static readonly long[] Value={ 9L,2L,8L,3L,8L,0L,7L,9L,9L,2L,5L,8L,9L,7L,4L,0L,2L,9L,5L,1L,4L,6L,5L,6L,0L,4L,4L,6L,6L,1L,2L,0L,7L,0L,1L,5L,1L,7L,7L,8L,3L,7L,0L,0L,6L,2L,8L,4L,4L,7L,0L,4L,2L,3L,6L,8L,0L,2L,1L,4L,8L,4L,0L,3L,3L,0L,5L,9L,4L,2L,4L,7L,0L,6L,9L,5L,9L,3L,7L,6L,7L,7L,2L,2L,1L,7L,7L,6L,8L,4L,8L,8L,9L,9L,0L,8L,0L,4L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105172Inst : IEnumerable<long>
{
public static readonly long[] Value=A105172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105172.Bytes);
public long this[int i]=>Value[i];

public static A105172Inst Instance=new A105172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105173
{
public static readonly long[] Value={ 3L,7L,8L,15L,16L,23L,24L,32L,39L,40L,47L,48L,55L,56L,63L,64L,71L,79L,80L,87L,95L,103L,104L,111L,112L,119L,120L,128L,135L,136L,143L,151L,152L,159L,167L,175L,176L,183L,199L,208L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105173Inst : IEnumerable<long>
{
public static readonly long[] Value=A105173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105173.Bytes);
public long this[int i]=>Value[i];

public static A105173Inst Instance=new A105173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105174
{
public static readonly long[] Value={ 8L,15L,23L,24L,71L,80L,104L,128L,159L,216L,231L,264L,288L,303L,336L,344L,455L,495L,528L,543L,560L,608L,624L,680L,744L,816L,840L,879L,896L,1016L,1104L,1311L,1415L,1440L,1464L,1520L,1584L,1599L,1751L,1871L,1896L,1920L,1976L,2015L,2016L,2055L,2088L,2103L,2175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105174Inst : IEnumerable<long>
{
public static readonly long[] Value=A105174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105174.Bytes);
public long this[int i]=>Value[i];

public static A105174Inst Instance=new A105174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105175
{
public static readonly BigInteger[] Value={ 0L,0L,9235919L,14984879L,447402699579360L,725891508817440L,BigInteger.Parse("21672901717138141202159"),BigInteger.Parse("35163344661747893105039"),BigInteger.Parse("1049869992475115099179547651520"),BigInteger.Parse("1703368606439836689249786415680"),BigInteger.Parse("50857380127742528965284060018658947599"),BigInteger.Parse("82513897278978744922944413386362572399") };
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
public class A105175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105175Inst Instance=new A105175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105176
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,17L,23L,34L,201L,706L,1413L,2265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105176Inst : IEnumerable<long>
{
public static readonly long[] Value=A105176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105176.Bytes);
public long this[int i]=>Value[i];

public static A105176Inst Instance=new A105176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105177
{
public static readonly long[] Value={ 3L,1L,4L,5L,9L,2L,6L,8L,7L,0L,31L,14L,41L,15L,59L,92L,26L,65L,53L,35L,58L,89L,97L,79L,93L,32L,23L,38L,84L,46L,62L,64L,43L,33L,83L,27L,95L,50L,28L,88L,19L,71L,16L,69L,39L,99L,37L,75L,51L,10L,82L,20L,74L,49L,94L,44L,45L,30L,78L,81L,40L,86L,98L,80L,34L,48L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105177Inst : IEnumerable<long>
{
public static readonly long[] Value=A105177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105177.Bytes);
public long this[int i]=>Value[i];

public static A105177Inst Instance=new A105177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105178
{
public static readonly long[] Value={ 2L,7L,1L,8L,4L,5L,9L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105178Inst : IEnumerable<long>
{
public static readonly long[] Value=A105178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105178.Bytes);
public long this[int i]=>Value[i];

public static A105178Inst Instance=new A105178Inst();

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