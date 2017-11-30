using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A049745
{
public static readonly long[] Value={ 13L,21L,25L,45L,69L,97L,129L,177L,221L,277L,333L,401L,473L,553L,633L,725L,821L,933L,1041L,1153L,1273L,1405L,1541L,1685L,1829L,1993L,2145L,2313L,2477L,2661L,2845L,3041L,3241L,3433L,3657L,3869L,4085L,4317L,4545L,4809L,5049L,5297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049745Inst : IEnumerable<long>
{
public static readonly long[] Value=A049745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049745.Bytes);
public long this[int i]=>Value[i];

public static A049745Inst Instance=new A049745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049746
{
public static readonly long[] Value={ 29L,37L,45L,61L,81L,109L,145L,185L,233L,293L,349L,421L,489L,561L,657L,749L,845L,949L,1049L,1177L,1289L,1425L,1565L,1693L,1853L,2001L,2161L,2321L,2493L,2693L,2869L,3061L,3249L,3457L,3673L,3885L,4109L,4341L,4577L,4825L,5057L,5321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049746Inst : IEnumerable<long>
{
public static readonly long[] Value=A049746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049746.Bytes);
public long this[int i]=>Value[i];

public static A049746Inst Instance=new A049746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049747
{
public static readonly long[] Value={ 0L,2L,2L,3L,3L,3L,5L,5L,5L,5L,9L,7L,5L,7L,9L,13L,11L,9L,9L,11L,13L,19L,15L,11L,11L,11L,15L,19L,23L,21L,17L,13L,13L,17L,21L,23L,31L,25L,21L,19L,17L,19L,21L,25L,31L,39L,35L,27L,23L,23L,23L,23L,27L,35L,39L,49L,41L,35L,29L,25L,25L,25L,29L,35L,41L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049747Inst : IEnumerable<long>
{
public static readonly long[] Value=A049747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049747.Bytes);
public long this[int i]=>Value[i];

public static A049747Inst Instance=new A049747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049748
{
public static readonly long[] Value={ 0L,4L,9L,20L,37L,66L,101L,148L,209L,294L,383L,512L,639L,814L,1003L,1224L,1461L,1750L,2047L,2420L,2791L,3206L,3661L,4176L,4731L,5354L,5977L,6688L,7429L,8250L,9093L,10028L,10991L,12066L,13157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049748Inst : IEnumerable<long>
{
public static readonly long[] Value=A049748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049748.Bytes);
public long this[int i]=>Value[i];

public static A049748Inst Instance=new A049748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049749
{
public static readonly long[] Value={ 0L,3L,9L,19L,33L,53L,59L,101L,109L,141L,211L,235L,275L,315L,353L,435L,511L,543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049749Inst : IEnumerable<long>
{
public static readonly long[] Value=A049749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049749.Bytes);
public long this[int i]=>Value[i];

public static A049749Inst Instance=new A049749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049750
{
public static readonly long[] Value={ 0L,2L,6L,10L,23L,33L,60L,74L,121L,147L,218L,256L,349L,407L,552L,612L,785L,875L,1094L,1210L,1501L,1603L,1948L,2088L,2503L,2677L,3146L,3344L,3891L,4125L,4764L,5014L,5751L,6033L,6850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049750Inst : IEnumerable<long>
{
public static readonly long[] Value=A049750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049750.Bytes);
public long this[int i]=>Value[i];

public static A049750Inst Instance=new A049750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049751
{
public static readonly long[] Value={ 0L,4L,4L,6L,6L,6L,10L,10L,10L,10L,18L,14L,10L,14L,18L,26L,22L,18L,18L,22L,26L,38L,30L,22L,22L,22L,30L,38L,46L,42L,34L,26L,26L,34L,42L,46L,62L,50L,42L,38L,34L,38L,42L,50L,62L,78L,70L,54L,46L,46L,46L,46L,54L,70L,78L,98L,82L,70L,58L,50L,50L,50L,58L,70L,82L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049751Inst : IEnumerable<long>
{
public static readonly long[] Value=A049751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049751.Bytes);
public long this[int i]=>Value[i];

public static A049751Inst Instance=new A049751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049752
{
public static readonly long[] Value={ 0L,3L,5L,11L,17L,25L,35L,49L,61L,77L,99L,119L,135L,163L,189L,219L,247L,283L,309L,343L,385L,421L,463L,505L,553L,603L,645L,699L,751L,799L,857L,919L,979L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049752Inst : IEnumerable<long>
{
public static readonly long[] Value=A049752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049752.Bytes);
public long this[int i]=>Value[i];

public static A049752Inst Instance=new A049752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049753
{
public static readonly long[] Value={ 2L,5L,9L,13L,23L,31L,45L,57L,71L,89L,111L,127L,151L,175L,203L,231L,267L,295L,327L,367L,397L,443L,487L,535L,577L,625L,677L,723L,781L,831L,883L,951L,1005L,1071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049753Inst : IEnumerable<long>
{
public static readonly long[] Value=A049753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049753.Bytes);
public long this[int i]=>Value[i];

public static A049753Inst Instance=new A049753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049754
{
public static readonly long[] Value={ 3L,7L,11L,19L,25L,39L,49L,65L,77L,101L,119L,141L,163L,191L,219L,249L,283L,313L,343L,387L,421L,467L,505L,557L,603L,647L,699L,755L,799L,863L,919L,983L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049754Inst : IEnumerable<long>
{
public static readonly long[] Value=A049754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049754.Bytes);
public long this[int i]=>Value[i];

public static A049754Inst Instance=new A049754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049755
{
public static readonly long[] Value={ 5L,11L,17L,23L,35L,47L,57L,75L,93L,111L,129L,155L,175L,207L,237L,267L,297L,331L,367L,403L,445L,487L,537L,583L,625L,679L,729L,781L,835L,887L,951L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049755Inst : IEnumerable<long>
{
public static readonly long[] Value=A049755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049755.Bytes);
public long this[int i]=>Value[i];

public static A049755Inst Instance=new A049755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049756
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,15L,21L,25L,35L,41L,51L,59L,71L,83L,99L,113L,123L,141L,159L,171L,195L,213L,237L,255L,281L,301L,323L,351L,377L,399L,431L,459L,495L,523L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049756Inst : IEnumerable<long>
{
public static readonly long[] Value=A049756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049756.Bytes);
public long this[int i]=>Value[i];

public static A049756Inst Instance=new A049756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049757
{
public static readonly long[] Value={ 3L,5L,5L,9L,11L,17L,21L,27L,35L,45L,51L,61L,73L,85L,99L,115L,123L,143L,159L,175L,195L,217L,237L,259L,283L,305L,323L,353L,377L,403L,431L,463L,495L,525L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049757Inst : IEnumerable<long>
{
public static readonly long[] Value=A049757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049757.Bytes);
public long this[int i]=>Value[i];

public static A049757Inst Instance=new A049757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049758
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,19L,23L,29L,37L,47L,55L,65L,75L,87L,105L,117L,127L,145L,159L,179L,197L,219L,241L,261L,283L,307L,327L,353L,381L,407L,435L,467L,497L,527L,565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049758Inst : IEnumerable<long>
{
public static readonly long[] Value=A049758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049758.Bytes);
public long this[int i]=>Value[i];

public static A049758Inst Instance=new A049758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049759
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,4L,1L,0L,0L,0L,1L,0L,4L,4L,1L,0L,0L,1L,0L,1L,1L,3L,4L,1L,0L,0L,0L,1L,0L,0L,4L,2L,4L,1L,0L,0L,1L,1L,1L,1L,1L,2L,1L,4L,1L,0L,0L,0L,0L,0L,4L,0L,4L,0L,0L,4L,1L,0L,0L,1L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049759Inst : IEnumerable<long>
{
public static readonly long[] Value=A049759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049759.Bytes);
public long this[int i]=>Value[i];

public static A049759Inst Instance=new A049759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049760
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,1L,8L,10L,11L,12L,13L,13L,31L,37L,31L,41L,42L,47L,58L,60L,82L,86L,95L,76L,125L,123L,140L,103L,115L,134L,188L,229L,235L,213L,186L,239L,264L,283L,244L,243L,263L,342L,369L,430L,387L,407L,473L,413L,446L,489L,522L,492L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049760Inst : IEnumerable<long>
{
public static readonly long[] Value=A049760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049760.Bytes);
public long this[int i]=>Value[i];

public static A049760Inst Instance=new A049760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049761
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,3L,3L,1L,0L,0L,0L,2L,0L,2L,2L,1L,0L,0L,1L,0L,1L,4L,3L,1L,1L,0L,0L,0L,1L,0L,0L,4L,6L,0L,1L,0L,0L,1L,2L,3L,1L,5L,1L,3L,8L,1L,0L,0L,0L,0L,0L,3L,0L,6L,0L,0L,8L,1L,0L,0L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049761Inst : IEnumerable<long>
{
public static readonly long[] Value=A049761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049761.Bytes);
public long this[int i]=>Value[i];

public static A049761Inst Instance=new A049761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049762
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,1L,9L,7L,11L,12L,25L,18L,34L,34L,41L,32L,76L,44L,87L,64L,93L,85L,122L,75L,80L,160L,144L,132L,172L,103L,218L,232L,220L,245L,251L,210L,299L,330L,344L,315L,413L,275L,456L,392L,383L,472L,502L,479L,449L,553L,557L,626L,646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049762Inst : IEnumerable<long>
{
public static readonly long[] Value=A049762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049762.Bytes);
public long this[int i]=>Value[i];

public static A049762Inst Instance=new A049762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049763
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,4L,1L,0L,0L,1L,0L,1L,1L,3L,2L,1L,0L,0L,0L,1L,0L,0L,4L,4L,0L,1L,0L,0L,1L,1L,1L,1L,1L,4L,1L,7L,1L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,6L,1L,0L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049763Inst : IEnumerable<long>
{
public static readonly long[] Value=A049763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049763.Bytes);
public long this[int i]=>Value[i];

public static A049763Inst Instance=new A049763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049764
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,1L,5L,7L,9L,10L,18L,10L,18L,25L,28L,40L,44L,26L,52L,79L,60L,78L,73L,101L,117L,133L,114L,136L,91L,90L,158L,188L,220L,244L,218L,220L,208L,283L,280L,303L,220L,319L,287L,393L,398L,446L,391L,459L,435L,534L,481L,471L,428L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049764Inst : IEnumerable<long>
{
public static readonly long[] Value=A049764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049764.Bytes);
public long this[int i]=>Value[i];

public static A049764Inst Instance=new A049764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049765
{
public static readonly long[] Value={ 0L,1L,0L,1L,3L,0L,1L,2L,4L,0L,1L,3L,5L,5L,0L,1L,2L,3L,6L,6L,0L,1L,3L,4L,7L,7L,7L,0L,1L,2L,5L,4L,8L,8L,8L,0L,1L,3L,3L,5L,9L,9L,9L,9L,0L,1L,2L,4L,6L,5L,10L,10L,10L,10L,0L,1L,3L,5L,7L,6L,11L,11L,11L,11L,11L,0L,1L,2L,3L,4L,7L,6L,12L,12L,12L,12L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049765Inst : IEnumerable<long>
{
public static readonly long[] Value=A049765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049765.Bytes);
public long this[int i]=>Value[i];

public static A049765Inst Instance=new A049765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049766
{
public static readonly long[] Value={ 0L,1L,4L,7L,14L,18L,29L,36L,48L,58L,77L,83L,106L,122L,141L,156L,187L,200L,235L,251L,280L,308L,351L,361L,403L,437L,476L,502L,557L,573L,632L,663L,712L,758L,813L,828L,899L,951L,1010L,1038L,1117L,1145L,1228L,1274L,1329L,1393L,1484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049766Inst : IEnumerable<long>
{
public static readonly long[] Value=A049766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049766.Bytes);
public long this[int i]=>Value[i];

public static A049766Inst Instance=new A049766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049767
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,1L,0L,2L,0L,1L,5L,5L,2L,0L,1L,4L,3L,4L,2L,0L,1L,5L,3L,3L,8L,2L,0L,1L,4L,2L,0L,5L,8L,2L,0L,1L,5L,0L,8L,8L,3L,8L,2L,0L,1L,4L,10L,6L,5L,10L,11L,8L,2L,0L,1L,5L,10L,6L,4L,4L,7L,10L,8L,2L,0L,1L,4L,9L,4L,5L,0L,5L,4L,9L,8L,2L,0L,1L,5L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049767Inst : IEnumerable<long>
{
public static readonly long[] Value=A049767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049767.Bytes);
public long this[int i]=>Value[i];

public static A049767Inst Instance=new A049767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049768
{
public static readonly long[] Value={ 0L,1L,3L,3L,13L,14L,22L,22L,35L,57L,57L,51L,109L,114L,101L,97L,178L,176L,210L,190L,264L,295L,279L,224L,375L,448L,428L,397L,521L,499L,560L,533L,719L,774L,676L,641L,930L,948L,816L,783L,1083L,1147L,1229L,1156L,1227L,1304L,1319L,1093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049768Inst : IEnumerable<long>
{
public static readonly long[] Value=A049768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049768.Bytes);
public long this[int i]=>Value[i];

public static A049768Inst Instance=new A049768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049769
{
public static readonly long[] Value={ 0L,1L,0L,1L,3L,0L,1L,0L,4L,0L,1L,4L,4L,5L,0L,1L,2L,3L,4L,6L,0L,1L,2L,7L,4L,9L,7L,0L,1L,0L,5L,0L,7L,2L,8L,0L,1L,9L,0L,2L,12L,3L,2L,9L,0L,1L,8L,8L,4L,5L,10L,9L,2L,10L,0L,1L,9L,7L,12L,5L,12L,3L,9L,11L,11L,0L,1L,8L,3L,4L,8L,0L,13L,8L,9L,12L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049769Inst : IEnumerable<long>
{
public static readonly long[] Value=A049769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049769.Bytes);
public long this[int i]=>Value[i];

public static A049769Inst Instance=new A049769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049770
{
public static readonly long[] Value={ 0L,1L,4L,5L,14L,16L,30L,23L,38L,57L,80L,78L,112L,125L,146L,128L,212L,179L,258L,244L,303L,316L,375L,315L,330L,485L,387L,496L,578L,538L,683L,616L,748L,806L,846L,750L,965L,1033L,1085L,1035L,1233L,1136L,1359L,1316L,1328L,1507L,1583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049770Inst : IEnumerable<long>
{
public static readonly long[] Value=A049770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049770.Bytes);
public long this[int i]=>Value[i];

public static A049770Inst Instance=new A049770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049771
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,1L,0L,2L,0L,1L,2L,2L,2L,0L,1L,4L,3L,4L,2L,0L,1L,3L,5L,5L,3L,2L,0L,1L,0L,2L,0L,2L,4L,2L,0L,1L,8L,0L,5L,5L,3L,9L,2L,0L,1L,6L,2L,6L,5L,10L,5L,6L,2L,0L,1L,6L,5L,4L,10L,10L,7L,5L,12L,2L,0L,1L,4L,9L,4L,2L,0L,3L,4L,9L,10L,2L,0L,1L,4L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049771Inst : IEnumerable<long>
{
public static readonly long[] Value=A049771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049771.Bytes);
public long this[int i]=>Value[i];

public static A049771Inst Instance=new A049771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049772
{
public static readonly long[] Value={ 0L,1L,3L,3L,7L,14L,19L,11L,33L,43L,62L,48L,70L,102L,80L,48L,180L,155L,204L,225L,242L,287L,257L,273L,337L,406L,348L,430L,555L,419L,530L,460L,704L,805L,666L,622L,800L,948L,774L,675L,1040L,1124L,1147L,1119L,1364L,1343L,1237L,995L,1415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049772Inst : IEnumerable<long>
{
public static readonly long[] Value=A049772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049772.Bytes);
public long this[int i]=>Value[i];

public static A049772Inst Instance=new A049772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049773
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,4L,1L,5L,3L,7L,2L,6L,4L,8L,1L,9L,5L,13L,3L,11L,7L,15L,2L,10L,6L,14L,4L,12L,8L,16L,1L,17L,9L,25L,5L,21L,13L,29L,3L,19L,11L,27L,7L,23L,15L,31L,2L,18L,10L,26L,6L,22L,14L,30L,4L,20L,12L,28L,8L,24L,16L,32L,1L,33L,17L,49L,9L,41L,25L,57L,5L,37L,21L,53L,13L,45L,29L,61L,3L,35L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049773Inst : IEnumerable<long>
{
public static readonly long[] Value=A049773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049773.Bytes);
public long this[int i]=>Value[i];

public static A049773Inst Instance=new A049773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049774
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,17L,70L,349L,2017L,13358L,99377L,822041L,7477162L,74207209L,797771521L,9236662346L,114579019469L,1516103040833L,21314681315998L,317288088082405L,4985505271920097L,82459612672301846L,1432064398910663705L,BigInteger.Parse("26054771465540507273"),BigInteger.Parse("495583804405888997218") };
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
public class A049774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049774Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A049774.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A049774.Bytes);
public BigInteger this[int i]=>Value[i];

public static A049774Inst Instance=new A049774Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049775
{
public static readonly long[] Value={ 2L,7L,26L,100L,392L,1552L,6176L,24640L,98432L,393472L,1573376L,6292480L,25167872L,100667392L,402661376L,1610629120L,6442483712L,25769869312L,103079346176L,412317122560L,1649267965952L,6597070815232L,26388281163776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049775Inst : IEnumerable<long>
{
public static readonly long[] Value=A049775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049775.Bytes);
public long this[int i]=>Value[i];

public static A049775Inst Instance=new A049775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049776
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,3L,6L,8L,1L,7L,10L,16L,1L,5L,11L,15L,18L,22L,28L,32L,1L,13L,19L,31L,34L,46L,52L,64L,1L,9L,21L,29L,35L,43L,55L,63L,66L,74L,86L,94L,100L,108L,120L,128L,1L,25L,37L,61L,67L,91L,103L,127L,130L,154L,166L,190L,196L,220L,232L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049776Inst : IEnumerable<long>
{
public static readonly long[] Value=A049776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049776.Bytes);
public long this[int i]=>Value[i];

public static A049776Inst Instance=new A049776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049777
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,3L,10L,9L,7L,4L,15L,14L,12L,9L,5L,21L,20L,18L,15L,11L,6L,28L,27L,25L,22L,18L,13L,7L,36L,35L,33L,30L,26L,21L,15L,8L,45L,44L,42L,39L,35L,30L,24L,17L,9L,55L,54L,52L,49L,45L,40L,34L,27L,19L,10L,66L,65L,63L,60L,56L,51L,45L,38L,30L,21L,11L,78L,77L,75L,72L,68L,63L,57L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049777Inst : IEnumerable<long>
{
public static readonly long[] Value=A049777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049777.Bytes);
public long this[int i]=>Value[i];

public static A049777Inst Instance=new A049777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049778
{
public static readonly long[] Value={ 1L,3L,9L,17L,32L,50L,78L,110L,155L,205L,271L,343L,434L,532L,652L,780L,933L,1095L,1285L,1485L,1716L,1958L,2234L,2522L,2847L,3185L,3563L,3955L,4390L,4840L,5336L,5848L,6409L,6987L,7617L,8265L,8968L,9690L,10470L,11270L,12131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049778Inst : IEnumerable<long>
{
public static readonly long[] Value=A049778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049778.Bytes);
public long this[int i]=>Value[i];

public static A049778Inst Instance=new A049778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049779
{
public static readonly long[] Value={ 2L,5L,13L,23L,41L,62L,94L,130L,180L,235L,307L,385L,483L,588L,716L,852L,1014L,1185L,1385L,1595L,1837L,2090L,2378L,2678L,3016L,3367L,3759L,4165L,4615L,5080L,5592L,6120L,6698L,7293L,7941L,8607L,9329L,10070L,10870L,11690L,12572L,13475L,14443L,15433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049779Inst : IEnumerable<long>
{
public static readonly long[] Value=A049779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049779.Bytes);
public long this[int i]=>Value[i];

public static A049779Inst Instance=new A049779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049780
{
public static readonly long[] Value={ 0L,1L,0L,3L,2L,0L,6L,5L,3L,0L,10L,9L,7L,4L,0L,15L,14L,12L,9L,5L,0L,21L,20L,18L,15L,11L,6L,0L,28L,27L,25L,22L,18L,13L,7L,0L,36L,35L,33L,30L,26L,21L,15L,8L,0L,45L,44L,42L,39L,35L,30L,24L,17L,9L,0L,55L,54L,52L,49L,45L,40L,34L,27L,19L,10L,0L,66L,65L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049780Inst : IEnumerable<long>
{
public static readonly long[] Value=A049780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049780.Bytes);
public long this[int i]=>Value[i];

public static A049780Inst Instance=new A049780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049781
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,11L,13L,16L,17L,19L,22L,25L,26L,32L,34L,35L,37L,38L,40L,44L,47L,50L,53L,56L,58L,64L,65L,67L,68L,71L,76L,80L,82L,85L,86L,95L,97L,98L,101L,103L,106L,110L,112L,116L,118L,119L,121L,130L,131L,134L,137L,142L,143L,145L,149L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049781Inst : IEnumerable<long>
{
public static readonly long[] Value=A049781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049781.Bytes);
public long this[int i]=>Value[i];

public static A049781Inst Instance=new A049781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049782
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,4L,6L,2L,1L,4L,1L,10L,10L,6L,4L,10L,13L,10L,9L,14L,13L,12L,21L,10L,14L,10L,10L,6L,17L,4L,2L,26L,1L,30L,34L,10L,5L,28L,10L,34L,4L,34L,16L,34L,19L,44L,18L,10L,48L,14L,13L,10L,13L,10L,34L,34L,28L,46L,28L,34L,22L,2L,55L,26L,49L,34L,65L,30L,67L,34L,68L,10L,55L,42L,64L,66L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049782Inst : IEnumerable<long>
{
public static readonly long[] Value=A049782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049782.Bytes);
public long this[int i]=>Value[i];

public static A049782Inst Instance=new A049782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049783
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,2L,2L,1L,0L,0L,0L,2L,1L,0L,0L,1L,1L,4L,3L,3L,2L,0L,0L,2L,0L,3L,4L,3L,0L,0L,1L,0L,2L,5L,4L,3L,4L,2L,0L,0L,1L,2L,0L,5L,4L,4L,4L,1L,0L,1L,2L,4L,2L,8L,7L,8L,8L,6L,5L,0L,0L,0L,0L,2L,0L,5L,4L,3L,4L,3L,0L,0L,1L,1L,2L,4L,3L,8L,8L,7L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049783Inst : IEnumerable<long>
{
public static readonly long[] Value=A049783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049783.Bytes);
public long this[int i]=>Value[i];

public static A049783Inst Instance=new A049783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049784
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,3L,14L,12L,21L,21L,51L,21L,62L,69L,79L,63L,136L,90L,181L,129L,160L,186L,324L,160L,264L,306L,371L,297L,512L,285L,528L,444L,547L,628L,768L,372L,715L,820L,980L,652L,1079L,702L,1173L,1053L,1002L,1155L,1728L,960L,1417L,1292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049784Inst : IEnumerable<long>
{
public static readonly long[] Value=A049784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049784.Bytes);
public long this[int i]=>Value[i];

public static A049784Inst Instance=new A049784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049785
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,0L,2L,1L,5L,0L,5L,4L,3L,2L,9L,2L,10L,4L,6L,7L,17L,0L,10L,11L,13L,6L,19L,4L,18L,10L,15L,18L,21L,2L,19L,22L,27L,8L,27L,10L,30L,20L,17L,22L,44L,6L,28L,21L,29L,22L,47L,21L,34L,17L,28L,35L,63L,8L,37L,44L,38L,28L,43L,19L,51L,41L,55L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049785Inst : IEnumerable<long>
{
public static readonly long[] Value=A049785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049785.Bytes);
public long this[int i]=>Value[i];

public static A049785Inst Instance=new A049785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049786
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,3L,3L,4L,4L,6L,3L,6L,7L,8L,6L,10L,8L,11L,9L,11L,10L,18L,10L,12L,14L,18L,14L,20L,12L,19L,19L,20L,21L,30L,13L,20L,25L,32L,21L,28L,18L,31L,29L,28L,25L,45L,25L,30L,31L,34L,30L,48L,37L,43L,28L,33L,38L,64L,29L,38L,47L,53L,37L,50L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049786Inst : IEnumerable<long>
{
public static readonly long[] Value=A049786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049786.Bytes);
public long this[int i]=>Value[i];

public static A049786Inst Instance=new A049786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049787
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,2L,3L,4L,3L,4L,8L,4L,8L,8L,10L,5L,13L,9L,16L,10L,12L,13L,20L,11L,16L,16L,20L,17L,27L,13L,26L,20L,25L,24L,32L,12L,30L,26L,34L,24L,40L,19L,38L,30L,33L,34L,47L,26L,41L,33L,43L,33L,55L,38L,53L,33L,40L,41L,66L,30L,58L,48L,55L,42L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049787Inst : IEnumerable<long>
{
public static readonly long[] Value=A049787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049787.Bytes);
public long this[int i]=>Value[i];

public static A049787Inst Instance=new A049787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049788
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,4L,3L,4L,4L,8L,3L,9L,9L,11L,8L,12L,10L,17L,9L,13L,15L,23L,14L,17L,19L,22L,20L,30L,12L,27L,22L,26L,30L,35L,15L,29L,35L,35L,27L,43L,22L,39L,36L,34L,40L,56L,29L,42L,38L,45L,39L,58L,43L,54L,34L,45L,49L,69L,33L,59L,67L,56L,45L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049788Inst : IEnumerable<long>
{
public static readonly long[] Value=A049788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049788.Bytes);
public long this[int i]=>Value[i];

public static A049788Inst Instance=new A049788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049789
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,5L,5L,7L,4L,7L,10L,6L,9L,14L,10L,17L,10L,14L,16L,24L,12L,19L,20L,24L,18L,32L,16L,25L,23L,30L,31L,33L,19L,31L,34L,43L,28L,45L,26L,41L,37L,37L,41L,61L,27L,44L,39L,49L,41L,63L,47L,58L,35L,48L,54L,76L,37L,61L,68L,65L,46L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049789Inst : IEnumerable<long>
{
public static readonly long[] Value=A049789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049789.Bytes);
public long this[int i]=>Value[i];

public static A049789Inst Instance=new A049789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049790
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,7L,4L,6L,9L,11L,5L,7L,11L,13L,18L,6L,9L,14L,16L,22L,24L,7L,10L,16L,18L,25L,27L,34L,8L,12L,18L,22L,29L,31L,39L,43L,9L,13L,21L,24L,32L,35L,44L,47L,55L,10L,15L,23L,27L,37L,39L,49L,53L,61L,66L,11L,16L,25L,29L,40L,42L,53L,57L,66L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049790Inst : IEnumerable<long>
{
public static readonly long[] Value=A049790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049790.Bytes);
public long this[int i]=>Value[i];

public static A049790Inst Instance=new A049790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049791
{
public static readonly long[] Value={ 1L,5L,14L,30L,54L,91L,137L,202L,280L,380L,492L,644L,799L,994L,1212L,1471L,1735L,2071L,2400L,2811L,3232L,3709L,4190L,4804L,5380L,6046L,6739L,7535L,8297L,9246L,10115L,11153L,12184L,13320L,14458L,15839L,17074L,18493L,19931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049791Inst : IEnumerable<long>
{
public static readonly long[] Value=A049791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049791.Bytes);
public long this[int i]=>Value[i];

public static A049791Inst Instance=new A049791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049792
{
public static readonly long[] Value={ 1L,3L,7L,11L,18L,24L,34L,43L,55L,66L,82L,94L,113L,129L,150L,167L,192L,211L,239L,261L,290L,315L,349L,374L,410L,440L,478L,509L,552L,583L,629L,665L,711L,750L,802L,838L,893L,937L,992L,1036L,1097L,1141L,1205L,1255L,1317L,1370L,1440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049792Inst : IEnumerable<long>
{
public static readonly long[] Value=A049792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049792.Bytes);
public long this[int i]=>Value[i];

public static A049792Inst Instance=new A049792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049793
{
public static readonly long[] Value={ 1L,2L,4L,9L,13L,22L,27L,39L,47L,61L,71L,91L,100L,122L,137L,160L,175L,205L,220L,253L,272L,304L,326L,368L,386L,427L,455L,497L,523L,575L,598L,651L,683L,733L,768L,830L,856L,918L,959L,1021L,1056L,1129L,1162L,1236L,1281L,1347L,1393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049793Inst : IEnumerable<long>
{
public static readonly long[] Value=A049793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049793.Bytes);
public long this[int i]=>Value[i];

public static A049793Inst Instance=new A049793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049794
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,16L,25L,31L,44L,53L,66L,79L,97L,108L,130L,148L,168L,187L,214L,233L,265L,286L,315L,344L,381L,402L,442L,474L,511L,545L,590L,619L,670L,705L,751L,797L,848L,880L,940L,988L,1041L,1087L,1150L,1192L,1263L,1311L,1370L,1431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049794Inst : IEnumerable<long>
{
public static readonly long[] Value=A049794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049794.Bytes);
public long this[int i]=>Value[i];

public static A049794Inst Instance=new A049794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049795
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,14L,18L,29L,35L,49L,57L,74L,84L,105L,115L,140L,155L,180L,195L,228L,244L,278L,296L,332L,356L,397L,416L,460L,487L,534L,559L,612L,637L,691L,722L,779L,814L,872L,901L,968L,1007L,1073L,1107L,1180L,1218L,1292L,1333L,1407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049795Inst : IEnumerable<long>
{
public static readonly long[] Value=A049795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049795.Bytes);
public long this[int i]=>Value[i];

public static A049795Inst Instance=new A049795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049796
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,16L,22L,32L,39L,53L,64L,79L,91L,113L,124L,147L,166L,188L,208L,238L,256L,288L,313L,344L,371L,411L,434L,473L,509L,548L,580L,629L,657L,709L,749L,796L,837L,893L,928L,987L,1038L,1093L,1136L,1206L,1246L,1314L,1371L,1431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049796Inst : IEnumerable<long>
{
public static readonly long[] Value=A049796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049796.Bytes);
public long this[int i]=>Value[i];

public static A049796Inst Instance=new A049796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049797
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,4L,4L,4L,6L,14L,4L,14L,20L,16L,16L,30L,22L,38L,32L,30L,44L,64L,38L,50L,68L,68L,66L,92L,66L,94L,94L,96L,122L,130L,90L,124L,154L,158L,136L,174L,148L,188L,194L,172L,210L,254L,196L,228L,240L,248L,258L,308L,282L,302L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049797Inst : IEnumerable<long>
{
public static readonly long[] Value=A049797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049797.Bytes);
public long this[int i]=>Value[i];

public static A049797Inst Instance=new A049797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049798
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,2L,2L,3L,7L,2L,7L,10L,8L,8L,15L,11L,19L,16L,15L,22L,32L,19L,25L,34L,34L,33L,46L,33L,47L,47L,48L,61L,65L,45L,62L,77L,79L,68L,87L,74L,94L,97L,86L,105L,127L,98L,114L,120L,124L,129L,154L,141L,151L,142L,147L,172L,200L,151L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049798Inst : IEnumerable<long>
{
public static readonly long[] Value=A049798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049798.Bytes);
public long this[int i]=>Value[i];

public static A049798Inst Instance=new A049798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049799
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,3L,2L,9L,0L,8L,12L,12L,5L,18L,15L,29L,12L,18L,29L,48L,21L,26L,42L,54L,38L,63L,39L,65L,51L,69L,92L,87L,45L,77L,105L,129L,77L,114L,96L,134L,123L,111L,146L,189L,126L,149L,144L,180L,170L,219L,207L,209L,156L,198L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049799Inst : IEnumerable<long>
{
public static readonly long[] Value=A049799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049799.Bytes);
public long this[int i]=>Value[i];

public static A049799Inst Instance=new A049799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049800
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,2L,2L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,2L,2L,0L,0L,0L,1L,1L,2L,2L,3L,3L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,0L,0L,0L,0L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049800Inst : IEnumerable<long>
{
public static readonly long[] Value=A049800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049800.Bytes);
public long this[int i]=>Value[i];

public static A049800Inst Instance=new A049800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049801
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,2L,2L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,2L,2L,2L,2L,2L,2L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049801Inst : IEnumerable<long>
{
public static readonly long[] Value=A049801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049801.Bytes);
public long this[int i]=>Value[i];

public static A049801Inst Instance=new A049801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049802
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,4L,0L,3L,4L,7L,4L,7L,8L,11L,0L,4L,6L,10L,8L,12L,14L,18L,8L,12L,14L,18L,16L,20L,22L,26L,0L,5L,8L,13L,12L,17L,20L,25L,16L,21L,24L,29L,28L,33L,36L,41L,16L,21L,24L,29L,28L,33L,36L,41L,32L,37L,40L,45L,44L,49L,52L,57L,0L,6L,10L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049802Inst : IEnumerable<long>
{
public static readonly long[] Value=A049802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049802.Bytes);
public long this[int i]=>Value[i];

public static A049802Inst Instance=new A049802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049803
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,0L,1L,2L,0L,2L,4L,3L,5L,7L,6L,8L,10L,0L,2L,4L,3L,5L,7L,6L,8L,10L,0L,3L,6L,6L,9L,12L,12L,15L,18L,9L,12L,15L,15L,18L,21L,21L,24L,27L,18L,21L,24L,24L,27L,30L,30L,33L,36L,0L,3L,6L,6L,9L,12L,12L,15L,18L,9L,12L,15L,15L,18L,21L,21L,24L,27L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049803Inst : IEnumerable<long>
{
public static readonly long[] Value=A049803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049803.Bytes);
public long this[int i]=>Value[i];

public static A049803Inst Instance=new A049803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049804
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,2L,4L,6L,4L,6L,8L,10L,8L,10L,12L,14L,12L,14L,16L,18L,0L,2L,4L,6L,4L,6L,8L,10L,8L,10L,12L,14L,12L,14L,16L,18L,0L,2L,4L,6L,4L,6L,8L,10L,8L,10L,12L,14L,12L,14L,16L,18L,0L,3L,6L,9L,8L,11L,14L,17L,16L,19L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049804Inst : IEnumerable<long>
{
public static readonly long[] Value=A049804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049804.Bytes);
public long this[int i]=>Value[i];

public static A049804Inst Instance=new A049804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049805
{
public static readonly long[] Value={ 2L,3L,2L,5L,3L,2L,7L,4L,3L,2L,11L,6L,4L,3L,2L,13L,7L,5L,4L,3L,2L,19L,10L,7L,5L,4L,3L,2L,23L,12L,8L,6L,5L,4L,3L,2L,29L,15L,10L,8L,6L,5L,4L,3L,2L,33L,17L,12L,9L,7L,6L,5L,4L,3L,2L,43L,22L,15L,11L,9L,7L,6L,5L,4L,3L,2L,47L,24L,16L,12L,10L,8L,7L,6L,5L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049805Inst : IEnumerable<long>
{
public static readonly long[] Value=A049805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049805.Bytes);
public long this[int i]=>Value[i];

public static A049805Inst Instance=new A049805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049806
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,10L,12L,15L,17L,22L,24L,30L,33L,37L,41L,49L,52L,61L,65L,71L,76L,87L,91L,101L,107L,116L,122L,136L,140L,155L,163L,173L,181L,193L,199L,217L,226L,238L,246L,266L,272L,293L,303L,315L,326L,349L,357L,378L,388L,404L,416L,442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049806Inst : IEnumerable<long>
{
public static readonly long[] Value=A049806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049806.Bytes);
public long this[int i]=>Value[i];

public static A049806Inst Instance=new A049806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049807
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,15L,16L,20L,22L,25L,28L,33L,35L,41L,43L,47L,51L,58L,61L,68L,72L,78L,82L,91L,93L,103L,108L,115L,121L,129L,133L,145L,151L,159L,165L,178L,182L,196L,202L,210L,218L,233L,238L,252L,258L,269L,277L,294L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049807Inst : IEnumerable<long>
{
public static readonly long[] Value=A049807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049807.Bytes);
public long this[int i]=>Value[i];

public static A049807Inst Instance=new A049807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049808
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,6L,8L,9L,11L,12L,15L,17L,19L,21L,25L,26L,30L,32L,36L,39L,44L,46L,51L,54L,58L,61L,68L,70L,77L,81L,87L,91L,97L,100L,109L,114L,120L,124L,134L,136L,146L,151L,157L,163L,174L,178L,189L,194L,202L,208L,221L,226L,236L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049808Inst : IEnumerable<long>
{
public static readonly long[] Value=A049808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049808.Bytes);
public long this[int i]=>Value[i];

public static A049808Inst Instance=new A049808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049809
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,15L,17L,20L,21L,24L,26L,29L,31L,35L,36L,40L,43L,47L,50L,55L,56L,62L,65L,69L,72L,77L,80L,87L,91L,96L,99L,107L,109L,117L,121L,126L,131L,140L,143L,151L,155L,162L,167L,177L,180L,188L,193L,201L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049809Inst : IEnumerable<long>
{
public static readonly long[] Value=A049809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049809.Bytes);
public long this[int i]=>Value[i];

public static A049809Inst Instance=new A049809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049810
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,13L,14L,16L,17L,20L,22L,24L,26L,29L,30L,34L,36L,39L,41L,45L,46L,51L,54L,58L,61L,65L,67L,73L,76L,80L,82L,88L,90L,97L,101L,105L,109L,116L,119L,126L,129L,135L,139L,147L,150L,158L,162L,168L,173L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049810Inst : IEnumerable<long>
{
public static readonly long[] Value=A049810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049810.Bytes);
public long this[int i]=>Value[i];

public static A049810Inst Instance=new A049810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049811
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,14L,15L,17L,18L,20L,22L,25L,26L,29L,31L,33L,35L,39L,40L,44L,46L,49L,51L,55L,57L,62L,65L,69L,71L,76L,78L,84L,87L,90L,93L,99L,101L,107L,110L,115L,119L,126L,129L,135L,138L,144L,148L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049811Inst : IEnumerable<long>
{
public static readonly long[] Value=A049811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049811.Bytes);
public long this[int i]=>Value[i];

public static A049811Inst Instance=new A049811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049812
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,15L,16L,18L,19L,21L,22L,25L,27L,29L,31L,34L,35L,38L,40L,43L,45L,49L,50L,54L,56L,59L,61L,66L,68L,73L,76L,79L,82L,87L,89L,95L,97L,101L,104L,110L,112L,117L,120L,125L,129L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049812Inst : IEnumerable<long>
{
public static readonly long[] Value=A049812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049812.Bytes);
public long this[int i]=>Value[i];

public static A049812Inst Instance=new A049812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049813
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,16L,17L,19L,20L,22L,23L,25L,27L,30L,31L,34L,36L,38L,40L,43L,44L,48L,50L,53L,55L,59L,60L,64L,66L,69L,72L,77L,79L,84L,86L,90L,93L,98L,100L,105L,108L,112L,115L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049813Inst : IEnumerable<long>
{
public static readonly long[] Value=A049813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049813.Bytes);
public long this[int i]=>Value[i];

public static A049813Inst Instance=new A049813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049814
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,14L,15L,17L,18L,20L,21L,23L,24L,26L,27L,30L,32L,34L,36L,39L,40L,43L,45L,47L,49L,53L,54L,58L,60L,63L,65L,69L,70L,74L,76L,80L,83L,88L,90L,94L,97L,101L,104L,109L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049814Inst : IEnumerable<long>
{
public static readonly long[] Value=A049814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049814.Bytes);
public long this[int i]=>Value[i];

public static A049814Inst Instance=new A049814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049815
{
public static readonly long[] Value={ 2L,5L,10L,16L,26L,34L,50L,63L,82L,98L,127L,144L,181L,205L,237L,268L,320L,347L,407L,442L,493L,537L,613L,651L,729L,782L,855L,911L,1014L,1057L,1170L,1240L,1331L,1405L,1512L,1574L,1716L,1801L,1911L,1992L,2152L,2219L,2389L,2487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049815Inst : IEnumerable<long>
{
public static readonly long[] Value=A049815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049815.Bytes);
public long this[int i]=>Value[i];

public static A049815Inst Instance=new A049815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049816
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,2L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,2L,2L,1L,0L,0L,0L,2L,0L,3L,1L,1L,0L,0L,1L,0L,1L,2L,1L,2L,1L,0L,0L,0L,1L,1L,0L,2L,2L,1L,1L,0L,0L,1L,2L,2L,1L,2L,3L,3L,2L,1L,0L,0L,0L,0L,0L,2L,0L,3L,1L,1L,1L,1L,0L,0L,1L,1L,1L,3L,1L,2L,4L,2L,2L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049816Inst : IEnumerable<long>
{
public static readonly long[] Value=A049816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049816.Bytes);
public long this[int i]=>Value[i];

public static A049816Inst Instance=new A049816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049817
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,2L,7L,7L,8L,8L,17L,9L,20L,18L,17L,19L,30L,24L,37L,25L,30L,34L,51L,31L,44L,48L,49L,45L,68L,42L,71L,59L,64L,72L,67L,57L,88L,82L,85L,71L,106L,72L,113L,89L,88L,106L,131L,91L,116L,112L,119L,113L,152L,114L,129L,111L,136L,144L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049817Inst : IEnumerable<long>
{
public static readonly long[] Value=A049817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049817.Bytes);
public long this[int i]=>Value[i];

public static A049817Inst Instance=new A049817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049818
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,8L,15L,22L,30L,38L,55L,64L,84L,102L,119L,138L,168L,192L,229L,254L,284L,318L,369L,400L,444L,492L,541L,586L,654L,696L,767L,826L,890L,962L,1029L,1086L,1174L,1256L,1341L,1412L,1518L,1590L,1703L,1792L,1880L,1986L,2117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049818Inst : IEnumerable<long>
{
public static readonly long[] Value=A049818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049818.Bytes);
public long this[int i]=>Value[i];

public static A049818Inst Instance=new A049818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049819
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,3L,2L,2L,3L,3L,4L,3L,3L,3L,3L,4L,4L,3L,5L,3L,4L,3L,4L,4L,4L,4L,5L,5L,5L,4L,4L,6L,4L,4L,5L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,5L,6L,6L,5L,5L,5L,4L,7L,5L,5L,5L,5L,6L,5L,5L,5L,6L,6L,6L,6L,6L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049819Inst : IEnumerable<long>
{
public static readonly long[] Value=A049819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049819.Bytes);
public long this[int i]=>Value[i];

public static A049819Inst Instance=new A049819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049820
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,2L,5L,4L,6L,6L,9L,6L,11L,10L,11L,11L,15L,12L,17L,14L,17L,18L,21L,16L,22L,22L,23L,22L,27L,22L,29L,26L,29L,30L,31L,27L,35L,34L,35L,32L,39L,34L,41L,38L,39L,42L,45L,38L,46L,44L,47L,46L,51L,46L,51L,48L,53L,54L,57L,48L,59L,58L,57L,57L,61L,58L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049820Inst : IEnumerable<long>
{
public static readonly long[] Value=A049820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049820.Bytes);
public long this[int i]=>Value[i];

public static A049820Inst Instance=new A049820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049821
{
public static readonly long[] Value={ 3L,4L,5L,6L,8L,9L,12L,12L,14L,15L,15L,17L,18L,18L,20L,20L,22L,23L,23L,25L,25L,27L,28L,28L,38L,28L,29L,35L,33L,38L,35L,41L,37L,37L,39L,41L,46L,48L,43L,51L,45L,53L,48L,48L,50L,50L,58L,52L,60L,54L,56L,62L,56L,65L,59L,61L,61L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049821Inst : IEnumerable<long>
{
public static readonly long[] Value=A049821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049821.Bytes);
public long this[int i]=>Value[i];

public static A049821Inst Instance=new A049821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049822
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,2L,4L,4L,3L,4L,5L,4L,6L,5L,4L,6L,5L,6L,9L,6L,3L,6L,9L,7L,7L,8L,5L,10L,7L,6L,9L,7L,8L,11L,8L,6L,9L,10L,7L,12L,7L,8L,14L,8L,3L,10L,12L,13L,10L,11L,5L,10L,12L,12L,13L,8L,3L,14L,11L,8L,15L,11L,13L,16L,7L,9L,9L,14L,7L,14L,11L,9L,16L,12L,11L,15L,7L,14L,16L,11L,3L,18L,17L,10L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049822Inst : IEnumerable<long>
{
public static readonly long[] Value=A049822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049822.Bytes);
public long this[int i]=>Value[i];

public static A049822Inst Instance=new A049822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049823
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,1L,2L,2L,4L,1L,4L,4L,4L,4L,7L,2L,6L,5L,6L,8L,8L,5L,7L,7L,8L,7L,10L,7L,10L,9L,9L,11L,12L,6L,11L,12L,10L,10L,12L,11L,10L,15L,12L,14L,14L,10L,14L,11L,16L,14L,12L,12L,17L,16L,16L,16L,14L,14L,10L,18L,15L,16L,20L,17L,16L,18L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049823Inst : IEnumerable<long>
{
public static readonly long[] Value=A049823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049823.Bytes);
public long this[int i]=>Value[i];

public static A049823Inst Instance=new A049823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049824
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,1L,1L,2L,1L,2L,4L,2L,4L,3L,0L,4L,8L,5L,3L,5L,6L,5L,7L,3L,6L,9L,7L,8L,9L,6L,8L,12L,9L,8L,9L,7L,12L,11L,5L,12L,18L,12L,10L,9L,11L,12L,17L,16L,12L,14L,10L,18L,22L,12L,11L,16L,11L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049824Inst : IEnumerable<long>
{
public static readonly long[] Value=A049824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049824.Bytes);
public long this[int i]=>Value[i];

public static A049824Inst Instance=new A049824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049825
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,2L,0L,1L,0L,2L,0L,3L,3L,2L,2L,3L,1L,4L,2L,4L,2L,2L,4L,6L,4L,6L,3L,7L,3L,10L,2L,5L,6L,6L,5L,6L,7L,6L,7L,13L,8L,6L,5L,9L,10L,14L,3L,19L,10L,11L,8L,8L,7L,14L,8L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049825Inst : IEnumerable<long>
{
public static readonly long[] Value=A049825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049825.Bytes);
public long this[int i]=>Value[i];

public static A049825Inst Instance=new A049825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049826
{
public static readonly long[] Value={ 0L,1L,3L,4L,8L,7L,13L,14L,16L,17L,27L,20L,32L,31L,31L,34L,46L,41L,55L,44L,50L,55L,73L,54L,68L,73L,75L,72L,96L,71L,101L,90L,96L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049826Inst : IEnumerable<long>
{
public static readonly long[] Value=A049826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049826.Bytes);
public long this[int i]=>Value[i];

public static A049826Inst Instance=new A049826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049827
{
public static readonly long[] Value={ 0L,1L,3L,6L,8L,13L,13L,20L,22L,25L,27L,38L,32L,45L,45L,46L,50L,63L,59L,74L,64L,71L,77L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049827Inst : IEnumerable<long>
{
public static readonly long[] Value=A049827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049827.Bytes);
public long this[int i]=>Value[i];

public static A049827Inst Instance=new A049827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049828
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,3L,1L,0L,0L,0L,0L,2L,1L,0L,0L,1L,1L,4L,3L,1L,0L,0L,0L,3L,0L,6L,2L,1L,0L,0L,1L,0L,1L,5L,3L,3L,1L,0L,0L,0L,1L,2L,0L,6L,4L,2L,1L,0L,0L,1L,3L,4L,1L,6L,8L,6L,3L,1L,0L,0L,0L,0L,0L,3L,0L,8L,4L,3L,2L,1L,0L,0L,1L,1L,1L,6L,1L,7L,11L,5L,4L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049828Inst : IEnumerable<long>
{
public static readonly long[] Value=A049828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049828.Bytes);
public long this[int i]=>Value[i];

public static A049828Inst Instance=new A049828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049829
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,3L,10L,12L,14L,16L,33L,21L,41L,45L,46L,50L,74L,72L,99L,83L,97L,111L,158L,120L,148L,176L,181L,185L,243L,191L,262L,254L,282L,314L,313L,293L,363L,391L,418L,386L,480L,414L,529L,497L,501L,573L,660L,570L,626L,672L,699L,703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049829Inst : IEnumerable<long>
{
public static readonly long[] Value=A049829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049829.Bytes);
public long this[int i]=>Value[i];

public static A049829Inst Instance=new A049829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049830
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,10L,20L,32L,46L,62L,95L,116L,157L,202L,248L,298L,372L,444L,543L,626L,723L,834L,992L,1112L,1260L,1436L,1617L,1802L,2045L,2236L,2498L,2752L,3034L,3348L,3661L,3954L,4317L,4708L,5126L,5512L,5992L,6406L,6935L,7432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049830Inst : IEnumerable<long>
{
public static readonly long[] Value=A049830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049830.Bytes);
public long this[int i]=>Value[i];

public static A049830Inst Instance=new A049830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049831
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,2L,4L,6L,5L,6L,8L,8L,11L,10L,9L,12L,12L,15L,15L,14L,19L,16L,19L,18L,19L,22L,21L,23L,26L,25L,27L,24L,27L,32L,27L,30L,33L,31L,33L,30L,35L,38L,35L,38L,40L,38L,44L,39L,44L,46L,43L,44L,47L,45L,53L,46L,49L,52L,50L,56L,54L,54L,57L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049831Inst : IEnumerable<long>
{
public static readonly long[] Value=A049831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049831.Bytes);
public long this[int i]=>Value[i];

public static A049831Inst Instance=new A049831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049832
{
public static readonly long[] Value={ 0L,1L,4L,7L,15L,18L,31L,40L,50L,61L,88L,87L,119L,136L,151L,170L,210L,225L,270L,273L,307L,342L,411L,396L,448L,501L,532L,563L,649L,626L,727L,750L,810L,875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049832Inst : IEnumerable<long>
{
public static readonly long[] Value=A049832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049832.Bytes);
public long this[int i]=>Value[i];

public static A049832Inst Instance=new A049832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049833
{
public static readonly long[] Value={ 0L,1L,5L,13L,23L,40L,54L,80L,104L,131L,161L,209L,231L,288L,332L,376L,426L,499L,549L,631L,673L,748L,826L,940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049833Inst : IEnumerable<long>
{
public static readonly long[] Value=A049833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049833.Bytes);
public long this[int i]=>Value[i];

public static A049833Inst Instance=new A049833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049834
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,2L,4L,1L,5L,4L,4L,5L,1L,6L,3L,2L,3L,6L,1L,7L,5L,5L,5L,5L,7L,1L,8L,4L,5L,2L,5L,4L,8L,1L,9L,6L,3L,6L,6L,3L,6L,9L,1L,10L,5L,6L,4L,2L,4L,6L,5L,10L,1L,11L,7L,6L,6L,7L,7L,6L,6L,7L,11L,1L,12L,6L,4L,3L,6L,2L,6L,3L,4L,6L,12L,1L,13L,8L,7L,7L,6L,8L,8L,6L,7L,7L,8L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049834Inst : IEnumerable<long>
{
public static readonly long[] Value=A049834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049834.Bytes);
public long this[int i]=>Value[i];

public static A049834Inst Instance=new A049834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049835
{
public static readonly long[] Value={ 1L,3L,7L,11L,19L,21L,35L,37L,49L,53L,75L,65L,99L,93L,105L,115L,151L,127L,179L,153L,181L,193L,239L,191L,257L,249L,271L,261L,339L,263L,375L,329L,361L,373L,401L,351L,487L,441L,461L,427L,563L,443L,603L,517L,535L,585L,683L,533L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049835Inst : IEnumerable<long>
{
public static readonly long[] Value=A049835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049835.Bytes);
public long this[int i]=>Value[i];

public static A049835Inst Instance=new A049835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049836
{
public static readonly long[] Value={ 1L,4L,11L,22L,41L,62L,97L,134L,183L,236L,311L,376L,475L,568L,673L,788L,939L,1066L,1245L,1398L,1579L,1772L,2011L,2202L,2459L,2708L,2979L,3240L,3579L,3842L,4217L,4546L,4907L,5280L,5681L,6032L,6519L,6960L,7421L,7848L,8411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049836Inst : IEnumerable<long>
{
public static readonly long[] Value=A049836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049836.Bytes);
public long this[int i]=>Value[i];

public static A049836Inst Instance=new A049836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049837
{
public static readonly long[] Value={ 2L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,4L,5L,4L,3L,3L,4L,4L,5L,4L,3L,3L,5L,5L,5L,5L,4L,3L,3L,4L,5L,4L,6L,6L,4L,3L,3L,5L,3L,5L,5L,6L,6L,4L,3L,3L,4L,4L,4L,4L,6L,6L,6L,4L,3L,3L,5L,5L,6L,5L,5L,6L,6L,6L,4L,3L,3L,4L,4L,4L,5L,4L,6L,6L,5L,6L,4L,3L,3L,5L,5L,5L,6L,5L,5L,7L,6L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049837Inst : IEnumerable<long>
{
public static readonly long[] Value=A049837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049837.Bytes);
public long this[int i]=>Value[i];

public static A049837Inst Instance=new A049837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049838
{
public static readonly long[] Value={ 2L,6L,10L,13L,19L,23L,30L,35L,40L,44L,54L,54L,65L,71L,75L,81L,91L,94L,103L,105L,110L,124L,134L,129L,138L,153L,156L,162L,174L,168L,188L,191L,199L,210L,209L,206L,232L,245L,244L,239L,259L,259L,280L,280L,279L,304L,315L,298L,309L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049838Inst : IEnumerable<long>
{
public static readonly long[] Value=A049838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049838.Bytes);
public long this[int i]=>Value[i];

public static A049838Inst Instance=new A049838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049839
{
public static readonly long[] Value={ 2L,3L,4L,4L,5L,5L,5L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,8L,9L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,9L,9L,10L,9L,9L,9L,9L,10L,9L,10L,10L,10L,10L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049839Inst : IEnumerable<long>
{
public static readonly long[] Value=A049839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049839.Bytes);
public long this[int i]=>Value[i];

public static A049839Inst Instance=new A049839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049840
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,4L,7L,4L,5L,7L,10L,9L,5L,6L,6L,6L,10L,11L,6L,7L,9L,10L,14L,14L,13L,7L,8L,8L,13L,8L,18L,14L,15L,8L,9L,11L,9L,13L,18L,15L,18L,17L,9L,10L,10L,13L,14L,10L,20L,20L,18L,19L,10L,11L,13L,16L,18L,16L,22L,25L,24L,22L,21L,11L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049840Inst : IEnumerable<long>
{
public static readonly long[] Value=A049840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049840.Bytes);
public long this[int i]=>Value[i];

public static A049840Inst Instance=new A049840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049841
{
public static readonly long[] Value={ 1L,4L,11L,19L,36L,45L,74L,92L,119L,144L,199L,203L,276L,307L,346L,394L,483L,504L,613L,621L,704L,785L,918L,896L,1033L,1128L,1207L,1271L,1462L,1421L,1658L,1694L,1827L,1966L,2051L,2087L,2362L,2465L,2594L,2626L,2941L,2886L,3239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049841Inst : IEnumerable<long>
{
public static readonly long[] Value=A049841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049841.Bytes);
public long this[int i]=>Value[i];

public static A049841Inst Instance=new A049841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049842
{
public static readonly long[] Value={ 1L,2L,5L,7L,10L,11L,14L,18L,18L,20L,25L,26L,31L,32L,33L,36L,39L,43L,45L,46L,52L,50L,55L,54L,59L,62L,64L,67L,72L,73L,76L,74L,79L,86L,83L,86L,92L,91L,94L,94L,100L,104L,103L,108L,112L,111L,119L,115L,122L,126L,124L,127L,132L,129L,141L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049842Inst : IEnumerable<long>
{
public static readonly long[] Value=A049842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049842.Bytes);
public long this[int i]=>Value[i];

public static A049842Inst Instance=new A049842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049843
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,2L,1L,3L,1L,1L,3L,2L,2L,1L,2L,2L,2L,3L,2L,1L,1L,2L,3L,4L,2L,2L,1L,2L,3L,2L,1L,3L,3L,3L,1L,2L,2L,1L,4L,2L,4L,3L,3L,1L,1L,1L,2L,3L,4L,4L,5L,3L,2L,1L,1L,2L,2L,3L,3L,3L,2L,5L,5L,2L,1L,2L,1L,2L,4L,2L,3L,2L,5L,4L,2L,2L,1L,1L,3L,1L,2L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049843Inst : IEnumerable<long>
{
public static readonly long[] Value=A049843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049843.Bytes);
public long this[int i]=>Value[i];

public static A049843Inst Instance=new A049843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A049844
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,12L,15L,18L,22L,26L,29L,30L,31L,41L,43L,44L,51L,53L,52L,62L,63L,70L,67L,81L,86L,84L,93L,96L,99L,102L,109L,111L,118L,119L,129L,129L,141L,149L,153L,150L,149L,163L,166L,162L,167L,177L,176L,189L,192L,199L,204L,198L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A049844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A049844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A049844Inst : IEnumerable<long>
{
public static readonly long[] Value=A049844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A049844.Bytes);
public long this[int i]=>Value[i];

public static A049844Inst Instance=new A049844Inst();

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