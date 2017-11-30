using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A096391
{
public static readonly long[] Value={ 0L,6L,8L,9L,7L,9L,4L,6L,2L,4L,7L,5L,4L,3L,3L,7L,3L,4L,3L,9L,2L,0L,1L,7L,2L,0L,7L,6L,6L,1L,2L,0L,3L,5L,5L,4L,1L,4L,0L,6L,9L,0L,3L,4L,0L,4L,2L,8L,5L,3L,0L,1L,9L,1L,7L,3L,9L,7L,3L,9L,2L,3L,1L,1L,0L,6L,6L,5L,4L,6L,3L,4L,1L,5L,2L,3L,3L,4L,4L,1L,9L,1L,7L,5L,8L,9L,3L,2L,5L,0L,5L,2L,4L,5L,2L,3L,5L,9L,6L,7L,6L,2L,2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096391Inst : IEnumerable<long>
{
public static readonly long[] Value=A096391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096391.Bytes);
public long this[int i]=>Value[i];

public static A096391Inst Instance=new A096391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096392
{
public static readonly long[] Value={ 3L,4L,2L,1L,1L,7L,5L,1L,2L,1L,6L,0L,5L,6L,4L,4L,1L,7L,4L,1L,4L,6L,8L,1L,8L,2L,7L,1L,1L,5L,5L,3L,0L,8L,7L,5L,4L,4L,5L,1L,3L,2L,5L,5L,5L,6L,8L,3L,2L,5L,3L,5L,1L,3L,9L,7L,8L,8L,8L,8L,7L,1L,0L,1L,4L,9L,3L,5L,7L,2L,3L,0L,5L,7L,8L,5L,2L,4L,7L,7L,9L,0L,0L,0L,7L,7L,2L,7L,1L,7L,6L,7L,9L,4L,9L,1L,1L,3L,0L,8L,4L,1L,9L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096392Inst : IEnumerable<long>
{
public static readonly long[] Value=A096392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096392.Bytes);
public long this[int i]=>Value[i];

public static A096392Inst Instance=new A096392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096393
{
public static readonly long[] Value={ 2L,3L,3L,3L,17L,3L,3L,7L,37L,3L,3L,43L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096393Inst : IEnumerable<long>
{
public static readonly long[] Value=A096393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096393.Bytes);
public long this[int i]=>Value[i];

public static A096393Inst Instance=new A096393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096394
{
public static readonly long[] Value={ 3L,5L,6L,9L,12L,19L,92L,173L,242L,703L,1861L,3186L,4746L,7843L,26547L,180987L,383025L,561307L,2678667L,66497629L,118070060L,287778019L,527652876L,2387762279L,29492819981L,118172840270L,370227553800L,765130000703664L,4360055342801637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096394Inst : IEnumerable<long>
{
public static readonly long[] Value=A096394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096394.Bytes);
public long this[int i]=>Value[i];

public static A096394Inst Instance=new A096394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096395
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,10L,17L,38L,466L,639L,27563L,131637L,221702L,1788830L,3038164L,7008953L,7514089L,25863143L,88325365L,138580426L,1775990455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096395Inst : IEnumerable<long>
{
public static readonly long[] Value=A096395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096395.Bytes);
public long this[int i]=>Value[i];

public static A096395Inst Instance=new A096395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096396
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,5L,2L,6L,3L,6L,2L,6L,5L,7L,8L,8L,3L,10L,4L,6L,6L,14L,4L,20L,9L,9L,6L,14L,6L,21L,8L,10L,10L,14L,12L,18L,12L,18L,8L,20L,8L,21L,10L,12L,13L,28L,8L,42L,11L,18L,12L,26L,10L,29L,12L,18L,15L,32L,8L,30L,19L,19L,32L,24L,14L,32L,16L,22L,14L,42L,12L,36L,23L,22L,18L,30L,14L,50L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096396Inst : IEnumerable<long>
{
public static readonly long[] Value=A096396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096396.Bytes);
public long this[int i]=>Value[i];

public static A096396Inst Instance=new A096396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096397
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,2L,0L,1L,4L,2L,6L,1L,1L,0L,8L,3L,8L,4L,6L,4L,8L,4L,0L,3L,9L,6L,14L,2L,9L,8L,10L,6L,10L,0L,18L,6L,6L,8L,20L,4L,21L,10L,12L,9L,18L,8L,0L,9L,14L,12L,26L,8L,11L,12L,18L,13L,26L,8L,30L,11L,17L,0L,24L,6L,34L,16L,22L,10L,28L,12L,36L,13L,18L,18L,30L,10L,28L,16L,0L,18L,39L,12L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096397Inst : IEnumerable<long>
{
public static readonly long[] Value=A096397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096397.Bytes);
public long this[int i]=>Value[i];

public static A096397Inst Instance=new A096397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096398
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,16L,25L,36L,49L,64L,81L,100L,121L,144L,169L,196L,225L,256L,289L,324L,361L,400L,441L,484L,529L,576L,625L,676L,729L,784L,841L,900L,961L,1024L,1089L,1156L,1225L,1296L,1369L,1444L,1521L,1600L,1681L,1764L,1849L,1936L,2025L,2116L,2209L,2304L,2401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096398Inst : IEnumerable<long>
{
public static readonly long[] Value=A096398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096398.Bytes);
public long this[int i]=>Value[i];

public static A096398Inst Instance=new A096398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096399
{
public static readonly long[] Value={ 5775L,5984L,7424L,11024L,21735L,21944L,26144L,27404L,39375L,43064L,49664L,56924L,58695L,61424L,69615L,70784L,76544L,77175L,79695L,81080L,81675L,82004L,84524L,84644L,89775L,91664L,98175L,103455L,104895L,106784L,109395L,111824L,116655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096399Inst : IEnumerable<long>
{
public static readonly long[] Value=A096399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096399.Bytes);
public long this[int i]=>Value[i];

public static A096399Inst Instance=new A096399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096400
{
public static readonly long[] Value={ 89L,88L,86L,85L,83L,82L,80L,79L,77L,76L,74L,73L,71L,70L,68L,67L,65L,64L,62L,61L,59L,58L,56L,55L,53L,52L,50L,49L,47L,46L,44L,43L,41L,40L,38L,37L,35L,34L,32L,31L,29L,28L,26L,25L,23L,22L,20L,19L,17L,16L,14L,13L,11L,10L,8L,7L,5L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096400Inst : IEnumerable<long>
{
public static readonly long[] Value=A096400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096400.Bytes);
public long this[int i]=>Value[i];

public static A096400Inst Instance=new A096400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096401
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,8L,8L,10L,11L,13L,14L,17L,18L,21L,23L,26L,28L,32L,35L,39L,43L,48L,53L,59L,65L,72L,80L,88L,97L,107L,118L,129L,142L,155L,171L,186L,204L,222L,244L,265L,290L,315L,345L,374L,409L,443L,484L,524L,571L,618L,673L,727L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096401Inst : IEnumerable<long>
{
public static readonly long[] Value=A096401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096401.Bytes);
public long this[int i]=>Value[i];

public static A096401Inst Instance=new A096401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096402
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,14L,47L,182L,786L,3774L,19974L,115236L,720038L,4846512L,34950929L,268836776L,2197143724L,19013216102L,173672030192L,1669863067916L,16858620684522L,178306120148144L,1971584973897417L,22748265125187632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096402Inst : IEnumerable<long>
{
public static readonly long[] Value=A096402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096402.Bytes);
public long this[int i]=>Value[i];

public static A096402Inst Instance=new A096402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096403
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,2L,5L,5L,9L,10L,14L,17L,26L,30L,41L,52L,67L,81L,108L,129L,168L,204L,257L,311L,393L,470L,584L,705L,865L,1036L,1270L,1514L,1838L,2192L,2639L,3137L,3767L,4455L,5321L,6287L,7469L,8794L,10419L,12230L,14427L,16904L,19863L,23210L,27207L,31701L,37039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096403Inst : IEnumerable<long>
{
public static readonly long[] Value=A096403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096403.Bytes);
public long this[int i]=>Value[i];

public static A096403Inst Instance=new A096403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096436
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,4L,2L,1L,2L,3L,3L,2L,3L,4L,4L,3L,2L,3L,4L,4L,3L,4L,5L,1L,2L,3L,4L,2L,3L,4L,5L,3L,2L,3L,4L,4L,3L,4L,5L,5L,4L,3L,4L,5L,5L,4L,5L,1L,2L,3L,4L,2L,3L,4L,5L,3L,2L,3L,4L,4L,3L,4L,5L,5L,4L,3L,4L,5L,5L,4L,5L,6L,2L,3L,4L,5L,3L,4L,5L,6L,4L,3L,4L,5L,5L,4L,5L,6L,6L,5L,4L,5L,6L,6L,5L,6L,2L,3L,4L,5L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096436Inst : IEnumerable<long>
{
public static readonly long[] Value=A096436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096436.Bytes);
public long this[int i]=>Value[i];

public static A096436Inst Instance=new A096436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096437
{
public static readonly long[] Value={ 1L,5L,7L,4L,9L,7L,5L,6L,5L,1L,2L,9L,0L,7L,4L,5L,6L,3L,4L,6L,8L,2L,6L,8L,1L,9L,9L,7L,6L,0L,6L,9L,9L,2L,7L,6L,5L,2L,6L,0L,8L,7L,2L,5L,7L,5L,2L,5L,9L,2L,2L,7L,9L,5L,4L,2L,7L,3L,3L,6L,3L,5L,6L,1L,1L,9L,5L,1L,3L,1L,4L,5L,6L,9L,5L,8L,0L,2L,0L,1L,7L,7L,5L,3L,7L,0L,3L,6L,6L,2L,2L,6L,4L,8L,2L,9L,6L,7L,1L,7L,9L,3L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096437Inst : IEnumerable<long>
{
public static readonly long[] Value=A096437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096437.Bytes);
public long this[int i]=>Value[i];

public static A096437Inst Instance=new A096437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096438
{
public static readonly long[] Value={ 1L,3L,5L,3L,6L,7L,9L,6L,3L,7L,2L,0L,7L,3L,1L,6L,9L,5L,1L,2L,1L,0L,6L,5L,6L,9L,3L,6L,6L,8L,9L,1L,3L,0L,2L,7L,7L,6L,9L,0L,1L,3L,9L,1L,3L,2L,3L,1L,0L,4L,1L,6L,3L,6L,7L,0L,6L,0L,9L,0L,4L,0L,2L,8L,3L,4L,1L,6L,1L,0L,4L,7L,5L,0L,7L,9L,2L,6L,6L,4L,3L,8L,4L,9L,1L,4L,4L,7L,0L,4L,5L,4L,5L,1L,5L,3L,5L,7L,5L,1L,2L,0L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096438Inst : IEnumerable<long>
{
public static readonly long[] Value=A096438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096438.Bytes);
public long this[int i]=>Value[i];

public static A096438Inst Instance=new A096438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096439
{
public static readonly long[] Value={ 3L,3L,0L,4L,6L,5L,4L,2L,5L,6L,8L,1L,9L,0L,3L,2L,5L,6L,4L,1L,5L,5L,3L,2L,4L,3L,1L,2L,9L,0L,0L,3L,4L,9L,5L,7L,7L,2L,5L,4L,0L,2L,5L,4L,3L,6L,4L,8L,7L,8L,4L,5L,2L,1L,7L,7L,9L,7L,3L,1L,8L,6L,0L,7L,8L,1L,4L,5L,5L,7L,6L,5L,5L,3L,0L,6L,3L,1L,7L,6L,5L,5L,3L,2L,2L,4L,9L,9L,0L,5L,8L,9L,1L,2L,8L,5L,2L,1L,1L,6L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096439Inst : IEnumerable<long>
{
public static readonly long[] Value=A096439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096439.Bytes);
public long this[int i]=>Value[i];

public static A096439Inst Instance=new A096439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096440
{
public static readonly long[] Value={ 2L,2L,1L,8L,6L,2L,5L,5L,9L,7L,1L,5L,6L,6L,4L,4L,8L,4L,0L,9L,8L,7L,0L,5L,7L,4L,3L,7L,8L,9L,8L,4L,9L,4L,7L,6L,4L,2L,8L,5L,9L,5L,7L,8L,4L,4L,5L,6L,0L,7L,9L,1L,9L,4L,3L,2L,8L,7L,0L,2L,0L,7L,4L,2L,3L,1L,2L,9L,9L,2L,8L,4L,4L,2L,4L,6L,6L,7L,5L,4L,3L,5L,2L,7L,2L,7L,7L,0L,4L,8L,9L,6L,3L,2L,8L,5L,3L,8L,6L,8L,0L,6L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096440Inst : IEnumerable<long>
{
public static readonly long[] Value=A096440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096440.Bytes);
public long this[int i]=>Value[i];

public static A096440Inst Instance=new A096440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096441
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,7L,5L,11L,8L,17L,12L,26L,18L,37L,27L,54L,38L,76L,54L,106L,76L,145L,104L,199L,142L,266L,192L,357L,256L,472L,340L,621L,448L,809L,585L,1053L,760L,1354L,982L,1740L,1260L,2218L,1610L,2818L,2048L,3559L,2590L,4485L,3264L,5616L,4097L,7018L,5120L,8728L,6378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096441Inst : IEnumerable<long>
{
public static readonly long[] Value=A096441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096441.Bytes);
public long this[int i]=>Value[i];

public static A096441Inst Instance=new A096441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096442
{
public static readonly long[] Value={ 4L,12L,12L,20L,12L,420L,4L,60L,84L,220L,12L,1092L,4L,60L,924L,340L,12L,103740L,4L,660L,84L,92L,12L,13260L,44L,60L,1596L,580L,12L,1861860L,4L,204L,1932L,20L,132L,3838380L,4L,60L,84L,153340L,12L,1361724L,4L,1380L,77748L,940L,12L,92820L,4L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096442Inst : IEnumerable<long>
{
public static readonly long[] Value=A096442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096442.Bytes);
public long this[int i]=>Value[i];

public static A096442Inst Instance=new A096442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096443
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,5L,7L,9L,11L,15L,7L,12L,16L,21L,26L,36L,52L,11L,19L,29L,38L,31L,52L,74L,66L,92L,135L,203L,15L,30L,47L,64L,57L,98L,141L,109L,137L,198L,296L,249L,371L,566L,877L,22L,45L,77L,105L,97L,171L,250L,109L,212L,269L,392L,592L,300L,444L,560L,850L,1315L,712L,1075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096443Inst : IEnumerable<long>
{
public static readonly long[] Value=A096443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096443.Bytes);
public long this[int i]=>Value[i];

public static A096443Inst Instance=new A096443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096444
{
public static readonly long[] Value={ 1L,0L,7L,0L,7L,9L,6L,3L,2L,6L,7L,9L,4L,8L,9L,6L,6L,1L,9L,2L,3L,1L,3L,2L,1L,6L,9L,1L,6L,3L,9L,7L,5L,1L,4L,4L,2L,0L,9L,8L,5L,8L,4L,6L,9L,9L,6L,8L,7L,5L,5L,2L,9L,1L,0L,4L,8L,7L,4L,7L,2L,2L,9L,6L,1L,5L,3L,9L,0L,8L,2L,0L,3L,1L,4L,3L,1L,0L,4L,4L,9L,9L,3L,1L,4L,0L,1L,7L,4L,1L,2L,6L,7L,1L,0L,5L,8L,5L,3L,3L,9L,9L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096444Inst : IEnumerable<long>
{
public static readonly long[] Value=A096444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096444.Bytes);
public long this[int i]=>Value[i];

public static A096444Inst Instance=new A096444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096445
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096445Inst : IEnumerable<long>
{
public static readonly long[] Value=A096445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096445.Bytes);
public long this[int i]=>Value[i];

public static A096445Inst Instance=new A096445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096446
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,3L,2L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096446Inst : IEnumerable<long>
{
public static readonly long[] Value=A096446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096446.Bytes);
public long this[int i]=>Value[i];

public static A096446Inst Instance=new A096446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096447
{
public static readonly long[] Value={ 3L,7L,19L,43L,463L,26839L,26861L,26879L,26891L,26903L,26927L,616783L,616799L,616841L,616849L,616877L,617039L,617269L,617369L,617401L,617429L,617453L,617471L,617479L,617521L,617537L,617587L,617689L,617717L,617723L,618439L,618547L,618619L,618643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096447Inst : IEnumerable<long>
{
public static readonly long[] Value=A096447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096447.Bytes);
public long this[int i]=>Value[i];

public static A096447Inst Instance=new A096447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096448
{
public static readonly long[] Value={ 5L,11L,17L,23L,31L,41L,47L,59L,67L,103L,127L,419L,431L,439L,461L,467L,1259L,1279L,1303L,26833L,26849L,26881L,26893L,26921L,26947L,615883L,616769L,616787L,616793L,616829L,617051L,617059L,617087L,617257L,617473L,617509L,617647L,617681L,617731L,617819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096448Inst : IEnumerable<long>
{
public static readonly long[] Value=A096448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096448.Bytes);
public long this[int i]=>Value[i];

public static A096448Inst Instance=new A096448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096449
{
public static readonly long[] Value={ 5L,11L,17L,23L,41L,47L,83L,167L,227L,233L,608981812919L,608981812961L,608981813017L,608981813569L,608981813677L,608981813833L,608981813851L,608981813927L,608981813939L,608981813963L,608981814043L,608981814149L,608981814251L,608981814827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096449Inst : IEnumerable<long>
{
public static readonly long[] Value=A096449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096449.Bytes);
public long this[int i]=>Value[i];

public static A096449Inst Instance=new A096449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096450
{
public static readonly long[] Value={ 7L,29L,37L,61L,89L,101L,107L,113L,131L,151L,181L,239L,251L,271L,397L,421L,443L,463L,479L,491L,503L,557L,569L,577L,601L,743L,757L,787L,857L,863L,881L,887L,1291L,1511L,1531L,1549L,1609L,1657L,1667L,1693L,1699L,1861L,1987L,1997L,2003L,2017L,2053L,2377L,2393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096450Inst : IEnumerable<long>
{
public static readonly long[] Value=A096450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096450.Bytes);
public long this[int i]=>Value[i];

public static A096450Inst Instance=new A096450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096451
{
public static readonly long[] Value={ 13L,29L,37L,53L,61L,71L,79L,101L,107L,113L,131L,139L,151L,163L,199L,359L,409L,421L,433L,443L,457L,479L,1223L,1231L,1249L,1277L,1283L,1291L,1301L,1307L,1399L,1423L,1439L,8699L,8779L,26821L,26951L,26959L,26987L,27011L,27031L,615731L,615869L,615887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096451Inst : IEnumerable<long>
{
public static readonly long[] Value=A096451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096451.Bytes);
public long this[int i]=>Value[i];

public static A096451Inst Instance=new A096451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096468
{
public static readonly long[] Value={ 12L,16L,18L,30L,32L,36L,40L,42L,44L,48L,50L,54L,56L,60L,64L,66L,68L,70L,72L,76L,78L,80L,84L,90L,96L,98L,100L,104L,108L,110L,112L,114L,120L,126L,128L,130L,132L,136L,140L,144L,150L,152L,154L,156L,160L,162L,164L,168L,170L,172L,174L,176L,180L,182L,186L,190L,192L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096468Inst : IEnumerable<long>
{
public static readonly long[] Value=A096468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096468.Bytes);
public long this[int i]=>Value[i];

public static A096468Inst Instance=new A096468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096469
{
public static readonly long[] Value={ 1L,3L,33L,23L,237L,93L,37L,291L,421L,7L,471L,213L,1941L,29L,43L,17L,327L,1L,523L,21L,3403L,1L,13281L,3851L,3583L,3081L,1681L,157L,34989L,5411L,2431L,1229L,4767L,1021L,8397L,603L,429L,561L,6571L,47L,8601L,347L,15027L,687L,1611L,273L,29979L,201L,5719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096469Inst : IEnumerable<long>
{
public static readonly long[] Value=A096469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096469.Bytes);
public long this[int i]=>Value[i];

public static A096469Inst Instance=new A096469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096470
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-1L,2L,1L,1L,-2L,4L,-3L,1L,1L,-3L,7L,-10L,11L,1L,1L,-4L,11L,-21L,32L,-31L,1L,1L,-5L,16L,-37L,69L,-100L,101L,1L,1L,-6L,22L,-59L,128L,-228L,329L,-328L,1L,1L,-7L,29L,-88L,216L,-444L,773L,-1101L,1102L,1L,1L,-8L,37L,-125L,341L,-785L,1558L,-2659L,3761L,-3760L,1L,1L,-9L,46L,-171L,512L,-1297L,2855L,-5514L,9275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096470Inst : IEnumerable<long>
{
public static readonly long[] Value=A096470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096470.Bytes);
public long this[int i]=>Value[i];

public static A096470Inst Instance=new A096470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096471
{
public static readonly long[] Value={ 1L,3L,12L,60L,345L,2415L,18480L,166320L,1596105L,17557155L,202951980L,2638375740L,35703612945L,535554194175L,8307234936000L,141222993912000L,2470641012464625L,46942179236827875L,914462992955011500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096471Inst : IEnumerable<long>
{
public static readonly long[] Value=A096471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096471.Bytes);
public long this[int i]=>Value[i];

public static A096471Inst Instance=new A096471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096472
{
public static readonly long[] Value={ 3600L,7200L,10800L,14400L,18000L,21600L,25200L,28800L,32400L,36000L,39600L,43200L,46800L,50400L,54000L,57600L,61200L,64800L,68400L,72000L,75600L,79200L,82800L,86400L,90000L,93600L,97200L,100800L,104400L,108000L,111600L,115200L,118800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096472Inst : IEnumerable<long>
{
public static readonly long[] Value=A096472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096472.Bytes);
public long this[int i]=>Value[i];

public static A096472Inst Instance=new A096472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096473
{
public static readonly long[] Value={ 5L,11L,101L,191L,727L,929L,30803L,74047L,77477L,1123211L,1150511L,1338331L,1444441L,1684861L,1761671L,3065603L,3392933L,3503053L,3541453L,9779779L,9845489L,9926299L,9927299L,9932399L,112959211L,113030311L,114535411L,119676911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096473Inst : IEnumerable<long>
{
public static readonly long[] Value=A096473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096473.Bytes);
public long this[int i]=>Value[i];

public static A096473Inst Instance=new A096473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096474
{
public static readonly long[] Value={ 6L,6L,10L,8L,18L,12L,6L,14L,16L,12L,24L,18L,24L,18L,16L,14L,24L,18L,24L,18L,10L,12L,18L,40L,28L,20L,24L,18L,28L,10L,12L,12L,8L,8L,22L,16L,12L,12L,14L,14L,26L,36L,24L,30L,24L,8L,18L,30L,12L,22L,22L,16L,18L,24L,10L,14L,18L,14L,10L,20L,10L,32L,32L,12L,10L,44L,30L,18L,16L,36L,14L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096474Inst : IEnumerable<long>
{
public static readonly long[] Value=A096474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096474.Bytes);
public long this[int i]=>Value[i];

public static A096474Inst Instance=new A096474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096475
{
public static readonly long[] Value={ 3L,17L,11L,41L,71L,101L,29L,569L,881L,137L,1151L,521L,1289L,2027L,10331L,1229L,3461L,461L,2549L,2129L,6569L,6131L,14387L,34157L,5657L,4259L,44621L,17387L,25301L,11159L,56099L,34367L,64877L,23201L,80147L,73361L,21017L,46349L,162287L,94439L,469877L,122501L,35507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096475Inst : IEnumerable<long>
{
public static readonly long[] Value=A096475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096475.Bytes);
public long this[int i]=>Value[i];

public static A096475Inst Instance=new A096475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096476
{
public static readonly long[] Value={ 5L,59L,31L,179L,353L,547L,109L,4133L,6841L,773L,9293L,3733L,10559L,17627L,108643L,9973L,32261L,3259L,22811L,18617L,65731L,60821L,156371L,404029L,55733L,40637L,540619L,192677L,290897L,118297L,693877L,406883L,812527L,264659L,1022303L,928471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096476Inst : IEnumerable<long>
{
public static readonly long[] Value=A096476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096476.Bytes);
public long this[int i]=>Value[i];

public static A096476Inst Instance=new A096476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096477
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,13L,14L,23L,24L,29L,30L,40L,59L,63L,65L,71L,74L,90L,103L,106L,110L,112L,117L,122L,128L,132L,187L,188L,193L,207L,248L,257L,258L,267L,271L,281L,285L,292L,296L,299L,300L,303L,304L,311L,317L,325L,340L,343L,344L,354L,356L,360L,368L,382L,389L,395L,402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096477Inst : IEnumerable<long>
{
public static readonly long[] Value=A096477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096477.Bytes);
public long this[int i]=>Value[i];

public static A096477Inst Instance=new A096477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096478
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,41L,43L,83L,89L,109L,113L,173L,277L,307L,313L,353L,373L,463L,563L,577L,601L,613L,643L,673L,719L,743L,1117L,1123L,1171L,1279L,1571L,1621L,1627L,1709L,1741L,1823L,1867L,1907L,1949L,1979L,1987L,1999L,2003L,2063L,2099L,2153L,2287L,2309L,2311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096478Inst : IEnumerable<long>
{
public static readonly long[] Value=A096478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096478.Bytes);
public long this[int i]=>Value[i];

public static A096478Inst Instance=new A096478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096479
{
public static readonly long[] Value={ 3L,5L,11L,17L,41L,59L,179L,191L,431L,461L,599L,617L,1031L,1787L,2027L,2081L,2381L,2549L,3299L,4091L,4217L,4421L,4517L,4787L,5021L,5441L,5651L,8999L,9041L,9461L,10457L,13217L,13709L,13757L,14591L,14867L,15641L,16061L,16451L,16901L,17189L,17291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096479Inst : IEnumerable<long>
{
public static readonly long[] Value=A096479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096479.Bytes);
public long this[int i]=>Value[i];

public static A096479Inst Instance=new A096479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096480
{
public static readonly long[] Value={ 1L,8L,5L,22L,16L,15L,33L,67L,62L,164L,88L,56L,73L,202L,134L,504L,201L,261L,799L,1461L,289L,282L,1309L,1053L,1143L,939L,527L,3531L,2179L,4751L,2461L,5308L,2837L,3983L,1946L,8622L,9488L,12862L,6377L,4653L,7594L,7646L,19251L,22538L,9561L,32509L,26146L,17568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096480Inst : IEnumerable<long>
{
public static readonly long[] Value=A096480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096480.Bytes);
public long this[int i]=>Value[i];

public static A096480Inst Instance=new A096480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096481
{
public static readonly long[] Value={ 2L,19L,11L,79L,53L,47L,137L,331L,293L,971L,457L,263L,367L,1231L,757L,3607L,1229L,1663L,6131L,12227L,1879L,1831L,10733L,8423L,9221L,7393L,3793L,32941L,19213L,45863L,21961L,51871L,25763L,37591L,16879L,89017L,98867L,138241L,63611L,44773L,77279L,77783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096481Inst : IEnumerable<long>
{
public static readonly long[] Value=A096481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096481.Bytes);
public long this[int i]=>Value[i];

public static A096481Inst Instance=new A096481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096482
{
public static readonly long[] Value={ 3L,67L,31L,401L,241L,211L,773L,2221L,1913L,7649L,3229L,1669L,2477L,10009L,5749L,33647L,9973L,14107L,60821L,130729L,16141L,15683L,113233L,86629L,95651L,74959L,35617L,388403L,214993L,557093L,248909L,637003L,296843L,448451L,186481L,1145899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096482Inst : IEnumerable<long>
{
public static readonly long[] Value=A096482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096482.Bytes);
public long this[int i]=>Value[i];

public static A096482Inst Instance=new A096482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096483
{
public static readonly long[] Value={ 1L,3L,10L,33L,105L,333L,1054L,3333L,10540L,33333L,105409L,333333L,1054092L,3333333L,10540925L,33333333L,105409255L,333333333L,1054092553L,3333333333L,10540925533L,33333333333L,105409255338L,333333333333L,1054092553389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096483Inst : IEnumerable<long>
{
public static readonly long[] Value=A096483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096483.Bytes);
public long this[int i]=>Value[i];

public static A096483Inst Instance=new A096483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096484
{
public static readonly long[] Value={ 1L,10L,105L,1054L,10540L,105409L,1054092L,10540925L,105409255L,1054092553L,10540925533L,105409255338L,1054092553389L,10540925533894L,105409255338945L,1054092553389459L,10540925533894597L,105409255338945977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096484Inst : IEnumerable<long>
{
public static readonly long[] Value=A096484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096484.Bytes);
public long this[int i]=>Value[i];

public static A096484Inst Instance=new A096484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096485
{
public static readonly long[] Value={ 2L,6L,2L,24L,2L,622L,2L,2396L,2L,21912L,2L,527718L,2L,168484L,2L,13171730L,2L,359947864L,2L,52090778L,2L,16658818532L,2L,134257065348L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096485Inst : IEnumerable<long>
{
public static readonly long[] Value=A096485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096485.Bytes);
public long this[int i]=>Value[i];

public static A096485Inst Instance=new A096485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096486
{
public static readonly long[] Value={ 8L,170L,2242L,2132L,1294L,976846L,216566L,9904144L,25617930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096486Inst : IEnumerable<long>
{
public static readonly long[] Value=A096486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096486.Bytes);
public long this[int i]=>Value[i];

public static A096486Inst Instance=new A096486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096487
{
public static readonly long[] Value={ 6L,20L,66L,210L,666L,2108L,6666L,21080L,66666L,210818L,666666L,2108184L,6666666L,21081850L,66666666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096487Inst : IEnumerable<long>
{
public static readonly long[] Value=A096487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096487.Bytes);
public long this[int i]=>Value[i];

public static A096487Inst Instance=new A096487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096488
{
public static readonly long[] Value={ 2L,3L,2L,8L,2L,37L,2L,76L,2L,217L,2L,870L,2L,583L,2L,5034L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096488Inst : IEnumerable<long>
{
public static readonly long[] Value=A096488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096488.Bytes);
public long this[int i]=>Value[i];

public static A096488Inst Instance=new A096488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096489
{
public static readonly long[] Value={ 1L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096489Inst : IEnumerable<long>
{
public static readonly long[] Value=A096489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096489.Bytes);
public long this[int i]=>Value[i];

public static A096489Inst Instance=new A096489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096490
{
public static readonly long[] Value={ 60L,120L,168L,180L,240L,252L,300L,336L,360L,420L,480L,504L,540L,600L,660L,672L,720L,756L,780L,792L,840L,900L,924L,936L,960L,1008L,1020L,1080L,1140L,1176L,1200L,1260L,1320L,1344L,1380L,1440L,1500L,1512L,1560L,1584L,1620L,1680L,1740L,1764L,1800L,1848L,1860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096490Inst : IEnumerable<long>
{
public static readonly long[] Value=A096490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096490.Bytes);
public long this[int i]=>Value[i];

public static A096490Inst Instance=new A096490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096491
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,4L,4L,4L,3L,6L,6L,6L,6L,6L,6L,4L,8L,8L,8L,8L,8L,8L,8L,8L,5L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,6L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,7L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,8L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096491Inst : IEnumerable<long>
{
public static readonly long[] Value=A096491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096491.Bytes);
public long this[int i]=>Value[i];

public static A096491Inst Instance=new A096491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096492
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,3L,2L,1L,1L,2L,4L,2L,3L,4L,3L,2L,1L,1L,2L,3L,3L,2L,4L,2L,3L,3L,2L,1L,1L,2L,2L,2L,2L,2L,4L,3L,3L,5L,3L,2L,1L,1L,2L,4L,3L,4L,2L,2L,3L,2L,4L,3L,5L,3L,2L,1L,1L,2L,5L,2L,4L,3L,4L,2L,3L,2L,2L,5L,4L,3L,3L,2L,1L,1L,2L,2L,3L,4L,2L,3L,3L,2L,3L,4L,4L,6L,3L,3L,3L,3L,2L,1L,1L,2L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096492Inst : IEnumerable<long>
{
public static readonly long[] Value=A096492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096492.Bytes);
public long this[int i]=>Value[i];

public static A096492Inst Instance=new A096492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096493
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,2L,1L,1L,1L,1L,0L,0L,0L,1L,2L,1L,1L,2L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,1L,1L,2L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,2L,1L,2L,0L,0L,0L,0L,0L,3L,0L,1L,1L,2L,1L,1L,0L,0L,2L,2L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,1L,1L,1L,0L,3L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096493Inst : IEnumerable<long>
{
public static readonly long[] Value=A096493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096493.Bytes);
public long this[int i]=>Value[i];

public static A096493Inst Instance=new A096493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096494
{
public static readonly long[] Value={ 2L,2L,4L,4L,6L,6L,8L,8L,8L,10L,10L,12L,12L,12L,12L,14L,14L,14L,16L,16L,16L,16L,18L,18L,18L,20L,20L,20L,20L,20L,22L,22L,22L,22L,24L,24L,24L,24L,24L,26L,26L,26L,26L,26L,28L,28L,28L,28L,30L,30L,30L,30L,30L,30L,32L,32L,32L,32L,32L,32L,32L,34L,34L,34L,34L,34L,36L,36L,36L,36L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096494Inst : IEnumerable<long>
{
public static readonly long[] Value=A096494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096494.Bytes);
public long this[int i]=>Value[i];

public static A096494Inst Instance=new A096494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096495
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,1L,4L,3L,3L,4L,1L,2L,4L,3L,3L,4L,5L,5L,4L,3L,3L,2L,3L,3L,1L,5L,4L,6L,3L,6L,4L,3L,6L,5L,7L,5L,6L,3L,3L,6L,6L,6L,5L,1L,7L,8L,3L,2L,3L,3L,6L,5L,5L,1L,4L,2L,7L,7L,5L,6L,3L,6L,6L,6L,5L,8L,6L,5L,4L,4L,3L,7L,3L,9L,4L,3L,7L,1L,6L,6L,8L,7L,6L,3L,2L,5L,7L,5L,9L,4L,6L,9L,8L,4L,4L,6L,6L,8L,9L,8L,2L,4L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096495Inst : IEnumerable<long>
{
public static readonly long[] Value=A096495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096495.Bytes);
public long this[int i]=>Value[i];

public static A096495Inst Instance=new A096495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096496
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,2L,1L,1L,2L,0L,1L,2L,1L,1L,2L,2L,3L,2L,1L,1L,0L,2L,1L,0L,1L,1L,2L,1L,4L,2L,1L,4L,2L,4L,3L,4L,1L,0L,4L,1L,3L,2L,0L,3L,4L,1L,0L,1L,1L,2L,2L,2L,0L,0L,1L,1L,3L,1L,1L,0L,4L,3L,3L,1L,5L,3L,2L,2L,2L,1L,3L,2L,4L,2L,1L,2L,0L,3L,4L,5L,5L,3L,1L,0L,3L,4L,1L,4L,1L,3L,3L,2L,1L,1L,2L,2L,2L,4L,4L,0L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096496Inst : IEnumerable<long>
{
public static readonly long[] Value=A096496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096496.Bytes);
public long this[int i]=>Value[i];

public static A096496Inst Instance=new A096496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096497
{
public static readonly BigInteger[] Value={ 2L,13L,113L,1117L,11113L,111119L,1111151L,11111117L,111111113L,1111111121L,11111111113L,111111111149L,1111111111139L,11111111111123L,111111111111229L,1111111111111123L,11111111111111119L,111111111111111131L,1111111111111111171L,11111111111111111131UL,BigInteger.Parse("111111111111111111157"),BigInteger.Parse("1111111111111111111189") };
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
public class A096497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096497Inst Instance=new A096497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096498
{
public static readonly BigInteger[] Value={ 7L,109L,1109L,11093L,111109L,1111091L,11111101L,111111109L,1111111097L,11111111059L,111111111103L,1111111111093L,11111111111053L,111111111111053L,1111111111111039L,11111111111111107L,111111111111111091L,1111111111111111037L,11111111111111111027UL,BigInteger.Parse("111111111111111111053"),BigInteger.Parse("1111111111111111111097") };
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
public class A096498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096498Inst Instance=new A096498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096499
{
public static readonly long[] Value={ 6L,4L,8L,20L,10L,60L,16L,4L,24L,54L,46L,46L,70L,176L,84L,12L,40L,134L,104L,104L,92L,24L,84L,270L,300L,130L,414L,90L,88L,240L,148L,198L,12L,64L,12L,300L,66L,70L,80L,102L,420L,142L,630L,140L,600L,88L,176L,312L,80L,96L,460L,132L,420L,284L,144L,408L,312L,180L,44L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096499Inst : IEnumerable<long>
{
public static readonly long[] Value=A096499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096499.Bytes);
public long this[int i]=>Value[i];

public static A096499Inst Instance=new A096499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096740
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,10L,11L,13L,14L,16L,18L,20L,22L,25L,27L,30L,33L,36L,40L,44L,48L,53L,59L,64L,71L,78L,86L,94L,104L,113L,125L,136L,149L,163L,179L,194L,213L,232L,254L,276L,302L,328L,359L,390L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096740Inst : IEnumerable<long>
{
public static readonly long[] Value=A096740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096740.Bytes);
public long this[int i]=>Value[i];

public static A096740Inst Instance=new A096740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096741
{
public static readonly long[] Value={ 1L,5L,7L,17L,42L,71L,78L,97L,215L,307L,383L,433L,545L,804L,1351L,1727L,1777L,1849L,2039L,2316L,2387L,2395L,2899L,2981L,3331L,4446L,5441L,7057L,7189L,7321L,8023L,8135L,9847L,9959L,11052L,13175L,13679L,17514L,18143L,18817L,18929L,19110L,20593L,22247L,23417L,23783L,24407L,24648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096741Inst : IEnumerable<long>
{
public static readonly long[] Value=A096741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096741.Bytes);
public long this[int i]=>Value[i];

public static A096741Inst Instance=new A096741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096742
{
public static readonly long[] Value={ 1L,1L,3L,15L,41L,387L,1017L,4715L,11917L,220323L,517545L,2403313L,6436023L,58028007L,53008869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096742Inst : IEnumerable<long>
{
public static readonly long[] Value=A096742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096742.Bytes);
public long this[int i]=>Value[i];

public static A096742Inst Instance=new A096742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096743
{
public static readonly long[] Value={ 1L,1L,5L,35L,135L,1755L,6303L,39815L,132675L,3322515L,10561455L,64566253L,199681945L,2391238415L,7233344915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096743Inst : IEnumerable<long>
{
public static readonly long[] Value=A096743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096743.Bytes);
public long this[int i]=>Value[i];

public static A096743Inst Instance=new A096743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096744
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,6L,3L,1L,1L,1L,16L,12L,3L,1L,1L,1L,40L,37L,12L,3L,1L,1L,1L,133L,138L,55L,12L,3L,1L,1L,1L,429L,498L,219L,55L,12L,3L,1L,1L,1L,1696L,2103L,969L,273L,55L,12L,3L,1L,1L,1L,6583L,8734L,4215L,1266L,273L,55L,12L,3L,1L,1L,1L,29167L,40291L,19989L,6213L,1428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096744Inst : IEnumerable<long>
{
public static readonly long[] Value=A096744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096744.Bytes);
public long this[int i]=>Value[i];

public static A096744Inst Instance=new A096744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096745
{
public static readonly long[] Value={ 1L,1L,3L,6L,16L,40L,133L,429L,1696L,6583L,29167L,128401L,615653L,2958117L,15028861L,76857851L,407990489L,2184026420L,11995664112L,66461796492L,375029195862L,2133759026832L,12304892986311L,71492951054537L,419663091288141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096745Inst : IEnumerable<long>
{
public static readonly long[] Value=A096745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096745.Bytes);
public long this[int i]=>Value[i];

public static A096745Inst Instance=new A096745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096746
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,34L,95L,344L,1219L,5114L,21144L,97434L,447809L,2208466L,10936470L,56737343L,296549762L,1599644305L,8703053327L,48405621146L,271532403698L,1547645029663L,8891197779388L,51692123365192L,302672852318074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096746Inst : IEnumerable<long>
{
public static readonly long[] Value=A096746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096746.Bytes);
public long this[int i]=>Value[i];

public static A096746Inst Instance=new A096746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096747
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,4L,6L,6L,1L,7L,18L,24L,24L,1L,11L,46L,96L,120L,120L,1L,16L,101L,326L,600L,720L,720L,1L,22L,197L,932L,2556L,4320L,5040L,5040L,1L,29L,351L,2311L,9080L,22212L,35280L,40320L,40320L,1L,37L,583L,5119L,27568L,94852L,212976L,322560L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096747Inst : IEnumerable<long>
{
public static readonly long[] Value=A096747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096747.Bytes);
public long this[int i]=>Value[i];

public static A096747Inst Instance=new A096747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096748
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,5L,6L,8L,10L,13L,16L,21L,26L,34L,42L,55L,68L,89L,110L,144L,178L,233L,288L,377L,466L,610L,754L,987L,1220L,1597L,1974L,2584L,3194L,4181L,5168L,6765L,8362L,10946L,13530L,17711L,21892L,28657L,35422L,46368L,57314L,75025L,92736L,121393L,150050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096748Inst : IEnumerable<long>
{
public static readonly long[] Value=A096748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096748.Bytes);
public long this[int i]=>Value[i];

public static A096748Inst Instance=new A096748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096749
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,1L,1L,2L,2L,3L,3L,4L,5L,6L,7L,9L,10L,12L,15L,17L,20L,24L,28L,32L,38L,44L,51L,59L,68L,78L,91L,103L,118L,136L,155L,176L,201L,228L,259L,294L,332L,375L,425L,478L,538L,607L,681L,764L,858L,961L,1075L,1203L,1343L,1499L,1673L,1863L,2073L,2308L,2564L,2847L,3161L,3504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096749Inst : IEnumerable<long>
{
public static readonly long[] Value=A096749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096749.Bytes);
public long this[int i]=>Value[i];

public static A096749Inst Instance=new A096749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096750
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,6L,7L,8L,12L,21L,33L,44L,55L,76L,119L,185L,263L,351L,480L,706L,1066L,1551L,2156L,2982L,4269L,6281L,9162L,13013L,18252L,25921L,37513L,54449L,78045L,110626L,157124L,225490L,325403L,467576L,666960L,949661L,1358381L,1951976L,2803811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096750Inst : IEnumerable<long>
{
public static readonly long[] Value=A096750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096750.Bytes);
public long this[int i]=>Value[i];

public static A096750Inst Instance=new A096750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096751
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,1L,1L,4L,6L,5L,1L,1L,1L,5L,10L,13L,7L,1L,1L,1L,6L,15L,26L,24L,11L,1L,1L,1L,7L,21L,45L,59L,48L,15L,1L,1L,1L,8L,28L,71L,120L,140L,86L,22L,1L,1L,1L,9L,36L,105L,216L,326L,307L,160L,30L,1L,1L,1L,10L,45L,148L,357L,657L,835L,684L,282L,42L,1L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096751Inst : IEnumerable<long>
{
public static readonly long[] Value=A096751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096751.Bytes);
public long this[int i]=>Value[i];

public static A096751Inst Instance=new A096751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096752
{
public static readonly long[] Value={ 1L,1L,3L,10L,45L,216L,1197L,7134L,46209L,319555L,2350183L,18254380L,149117618L,1275857233L,11396595255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096752Inst : IEnumerable<long>
{
public static readonly long[] Value=A096752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096752.Bytes);
public long this[int i]=>Value[i];

public static A096752Inst Instance=new A096752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096753
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,18L,38L,85L,198L,478L,1192L,3063L,8093L,21956L,61087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096753Inst : IEnumerable<long>
{
public static readonly long[] Value=A096753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096753.Bytes);
public long this[int i]=>Value[i];

public static A096753Inst Instance=new A096753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096754
{
public static readonly long[] Value={ 1L,1L,0L,-1L,1L,0L,-3L,1L,0L,-6L,0L,1L,1L,0L,-10L,0L,5L,1L,0L,-15L,0L,15L,0L,-1L,1L,0L,-21L,0L,35L,0L,-7L,1L,0L,-28L,0L,70L,0L,-28L,0L,1L,1L,0L,-36L,0L,126L,0L,-84L,0L,9L,1L,0L,-45L,0L,210L,0L,-210L,0L,45L,0L,-1L,1L,0L,-55L,0L,330L,0L,-462L,0L,165L,0L,-11L,1L,0L,-66L,0L,495L,0L,-924L,0L,495L,0L,-66L,0L,1L,1L,0L,-78L,0L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096754Inst : IEnumerable<long>
{
public static readonly long[] Value=A096754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096754.Bytes);
public long this[int i]=>Value[i];

public static A096754Inst Instance=new A096754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096755
{
public static readonly long[] Value={ 1L,94L,153L,12700L,32788L,255945L,4657555L,159090113L,812432526L,3961184001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096755Inst : IEnumerable<long>
{
public static readonly long[] Value=A096755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096755.Bytes);
public long this[int i]=>Value[i];

public static A096755Inst Instance=new A096755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096772
{
public static readonly long[] Value={ 1L,2L,5L,14L,33L,72L,125L,219L,376L,573L,745L,1209L,1557L,2442L,3098L,4048L,5298L,6704L,7839L,10987L,12332L,15465L,19144L,24546L,28974L,34406L,37769L,45864L,50877L,61372L,68303L,77918L,88545L,101917L,122032L,131625L,148575L,171237L,197815L,201454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096772Inst : IEnumerable<long>
{
public static readonly long[] Value=A096772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096772.Bytes);
public long this[int i]=>Value[i];

public static A096772Inst Instance=new A096772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096773
{
public static readonly long[] Value={ 0L,3L,1L,13L,5L,53L,21L,213L,85L,853L,341L,3413L,1365L,13653L,5461L,54613L,21845L,218453L,87381L,873813L,349525L,3495253L,1398101L,13981013L,5592405L,55924053L,22369621L,223696213L,89478485L,894784853L,357913941L,3579139413L,1431655765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096773Inst : IEnumerable<long>
{
public static readonly long[] Value=A096773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096773.Bytes);
public long this[int i]=>Value[i];

public static A096773Inst Instance=new A096773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096774
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,15L,19L,20L,46L,52L,53L,192L,380L,588L,776L,906L,1350L,1736L,2914L,7508L,15710L,16453L,17488L,18109L,21604L,25891L,26725L,34838L,67468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096774Inst : IEnumerable<long>
{
public static readonly long[] Value=A096774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096774.Bytes);
public long this[int i]=>Value[i];

public static A096774Inst Instance=new A096774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096775
{
public static readonly long[] Value={ 1L,2L,6L,30L,210L,2310L,2310L,2310L,2310L,2310L,9240L,9240L,933240L,8399160L,16798320L,16798320L,16798320L,16798320L,117588240L,2234176560L,2234176560L,373107485520L,93649978865520L,468249894327600L,41674240595156400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096775Inst : IEnumerable<long>
{
public static readonly long[] Value=A096775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096775.Bytes);
public long this[int i]=>Value[i];

public static A096775Inst Instance=new A096775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096776
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,4L,3L,2L,11L,3L,13L,2L,3L,4L,17L,6L,19L,4L,3L,2L,23L,4L,5L,2L,9L,4L,29L,5L,31L,8L,3L,2L,5L,4L,37L,2L,3L,5L,41L,6L,43L,4L,5L,2L,47L,6L,7L,10L,3L,4L,53L,6L,5L,7L,3L,2L,59L,6L,61L,2L,7L,8L,5L,6L,67L,4L,3L,7L,71L,8L,73L,2L,15L,4L,7L,6L,79L,8L,9L,2L,83L,12L,5L,2L,3L,8L,89L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096776Inst : IEnumerable<long>
{
public static readonly long[] Value=A096776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096776.Bytes);
public long this[int i]=>Value[i];

public static A096776Inst Instance=new A096776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096777
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,15L,20L,25L,31L,38L,45L,53L,62L,71L,81L,92L,103L,115L,128L,141L,155L,170L,185L,201L,218L,235L,253L,272L,291L,311L,332L,353L,375L,398L,421L,445L,470L,495L,521L,548L,575L,603L,632L,661L,691L,722L,753L,785L,818L,851L,885L,920L,955L,991L,1028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096777Inst : IEnumerable<long>
{
public static readonly long[] Value=A096777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096777.Bytes);
public long this[int i]=>Value[i];

public static A096777Inst Instance=new A096777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096778
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,10L,14L,19L,26L,34L,45L,58L,75L,95L,121L,151L,189L,234L,289L,354L,433L,526L,637L,768L,923L,1105L,1319L,1569L,1861L,2202L,2597L,3056L,3587L,4201L,4908L,5723L,6658L,7732L,8961L,10367L,11971L,13802L,15884L,18253L,20942L,23992L,27445L,31353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096778Inst : IEnumerable<long>
{
public static readonly long[] Value=A096778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096778.Bytes);
public long this[int i]=>Value[i];

public static A096778Inst Instance=new A096778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096779
{
public static readonly long[] Value={ 2L,1L,4L,3L,6L,5L,8L,7L,10L,9L,20L,30L,22L,23L,24L,25L,26L,27L,28L,11L,33L,13L,14L,15L,16L,17L,18L,19L,31L,12L,29L,40L,21L,50L,41L,42L,44L,45L,46L,32L,35L,36L,51L,37L,38L,39L,52L,53L,55L,34L,43L,47L,48L,60L,49L,70L,61L,62L,63L,54L,57L,58L,59L,71L,72L,73L,80L,74L,75L,56L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096779Inst : IEnumerable<long>
{
public static readonly long[] Value=A096779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096779.Bytes);
public long this[int i]=>Value[i];

public static A096779Inst Instance=new A096779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096780
{
public static readonly long[] Value={ 1L,2L,4L,3L,11L,5L,22L,7L,6L,12L,56L,8L,79L,23L,13L,9L,137L,16L,172L,10L,24L,57L,254L,17L,14L,80L,37L,25L,407L,15L,466L,29L,58L,138L,26L,18L,667L,173L,81L,30L,821L,19L,904L,59L,38L,255L,1082L,20L,27L,46L,139L,82L,1379L,21L,60L,28L,174L,408L,1712L,47L,1831L,467L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096780Inst : IEnumerable<long>
{
public static readonly long[] Value=A096780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096780.Bytes);
public long this[int i]=>Value[i];

public static A096780Inst Instance=new A096780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096781
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,16L,12L,10L,18L,48L,6L,20L,30L,28L,40L,36L,21L,104L,99L,70L,150L,8L,25L,54L,56L,96L,100L,11L,72L,81L,132L,192L,26L,195L,224L,350L,49L,126L,121L,39L,221L,280L,135L,345L,304L,110L,55L,168L,294L,225L,390L,384L,68L,323L,414L,5L,7L,80L,117L,160L,154L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096781Inst : IEnumerable<long>
{
public static readonly long[] Value=A096781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096781.Bytes);
public long this[int i]=>Value[i];

public static A096781Inst Instance=new A096781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096782
{
public static readonly long[] Value={ 1L,2L,3L,4L,56L,11L,57L,22L,5L,8L,28L,7L,3082L,254L,79L,6L,9317L,9L,907L,12L,17L,174L,8003L,137L,23L,33L,667L,14L,677L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096782Inst : IEnumerable<long>
{
public static readonly long[] Value=A096782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096782.Bytes);
public long this[int i]=>Value[i];

public static A096782Inst Instance=new A096782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096783
{
public static readonly long[] Value={ 0L,96L,800L,2400L,3200L,3648L,4096L,4800L,6272L,7296L,9600L,18272L,19648L,20000L,20672L,23648L,28224L,28800L,29472L,31424L,34848L,36896L,37472L,43072L,48672L,50272L,51200L,53600L,53824L,55072L,57696L,59648L,62848L,64800L,66048L,69824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096783Inst : IEnumerable<long>
{
public static readonly long[] Value=A096783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096783.Bytes);
public long this[int i]=>Value[i];

public static A096783Inst Instance=new A096783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096784
{
public static readonly long[] Value={ 8L,9L,14L,15L,20L,21L,26L,33L,35L,39L,44L,48L,50L,51L,54L,56L,63L,65L,68L,69L,74L,75L,81L,86L,90L,95L,98L,99L,105L,111L,114L,116L,119L,120L,125L,128L,134L,135L,140L,141L,146L,153L,155L,158L,165L,168L,174L,176L,183L,186L,189L,194L,200L,204L,209L,215L,216L,219L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096784Inst : IEnumerable<long>
{
public static readonly long[] Value=A096784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096784.Bytes);
public long this[int i]=>Value[i];

public static A096784Inst Instance=new A096784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096785
{
public static readonly long[] Value={ 17L,29L,41L,53L,89L,97L,101L,109L,113L,137L,149L,173L,181L,197L,229L,233L,241L,257L,269L,281L,293L,317L,337L,349L,353L,373L,389L,401L,409L,433L,449L,461L,509L,521L,557L,569L,577L,593L,601L,617L,641L,653L,677L,701L,709L,761L,769L,773L,797L,809L,821L,829L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096785Inst : IEnumerable<long>
{
public static readonly long[] Value=A096785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096785.Bytes);
public long this[int i]=>Value[i];

public static A096785Inst Instance=new A096785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096786
{
public static readonly long[] Value={ 8L,14L,20L,26L,44L,48L,50L,54L,56L,68L,74L,86L,90L,98L,114L,116L,120L,128L,134L,140L,146L,158L,168L,174L,176L,186L,194L,200L,204L,216L,224L,230L,254L,260L,278L,284L,288L,296L,300L,308L,320L,326L,338L,350L,354L,380L,384L,386L,398L,404L,410L,414L,426L,428L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096786Inst : IEnumerable<long>
{
public static readonly long[] Value=A096786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096786.Bytes);
public long this[int i]=>Value[i];

public static A096786Inst Instance=new A096786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096787
{
public static readonly long[] Value={ 19L,31L,43L,67L,71L,79L,103L,127L,131L,139L,151L,163L,191L,199L,211L,223L,239L,251L,271L,283L,307L,311L,331L,367L,379L,419L,431L,439L,443L,463L,487L,491L,499L,523L,547L,571L,599L,607L,619L,631L,643L,647L,659L,683L,691L,727L,739L,743L,751L,787L,811L,823L,827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096787Inst : IEnumerable<long>
{
public static readonly long[] Value=A096787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096787.Bytes);
public long this[int i]=>Value[i];

public static A096787Inst Instance=new A096787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096820
{
public static readonly long[] Value={ 5L,6L,7L,9L,11L,13L,14L,21L,23L,41L,46L,89L,110L,389L,413L,489L,869L,1589L,1713L,2831L,10843L,11257L,16949L,24513L,39621L,43349L,62941L,96094L,139237L,145289L,264683L,396790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096820Inst : IEnumerable<long>
{
public static readonly long[] Value=A096820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096820.Bytes);
public long this[int i]=>Value[i];

public static A096820Inst Instance=new A096820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096821
{
public static readonly BigInteger[] Value={ 24L,304L,127744L,33501184L,8589082624L,BigInteger.Parse("10384593717069654320312270165377024"),BigInteger.Parse("822752278660603021077484591278411581166520461101278617407586304"),BigInteger.Parse("15177100720513508366558296147058741458142670970377727126573378340391656803557965824") };
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
public class A096821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096821Inst Instance=new A096821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096822
{
public static readonly long[] Value={ 3L,5L,3L,549755813881L,7L,5L,3L,17L,47L,13L,11L,41L,7L,5L,3L,97L,31L,29L,2011L,89L,23L,536870869L,19L,17L,79L,13L,11L,73L,7L,5L,3L,193L,191L,61L,59L,953L,439L,53L,179L,433L,47L,173L,43L,41L,167L,37L,163L,929L,31L,29L,67108763L,409L,23L,149L,19L,17L,911L,13L,11L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096822Inst : IEnumerable<long>
{
public static readonly long[] Value=A096822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096822.Bytes);
public long this[int i]=>Value[i];

public static A096822Inst Instance=new A096822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096823
{
public static readonly BigInteger[] Value={ 6L,20L,12L,BigInteger.Parse("151115727449904501489664"),56L,40L,24L,272L,1504L,208L,176L,1312L,112L,80L,48L,6208L,992L,928L,2059264L,5696L,736L,144115176533131264L,608L,544L,5056L,416L,352L,4672L,224L,160L,96L,24704L,24448L,3904L,3776L,487936L,112384L,3392L,22912L };
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
public class A096823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096823Inst Instance=new A096823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096824
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,9L,14L,24L,42L,75L,136L,258L,492L,942L,1809L,3482L,6828L,13398L,26304L,51666L,101523L,199564L,395646L,784464L,1555530L,3084756L,6117846L,12134169L,24068774L,47937984L,95480322L,190176180L,378796830L,754508904L,1502899962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096824Inst : IEnumerable<long>
{
public static readonly long[] Value=A096824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096824.Bytes);
public long this[int i]=>Value[i];

public static A096824Inst Instance=new A096824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096825
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,2L,2L,2L,3L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,4L,1L,2L,2L,1L,2L,3L,1L,2L,2L,3L,1L,3L,1L,2L,2L,2L,2L,3L,1L,2L,1L,2L,1L,4L,2L,2L,2L,2L,1L,4L,2L,2L,2L,2L,2L,2L,1L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096825Inst : IEnumerable<long>
{
public static readonly long[] Value=A096825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096825.Bytes);
public long this[int i]=>Value[i];

public static A096825Inst Instance=new A096825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096826
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,1L,2L,4L,3L,1L,2L,3L,2L,1L,1L,5L,2L,3L,2L,3L,1L,1L,2L,6L,3L,1L,4L,3L,2L,2L,2L,6L,1L,1L,1L,1L,2L,1L,1L,6L,2L,2L,2L,3L,3L,1L,2L,10L,3L,3L,1L,3L,2L,6L,1L,6L,1L,1L,2L,1L,2L,1L,3L,7L,1L,2L,2L,3L,1L,2L,2L,4L,2L,1L,3L,3L,1L,2L,2L,10L,5L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096826Inst : IEnumerable<long>
{
public static readonly long[] Value=A096826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096826.Bytes);
public long this[int i]=>Value[i];

public static A096826Inst Instance=new A096826Inst();

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