using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A085549
{
public static readonly long[] Value={ 1L,2L,4L,10L,28L,97L,359L,1635L,8296L,48432L,316520L,2305104L,18428254L,160384348L,1506613063L,15180782537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085549Inst : IEnumerable<long>
{
public static readonly long[] Value=A085549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085549.Bytes);
public long this[int i]=>Value[i];

public static A085549Inst Instance=new A085549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085550
{
public static readonly long[] Value={ 3L,0L,2L,7L,7L,5L,6L,3L,7L,7L,3L,1L,9L,9L,4L,6L,4L,6L,5L,5L,9L,6L,1L,0L,6L,3L,3L,7L,3L,5L,2L,4L,7L,9L,7L,3L,1L,2L,5L,6L,4L,8L,2L,8L,6L,9L,2L,2L,6L,2L,3L,1L,0L,6L,3L,5L,5L,2L,2L,6L,5L,2L,8L,1L,1L,3L,5L,8L,3L,4L,7L,4L,1L,4L,6L,5L,0L,5L,2L,2L,2L,6L,0L,2L,3L,0L,9L,5L,4L,1L,0L,0L,9L,2L,4L,5L,3L,5L,8L,8L,3L,6L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085550Inst : IEnumerable<long>
{
public static readonly long[] Value=A085550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085550.Bytes);
public long this[int i]=>Value[i];

public static A085550Inst Instance=new A085550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085551
{
public static readonly long[] Value={ 1L,9L,2L,5L,8L,2L,4L,0L,3L,5L,6L,7L,2L,5L,2L,0L,1L,5L,6L,2L,5L,3L,5L,5L,2L,4L,5L,7L,7L,0L,1L,6L,4L,7L,7L,8L,1L,4L,7L,5L,6L,0L,0L,8L,0L,8L,2L,2L,3L,9L,4L,4L,1L,8L,8L,4L,0L,1L,9L,4L,3L,3L,5L,0L,0L,8L,3L,2L,2L,9L,8L,1L,4L,1L,3L,8L,2L,9L,3L,4L,6L,4L,3L,8L,3L,1L,6L,8L,9L,0L,8L,3L,9L,9L,1L,7L,7L,4L,2L,2L,0L,9L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085551Inst : IEnumerable<long>
{
public static readonly long[] Value=A085551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085551.Bytes);
public long this[int i]=>Value[i];

public static A085551Inst Instance=new A085551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085552
{
public static readonly long[] Value={ 6L,1L,2L,0L,8L,7L,9L,2L,8L,5L,4L,8L,9L,7L,7L,6L,8L,6L,5L,1L,5L,9L,4L,1L,6L,1L,9L,4L,5L,9L,9L,8L,0L,7L,2L,1L,3L,1L,0L,4L,4L,4L,0L,5L,9L,3L,7L,9L,0L,2L,4L,7L,4L,0L,0L,7L,7L,4L,6L,3L,8L,7L,0L,3L,9L,9L,5L,1L,2L,8L,7L,3L,3L,8L,3L,6L,6L,1L,8L,3L,8L,6L,3L,7L,6L,5L,2L,4L,4L,2L,9L,8L,9L,3L,2L,1L,9L,5L,9L,7L,4L,3L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085552Inst : IEnumerable<long>
{
public static readonly long[] Value=A085552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085552.Bytes);
public long this[int i]=>Value[i];

public static A085552Inst Instance=new A085552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085553
{
public static readonly long[] Value={ 5L,29L,1229L,4229L,366029L,819029L,1155629L,1311029L,1575029L,3822029L,4389029L,4515629L,5880629L,7102229L,9333029L,9954029L,13213229L,13432229L,16120229L,19140629L,25654229L,34987229L,37393229L,38875229L,39375629L,41152229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085553Inst : IEnumerable<long>
{
public static readonly long[] Value=A085553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085553.Bytes);
public long this[int i]=>Value[i];

public static A085553Inst Instance=new A085553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085554
{
public static readonly long[] Value={ 5L,13L,229L,1093L,2029L,3253L,13693L,21613L,59053L,65029L,91813L,140629L,178933L,199813L,205213L,227533L,328333L,567013L,700573L,804613L,815413L,1071229L,2241013L,3629029L,4223029L,4347229L,4809253L,5212093L,5919493L,6185173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085554Inst : IEnumerable<long>
{
public static readonly long[] Value=A085554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085554.Bytes);
public long this[int i]=>Value[i];

public static A085554Inst Instance=new A085554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085555
{
public static readonly long[] Value={ 5L,13L,29L,229L,1093L,1229L,2029L,3253L,4229L,13693L,21613L,59053L,65029L,91813L,140629L,178933L,199813L,205213L,227533L,328333L,366029L,567013L,700573L,804613L,815413L,819029L,1071229L,1155629L,1311029L,1575029L,2241013L,3629029L,3822029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085555Inst : IEnumerable<long>
{
public static readonly long[] Value=A085555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085555.Bytes);
public long this[int i]=>Value[i];

public static A085555Inst Instance=new A085555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085556
{
public static readonly long[] Value={ 12L,13L,15L,17L,20L,21L,24L,26L,28L,29L,30L,31L,34L,36L,38L,39L,42L,43L,45L,47L,50L,51L,54L,56L,58L,59L,62L,63L,65L,67L,70L,71L,74L,76L,78L,79L,82L,83L,85L,87L,92L,93L,95L,97L,1022L,1023L,1025L,1027L,1032L,1033L,1035L,1037L,1052L,1053L,1055L,1057L,1072L,1073L,1075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085556Inst : IEnumerable<long>
{
public static readonly long[] Value=A085556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085556.Bytes);
public long this[int i]=>Value[i];

public static A085556Inst Instance=new A085556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085557
{
public static readonly long[] Value={ 2L,3L,5L,7L,22L,23L,25L,27L,32L,33L,35L,37L,52L,53L,55L,57L,72L,73L,75L,77L,122L,123L,125L,127L,132L,133L,135L,137L,152L,153L,155L,157L,172L,173L,175L,177L,202L,203L,205L,207L,212L,213L,215L,217L,220L,221L,222L,223L,224L,225L,226L,227L,228L,229L,230L,231L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085557Inst : IEnumerable<long>
{
public static readonly long[] Value=A085557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085557.Bytes);
public long this[int i]=>Value[i];

public static A085557Inst Instance=new A085557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085558
{
public static readonly long[] Value={ 0L,1L,4L,6L,8L,9L,10L,11L,14L,16L,18L,19L,40L,41L,44L,46L,48L,49L,60L,61L,64L,66L,68L,69L,80L,81L,84L,86L,88L,89L,90L,91L,94L,96L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,124L,126L,128L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085558Inst : IEnumerable<long>
{
public static readonly long[] Value=A085558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085558.Bytes);
public long this[int i]=>Value[i];

public static A085558Inst Instance=new A085558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085559
{
public static readonly long[] Value={ 1L,2673L,811538L,5978882L,137149922L,292965218L,779888018L,5745705602L,49511121842L,49511121842L,281539574498L,281539574498L,7865870969138L,7865870969138L,7865870969138L,7865870969138L,47580188090162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085559Inst : IEnumerable<long>
{
public static readonly long[] Value=A085559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085559.Bytes);
public long this[int i]=>Value[i];

public static A085559Inst Instance=new A085559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085560
{
public static readonly long[] Value={ 1L,3L,8L,21L,56L,151L,410L,1114L,3027L,8227L,22362L,60785L,165230L,449141L,1220891L,3318725L,9021229L,24522242L,66658364L,181196219L,492542389L,1338869025L,3639423341L,9892978333L,26891903231L,73099771885L,198705781579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085560Inst : IEnumerable<long>
{
public static readonly long[] Value=A085560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085560.Bytes);
public long this[int i]=>Value[i];

public static A085560Inst Instance=new A085560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085561
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,2L,1L,4L,5L,3L,4L,3L,4L,3L,6L,3L,2L,5L,3L,5L,4L,4L,3L,4L,3L,4L,5L,3L,4L,1L,3L,4L,7L,5L,4L,3L,6L,4L,3L,4L,5L,3L,4L,3L,4L,5L,4L,5L,5L,3L,3L,5L,6L,3L,5L,5L,3L,5L,2L,9L,2L,5L,3L,8L,3L,3L,3L,7L,8L,2L,1L,5L,5L,6L,2L,6L,3L,6L,3L,5L,2L,5L,5L,2L,3L,2L,2L,8L,2L,15L,7L,5L,4L,6L,3L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085561Inst : IEnumerable<long>
{
public static readonly long[] Value=A085561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085561.Bytes);
public long this[int i]=>Value[i];

public static A085561Inst Instance=new A085561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085562
{
public static readonly long[] Value={ 1L,0L,0L,4L,0L,6L,0L,8L,9L,1L,2L,1L,1L,5L,1L,7L,1L,9L,10L,0L,1L,0L,0L,4L,0L,6L,0L,8L,9L,0L,1L,0L,0L,4L,0L,6L,0L,8L,9L,4L,5L,4L,4L,8L,4L,10L,4L,12L,13L,0L,1L,0L,0L,4L,0L,6L,0L,8L,9L,6L,7L,6L,6L,10L,6L,12L,6L,14L,15L,0L,1L,0L,0L,4L,0L,6L,0L,8L,9L,8L,9L,8L,8L,12L,8L,14L,8L,16L,17L,9L,10L,9L,9L,13L,9L,15L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085562Inst : IEnumerable<long>
{
public static readonly long[] Value=A085562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085562.Bytes);
public long this[int i]=>Value[i];

public static A085562Inst Instance=new A085562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085563
{
public static readonly long[] Value={ 0L,2L,3L,0L,5L,0L,7L,0L,0L,0L,0L,2L,3L,0L,5L,0L,7L,0L,0L,2L,2L,4L,5L,2L,7L,2L,9L,2L,2L,3L,3L,5L,6L,3L,8L,3L,10L,3L,3L,0L,0L,2L,3L,0L,5L,0L,7L,0L,0L,5L,5L,7L,8L,5L,10L,5L,12L,5L,5L,0L,0L,2L,3L,0L,5L,0L,7L,0L,0L,7L,7L,9L,10L,7L,12L,7L,14L,7L,7L,0L,0L,2L,3L,0L,5L,0L,7L,0L,0L,0L,0L,2L,3L,0L,5L,0L,7L,0L,0L,0L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085563Inst : IEnumerable<long>
{
public static readonly long[] Value=A085563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085563.Bytes);
public long this[int i]=>Value[i];

public static A085563Inst Instance=new A085563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085564
{
public static readonly long[] Value={ 11L,41L,61L,89L,101L,113L,131L,151L,163L,167L,191L,199L,211L,241L,311L,349L,389L,401L,409L,421L,431L,439L,449L,461L,479L,541L,601L,613L,617L,631L,641L,661L,761L,809L,829L,839L,859L,881L,911L,919L,947L,983L,991L,1013L,1019L,1021L,1031L,1051L,1063L,1091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085564Inst : IEnumerable<long>
{
public static readonly long[] Value=A085564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085564.Bytes);
public long this[int i]=>Value[i];

public static A085564Inst Instance=new A085564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085565
{
public static readonly long[] Value={ 1L,3L,1L,1L,0L,2L,8L,7L,7L,7L,1L,4L,6L,0L,5L,9L,9L,0L,5L,2L,3L,2L,4L,1L,9L,7L,9L,4L,9L,4L,5L,5L,5L,9L,7L,0L,6L,8L,4L,1L,3L,7L,7L,4L,7L,5L,7L,1L,5L,8L,1L,1L,5L,8L,1L,4L,0L,8L,4L,1L,0L,8L,5L,1L,9L,0L,0L,3L,9L,5L,2L,9L,3L,5L,3L,5L,2L,0L,7L,1L,2L,5L,1L,1L,5L,1L,4L,7L,7L,6L,6L,4L,8L,0L,7L,1L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085565Inst : IEnumerable<long>
{
public static readonly long[] Value=A085565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085565.Bytes);
public long this[int i]=>Value[i];

public static A085565Inst Instance=new A085565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085566
{
public static readonly long[] Value={ 5L,9L,9L,0L,7L,0L,1L,1L,7L,3L,6L,7L,7L,9L,6L,1L,0L,3L,7L,1L,9L,9L,6L,1L,2L,4L,6L,1L,4L,0L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085566Inst : IEnumerable<long>
{
public static readonly long[] Value=A085566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085566.Bytes);
public long this[int i]=>Value[i];

public static A085566Inst Instance=new A085566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085567
{
public static readonly long[] Value={ 1L,4L,15L,42L,121L,336L,930L,2548L,6937L,0L,51322L,0L,379097L,0L,2801205L,0L,20698345L,56264090L,152941920L,0L,0L,0L,8350344420L,0L,61701166395L,0L,455913379395L,1239301050694L,3368769533660L,0L,24892027072619L,0L,183928584450999L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085567Inst : IEnumerable<long>
{
public static readonly long[] Value=A085567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085567.Bytes);
public long this[int i]=>Value[i];

public static A085567Inst Instance=new A085567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085568
{
public static readonly long[] Value={ 1L,2L,8L,4L,88L,28L,104L,376L,1904L,372L,30152L,4952L,193072L,245848L,64304L,7984L,8303392L,32131172L,126932136L,164384184L,185914544L,16850280L,3006076208L,249890288L,5554299808L,21745428728L,9598969456L,37645191344L,5687521456416L,378608431568L,4518712438048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085568Inst : IEnumerable<long>
{
public static readonly long[] Value=A085568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085568.Bytes);
public long this[int i]=>Value[i];

public static A085568Inst Instance=new A085568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085569
{
public static readonly long[] Value={ 1L,1L,3L,1L,15L,3L,7L,15L,45L,5L,231L,21L,455L,315L,45L,3L,1683L,3465L,7315L,5005L,3003L,143L,13455L,585L,6825L,13923L,3213L,6545L,515185L,17765L,110143L,31977L,2078505L,62985L,1789515L,51129L,210197L,426075L,246675L,6325L,1400355L,34155L,41612175L,84192075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085569Inst : IEnumerable<long>
{
public static readonly long[] Value=A085569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085569.Bytes);
public long this[int i]=>Value[i];

public static A085569Inst Instance=new A085569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085570
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,8L,14L,24L,39L,74L,128L,232L,423L,776L,1426L,2660L,4931L,9268L,17346L,32840L,61903L,117832L,223410L,427156L,813812L,1561830L,2987535L,5751742L,11039759L,21312036L,41025866L,79386066L,153208323L,297072312L,574604611L,1116186954L,2163216427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085570Inst : IEnumerable<long>
{
public static readonly long[] Value=A085570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085570.Bytes);
public long this[int i]=>Value[i];

public static A085570Inst Instance=new A085570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085571
{
public static readonly long[] Value={ 2L,6L,11L,20L,101L,175L,593L,173L,1502L,2684L,28649L,52169L,662393L,1224077L,4506259L,4210067L,23506871L,44294491L,41572193L,78849257L,1639049932L,3125022742L,23750582143L,9095291663L,225666905951L,144544431373L,276913262539L,76244134117L,732674442397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085571Inst : IEnumerable<long>
{
public static readonly long[] Value=A085571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085571.Bytes);
public long this[int i]=>Value[i];

public static A085571Inst Instance=new A085571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085572
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,6L,1L,5L,5L,30L,30L,210L,210L,420L,210L,630L,630L,315L,315L,3465L,3465L,13860L,2772L,36036L,12012L,12012L,1716L,8580L,8580L,17160L,8580L,145860L,204204L,612612L,612612L,11639628L,11639628L,29099070L,29099070L,29099070L,29099070L,1322685L,14549535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085572Inst : IEnumerable<long>
{
public static readonly long[] Value=A085572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085572.Bytes);
public long this[int i]=>Value[i];

public static A085572Inst Instance=new A085572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085573
{
public static readonly long[] Value={ 2L,6L,11L,20L,32L,56L,97L,172L,298L,534L,952L,1736L,3150L,5824L,10724L,20042L,37308L,70304L,131971L,250308L,473020L,901872L,1713596L,3281122L,6262254L,12033330L,23053047L,44431308L,85393280L,165008114L,318009610L,615878180L,1189803926L,2308781688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085573Inst : IEnumerable<long>
{
public static readonly long[] Value=A085573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085573.Bytes);
public long this[int i]=>Value[i];

public static A085573Inst Instance=new A085573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085574
{
public static readonly long[] Value={ 0L,9L,6L,1L,2L,7L,1L,7L,9L,11L,55L,38L,42L,83L,34L,98L,71L,46L,17L,99L,75L,77L,31L,51L,21L,35L,98L,82L,102L,32L,87L,49L,23L,84L,44L,89L,11L,15L,86L,6L,1L,33L,18L,39L,89L,625L,567L,111L,571L,731L,585L,17L,341L,341L,11L,445L,537L,182L,672L,802L,566L,68L,182L,1012L,352L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085574Inst : IEnumerable<long>
{
public static readonly long[] Value=A085574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085574.Bytes);
public long this[int i]=>Value[i];

public static A085574Inst Instance=new A085574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085575
{
public static readonly long[] Value={ 0L,1L,4L,9L,36L,49L,100L,144L,225L,361L,400L,441L,729L,900L,1225L,1369L,1444L,1936L,2025L,2209L,2704L,3600L,3969L,4225L,4900L,5776L,7225L,7396L,7921L,8836L,9409L,10000L,10404L,11449L,11881L,14400L,14884L,17424L,19044L,19881L,21025L,22500L,24025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085575Inst : IEnumerable<long>
{
public static readonly long[] Value=A085575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085575.Bytes);
public long this[int i]=>Value[i];

public static A085575Inst Instance=new A085575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085576
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,2L,3L,3L,4L,4L,4L,3L,3L,3L,4L,4L,5L,5L,4L,4L,3L,3L,4L,5L,6L,6L,6L,5L,4L,3L,4L,5L,6L,6L,7L,7L,6L,6L,5L,4L,4L,5L,6L,8L,8L,8L,8L,8L,6L,5L,4L,4L,6L,7L,8L,9L,9L,9L,9L,8L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085576Inst : IEnumerable<long>
{
public static readonly long[] Value=A085576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085576.Bytes);
public long this[int i]=>Value[i];

public static A085576Inst Instance=new A085576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085577
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,8L,10L,13L,17L,20L,25L,29L,34L,40L,45L,52L,58L,65L,73L,80L,89L,97L,106L,116L,125L,136L,146L,157L,169L,180L,193L,205L,218L,232L,245L,260L,274L,289L,305L,320L,337L,353L,370L,388L,405L,424L,442L,461L,481L,500L,521L,541L,562L,584L,605L,628L,650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085577Inst : IEnumerable<long>
{
public static readonly long[] Value=A085577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085577.Bytes);
public long this[int i]=>Value[i];

public static A085577Inst Instance=new A085577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085578
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,4L,5L,5L,4L,5L,6L,6L,6L,5L,6L,8L,8L,8L,8L,6L,7L,9L,11L,9L,11L,9L,7L,8L,11L,12L,13L,13L,12L,11L,8L,9L,12L,15L,15L,14L,15L,15L,12L,9L,10L,14L,17L,19L,17L,17L,19L,17L,14L,10L,11L,15L,18L,20L,22L,18L,22L,20L,18L,15L,11L,12L,17L,20L,22L,24L,24L,24L,24L,22L,20L,17L,12L,13L,18L,23L,24L,27L,27L,25L,27L,27L,24L,23L,18L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085578Inst : IEnumerable<long>
{
public static readonly long[] Value=A085578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085578.Bytes);
public long this[int i]=>Value[i];

public static A085578Inst Instance=new A085578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085579
{
public static readonly long[] Value={ 9L,3L,1L,4L,8L,4L,2L,8L,6L,7L,0L,8L,0L,4L,4L,3L,8L,1L,7L,6L,8L,6L,4L,9L,9L,5L,3L,6L,3L,6L,1L,3L,7L,9L,3L,4L,1L,7L,1L,0L,8L,0L,2L,2L,1L,8L,2L,8L,3L,7L,2L,3L,1L,0L,2L,4L,4L,4L,6L,6L,6L,7L,2L,5L,9L,0L,2L,3L,2L,5L,2L,2L,7L,1L,6L,8L,7L,3L,3L,0L,8L,8L,0L,8L,1L,9L,1L,6L,5L,4L,2L,8L,3L,5L,4L,3L,9L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085579Inst : IEnumerable<long>
{
public static readonly long[] Value=A085579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085579.Bytes);
public long this[int i]=>Value[i];

public static A085579Inst Instance=new A085579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085580
{
public static readonly long[] Value={ 6L,3L,1L,4L,0L,3L,1L,8L,3L,0L,3L,5L,2L,7L,6L,7L,4L,7L,9L,3L,0L,8L,9L,4L,2L,4L,1L,2L,1L,0L,7L,7L,7L,1L,2L,2L,4L,6L,0L,4L,6L,5L,7L,3L,5L,5L,7L,6L,6L,0L,7L,7L,7L,3L,8L,9L,5L,8L,4L,0L,3L,3L,1L,7L,7L,5L,5L,6L,9L,6L,6L,1L,2L,3L,7L,9L,7L,5L,9L,9L,3L,4L,5L,7L,7L,2L,9L,5L,0L,1L,6L,5L,5L,4L,1L,4L,6L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085580Inst : IEnumerable<long>
{
public static readonly long[] Value=A085580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085580.Bytes);
public long this[int i]=>Value[i];

public static A085580Inst Instance=new A085580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085581
{
public static readonly long[] Value={ 4L,4L,5L,6L,7L,8L,9L,10L,12L,12L,14L,15L,16L,17L,19L,20L,21L,22L,23L,23L,25L,26L,28L,30L,30L,31L,32L,32L,33L,36L,37L,39L,39L,41L,42L,43L,44L,45L,46L,48L,48L,50L,51L,51L,51L,54L,57L,58L,58L,59L,60L,60L,62L,64L,65L,66L,66L,67L,68L,68L,70L,74L,74L,74L,75L,78L,79L,81L,82L,82L,83L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085581Inst : IEnumerable<long>
{
public static readonly long[] Value=A085581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085581.Bytes);
public long this[int i]=>Value[i];

public static A085581Inst Instance=new A085581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085582
{
public static readonly long[] Value={ 0L,1L,10L,44L,130L,313L,640L,1192L,2044L,3305L,5078L,7524L,10750L,14993L,20388L,27128L,35448L,45665L,57922L,72636L,89970L,110297L,133976L,161440L,192860L,228857L,269758L,316012L,367974L,426417L,491468L,564120L,644640L,733633L,831674L,939292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085582Inst : IEnumerable<long>
{
public static readonly long[] Value=A085582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085582.Bytes);
public long this[int i]=>Value[i];

public static A085582Inst Instance=new A085582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085583
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,29L,51L,83L,131L,196L,286L,402L,554L,743L,981L,1269L,1621L,2038L,2536L,3116L,3796L,4577L,5479L,6503L,7671L,8984L,10466L,12118L,13966L,16011L,18281L,20777L,23529L,26538L,29836L,33424L,37336L,41573L,46171L,51131L,56491L,62252L,68454L,75098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085583Inst : IEnumerable<long>
{
public static readonly long[] Value=A085583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085583.Bytes);
public long this[int i]=>Value[i];

public static A085583Inst Instance=new A085583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085584
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,45L,100L,222L,491L,1086L,2401L,5310L,11744L,25977L,57460L,127101L,281144L,621882L,1375579L,3042726L,6730385L,14887338L,32930188L,72840249L,161119700L,356390301L,788321020L,1743734406L,3857070395L,8531684622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085584Inst : IEnumerable<long>
{
public static readonly long[] Value=A085584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085584.Bytes);
public long this[int i]=>Value[i];

public static A085584Inst Instance=new A085584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085585
{
public static readonly long[] Value={ 1L,9L,16L,25L,36L,49L,81L,100L,144L,225L,256L,289L,324L,441L,625L,676L,784L,841L,900L,1024L,1444L,1600L,2025L,2209L,2304L,2401L,2500L,2601L,2704L,2809L,3600L,3844L,4096L,4225L,4489L,4900L,6241L,6724L,6889L,8100L,8281L,8649L,8836L,9604L,10000L,10404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085585Inst : IEnumerable<long>
{
public static readonly long[] Value=A085585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085585.Bytes);
public long this[int i]=>Value[i];

public static A085585Inst Instance=new A085585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085586
{
public static readonly long[] Value={ 0L,2L,20L,200L,202L,2000L,2002L,2020L,20000L,20002L,20020L,20200L,200000L,200002L,200020L,200200L,202000L,2000000L,2000002L,2000020L,2000200L,2002000L,2020000L,20000000L,20000002L,20000020L,20000200L,20000202L,20002000L,20002002L,20020000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085586Inst : IEnumerable<long>
{
public static readonly long[] Value=A085586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085586.Bytes);
public long this[int i]=>Value[i];

public static A085586Inst Instance=new A085586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085587
{
public static readonly long[] Value={ 1L,1L,3L,2L,7L,1L,7L,6L,31L,4L,63L,14L,15L,1L,15L,14L,511L,12L,63L,62L,2047L,8L,1023L,126L,511L,28L,16383L,30L,31L,1L,31L,30L,4095L,28L,87381L,1022L,4095L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085587Inst : IEnumerable<long>
{
public static readonly long[] Value=A085587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085587.Bytes);
public long this[int i]=>Value[i];

public static A085587Inst Instance=new A085587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085604
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,3L,1L,0L,0L,3L,1L,1L,0L,0L,4L,2L,1L,0L,0L,0L,4L,2L,1L,1L,0L,0L,0L,7L,2L,1L,1L,0L,0L,0L,0L,7L,4L,1L,1L,0L,0L,0L,0L,0L,8L,4L,2L,1L,0L,0L,0L,0L,0L,0L,8L,4L,2L,1L,1L,0L,0L,0L,0L,0L,0L,10L,5L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,10L,5L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,11L,5L,2L,2L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085604Inst : IEnumerable<long>
{
public static readonly long[] Value=A085604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085604.Bytes);
public long this[int i]=>Value[i];

public static A085604Inst Instance=new A085604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085605
{
public static readonly long[] Value={ 2L,9L,448L,21025L,25566816L,13167792001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085605Inst : IEnumerable<long>
{
public static readonly long[] Value=A085605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085605.Bytes);
public long this[int i]=>Value[i];

public static A085605Inst Instance=new A085605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085606
{
public static readonly BigInteger[] Value={ 0L,-1L,0L,7L,80L,1023L,15624L,279935L,5764800L,134217727L,3486784400L,99999999999L,3138428376720L,106993205379071L,3937376385699288L,155568095557812223L,6568408355712890624L,BigInteger.Parse("295147905179352825855"),BigInteger.Parse("14063084452067724991008"),BigInteger.Parse("708235345355337676357631") };
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
public class A085606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085606Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085606.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085606Inst Instance=new A085606Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085607
{
public static readonly long[] Value={ 45L,54L,250L,495L,594L,1131L,1311L,2262L,2550L,2622L,2750L,2926L,3393L,3933L,4154L,4489L,4514L,4545L,4636L,4995L,5454L,5808L,5994L,6292L,6364L,6550L,7800L,8085L,8749L,9478L,9844L,12441L,13980L,14269L,14421L,15167L,15180L,15602L,16237L,18449L,18977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085607Inst : IEnumerable<long>
{
public static readonly long[] Value=A085607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085607.Bytes);
public long this[int i]=>Value[i];

public static A085607Inst Instance=new A085607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085608
{
public static readonly long[] Value={ 5L,1L,2L,13L,3L,18L,4L,23L,25L,26L,5L,31L,6L,35L,36L,38L,7L,42L,8L,304L,47L,48L,9L,53L,54L,56L,58L,60L,10L,63L,11L,453L,67L,69L,71L,73L,12L,76L,78L,79L,13L,82L,14L,86L,88L,89L,15L,93L,94L,96L,682L,98L,16L,100L,102L,103L,105L,107L,17L,110L,18L,807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085608Inst : IEnumerable<long>
{
public static readonly long[] Value=A085608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085608.Bytes);
public long this[int i]=>Value[i];

public static A085608Inst Instance=new A085608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085609
{
public static readonly long[] Value={ 6L,0L,8L,3L,8L,1L,7L,1L,7L,8L,6L,3L,3L,2L,4L,7L,2L,2L,6L,8L,3L,8L,3L,4L,5L,8L,5L,8L,1L,5L,6L,2L,0L,1L,8L,7L,7L,5L,9L,1L,4L,8L,5L,9L,8L,2L,2L,6L,0L,2L,2L,5L,2L,1L,1L,9L,9L,5L,7L,3L,0L,8L,1L,5L,5L,2L,1L,7L,9L,7L,3L,1L,6L,6L,2L,1L,0L,7L,3L,9L,9L,5L,1L,5L,3L,4L,1L,7L,1L,3L,6L,8L,9L,7L,6L,6L,3L,1L,6L,8L,5L,6L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085609Inst : IEnumerable<long>
{
public static readonly long[] Value=A085609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085609.Bytes);
public long this[int i]=>Value[i];

public static A085609Inst Instance=new A085609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085610
{
public static readonly long[] Value={ 101L,251L,10001L,18751L,200001L,4218751L,100000001L,74218751L,10000000001L,3574218751L,1000000000001L,163574218751L,100000000000001L,480163574218751L,2000000000000001L,6230163574218751L,1000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085610Inst : IEnumerable<long>
{
public static readonly long[] Value=A085610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085610.Bytes);
public long this[int i]=>Value[i];

public static A085610Inst Instance=new A085610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085611
{
public static readonly long[] Value={ 1L,6L,12L,32L,57L,73L,144L,210L,255L,394L,516L,520L,833L,1032L,1182L,1518L,1809L,1927L,2500L,2904L,3205L,3836L,4368L,4768L,5577L,6258L,6550L,7780L,8625L,9265L,10496L,11526L,12403L,13782L,15012L,15996L,17689L,19140L,20218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085611Inst : IEnumerable<long>
{
public static readonly long[] Value=A085611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085611.Bytes);
public long this[int i]=>Value[i];

public static A085611Inst Instance=new A085611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085612
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,25L,5L,7L,11L,13L,6L,10L,14L,15L,21L,8L,27L,125L,343L,1331L,2197L,12L,18L,20L,28L,44L,45L,50L,16L,81L,625L,2401L,14641L,28561L,83521L,130321L,17L,19L,23L,29L,31L,37L,41L,43L,47L,22L,26L,33L,34L,35L,38L,39L,46L,51L,55L,24L,40L,54L,56L,88L,104L,135L,136L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085612Inst : IEnumerable<long>
{
public static readonly long[] Value=A085612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085612.Bytes);
public long this[int i]=>Value[i];

public static A085612Inst Instance=new A085612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085613
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,41L,65L,155L,257L,593L,1025L,2291L,4097L,8921L,16385L,34955L,65537L,137633L,262145L,543971L,1048577L,2156201L,4194305L,8565755L,16777217L,34085873L,67108865L,135812051L,268435457L,541653881L,1073741825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085613Inst : IEnumerable<long>
{
public static readonly long[] Value=A085613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085613.Bytes);
public long this[int i]=>Value[i];

public static A085613Inst Instance=new A085613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085614
{
public static readonly long[] Value={ 1L,3L,16L,105L,768L,6006L,49152L,415701L,3604480L,31870410L,286261248L,2604681690L,23957864448L,222399744300L,2080911654912L,19604537460045L,185813170126848L,1770558814528770L,16951376923852800L,162984598242674670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085614Inst : IEnumerable<long>
{
public static readonly long[] Value=A085614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085614.Bytes);
public long this[int i]=>Value[i];

public static A085614Inst Instance=new A085614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085615
{
public static readonly long[] Value={ 1L,1L,2L,8L,48L,352L,2880L,25216L,231168L,2190848L,21292032L,211044352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085615Inst : IEnumerable<long>
{
public static readonly long[] Value=A085615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085615.Bytes);
public long this[int i]=>Value[i];

public static A085615Inst Instance=new A085615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085616
{
public static readonly long[] Value={ 3L,11L,19L,35L,43L,67L,91L,115L,163L,235L,403L,427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085616Inst : IEnumerable<long>
{
public static readonly long[] Value=A085616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085616.Bytes);
public long this[int i]=>Value[i];

public static A085616Inst Instance=new A085616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085617
{
public static readonly long[] Value={ 0L,0L,2L,17L,392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085617Inst : IEnumerable<long>
{
public static readonly long[] Value=A085617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085617.Bytes);
public long this[int i]=>Value[i];

public static A085617Inst Instance=new A085617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085618
{
public static readonly long[] Value={ 1L,1L,4L,0L,19L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085618Inst : IEnumerable<long>
{
public static readonly long[] Value=A085618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085618.Bytes);
public long this[int i]=>Value[i];

public static A085618Inst Instance=new A085618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085619
{
public static readonly long[] Value={ 2L,2L,4L,8L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085619Inst : IEnumerable<long>
{
public static readonly long[] Value=A085619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085619.Bytes);
public long this[int i]=>Value[i];

public static A085619Inst Instance=new A085619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085652
{
public static readonly long[] Value={ 1L,1L,2L,11L,21L,112L,221L,1221L,11122L,22111L,122121L,1121112L,2212121L,12222121L,112211122L,222122211L,2111222221L,12111122112L,111112121221L,212112212221L,1212122111122L,11121211221111L,21222222221121L,122121211211112L,1121121211121121L,2212212111221121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085652Inst : IEnumerable<long>
{
public static readonly long[] Value=A085652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085652.Bytes);
public long this[int i]=>Value[i];

public static A085652Inst Instance=new A085652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085653
{
public static readonly long[] Value={ 6L,3L,5L,8L,7L,10L,11L,9L,12L,14L,13L,16L,17L,15L,21L,18L,19L,20L,23L,24L,22L,26L,29L,25L,27L,33L,28L,32L,30L,31L,37L,36L,34L,35L,38L,40L,41L,39L,46L,44L,42L,43L,47L,45L,48L,51L,53L,49L,50L,52L,55L,54L,59L,56L,57L,60L,58L,62L,61L,63L,66L,65L,64L,68L,69L,67L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085653Inst : IEnumerable<long>
{
public static readonly long[] Value=A085653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085653.Bytes);
public long this[int i]=>Value[i];

public static A085653Inst Instance=new A085653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085654
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,4L,0L,5L,8L,11L,13L,15L,18L,20L,22L,24L,1L,5L,8L,11L,13L,15L,18L,20L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085654Inst : IEnumerable<long>
{
public static readonly long[] Value=A085654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085654.Bytes);
public long this[int i]=>Value[i];

public static A085654Inst Instance=new A085654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085655
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,-4L,0L,3L,5L,7L,9L,12L,13L,15L,16L,-7L,-3L,0L,2L,4L,6L,9L,11L,13L,14L,-8L,-5L,-2L,0L,3L,5L,7L,9L,11L,12L,-10L,-7L,-4L,-3L,0L,2L,4L,6L,8L,9L,-12L,-9L,-6L,-5L,-2L,0L,2L,5L,7L,7L,-14L,-12L,-9L,-7L,-4L,-2L,0L,2L,4L,5L,-15L,-13L,-11L,-9L,-6L,-5L,-2L,0L,2L,3L,-18L,-15L,-13L,-11L,-8L,-7L,-4L,-2L,0L,1L,-20L,-16L,-14L,-12L,-9L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085655Inst : IEnumerable<long>
{
public static readonly long[] Value=A085655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085655.Bytes);
public long this[int i]=>Value[i];

public static A085655Inst Instance=new A085655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085656
{
public static readonly long[] Value={ 1L,3L,27L,681L,43369L,6184475L,1688686483L,665444089745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085656Inst : IEnumerable<long>
{
public static readonly long[] Value=A085656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085656.Bytes);
public long this[int i]=>Value[i];

public static A085656Inst Instance=new A085656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085657
{
public static readonly long[] Value={ 1L,2L,8L,61L,819L,17417L,506609L,15582436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085657Inst : IEnumerable<long>
{
public static readonly long[] Value=A085657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085657.Bytes);
public long this[int i]=>Value[i];

public static A085657Inst Instance=new A085657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085658
{
public static readonly long[] Value={ 1L,2L,8L,64L,924L,21737L,749684L,33568376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085658Inst : IEnumerable<long>
{
public static readonly long[] Value=A085658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085658.Bytes);
public long this[int i]=>Value[i];

public static A085658Inst Instance=new A085658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085659
{
public static readonly long[] Value={ 4L,1L,0L,7L,8L,1L,2L,9L,0L,5L,0L,2L,9L,0L,8L,6L,9L,5L,4L,7L,6L,0L,0L,9L,4L,9L,2L,0L,1L,8L,3L,6L,0L,5L,9L,1L,8L,8L,8L,3L,0L,6L,9L,7L,0L,3L,9L,3L,4L,1L,5L,3L,4L,5L,3L,0L,4L,5L,7L,1L,6L,5L,8L,8L,0L,6L,1L,3L,5L,1L,8L,2L,4L,3L,7L,6L,5L,4L,9L,9L,5L,8L,7L,5L,9L,7L,8L,6L,1L,9L,0L,4L,5L,4L,3L,5L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085659Inst : IEnumerable<long>
{
public static readonly long[] Value=A085659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085659.Bytes);
public long this[int i]=>Value[i];

public static A085659Inst Instance=new A085659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085660
{
public static readonly long[] Value={ 9L,1L,1L,7L,3L,3L,9L,1L,4L,7L,8L,6L,9L,6L,5L,0L,9L,7L,8L,9L,3L,7L,1L,7L,3L,1L,7L,8L,0L,5L,4L,3L,1L,8L,4L,5L,2L,5L,0L,4L,1L,3L,4L,2L,9L,2L,1L,5L,6L,9L,5L,4L,0L,1L,3L,3L,5L,6L,4L,0L,4L,6L,4L,7L,3L,3L,3L,1L,7L,3L,1L,2L,7L,5L,4L,5L,1L,9L,5L,2L,1L,3L,2L,1L,2L,0L,2L,4L,6L,0L,3L,5L,1L,6L,7L,1L,7L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085660Inst : IEnumerable<long>
{
public static readonly long[] Value=A085660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085660.Bytes);
public long this[int i]=>Value[i];

public static A085660Inst Instance=new A085660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085661
{
public static readonly long[] Value={ 6L,7L,8L,4L,3L,0L,4L,7L,7L,3L,6L,0L,7L,4L,0L,2L,2L,8L,9L,7L,9L,1L,6L,0L,1L,2L,6L,4L,8L,0L,3L,8L,6L,3L,2L,5L,0L,5L,2L,1L,1L,7L,2L,6L,0L,0L,9L,6L,1L,0L,1L,9L,4L,2L,0L,8L,2L,7L,4L,1L,1L,2L,0L,9L,2L,3L,7L,3L,9L,1L,3L,3L,4L,5L,6L,3L,7L,1L,3L,4L,4L,5L,8L,3L,7L,0L,1L,1L,9L,5L,4L,3L,2L,1L,6L,0L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085661Inst : IEnumerable<long>
{
public static readonly long[] Value=A085661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085661.Bytes);
public long this[int i]=>Value[i];

public static A085661Inst Instance=new A085661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085662
{
public static readonly long[] Value={ 7L,4L,5L,6L,2L,4L,1L,4L,1L,6L,6L,5L,5L,5L,7L,8L,8L,8L,8L,9L,3L,1L,5L,1L,0L,7L,0L,4L,3L,0L,3L,8L,3L,7L,9L,2L,0L,5L,0L,2L,9L,1L,6L,4L,6L,6L,1L,5L,3L,6L,6L,7L,3L,8L,4L,5L,6L,8L,7L,6L,5L,1L,7L,9L,9L,4L,1L,5L,2L,4L,5L,3L,0L,9L,5L,5L,1L,9L,2L,2L,3L,6L,0L,7L,8L,6L,5L,2L,1L,5L,0L,7L,9L,4L,0L,3L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085662Inst : IEnumerable<long>
{
public static readonly long[] Value=A085662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085662.Bytes);
public long this[int i]=>Value[i];

public static A085662Inst Instance=new A085662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085663
{
public static readonly long[] Value={ 8L,5L,7L,5L,5L,3L,2L,1L,5L,8L,4L,6L,3L,9L,3L,4L,1L,5L,7L,4L,4L,1L,0L,6L,2L,7L,2L,7L,6L,1L,9L,8L,9L,7L,9L,1L,1L,0L,5L,8L,5L,8L,4L,2L,4L,5L,9L,7L,4L,2L,4L,4L,8L,8L,6L,5L,2L,0L,5L,5L,4L,5L,0L,1L,7L,5L,0L,6L,3L,2L,1L,7L,3L,6L,9L,7L,3L,4L,9L,6L,0L,6L,2L,6L,8L,4L,3L,0L,5L,4L,7L,0L,4L,2L,7L,7L,7L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085663Inst : IEnumerable<long>
{
public static readonly long[] Value=A085663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085663.Bytes);
public long this[int i]=>Value[i];

public static A085663Inst Instance=new A085663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085664
{
public static readonly long[] Value={ 6L,5L,4L,2L,8L,9L,7L,9L,0L,4L,9L,7L,7L,7L,9L,1L,4L,9L,9L,7L,0L,9L,6L,6L,4L,7L,1L,3L,2L,7L,8L,0L,8L,4L,9L,6L,6L,2L,6L,6L,1L,5L,4L,9L,5L,4L,7L,2L,5L,9L,4L,9L,7L,9L,2L,1L,1L,7L,3L,5L,8L,8L,4L,2L,7L,4L,6L,8L,7L,5L,9L,3L,8L,7L,8L,9L,8L,5L,3L,1L,6L,4L,5L,9L,0L,4L,1L,3L,5L,1L,9L,2L,8L,7L,1L,4L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085664Inst : IEnumerable<long>
{
public static readonly long[] Value=A085664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085664.Bytes);
public long this[int i]=>Value[i];

public static A085664Inst Instance=new A085664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085665
{
public static readonly long[] Value={ 7L,4L,6L,8L,5L,9L,3L,3L,3L,9L,8L,7L,6L,5L,0L,2L,2L,6L,6L,8L,3L,0L,8L,0L,0L,0L,4L,3L,4L,2L,1L,0L,4L,6L,4L,4L,7L,5L,0L,4L,9L,6L,0L,1L,5L,4L,4L,5L,4L,6L,8L,1L,5L,4L,4L,3L,4L,0L,6L,8L,7L,1L,1L,3L,2L,9L,9L,2L,6L,8L,0L,7L,4L,4L,1L,7L,9L,8L,9L,3L,9L,0L,1L,4L,7L,1L,1L,9L,5L,6L,5L,2L,8L,2L,2L,9L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085665Inst : IEnumerable<long>
{
public static readonly long[] Value=A085665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085665.Bytes);
public long this[int i]=>Value[i];

public static A085665Inst Instance=new A085665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085666
{
public static readonly long[] Value={ 8L,6L,3L,5L,1L,8L,8L,5L,4L,8L,7L,8L,0L,5L,8L,8L,8L,1L,9L,8L,7L,0L,1L,5L,5L,9L,3L,1L,3L,6L,4L,3L,1L,8L,5L,0L,7L,7L,2L,2L,4L,7L,6L,0L,5L,8L,1L,8L,5L,7L,3L,4L,3L,0L,5L,7L,7L,5L,7L,2L,6L,9L,5L,4L,3L,0L,3L,8L,8L,5L,3L,4L,8L,3L,4L,6L,5L,8L,6L,4L,3L,9L,2L,9L,6L,5L,2L,4L,3L,0L,3L,4L,0L,0L,8L,7L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085666Inst : IEnumerable<long>
{
public static readonly long[] Value=A085666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085666.Bytes);
public long this[int i]=>Value[i];

public static A085666Inst Instance=new A085666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085667
{
public static readonly long[] Value={ 2L,3L,3L,1L,5L,0L,4L,3L,9L,9L,0L,0L,7L,1L,9L,5L,4L,6L,2L,2L,8L,9L,6L,8L,9L,9L,1L,1L,0L,1L,2L,1L,3L,7L,6L,6L,6L,3L,3L,2L,0L,1L,7L,4L,2L,8L,9L,6L,3L,5L,1L,6L,8L,2L,3L,2L,8L,0L,0L,5L,4L,5L,4L,6L,8L,1L,8L,0L,7L,9L,4L,3L,6L,6L,4L,2L,4L,9L,7L,3L,1L,4L,8L,5L,7L,3L,0L,6L,6L,6L,1L,3L,2L,1L,4L,0L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085667Inst : IEnumerable<long>
{
public static readonly long[] Value=A085667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085667.Bytes);
public long this[int i]=>Value[i];

public static A085667Inst Instance=new A085667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085716
{
public static readonly long[] Value={ 1L,1L,1L,1L,11L,5L,11L,16L,55L,305L,80L,256L,1451L,421L,541L,655L,1375L,4705L,2000L,7255L,9680L,9455L,9455L,37631L,19301L,203305L,83275L,32605L,108691L,44605L,76901L,308605L,153005L,478775L,186091L,189305L,591775L,289025L,2372005L,721151L,540905L,1566401L,1764400L,1217821L,760055L,798256L,4680055L,1386275L,1402000L,4822625L,2148080L,4628591L,2160455L,1636721L,11812625L,3869525L,4521505L,27105755L,6728105L,6340275L,7503505L,20599841L,24153305L,8088176L,6495280L,61395955L,17264525L,21321025L,12722855L,49860400L,42769375L,56285605L,88151275L,17478875L,21966025L,74338555L,155197205L,28850896L,37142851L,118690480L,44646025L,106111555L,54898055L,73297775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085716Inst : IEnumerable<long>
{
public static readonly long[] Value=A085716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085716.Bytes);
public long this[int i]=>Value[i];

public static A085716Inst Instance=new A085716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085717
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,6L,7L,9L,11L,14L,16L,18L,21L,24L,28L,31L,34L,38L,42L,47L,51L,55L,60L,65L,71L,76L,81L,87L,93L,100L,106L,112L,119L,126L,134L,141L,148L,156L,164L,173L,181L,189L,198L,207L,217L,226L,235L,245L,255L,266L,276L,286L,297L,308L,320L,331L,342L,354L,366L,379L,391L,403L,416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085717Inst : IEnumerable<long>
{
public static readonly long[] Value=A085717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085717.Bytes);
public long this[int i]=>Value[i];

public static A085717Inst Instance=new A085717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085718
{
public static readonly long[] Value={ 72L,576L,648L,750L,800L,900L,960L,1080L,3430L,4116L,4900L,5880L,6272L,7000L,7056L,7938L,8400L,8960L,9450L,10080L,10752L,11340L,12096L,13608L,18750L,20000L,22500L,24000L,25600L,27000L,28800L,30375L,30720L,32400L,34560L,36450L,36864L,37268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085718Inst : IEnumerable<long>
{
public static readonly long[] Value=A085718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085718.Bytes);
public long this[int i]=>Value[i];

public static A085718Inst Instance=new A085718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085719
{
public static readonly BigInteger[] Value={ 1L,5L,54L,1060L,33225L,1517028L,95036284L,7828309568L,820553006835L,106652605456000L,16835058193182834L,3172396072749375744L,BigInteger.Parse("703470523269606264445"),BigInteger.Parse("181335014313248383578368"),BigInteger.Parse("53768377727402203980675000"),BigInteger.Parse("18172294259291992881395286016") };
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
public class A085719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085719Inst Instance=new A085719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085720
{
public static readonly long[] Value={ 7L,37L,157L,185L,187L,271L,301L,355L,475L,485L,523L,533L,577L,611L,653L,661L,667L,731L,733L,755L,761L,791L,853L,911L,913L,937L,983L,1085L,1111L,1187L,1205L,1253L,1397L,1417L,1585L,1631L,1655L,1685L,1697L,1711L,1723L,1841L,1907L,1975L,2035L,2077L,2105L,2185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085720Inst : IEnumerable<long>
{
public static readonly long[] Value=A085720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085720.Bytes);
public long this[int i]=>Value[i];

public static A085720Inst Instance=new A085720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085721
{
public static readonly long[] Value={ 4L,6L,9L,25L,35L,49L,121L,143L,169L,289L,323L,361L,391L,437L,493L,527L,529L,551L,589L,667L,713L,841L,899L,961L,1369L,1517L,1591L,1681L,1739L,1763L,1849L,1927L,1961L,2021L,2173L,2183L,2209L,2257L,2279L,2419L,2491L,2501L,2537L,2623L,2773L,2809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085721Inst : IEnumerable<long>
{
public static readonly long[] Value=A085721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085721.Bytes);
public long this[int i]=>Value[i];

public static A085721Inst Instance=new A085721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085722
{
public static readonly long[] Value={ 3L,5L,8L,9L,11L,12L,15L,19L,22L,25L,28L,29L,30L,34L,35L,39L,42L,44L,45L,46L,48L,49L,50L,51L,52L,58L,59L,60L,61L,62L,64L,65L,69L,71L,76L,78L,79L,80L,85L,86L,88L,92L,95L,96L,100L,101L,102L,104L,106L,108L,114L,121L,131L,136L,139L,140L,141L,144L,145L,152L,154L,158L,159L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085722Inst : IEnumerable<long>
{
public static readonly long[] Value=A085722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085722.Bytes);
public long this[int i]=>Value[i];

public static A085722Inst Instance=new A085722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085723
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,3L,5L,3L,4L,3L,7L,4L,5L,6L,9L,2L,4L,9L,6L,3L,6L,4L,10L,6L,7L,5L,12L,6L,7L,10L,11L,4L,11L,6L,15L,5L,7L,8L,10L,10L,6L,10L,9L,8L,14L,8L,13L,6L,8L,10L,12L,5L,10L,14L,13L,7L,13L,13L,10L,12L,8L,7L,24L,4L,12L,8L,8L,7L,17L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085723Inst : IEnumerable<long>
{
public static readonly long[] Value=A085723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085723.Bytes);
public long this[int i]=>Value[i];

public static A085723Inst Instance=new A085723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085724
{
public static readonly long[] Value={ 4L,9L,11L,23L,37L,41L,49L,59L,67L,83L,97L,101L,103L,109L,131L,137L,139L,149L,167L,197L,199L,227L,241L,269L,271L,281L,293L,347L,373L,379L,421L,457L,487L,523L,727L,809L,881L,971L,983L,997L,1061L,1063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085724Inst : IEnumerable<long>
{
public static readonly long[] Value=A085724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085724.Bytes);
public long this[int i]=>Value[i];

public static A085724Inst Instance=new A085724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085725
{
public static readonly long[] Value={ 6L,8L,9L,14L,18L,19L,21L,23L,26L,34L,36L,40L,48L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085725Inst : IEnumerable<long>
{
public static readonly long[] Value=A085725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085725.Bytes);
public long this[int i]=>Value[i];

public static A085725Inst Instance=new A085725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085726
{
public static readonly long[] Value={ 3L,10L,14L,20L,23L,26L,29L,32L,38L,43L,49L,56L,62L,64L,67L,68L,73L,76L,80L,83L,86L,89L,97L,107L,121L,128L,136L,137L,157L,164L,167L,172L,178L,197L,202L,211L,223L,229L,284L,293L,307L,311L,328L,373L,389L,397L,458L,487L,521L,541L,557L,577L,586L,619L,673L,857L,914L,929L,947L,1082L,1151L,1249L,1277L,1279L,1306L,1318L,1493L,1499L,1667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085726Inst : IEnumerable<long>
{
public static readonly long[] Value=A085726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085726.Bytes);
public long this[int i]=>Value[i];

public static A085726Inst Instance=new A085726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085727
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,4L,4L,3L,4L,4L,6L,6L,5L,4L,6L,7L,8L,9L,9L,8L,8L,8L,9L,9L,8L,9L,11L,11L,12L,12L,13L,12L,12L,11L,12L,12L,12L,11L,12L,12L,14L,15L,15L,16L,17L,18L,18L,17L,17L,16L,17L,17L,17L,17L,17L,17L,17L,18L,20L,21L,20L,20L,21L,20L,22L,22L,22L,21L,23L,24L,26L,26L,25L,25L,25L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085727Inst : IEnumerable<long>
{
public static readonly long[] Value=A085727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085727.Bytes);
public long this[int i]=>Value[i];

public static A085727Inst Instance=new A085727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085728
{
public static readonly long[] Value={ 10L,19L,32L,45L,70L,81L,99L,125L,134L,154L,157L,183L,185L,189L,193L,236L,238L,245L,260L,269L,282L,300L,303L,313L,333L,341L,352L,354L,359L,371L,381L,384L,394L,397L,417L,453L,464L,527L,532L,562L,564L,595L,601L,606L,615L,620L,633L,641L,654L,670L,690L,699L,708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085728Inst : IEnumerable<long>
{
public static readonly long[] Value=A085728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085728.Bytes);
public long this[int i]=>Value[i];

public static A085728Inst Instance=new A085728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085729
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,6L,6L,11L,13L,8L,17L,19L,23L,10L,9L,29L,31L,10L,37L,41L,43L,47L,14L,53L,59L,61L,12L,67L,71L,73L,79L,12L,83L,89L,97L,101L,103L,107L,109L,113L,22L,15L,127L,14L,131L,137L,139L,149L,151L,157L,163L,167L,26L,173L,179L,181L,191L,193L,197L,199L,211L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085729Inst : IEnumerable<long>
{
public static readonly long[] Value=A085729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085729.Bytes);
public long this[int i]=>Value[i];

public static A085729Inst Instance=new A085729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085730
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,6L,4L,6L,10L,12L,8L,16L,18L,22L,20L,18L,28L,30L,16L,36L,40L,42L,46L,42L,52L,58L,60L,32L,66L,70L,72L,78L,54L,82L,88L,96L,100L,102L,106L,108L,112L,110L,100L,126L,64L,130L,136L,138L,148L,150L,156L,162L,166L,156L,172L,178L,180L,190L,192L,196L,198L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085730Inst : IEnumerable<long>
{
public static readonly long[] Value=A085730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085730.Bytes);
public long this[int i]=>Value[i];

public static A085730Inst Instance=new A085730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085731
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,1L,4L,3L,1L,1L,4L,1L,1L,1L,16L,1L,3L,1L,4L,1L,1L,1L,4L,5L,1L,27L,4L,1L,1L,1L,16L,1L,1L,1L,12L,1L,1L,1L,4L,1L,1L,1L,4L,3L,1L,1L,16L,7L,5L,1L,4L,1L,27L,1L,4L,1L,1L,1L,4L,1L,1L,3L,64L,1L,1L,1L,4L,1L,1L,1L,12L,1L,1L,5L,4L,1L,1L,1L,16L,27L,1L,1L,4L,1L,1L,1L,4L,1L,3L,1L,4L,1L,1L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085731Inst : IEnumerable<long>
{
public static readonly long[] Value=A085731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085731.Bytes);
public long this[int i]=>Value[i];

public static A085731Inst Instance=new A085731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085812
{
public static readonly long[] Value={ 1L,5L,22L,91L,366L,1454L,5748L,22691L,89590L,354010L,1400268L,5544334L,21973420L,87158972L,345977832L,1374249251L,5461704870L,21717305762L,86391846492L,343800647066L,1368639516420L,5450093895812L,21708897213912L,86492537630606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085812Inst : IEnumerable<long>
{
public static readonly long[] Value=A085812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085812.Bytes);
public long this[int i]=>Value[i];

public static A085812Inst Instance=new A085812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085813
{
public static readonly long[] Value={ 1L,6L,11L,16L,21L,27L,33L,38L,44L,51L,57L,63L,70L,76L,83L,90L,96L,103L,110L,117L,124L,131L,138L,145L,152L,159L,167L,174L,181L,189L,196L,203L,211L,218L,226L,233L,241L,248L,256L,264L,271L,279L,287L,294L,302L,310L,318L,326L,333L,341L,349L,357L,365L,373L,381L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085813Inst : IEnumerable<long>
{
public static readonly long[] Value=A085813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085813.Bytes);
public long this[int i]=>Value[i];

public static A085813Inst Instance=new A085813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085814
{
public static readonly long[] Value={ -1L,-2L,0L,-8L,12L,8L,0L,-128L,252L,472L,840L,1120L,2112L,128L,0L,-32768L,65532L,131000L,261528L,519648L,1029192L,1991728L,3865664L,6825984L,13835328L,21056128L,39611520L,20680192L,134234112L,32768L,0L,-2147483648L,4294967292L,8589934456L,17179866936L,34359709664L,68719241112L,137436945552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085814Inst : IEnumerable<long>
{
public static readonly long[] Value=A085814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085814.Bytes);
public long this[int i]=>Value[i];

public static A085814Inst Instance=new A085814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085815
{
public static readonly long[] Value={ 2L,1L,1L,0L,3L,2L,11L,28L,13L,12L,29L,62L,1L,10L,1L,30L,27L,40L,73L,42L,63L,90L,29L,8L,61L,120L,37L,20L,41L,20L,1L,66L,283L,66L,27L,146L,1L,222L,1L,8L,77L,190L,173L,18L,1L,50L,149L,50L,29L,66L,31L,26L,23L,10L,29L,150L,99L,330L,81L,356L,53L,102L,7L,126L,123L,10L,227L,526L,117L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085815Inst : IEnumerable<long>
{
public static readonly long[] Value=A085815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085815.Bytes);
public long this[int i]=>Value[i];

public static A085815Inst Instance=new A085815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085816
{
public static readonly long[] Value={ 14L,15L,22L,25L,51L,82L,115L,118L,121L,123L,141L,145L,146L,158L,166L,177L,185L,201L,203L,205L,206L,213L,215L,218L,254L,259L,265L,295L,302L,321L,323L,407L,411L,415L,417L,451L,471L,481L,482L,501L,502L,511L,514L,517L,526L,529L,542L,562L,581L,614L,671L,706L,707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085816Inst : IEnumerable<long>
{
public static readonly long[] Value=A085816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085816.Bytes);
public long this[int i]=>Value[i];

public static A085816Inst Instance=new A085816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085817
{
public static readonly long[] Value={ 4L,6L,7L,9L,12L,13L,14L,15L,20L,21L,22L,23L,24L,30L,31L,36L,38L,39L,41L,44L,45L,46L,47L,52L,53L,54L,55L,56L,62L,63L,69L,70L,71L,73L,76L,77L,78L,79L,81L,86L,87L,88L,94L,95L,96L,97L,101L,102L,103L,105L,108L,109L,110L,111L,112L,118L,119L,120L,126L,127L,129L,132L,133L,134L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085817Inst : IEnumerable<long>
{
public static readonly long[] Value=A085817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085817.Bytes);
public long this[int i]=>Value[i];

public static A085817Inst Instance=new A085817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085818
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,7L,11L,2L,3L,13L,17L,19L,23L,29L,31L,2L,37L,41L,43L,47L,53L,59L,61L,67L,5L,71L,3L,73L,79L,83L,89L,2L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,7L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085818Inst : IEnumerable<long>
{
public static readonly long[] Value=A085818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085818.Bytes);
public long this[int i]=>Value[i];

public static A085818Inst Instance=new A085818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085819
{
public static readonly ulong[] Value={ 1L,2L,6L,12L,60L,420L,4620L,9240L,27720L,360360L,6126120L,116396280L,2677114440L,77636318760L,2406725881560L,4813451763120L,178097715235440L,7302006324653040L,313986271960080720L,14757354782123793840UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085819Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A085819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085819.Bytes);
public ulong this[int i]=>Value[i];

public static A085819Inst Instance=new A085819Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085820
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,13L,17L,19L,21L,23L,27L,29L,31L,33L,37L,39L,41L,43L,47L,49L,51L,53L,57L,59L,61L,63L,67L,69L,71L,73L,77L,79L,81L,83L,87L,89L,91L,93L,97L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085820Inst : IEnumerable<long>
{
public static readonly long[] Value=A085820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085820.Bytes);
public long this[int i]=>Value[i];

public static A085820Inst Instance=new A085820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085821
{
public static readonly long[] Value={ 101L,103L,107L,109L,211L,113L,317L,419L,421L,223L,127L,229L,131L,233L,137L,139L,241L,443L,347L,149L,151L,353L,157L,359L,461L,163L,167L,269L,271L,173L,277L,179L,181L,283L,487L,389L,191L,193L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085821Inst : IEnumerable<long>
{
public static readonly long[] Value=A085821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085821.Bytes);
public long this[int i]=>Value[i];

public static A085821Inst Instance=new A085821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085822
{
public static readonly long[] Value={ 2L,13L,23L,113L,137L,373L,1973L,1733L,1373L,10337L,10313L,31379L,37337L,113173L,211373L,313739L,337397L,1113173L,1003733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085822Inst : IEnumerable<long>
{
public static readonly long[] Value=A085822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085822.Bytes);
public long this[int i]=>Value[i];

public static A085822Inst Instance=new A085822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085823
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,37L,53L,73L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085823Inst : IEnumerable<long>
{
public static readonly long[] Value=A085823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085823.Bytes);
public long this[int i]=>Value[i];

public static A085823Inst Instance=new A085823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085824
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,34L,35L,36L,37L,38L,39L,41L,44L,45L,48L,51L,52L,54L,55L,56L,57L,59L,61L,64L,66L,68L,77L,80L,83L,85L,97L,99L,100L,102L,103L,104L,106L,109L,111L,112L,114L,119L,120L,122L,127L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085824Inst : IEnumerable<long>
{
public static readonly long[] Value=A085824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085824.Bytes);
public long this[int i]=>Value[i];

public static A085824Inst Instance=new A085824Inst();

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