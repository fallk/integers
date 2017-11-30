using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A154764
{
public static readonly long[] Value={ 3L,5L,7L,23L,29L,41L,43L,47L,61L,67L,83L,89L,223L,227L,229L,241L,263L,269L,281L,283L,401L,409L,421L,443L,449L,461L,463L,467L,487L,601L,607L,641L,643L,647L,661L,683L,809L,821L,823L,827L,829L,863L,881L,883L,887L,2003L,2027L,2029L,2063L,2069L,2081L,2083L,2087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154764Inst : IEnumerable<long>
{
public static readonly long[] Value=A154764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154764.Bytes);
public long this[int i]=>Value[i];

public static A154764Inst Instance=new A154764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154765
{
public static readonly long[] Value={ 2L,11L,19L,29L,43L,47L,67L,83L,103L,107L,163L,167L,191L,199L,211L,229L,263L,283L,349L,389L,431L,439L,479L,509L,541L,569L,613L,617L,631L,659L,701L,709L,761L,769L,823L,827L,839L,859L,907L,911L,919L,929L,947L,967L,983L,991L,1013L,1031L,1039L,1051L,1093L,1097L,1103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154765Inst : IEnumerable<long>
{
public static readonly long[] Value=A154765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154765.Bytes);
public long this[int i]=>Value[i];

public static A154765Inst Instance=new A154765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154766
{
public static readonly long[] Value={ 1L,9L,10L,13L,14L,15L,18L,19L,23L,24L,26L,27L,28L,29L,31L,35L,38L,39L,42L,47L,51L,52L,54L,55L,58L,59L,62L,63L,69L,70L,73L,76L,77L,81L,83L,84L,85L,88L,92L,94L,95L,96L,97L,98L,99L,100L,101L,103L,104L,107L,112L,113L,114L,115L,119L,120L,122L,123L,125L,126L,127L,129L,132L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154766Inst : IEnumerable<long>
{
public static readonly long[] Value=A154766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154766.Bytes);
public long this[int i]=>Value[i];

public static A154766Inst Instance=new A154766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154767
{
public static readonly long[] Value={ 2L,41L,43L,61L,83L,163L,181L,211L,241L,263L,281L,283L,383L,401L,421L,431L,433L,443L,461L,463L,487L,563L,587L,601L,613L,631L,641L,643L,653L,661L,683L,787L,811L,821L,823L,827L,853L,857L,863L,877L,881L,883L,887L,1021L,1061L,1063L,1087L,1163L,1181L,1187L,1201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154767Inst : IEnumerable<long>
{
public static readonly long[] Value=A154767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154767.Bytes);
public long this[int i]=>Value[i];

public static A154767Inst Instance=new A154767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154768
{
public static readonly long[] Value={ 1L,56L,61L,78L,91L,93L,110L,143L,144L,172L,178L,179L,181L,197L,252L,279L,305L,311L,313L,314L,315L,323L,324L,326L,334L,340L,354L,360L,382L,386L,289L,390L,408L,409L,411L,412L,413L,415L,418L,436L,438L,441L,507L,531L,551L,552L,554L,556L,575L,582L,588L,602L,623L,643L,647L,653L,679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154768Inst : IEnumerable<long>
{
public static readonly long[] Value=A154768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154768.Bytes);
public long this[int i]=>Value[i];

public static A154768Inst Instance=new A154768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154769
{
public static readonly BigInteger[] Value={ 1234567891L,BigInteger.Parse("1234567891234567891234567891"),BigInteger.Parse("1234567891234567891234567891234567891234567891234567891234567891234567") };
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
public class A154769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154769Inst Instance=new A154769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154770
{
public static readonly long[] Value={ 10L,11L,12L,15L,21L,24L,30L,33L,36L,45L,54L,63L,72L,81L,90L,99L,108L,127L,176L,283L,407L,458L,578L,733L,849L,1003L,1117L,1381L,2044L,2318L,2953L,4397L,5435L,6557L,7964L,9989L,12279L,16572L,26426L,36970L,49970L,67738L,84716L,100181L,111599L,139413L,209606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154770Inst : IEnumerable<long>
{
public static readonly long[] Value=A154770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154770.Bytes);
public long this[int i]=>Value[i];

public static A154770Inst Instance=new A154770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154771
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,15L,17L,19L,21L,23L,25L,27L,29L,22L,24L,24L,28L,30L,32L,34L,36L,38L,40L,33L,35L,37L,36L,41L,43L,45L,47L,49L,51L,44L,46L,48L,50L,48L,54L,56L,58L,60L,62L,55L,57L,59L,61L,63L,60L,67L,69L,71L,73L,66L,68L,70L,72L,74L,76L,72L,80L,82L,84L,77L,79L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154771Inst : IEnumerable<long>
{
public static readonly long[] Value=A154771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154771.Bytes);
public long this[int i]=>Value[i];

public static A154771Inst Instance=new A154771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154772
{
public static readonly long[] Value={ 1L,3L,7L,14L,22L,29L,41L,46L,62L,64L,67L,88L,167L,179L,207L,231L,239L,249L,263L,266L,286L,290L,309L,315L,322L,323L,326L,344L,350L,353L,354L,372L,392L,421L,444L,454L,458L,496L,505L,553L,560L,561L,571L,585L,613L,636L,647L,661L,669L,682L,745L,788L,790L,791L,815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154772Inst : IEnumerable<long>
{
public static readonly long[] Value=A154772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154772.Bytes);
public long this[int i]=>Value[i];

public static A154772Inst Instance=new A154772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154773
{
public static readonly long[] Value={ 3L,5L,11L,14L,18L,20L,26L,27L,28L,29L,31L,38L,42L,52L,58L,64L,73L,82L,85L,90L,110L,125L,138L,156L,167L,180L,212L,234L,248L,297L,299L,303L,305L,308L,312L,314L,317L,319L,334L,336L,348L,361L,365L,371L,372L,377L,379L,414L,451L,465L,478L,499L,508L,509L,535L,554L,564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154773Inst : IEnumerable<long>
{
public static readonly long[] Value=A154773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154773.Bytes);
public long this[int i]=>Value[i];

public static A154773Inst Instance=new A154773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154774
{
public static readonly long[] Value={ 10L,14L,15L,25L,60L,74L,76L,87L,127L,129L,130L,140L,171L,196L,207L,224L,259L,263L,302L,314L,315L,319L,333L,337L,377L,389L,451L,454L,470L,491L,508L,518L,549L,568L,574L,589L,592L,624L,629L,636L,690L,696L,729L,748L,753L,769L,770L,771L,781L,791L,802L,833L,844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154774Inst : IEnumerable<long>
{
public static readonly long[] Value=A154774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154774.Bytes);
public long this[int i]=>Value[i];

public static A154774Inst Instance=new A154774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154775
{
public static readonly long[] Value={ 2L,4L,5L,42L,46L,49L,59L,82L,84L,100L,119L,128L,137L,182L,185L,187L,192L,233L,264L,301L,303L,340L,376L,390L,395L,422L,438L,446L,471L,472L,494L,518L,527L,570L,598L,609L,611L,633L,667L,688L,714L,716L,726L,728L,733L,744L,831L,837L,865L,875L,896L,926L,940L,948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154775Inst : IEnumerable<long>
{
public static readonly long[] Value=A154775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154775.Bytes);
public long this[int i]=>Value[i];

public static A154775Inst Instance=new A154775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154776
{
public static readonly long[] Value={ 1L,5L,4L,7L,4L,1L,1L,2L,2L,8L,9L,3L,8L,1L,6L,6L,3L,4L,7L,4L,8L,0L,9L,8L,4L,5L,5L,3L,8L,7L,1L,2L,8L,3L,5L,0L,5L,8L,6L,0L,5L,6L,7L,4L,3L,7L,8L,2L,8L,4L,1L,3L,7L,1L,3L,5L,5L,7L,9L,7L,9L,7L,1L,5L,3L,0L,6L,5L,6L,8L,0L,7L,4L,1L,6L,2L,8L,9L,1L,2L,1L,5L,3L,2L,6L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154776Inst : IEnumerable<long>
{
public static readonly long[] Value=A154776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154776.Bytes);
public long this[int i]=>Value[i];

public static A154776Inst Instance=new A154776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154777
{
public static readonly long[] Value={ 3L,6L,9L,11L,12L,17L,18L,19L,22L,24L,27L,33L,34L,36L,38L,41L,43L,44L,48L,51L,54L,57L,59L,66L,67L,68L,72L,73L,75L,76L,81L,82L,83L,86L,88L,89L,96L,97L,99L,102L,107L,108L,113L,114L,118L,121L,123L,129L,131L,132L,134L,136L,137L,139L,144L,146L,147L,150L,152L,153L,162L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154777Inst : IEnumerable<long>
{
public static readonly long[] Value=A154777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154777.Bytes);
public long this[int i]=>Value[i];

public static A154777Inst Instance=new A154777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154778
{
public static readonly long[] Value={ 6L,9L,14L,21L,24L,29L,30L,36L,41L,45L,46L,49L,54L,56L,61L,69L,70L,81L,84L,86L,89L,94L,96L,101L,105L,109L,116L,120L,126L,129L,134L,141L,144L,145L,149L,150L,161L,164L,166L,174L,180L,181L,184L,189L,196L,201L,205L,206L,214L,216L,224L,225L,229L,230L,241L,244L,245L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154778Inst : IEnumerable<long>
{
public static readonly long[] Value=A154778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154778.Bytes);
public long this[int i]=>Value[i];

public static A154778Inst Instance=new A154778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154779
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,6L,12L,17L,34L,55L,98L,161L,288L,448L,811L,1265L,2145L,3425L,5860L,9305L,15384L,24690L,40445L,64715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154779Inst : IEnumerable<long>
{
public static readonly long[] Value=A154779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154779.Bytes);
public long this[int i]=>Value[i];

public static A154779Inst Instance=new A154779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154780
{
public static readonly long[] Value={ 5L,35L,235L,335L,2335L,3335L,23335L,32335L,33335L,72335L,233335L,323335L,333335L,372335L,572335L,723335L,2333335L,2372335L,2723335L,3233335L,3323335L,3333335L,3572335L,3723335L,7233335L,7323335L,7372335L,7572335L,22372335L,23333335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154780Inst : IEnumerable<long>
{
public static readonly long[] Value=A154780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154780.Bytes);
public long this[int i]=>Value[i];

public static A154780Inst Instance=new A154780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154781
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,2L,5L,6L,7L,8L,9L,10L,11L,3L,4L,5L,3L,7L,8L,9L,10L,11L,12L,4L,5L,6L,7L,4L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,5L,11L,12L,13L,14L,6L,7L,8L,9L,10L,11L,6L,13L,14L,15L,7L,8L,9L,10L,11L,12L,13L,7L,15L,16L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154781Inst : IEnumerable<long>
{
public static readonly long[] Value=A154781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154781.Bytes);
public long this[int i]=>Value[i];

public static A154781Inst Instance=new A154781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154782
{
public static readonly long[] Value={ 0L,0L,1L,-1L,0L,-1L,-1L,1L,2L,0L,-1L,-1L,-1L,-1L,1L,-1L,0L,2L,3L,-1L,-1L,-1L,-1L,1L,-1L,0L,-1L,-1L,2L,-1L,-1L,3L,4L,-1L,1L,-1L,0L,-1L,-1L,-1L,-1L,2L,-1L,-1L,-1L,-1L,3L,1L,-1L,0L,5L,-1L,-1L,-1L,-1L,-1L,2L,-1L,-1L,-1L,-1L,-1L,1L,3L,0L,-1L,-1L,-1L,4L,-1L,-1L,5L,6L,2L,-1L,-1L,-1L,-1L,-1L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154782Inst : IEnumerable<long>
{
public static readonly long[] Value=A154782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154782.Bytes);
public long this[int i]=>Value[i];

public static A154782Inst Instance=new A154782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154783
{
public static readonly long[] Value={ 1L,6L,9L,20L,15L,30L,35L,40L,63L,70L,55L,108L,65L,70L,135L,112L,119L,162L,95L,140L,231L,198L,161L,312L,225L,182L,351L,196L,203L,450L,217L,352L,429L,238L,385L,540L,407L,418L,585L,440L,369L,798L,387L,396L,945L,414L,423L,720L,441L,650L,969L,676L,583L,1026L,825L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154783Inst : IEnumerable<long>
{
public static readonly long[] Value=A154783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154783.Bytes);
public long this[int i]=>Value[i];

public static A154783Inst Instance=new A154783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154784
{
public static readonly long[] Value={ 0L,4L,6L,16L,10L,24L,28L,32L,54L,60L,44L,96L,52L,56L,120L,96L,102L,144L,76L,120L,210L,176L,138L,288L,200L,156L,324L,168L,174L,420L,186L,320L,396L,204L,350L,504L,370L,380L,546L,400L,328L,756L,344L,352L,900L,368L,376L,672L,392L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154784Inst : IEnumerable<long>
{
public static readonly long[] Value=A154784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154784.Bytes);
public long this[int i]=>Value[i];

public static A154784Inst Instance=new A154784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154785
{
public static readonly long[] Value={ 1L,2L,3L,12L,15L,18L,21L,40L,45L,50L,55L,84L,65L,70L,105L,80L,119L,162L,57L,140L,189L,154L,161L,264L,225L,182L,297L,196L,203L,390L,155L,352L,429L,170L,385L,468L,333L,418L,585L,360L,369L,714L,387L,396L,855L,414L,423L,720L,343L,650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154785Inst : IEnumerable<long>
{
public static readonly long[] Value=A154785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154785.Bytes);
public long this[int i]=>Value[i];

public static A154785Inst Instance=new A154785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154786
{
public static readonly long[] Value={ 0L,0L,0L,8L,10L,12L,14L,32L,36L,40L,44L,72L,52L,56L,90L,64L,102L,144L,38L,120L,168L,132L,138L,240L,200L,156L,270L,168L,174L,360L,124L,320L,396L,136L,350L,432L,296L,380L,546L,320L,328L,672L,344L,352L,810L,368L,376L,672L,294L,600L,816L,520L,530L,864L,660L,784L,1140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154786Inst : IEnumerable<long>
{
public static readonly long[] Value=A154786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154786.Bytes);
public long this[int i]=>Value[i];

public static A154786Inst Instance=new A154786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154787
{
public static readonly long[] Value={ 0L,0L,0L,4L,5L,6L,7L,16L,18L,20L,22L,36L,26L,28L,45L,32L,51L,72L,19L,60L,84L,66L,69L,120L,100L,78L,135L,84L,87L,180L,62L,160L,198L,68L,175L,216L,148L,190L,273L,160L,164L,336L,172L,176L,405L,184L,188L,336L,147L,300L,408L,260L,265L,432L,330L,392L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154787Inst : IEnumerable<long>
{
public static readonly long[] Value=A154787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154787.Bytes);
public long this[int i]=>Value[i];

public static A154787Inst Instance=new A154787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154788
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,12L,24L,40L,48L,56L,128L,144L,192L,256L,384L,480L,576L,768L,1536L,4608L,6144L,6912L,15360L,36864L,294912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154788Inst : IEnumerable<long>
{
public static readonly long[] Value=A154788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154788.Bytes);
public long this[int i]=>Value[i];

public static A154788Inst Instance=new A154788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154789
{
public static readonly long[] Value={ 1L,2L,7L,9L,15L,19L,21L,39L,59L,66L,75L,96L,124L,125L,180L,327L,358L,434L,699L,999L,1685L,1779L,3561L,4184L,4835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154789Inst : IEnumerable<long>
{
public static readonly long[] Value=A154789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154789.Bytes);
public long this[int i]=>Value[i];

public static A154789Inst Instance=new A154789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154790
{
public static readonly BigInteger[] Value={ 1L,2L,15L,30L,176L,490L,792L,31185L,831820L,2323520L,8118264L,118114304L,2841940500L,3163127352L,684957390936L,60105349839666544L,471314064268398780L,BigInteger.Parse("52527070729108240605"),BigInteger.Parse("57601805366500810491219000") };
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
public class A154790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154790Inst Instance=new A154790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154791
{
public static readonly long[] Value={ 0L,1L,3L,1L,0L,5L,1L,3L,5L,7L,0L,3L,0L,7L,0L,1L,0L,5L,7L,0L,11L,1L,3L,0L,0L,0L,11L,13L,0L,3L,5L,0L,0L,11L,13L,0L,1L,0L,5L,7L,0L,11L,13L,0L,17L,1L,3L,0L,7L,0L,0L,13L,0L,17L,19L,0L,3L,5L,0L,0L,0L,0L,0L,17L,19L,0L,1L,0L,5L,7L,0L,11L,13L,0L,17L,19L,0L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154791Inst : IEnumerable<long>
{
public static readonly long[] Value=A154791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154791.Bytes);
public long this[int i]=>Value[i];

public static A154791Inst Instance=new A154791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154792
{
public static readonly long[] Value={ 0L,1L,3L,1L,0L,5L,0L,3L,5L,0L,0L,3L,0L,7L,0L,0L,0L,5L,7L,0L,0L,0L,3L,0L,0L,0L,11L,0L,0L,0L,5L,0L,0L,11L,0L,0L,0L,0L,0L,7L,0L,11L,0L,0L,0L,0L,0L,0L,7L,0L,0L,13L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154792Inst : IEnumerable<long>
{
public static readonly long[] Value=A154792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154792.Bytes);
public long this[int i]=>Value[i];

public static A154792Inst Instance=new A154792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154793
{
public static readonly long[] Value={ 1L,4L,2L,4L,8L,2L,8L,7L,4L,8L,4L,3L,2L,0L,8L,8L,7L,0L,6L,0L,5L,6L,7L,0L,8L,3L,1L,2L,0L,0L,5L,1L,6L,2L,1L,1L,7L,1L,9L,1L,0L,2L,8L,6L,5L,1L,0L,9L,1L,2L,5L,4L,8L,0L,0L,1L,5L,8L,3L,0L,5L,8L,3L,1L,1L,6L,3L,4L,7L,0L,3L,2L,1L,4L,3L,7L,0L,3L,7L,3L,7L,8L,6L,5L,5L,4L,9L,6L,2L,6L,2L,1L,9L,9L,0L,9L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154793Inst : IEnumerable<long>
{
public static readonly long[] Value=A154793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154793.Bytes);
public long this[int i]=>Value[i];

public static A154793Inst Instance=new A154793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154794
{
public static readonly long[] Value={ 1L,2L,0L,4L,1L,1L,9L,9L,8L,2L,6L,5L,5L,9L,2L,4L,7L,8L,0L,8L,5L,4L,9L,5L,5L,5L,7L,8L,8L,9L,7L,9L,7L,2L,1L,0L,7L,0L,7L,2L,7L,5L,9L,5L,2L,5L,8L,4L,8L,4L,3L,4L,1L,6L,5L,2L,4L,1L,7L,0L,9L,8L,4L,4L,5L,0L,8L,4L,3L,2L,7L,5L,7L,0L,9L,7L,6L,9L,8L,0L,3L,7L,9L,4L,7L,7L,0L,9L,0L,0L,8L,4L,7L,2L,7L,4L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154794Inst : IEnumerable<long>
{
public static readonly long[] Value=A154794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154794.Bytes);
public long this[int i]=>Value[i];

public static A154794Inst Instance=new A154794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154795
{
public static readonly long[] Value={ 1L,3L,7L,15L,101L,297L,1255L,4565L,10143L,14883L,21637L,31185L,44583L,63261L,173525L,239943L,329931L,1121505L,1505499L,2679689L,3554345L,4697205L,6185689L,10619863L,18004327L,23338469L,30167357L,38887673L,49995925L,64112359L,82010177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154795Inst : IEnumerable<long>
{
public static readonly long[] Value=A154795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154795.Bytes);
public long this[int i]=>Value[i];

public static A154795Inst Instance=new A154795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154796
{
public static readonly long[] Value={ 30L,56L,176L,490L,792L,1958L,3010L,6842L,89134L,124754L,451276L,614154L,831820L,2012558L,8118264L,13848650L,133230930L,214481126L,271248950L,541946240L,851376628L,1327710076L,3163127352L,4835271870L,5964539504L,7346629512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154796Inst : IEnumerable<long>
{
public static readonly long[] Value=A154796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154796.Bytes);
public long this[int i]=>Value[i];

public static A154796Inst Instance=new A154796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154797
{
public static readonly long[] Value={ 1L,5L,11L,77L,135L,231L,385L,627L,1575L,8349L,17977L,26015L,75175L,147273L,281589L,386155L,526823L,966467L,3087735L,5392783L,9289091L,20506255L,44108109L,56634173L,72533807L,241265379L,304801365L,952050665L,1482074143L,6620830889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154797Inst : IEnumerable<long>
{
public static readonly long[] Value=A154797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154797.Bytes);
public long this[int i]=>Value[i];

public static A154797Inst Instance=new A154797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154798
{
public static readonly long[] Value={ 2L,22L,42L,1002L,2436L,3718L,5604L,12310L,37338L,53174L,105558L,204226L,715220L,1300156L,1741630L,2323520L,4087968L,7089500L,12132164L,15796476L,26543660L,34262962L,92669720L,118114304L,150198136L,190569292L,384276336L,483502844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154798Inst : IEnumerable<long>
{
public static readonly long[] Value=A154798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154798.Bytes);
public long this[int i]=>Value[i];

public static A154798Inst Instance=new A154798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154799
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,19L,20L,21L,24L,28L,31L,33L,41L,42L,44L,52L,58L,69L,73L,76L,83L,92L,98L,115L,129L,138L,139L,154L,164L,165L,166L,172L,190L,198L,218L,223L,241L,268L,274L,292L,304L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154799Inst : IEnumerable<long>
{
public static readonly long[] Value=A154799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154799.Bytes);
public long this[int i]=>Value[i];

public static A154799Inst Instance=new A154799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154800
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,3L,5L,3L,7L,5L,7L,3L,11L,5L,11L,7L,11L,7L,13L,5L,17L,11L,13L,7L,19L,11L,17L,13L,17L,13L,19L,11L,23L,17L,19L,7L,31L,17L,23L,19L,23L,13L,31L,17L,29L,19L,29L,19L,31L,23L,29L,23L,31L,19L,37L,17L,41L,29L,31L,19L,43L,23L,41L,29L,37L,31L,37L,29L,41L,31L,41L,31L,43L,29L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154800Inst : IEnumerable<long>
{
public static readonly long[] Value=A154800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154800.Bytes);
public long this[int i]=>Value[i];

public static A154800Inst Instance=new A154800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154801
{
public static readonly long[] Value={ 1L,1L,5L,6L,2L,5L,9L,3L,0L,5L,2L,7L,1L,5L,5L,1L,4L,3L,7L,0L,6L,4L,8L,4L,4L,0L,3L,0L,8L,0L,1L,0L,5L,4L,2L,6L,4L,7L,6L,5L,1L,7L,8L,4L,6L,3L,9L,4L,2L,7L,8L,4L,0L,1L,4L,5L,0L,5L,3L,6L,6L,2L,7L,1L,1L,9L,4L,1L,2L,6L,3L,3L,4L,2L,2L,7L,6L,6L,3L,0L,8L,7L,7L,3L,1L,9L,0L,8L,3L,6L,6L,1L,5L,6L,7L,9L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154801Inst : IEnumerable<long>
{
public static readonly long[] Value=A154801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154801.Bytes);
public long this[int i]=>Value[i];

public static A154801Inst Instance=new A154801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154802
{
public static readonly long[] Value={ 1L,1L,1L,5L,7L,7L,1L,7L,8L,2L,6L,0L,4L,5L,1L,9L,3L,7L,2L,7L,6L,4L,1L,7L,6L,3L,2L,4L,1L,5L,1L,5L,4L,2L,4L,1L,2L,4L,1L,9L,1L,7L,7L,3L,5L,0L,3L,8L,5L,8L,9L,2L,2L,7L,1L,8L,9L,0L,7L,8L,4L,0L,1L,3L,6L,3L,3L,1L,0L,6L,0L,2L,0L,9L,6L,1L,8L,7L,0L,2L,3L,6L,3L,2L,2L,7L,8L,8L,8L,6L,9L,4L,0L,1L,4L,5L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154802Inst : IEnumerable<long>
{
public static readonly long[] Value=A154802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154802.Bytes);
public long this[int i]=>Value[i];

public static A154802Inst Instance=new A154802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154803
{
public static readonly long[] Value={ 1L,0L,8L,0L,9L,5L,2L,6L,1L,7L,7L,0L,9L,2L,7L,8L,9L,6L,5L,1L,7L,6L,4L,3L,2L,0L,1L,3L,8L,0L,2L,5L,6L,9L,1L,7L,7L,5L,9L,4L,5L,7L,6L,8L,0L,9L,2L,5L,4L,7L,2L,4L,5L,9L,7L,6L,1L,1L,1L,2L,9L,9L,2L,2L,6L,9L,4L,7L,0L,2L,7L,7L,4L,9L,3L,7L,8L,1L,2L,4L,8L,1L,2L,1L,2L,3L,3L,1L,5L,9L,7L,5L,0L,0L,5L,0L,8L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154803Inst : IEnumerable<long>
{
public static readonly long[] Value=A154803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154803.Bytes);
public long this[int i]=>Value[i];

public static A154803Inst Instance=new A154803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154804
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,2L,3L,3L,2L,4L,2L,2L,4L,3L,3L,4L,2L,3L,5L,4L,3L,6L,4L,3L,6L,3L,3L,7L,3L,5L,6L,3L,5L,7L,5L,5L,7L,5L,4L,9L,4L,4L,10L,4L,4L,7L,4L,6L,9L,6L,5L,9L,7L,7L,11L,6L,5L,12L,3L,5L,10L,4L,7L,10L,5L,5L,9L,8L,7L,11L,5L,5L,13L,5L,8L,11L,5L,8L,10L,6L,5L,14L,9L,6L,12L,7L,6L,15L,7L,8L,13L,5L,8L,12L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154804Inst : IEnumerable<long>
{
public static readonly long[] Value=A154804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154804.Bytes);
public long this[int i]=>Value[i];

public static A154804Inst Instance=new A154804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154805
{
public static readonly BigInteger[] Value={ 1111L,11110000L,111100001111L,1111000011110000L,11110000111100001111UL,BigInteger.Parse("111100001111000011110000"),BigInteger.Parse("1111000011110000111100001111"),BigInteger.Parse("11110000111100001111000011110000"),BigInteger.Parse("111100001111000011110000111100001111") };
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
public class A154805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154805Inst Instance=new A154805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154806
{
public static readonly ulong[] Value={ 15L,240L,3855L,61680L,986895L,15790320L,252645135L,4042322160L,64677154575L,1034834473200L,16557351571215L,264917625139440L,4238682002231055L,67818912035696880L,1085102592571150095L,17361641481138401520UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154806Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A154806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154806.Bytes);
public ulong this[int i]=>Value[i];

public static A154806Inst Instance=new A154806Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154807
{
public static readonly BigInteger[] Value={ 11111L,1111100000L,111110000011111L,11111000001111100000UL,BigInteger.Parse("1111100000111110000011111"),BigInteger.Parse("111110000011111000001111100000"),BigInteger.Parse("11111000001111100000111110000011111"),BigInteger.Parse("1111100000111110000011111000001111100000"),BigInteger.Parse("111110000011111000001111100000111110000011111") };
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
public class A154807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154807Inst Instance=new A154807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154808
{
public static readonly BigInteger[] Value={ 31L,992L,31775L,1016800L,32537631L,1041204192L,33318534175L,1066193093600L,34118178995231L,1091781727847392L,34937015291116575L,1117984489315730400L,BigInteger.Parse("35775503658103372831"),BigInteger.Parse("1144816117059307930592"),BigInteger.Parse("36634115745897853778975") };
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
public class A154808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154808Inst Instance=new A154808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154809
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,11L,12L,13L,14L,16L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,30L,32L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,64L,66L,67L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154809Inst : IEnumerable<long>
{
public static readonly long[] Value=A154809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154809.Bytes);
public long this[int i]=>Value[i];

public static A154809Inst Instance=new A154809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154810
{
public static readonly long[] Value={ 10L,100L,110L,1000L,1010L,1011L,1100L,1101L,1110L,10000L,10010L,10011L,10100L,10110L,10111L,11000L,11001L,11010L,11100L,11101L,11110L,100000L,100010L,100011L,100100L,100101L,100110L,100111L,101000L,101001L,101010L,101011L,101100L,101110L,101111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154810Inst : IEnumerable<long>
{
public static readonly long[] Value=A154810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154810.Bytes);
public long this[int i]=>Value[i];

public static A154810Inst Instance=new A154810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154811
{
public static readonly long[] Value={ 1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154811Inst : IEnumerable<long>
{
public static readonly long[] Value=A154811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154811.Bytes);
public long this[int i]=>Value[i];

public static A154811Inst Instance=new A154811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154812
{
public static readonly long[] Value={ 2L,11L,13L,19L,23L,29L,31L,41L,47L,59L,61L,67L,79L,97L,103L,107L,109L,113L,157L,163L,167L,191L,193L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,331L,337L,367L,373L,379L,383L,389L,401L,419L,433L,439L,443L,449L,461L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154812Inst : IEnumerable<long>
{
public static readonly long[] Value=A154812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154812.Bytes);
public long this[int i]=>Value[i];

public static A154812Inst Instance=new A154812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154813
{
public static readonly long[] Value={ 2L,11L,41L,43L,59L,101L,127L,173L,211L,223L,241L,263L,307L,311L,313L,317L,389L,419L,487L,557L,601L,613L,617L,619L,647L,673L,677L,727L,739L,751L,757L,761L,827L,839L,853L,857L,883L,929L,953L,971L,1013L,1021L,1033L,1039L,1061L,1091L,1103L,1109L,1123L,1151L,1181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154813Inst : IEnumerable<long>
{
public static readonly long[] Value=A154813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154813.Bytes);
public long this[int i]=>Value[i];

public static A154813Inst Instance=new A154813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154814
{
public static readonly long[] Value={ 1L,0L,5L,0L,5L,9L,8L,1L,4L,0L,1L,4L,8L,7L,7L,4L,1L,9L,1L,9L,1L,5L,6L,2L,7L,4L,7L,4L,2L,6L,0L,3L,2L,2L,8L,8L,2L,4L,0L,2L,6L,4L,6L,3L,7L,8L,8L,2L,7L,6L,7L,9L,2L,3L,9L,5L,6L,8L,1L,7L,0L,2L,6L,4L,4L,3L,0L,7L,8L,4L,1L,9L,9L,9L,9L,0L,0L,7L,0L,1L,8L,5L,1L,5L,0L,0L,6L,3L,4L,3L,6L,0L,7L,2L,6L,3L,3L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154814Inst : IEnumerable<long>
{
public static readonly long[] Value=A154814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154814.Bytes);
public long this[int i]=>Value[i];

public static A154814Inst Instance=new A154814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154815
{
public static readonly long[] Value={ 8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154815Inst : IEnumerable<long>
{
public static readonly long[] Value=A154815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154815.Bytes);
public long this[int i]=>Value[i];

public static A154815Inst Instance=new A154815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154816
{
public static readonly long[] Value={ 2L,5L,5L,17L,66L,17L,65L,685L,685L,65L,257L,6572L,16342L,6572L,257L,1025L,60675L,313300L,313300L,60675L,1025L,4097L,549418L,5340455L,10712060L,5340455L,549418L,4097L,16385L,4931825L,84856215L,303945575L,303945575L,84856215L,4931825L,16385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154816Inst : IEnumerable<long>
{
public static readonly long[] Value=A154816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154816.Bytes);
public long this[int i]=>Value[i];

public static A154816Inst Instance=new A154816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154817
{
public static readonly long[] Value={ 6L,23L,23L,76L,230L,76L,237L,1682L,1682L,237L,722L,10543L,23548L,10543L,722L,2179L,60657L,259723L,259723L,60657L,2179L,6552L,331612L,2485288L,4675014L,2485288L,331612L,6552L,19673L,1756340L,21707972L,69413294L,69413294L,21707972L,1756340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154817Inst : IEnumerable<long>
{
public static readonly long[] Value=A154817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154817.Bytes);
public long this[int i]=>Value[i];

public static A154817Inst Instance=new A154817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154818
{
public static readonly long[] Value={ 69636L,70215L,77058L,80892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154818Inst : IEnumerable<long>
{
public static readonly long[] Value=A154818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154818.Bytes);
public long this[int i]=>Value[i];

public static A154818Inst Instance=new A154818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154819
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,1L,10L,1L,1835L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154819Inst : IEnumerable<long>
{
public static readonly long[] Value=A154819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154819.Bytes);
public long this[int i]=>Value[i];

public static A154819Inst Instance=new A154819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154820
{
public static readonly long[] Value={ 4L,13L,25L,28L,31L,40L,46L,52L,55L,64L,82L,103L,130L,133L,205L,208L,250L,256L,265L,280L,289L,298L,301L,310L,313L,331L,349L,394L,400L,406L,439L,448L,460L,484L,493L,502L,505L,520L,526L,550L,562L,589L,598L,604L,625L,640L,652L,679L,697L,769L,796L,802L,820L,829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154820Inst : IEnumerable<long>
{
public static readonly long[] Value=A154820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154820.Bytes);
public long this[int i]=>Value[i];

public static A154820Inst Instance=new A154820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154821
{
public static readonly long[] Value={ 3L,7L,13L,139L,283L,1063L,1759L,1999L,2719L,2917L,3109L,3583L,4057L,4297L,4723L,5059L,5623L,5749L,6079L,6823L,8707L,9199L,9949L,12697L,15193L,15319L,15607L,16249L,16267L,16993L,17827L,18679L,18793L,20359L,20887L,21727L,22147L,23677L,24019L,24169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154821Inst : IEnumerable<long>
{
public static readonly long[] Value=A154821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154821.Bytes);
public long this[int i]=>Value[i];

public static A154821Inst Instance=new A154821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154822
{
public static readonly long[] Value={ 2161L,4951L,6421L,8761L,12241L,13411L,19891L,20731L,24631L,27271L,28411L,30091L,34981L,40471L,42331L,42901L,52021L,53731L,58111L,60631L,63361L,65701L,74611L,83641L,90841L,95101L,98251L,103171L,104851L,119671L,120871L,131731L,132661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154822Inst : IEnumerable<long>
{
public static readonly long[] Value=A154822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154822.Bytes);
public long this[int i]=>Value[i];

public static A154822Inst Instance=new A154822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154823
{
public static readonly long[] Value={ 3L,37L,157L,373L,877L,2083L,3607L,4153L,6043L,6577L,8737L,10993L,11677L,14029L,16333L,18253L,19429L,20023L,20443L,20743L,20899L,21757L,23227L,24733L,24859L,28477L,28687L,29347L,30223L,32203L,32833L,35869L,36529L,37447L,38833L,42073L,43789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154823Inst : IEnumerable<long>
{
public static readonly long[] Value=A154823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154823.Bytes);
public long this[int i]=>Value[i];

public static A154823Inst Instance=new A154823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154824
{
public static readonly long[] Value={ 3L,356647L,500719L,562759L,784513L,837307L,902017L,1003963L,1258903L,1456519L,1893427L,2157457L,2597953L,5771587L,6757843L,6842503L,7731133L,10035397L,11155957L,11929849L,12276643L,13395727L,14139283L,15609367L,16675003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154824Inst : IEnumerable<long>
{
public static readonly long[] Value=A154824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154824.Bytes);
public long this[int i]=>Value[i];

public static A154824Inst Instance=new A154824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154825
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,5L,3L,-21L,-51L,41L,391L,407L,-1927L,-6227L,2507L,49347L,71109L,-236079L,-966129L,9519L,7408497L,13685205L,-32079981L,-167077221L,-60639939L,1209248505L,2761755543L,-4457338681L,-30629783831L,-22124857219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154825Inst : IEnumerable<long>
{
public static readonly long[] Value=A154825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154825.Bytes);
public long this[int i]=>Value[i];

public static A154825Inst Instance=new A154825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154826
{
public static readonly long[] Value={ 1L,0L,2L,3L,8L,3L,2L,0L,9L,9L,2L,3L,9L,2L,6L,1L,9L,5L,7L,5L,5L,0L,7L,1L,0L,7L,1L,5L,4L,5L,9L,2L,0L,9L,0L,8L,1L,6L,1L,9L,7L,6L,7L,5L,1L,9L,0L,3L,5L,6L,0L,4L,5L,6L,9L,0L,7L,4L,0L,6L,1L,7L,2L,3L,7L,1L,8L,4L,7L,6L,8L,7L,9L,0L,8L,8L,6L,8L,9L,9L,7L,8L,0L,5L,8L,9L,1L,0L,3L,3L,5L,4L,1L,1L,8L,1L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154826Inst : IEnumerable<long>
{
public static readonly long[] Value=A154826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154826.Bytes);
public long this[int i]=>Value[i];

public static A154826Inst Instance=new A154826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154827
{
public static readonly long[] Value={ 9L,7L,8L,6L,0L,2L,1L,6L,8L,4L,7L,2L,9L,0L,4L,1L,2L,1L,5L,5L,9L,0L,4L,5L,9L,6L,4L,9L,2L,7L,9L,1L,1L,2L,2L,9L,5L,7L,7L,0L,4L,3L,8L,6L,2L,4L,3L,3L,4L,5L,4L,7L,9L,1L,1L,4L,5L,4L,0L,1L,5L,7L,0L,1L,0L,8L,7L,8L,9L,2L,4L,4L,6L,2L,8L,2L,1L,0L,7L,4L,3L,7L,9L,7L,1L,0L,6L,0L,7L,5L,2L,1L,9L,2L,0L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154827Inst : IEnumerable<long>
{
public static readonly long[] Value=A154827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154827.Bytes);
public long this[int i]=>Value[i];

public static A154827Inst Instance=new A154827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154828
{
public static readonly BigInteger[] Value={ 1L,2L,8L,52L,548L,9852L,323988L,20589852L,2599737428L,658007495452L,334291709264468L,340646270830877852L,BigInteger.Parse("695599447171017236308"),BigInteger.Parse("2844303802537519899994652"),BigInteger.Parse("23277772627131826189210443348") };
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
public class A154828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154828Inst Instance=new A154828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154829
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,17L,25L,9L,1L,171L,258L,102L,16L,1L,3113L,4635L,1788L,290L,25L,1L,106419L,154048L,54909L,7910L,665L,36L,1L,7035649L,9907933L,3232971L,385669L,26257L,1323L,49L,1L,915028347L,1262093470L,382948336L,37703584L,1889650L,71596L,2380L,64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154829Inst : IEnumerable<long>
{
public static readonly long[] Value=A154829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154829.Bytes);
public long this[int i]=>Value[i];

public static A154829Inst Instance=new A154829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154830
{
public static readonly long[] Value={ 9L,5L,9L,2L,4L,9L,8L,6L,6L,2L,7L,2L,5L,2L,5L,7L,7L,8L,9L,4L,2L,7L,3L,6L,6L,5L,9L,6L,4L,2L,0L,9L,2L,2L,4L,7L,0L,7L,2L,7L,1L,1L,7L,2L,0L,0L,7L,6L,2L,8L,2L,2L,6L,3L,9L,1L,4L,5L,7L,9L,6L,0L,2L,8L,5L,9L,6L,5L,1L,6L,2L,2L,9L,7L,2L,7L,5L,8L,1L,7L,9L,4L,0L,2L,6L,2L,2L,5L,6L,5L,9L,2L,0L,5L,6L,4L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154830Inst : IEnumerable<long>
{
public static readonly long[] Value=A154830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154830.Bytes);
public long this[int i]=>Value[i];

public static A154830Inst Instance=new A154830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154831
{
public static readonly long[] Value={ 3L,7L,11L,13L,21L,29L,39L,41L,43L,49L,53L,59L,73L,83L,85L,87L,95L,99L,101L,119L,129L,141L,143L,175L,181L,185L,189L,207L,217L,239L,241L,277L,279L,293L,311L,315L,323L,339L,343L,363L,367L,371L,375L,381L,389L,409L,421L,433L,435L,451L,473L,483L,497L,503L,507L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154831Inst : IEnumerable<long>
{
public static readonly long[] Value=A154831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154831.Bytes);
public long this[int i]=>Value[i];

public static A154831Inst Instance=new A154831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154832
{
public static readonly long[] Value={ 3L,7L,11L,13L,29L,41L,43L,53L,59L,73L,83L,101L,181L,239L,241L,277L,293L,311L,367L,389L,409L,421L,433L,503L,587L,617L,647L,683L,757L,773L,811L,823L,839L,881L,907L,953L,1019L,1093L,1117L,1187L,1249L,1361L,1471L,1481L,1543L,1553L,1571L,1637L,1667L,1747L,1789L,1847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154832Inst : IEnumerable<long>
{
public static readonly long[] Value=A154832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154832.Bytes);
public long this[int i]=>Value[i];

public static A154832Inst Instance=new A154832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154833
{
public static readonly long[] Value={ 3L,13L,31L,63L,93L,139L,181L,211L,229L,265L,271L,303L,325L,339L,343L,345L,411L,441L,519L,523L,531L,549L,555L,573L,619L,663L,675L,681L,693L,741L,751L,805L,819L,835L,853L,861L,945L,951L,969L,975L,993L,1063L,1071L,1095L,1119L,1143L,1275L,1281L,1305L,1329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154833Inst : IEnumerable<long>
{
public static readonly long[] Value=A154833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154833.Bytes);
public long this[int i]=>Value[i];

public static A154833Inst Instance=new A154833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154834
{
public static readonly long[] Value={ 3L,13L,31L,139L,181L,211L,229L,271L,523L,619L,751L,853L,1063L,1483L,1699L,2791L,3361L,3463L,3541L,3769L,4051L,4201L,4801L,4861L,4903L,5521L,5689L,5701L,6163L,6211L,6763L,6823L,6949L,7621L,8059L,8269L,8389L,8419L,8563L,8689L,8713L,9001L,9103L,9319L,10303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154834Inst : IEnumerable<long>
{
public static readonly long[] Value=A154834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154834.Bytes);
public long this[int i]=>Value[i];

public static A154834Inst Instance=new A154834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154835
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,72L,205L,597L,1770L,5329L,16253L,50112L,155939L,489111L,1544723L,4908164L,15678715L,50323541L,162213311L,524895810L,1704407999L,5552027379L,18137964251L,59412854411L,195090277189L,642056206297L,2117485840188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154835Inst : IEnumerable<long>
{
public static readonly long[] Value=A154835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154835.Bytes);
public long this[int i]=>Value[i];

public static A154835Inst Instance=new A154835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154836
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,36L,104L,311L,955L,2994L,9542L,30818L,100633L,331657L,1101708L,3684785L,12398126L,41936805L,142520868L,486400191L,1666330558L,5728305895L,19754004806L,68317426480L,236893446915L,823435684539L,2868676129248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154836Inst : IEnumerable<long>
{
public static readonly long[] Value=A154836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154836.Bytes);
public long this[int i]=>Value[i];

public static A154836Inst Instance=new A154836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154837
{
public static readonly long[] Value={ 9L,4L,1L,6L,3L,5L,6L,5L,3L,4L,6L,6L,5L,5L,2L,9L,4L,5L,7L,8L,7L,8L,6L,1L,8L,4L,0L,1L,4L,7L,3L,6L,7L,4L,1L,5L,3L,4L,1L,6L,2L,7L,1L,0L,6L,5L,1L,1L,2L,6L,4L,1L,8L,9L,1L,5L,2L,5L,2L,9L,4L,7L,4L,0L,1L,1L,4L,2L,9L,2L,0L,8L,5L,2L,8L,2L,1L,7L,9L,2L,7L,0L,0L,9L,7L,6L,0L,1L,8L,3L,4L,9L,9L,1L,3L,4L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154837Inst : IEnumerable<long>
{
public static readonly long[] Value=A154837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154837.Bytes);
public long this[int i]=>Value[i];

public static A154837Inst Instance=new A154837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154838
{
public static readonly long[] Value={ 9L,2L,5L,5L,1L,2L,8L,5L,2L,6L,3L,9L,0L,3L,6L,6L,9L,7L,0L,5L,4L,7L,9L,0L,8L,0L,4L,3L,9L,0L,5L,6L,1L,9L,8L,3L,5L,6L,3L,8L,6L,2L,0L,2L,9L,4L,9L,4L,2L,6L,3L,4L,4L,7L,3L,5L,8L,4L,7L,1L,1L,7L,6L,4L,5L,4L,0L,9L,8L,2L,1L,6L,1L,2L,0L,6L,3L,3L,5L,3L,8L,8L,5L,5L,8L,6L,2L,3L,3L,6L,1L,7L,9L,0L,1L,5L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154838Inst : IEnumerable<long>
{
public static readonly long[] Value=A154838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154838.Bytes);
public long this[int i]=>Value[i];

public static A154838Inst Instance=new A154838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154839
{
public static readonly long[] Value={ 9L,1L,0L,6L,8L,0L,9L,9L,4L,7L,8L,7L,8L,1L,1L,9L,9L,1L,9L,2L,8L,3L,0L,3L,8L,8L,8L,4L,0L,3L,5L,6L,3L,9L,8L,2L,5L,6L,4L,2L,6L,2L,3L,6L,4L,9L,6L,5L,2L,9L,3L,1L,8L,4L,6L,6L,8L,2L,9L,9L,8L,2L,6L,8L,6L,2L,4L,3L,4L,7L,3L,7L,0L,2L,7L,4L,1L,9L,0L,7L,0L,3L,3L,1L,5L,3L,7L,9L,2L,6L,1L,0L,6L,9L,3L,6L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154839Inst : IEnumerable<long>
{
public static readonly long[] Value=A154839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154839.Bytes);
public long this[int i]=>Value[i];

public static A154839Inst Instance=new A154839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154840
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,2L,1L,7L,1L,2L,3L,4L,5L,6L,7L,8L,9L,9L,8L,7L,6L,5L,4L,3L,2L,1L,19L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,37L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154840Inst : IEnumerable<long>
{
public static readonly long[] Value=A154840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154840.Bytes);
public long this[int i]=>Value[i];

public static A154840Inst Instance=new A154840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154841
{
public static readonly long[] Value={ 8L,8L,4L,7L,3L,6L,7L,4L,3L,9L,9L,9L,7L,7L,7L,4L,6L,6L,0L,3L,4L,9L,0L,6L,6L,6L,1L,9L,3L,7L,4L,6L,2L,0L,7L,8L,5L,8L,5L,3L,7L,6L,8L,4L,7L,3L,9L,9L,1L,2L,7L,1L,3L,9L,1L,6L,0L,9L,1L,7L,5L,1L,4L,6L,2L,7L,8L,3L,4L,4L,8L,8L,1L,1L,4L,8L,7L,4L,7L,5L,9L,2L,1L,8L,9L,6L,3L,5L,6L,4L,3L,1L,0L,6L,0L,2L,3L,7L,1L,7L,1L,0L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154841Inst : IEnumerable<long>
{
public static readonly long[] Value=A154841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154841.Bytes);
public long this[int i]=>Value[i];

public static A154841Inst Instance=new A154841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154842
{
public static readonly long[] Value={ 8L,9L,6L,9L,7L,5L,2L,9L,6L,8L,7L,0L,3L,0L,1L,7L,5L,7L,9L,1L,0L,2L,4L,9L,3L,5L,3L,6L,1L,3L,9L,2L,1L,8L,8L,3L,5L,9L,1L,6L,5L,1L,5L,2L,9L,7L,6L,8L,8L,8L,8L,0L,3L,8L,9L,0L,3L,0L,4L,6L,8L,4L,4L,2L,6L,0L,4L,5L,8L,1L,2L,0L,0L,2L,5L,6L,0L,5L,6L,9L,5L,6L,7L,0L,3L,1L,7L,9L,0L,7L,7L,2L,2L,8L,1L,5L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154842Inst : IEnumerable<long>
{
public static readonly long[] Value=A154842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154842.Bytes);
public long this[int i]=>Value[i];

public static A154842Inst Instance=new A154842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154843
{
public static readonly long[] Value={ 2L,1L,1L,1L,-2L,1L,1L,-1L,-1L,1L,1L,-12L,22L,-12L,1L,1L,14L,-15L,-15L,14L,1L,1L,-135L,359L,-450L,359L,-135L,1L,1L,699L,-1589L,889L,889L,-1589L,699L,1L,1L,-5068L,13390L,-15092L,13538L,-15092L,13390L,-5068L,1L,1L,40284L,-109038L,113588L,-44835L,-44835L,113588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154843Inst : IEnumerable<long>
{
public static readonly long[] Value=A154843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154843.Bytes);
public long this[int i]=>Value[i];

public static A154843Inst Instance=new A154843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154844
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,7L,14L,7L,1L,1L,11L,40L,40L,11L,1L,1L,16L,96L,180L,96L,16L,1L,1L,22L,203L,651L,651L,203L,22L,1L,1L,29L,393L,2016L,3402L,2016L,393L,29L,1L,1L,37L,717L,5671L,14721L,14721L,5671L,717L,37L,1L,1L,46L,1261L,15210L,56932L,85050L,56932L,15210L,1261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154844Inst : IEnumerable<long>
{
public static readonly long[] Value=A154844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154844.Bytes);
public long this[int i]=>Value[i];

public static A154844Inst Instance=new A154844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154845
{
public static readonly long[] Value={ 8L,8L,4L,2L,5L,8L,9L,1L,7L,8L,3L,0L,0L,1L,4L,9L,8L,4L,5L,9L,9L,1L,8L,4L,2L,1L,6L,3L,8L,1L,7L,3L,4L,0L,5L,9L,3L,8L,6L,9L,5L,6L,4L,1L,4L,7L,0L,6L,2L,2L,6L,6L,1L,6L,1L,1L,2L,2L,3L,6L,9L,3L,8L,6L,5L,8L,2L,3L,1L,2L,9L,1L,0L,4L,0L,8L,8L,9L,7L,1L,7L,3L,5L,3L,2L,7L,0L,0L,0L,2L,2L,6L,7L,3L,9L,3L,1L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154845Inst : IEnumerable<long>
{
public static readonly long[] Value=A154845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154845.Bytes);
public long this[int i]=>Value[i];

public static A154845Inst Instance=new A154845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154846
{
public static readonly long[] Value={ 8L,7L,2L,4L,1L,7L,1L,6L,7L,9L,4L,2L,1L,2L,6L,2L,3L,6L,9L,1L,7L,3L,5L,1L,2L,2L,5L,7L,7L,3L,5L,5L,3L,5L,5L,4L,5L,1L,0L,6L,4L,1L,7L,0L,1L,9L,9L,7L,9L,9L,9L,0L,7L,0L,4L,5L,8L,9L,5L,2L,6L,2L,5L,8L,5L,6L,7L,3L,6L,9L,5L,2L,6L,0L,0L,3L,9L,6L,9L,4L,0L,3L,9L,1L,9L,6L,7L,0L,8L,5L,6L,7L,5L,2L,8L,8L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154846Inst : IEnumerable<long>
{
public static readonly long[] Value=A154846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154846.Bytes);
public long this[int i]=>Value[i];

public static A154846Inst Instance=new A154846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154847
{
public static readonly long[] Value={ 4L,0L,8L,7L,4L,6L,2L,8L,4L,1L,2L,5L,0L,3L,3L,9L,4L,0L,8L,2L,5L,4L,0L,6L,6L,0L,1L,0L,8L,1L,0L,4L,0L,4L,3L,5L,4L,0L,1L,1L,2L,6L,7L,2L,8L,2L,3L,4L,4L,8L,2L,0L,6L,8L,8L,1L,2L,6L,6L,0L,9L,0L,6L,4L,3L,8L,6L,6L,9L,6L,5L,0L,9L,0L,4L,7L,3L,8L,2L,0L,6L,8L,2L,9L,7L,3L,4L,3L,1L,5L,1L,8L,4L,3L,6L,8L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154847Inst : IEnumerable<long>
{
public static readonly long[] Value=A154847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154847.Bytes);
public long this[int i]=>Value[i];

public static A154847Inst Instance=new A154847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154848
{
public static readonly long[] Value={ 2L,5L,7L,8L,9L,0L,1L,9L,2L,3L,1L,6L,2L,5L,6L,5L,8L,9L,3L,5L,1L,6L,3L,7L,4L,2L,4L,4L,6L,4L,0L,1L,7L,7L,6L,4L,4L,4L,8L,1L,7L,5L,4L,2L,9L,4L,7L,3L,9L,4L,4L,6L,7L,8L,9L,4L,9L,3L,7L,7L,4L,6L,0L,8L,9L,4L,0L,9L,7L,3L,6L,8L,7L,0L,5L,2L,3L,8L,1L,4L,2L,5L,6L,3L,0L,1L,3L,9L,7L,5L,9L,9L,9L,1L,6L,3L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154848Inst : IEnumerable<long>
{
public static readonly long[] Value=A154848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154848.Bytes);
public long this[int i]=>Value[i];

public static A154848Inst Instance=new A154848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154849
{
public static readonly long[] Value={ 2L,0L,4L,3L,7L,3L,1L,4L,2L,0L,6L,2L,5L,1L,6L,9L,7L,0L,4L,1L,2L,7L,0L,3L,3L,0L,0L,5L,4L,0L,5L,2L,0L,2L,1L,7L,7L,0L,0L,5L,6L,3L,3L,6L,4L,1L,1L,7L,2L,4L,1L,0L,3L,4L,4L,0L,6L,3L,3L,0L,4L,5L,3L,2L,1L,9L,3L,3L,4L,8L,2L,5L,4L,5L,2L,3L,6L,9L,1L,0L,3L,4L,1L,4L,8L,6L,7L,1L,5L,7L,5L,9L,2L,1L,8L,4L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154849Inst : IEnumerable<long>
{
public static readonly long[] Value=A154849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154849.Bytes);
public long this[int i]=>Value[i];

public static A154849Inst Instance=new A154849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154850
{
public static readonly long[] Value={ 1L,7L,6L,0L,3L,7L,4L,4L,2L,7L,7L,2L,2L,5L,8L,7L,9L,6L,0L,0L,9L,8L,6L,8L,1L,8L,6L,1L,2L,4L,8L,0L,5L,1L,7L,1L,9L,9L,8L,6L,3L,8L,0L,8L,2L,5L,4L,3L,8L,4L,7L,1L,0L,5L,5L,9L,4L,6L,0L,8L,9L,6L,4L,5L,7L,4L,8L,8L,6L,2L,3L,7L,6L,8L,8L,5L,4L,0L,9L,9L,5L,2L,8L,0L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154850Inst : IEnumerable<long>
{
public static readonly long[] Value=A154850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154850.Bytes);
public long this[int i]=>Value[i];

public static A154850Inst Instance=new A154850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154851
{
public static readonly long[] Value={ 2L,2L,2L,2L,4L,2L,3L,9L,9L,3L,7L,24L,34L,24L,7L,31L,103L,154L,154L,103L,31L,241L,778L,1055L,1036L,1055L,778L,241L,3121L,10127L,12957L,10083L,10083L,12957L,10127L,3121L,65521L,215148L,274724L,184020L,117846L,184020L,274724L,215148L,65521L,2227681L,7378804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154851Inst : IEnumerable<long>
{
public static readonly long[] Value=A154851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154851.Bytes);
public long this[int i]=>Value[i];

public static A154851Inst Instance=new A154851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154852
{
public static readonly long[] Value={ -1L,1L,-2L,0L,2L,-7L,-3L,3L,7L,-20L,-56L,0L,56L,20L,-61L,-415L,-370L,370L,415L,61L,-182L,-2632L,-5710L,0L,5710L,2632L,182L,-547L,-15155L,-64407L,-49735L,49735L,64407L,15155L,547L,-1640L,-82896L,-619696L,-1085840L,0L,1085840L,619696L,82896L,1640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154852Inst : IEnumerable<long>
{
public static readonly long[] Value=A154852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154852.Bytes);
public long this[int i]=>Value[i];

public static A154852Inst Instance=new A154852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154853
{
public static readonly long[] Value={ 1L,-1L,3L,0L,-3L,7L,33L,-33L,-7L,15L,294L,0L,-294L,-15L,31L,1915L,3820L,-3820L,-1915L,-31L,63L,11088L,65115L,0L,-65115L,-11088L,-63L,127L,60725L,783237L,1019935L,-1019935L,-783237L,-60725L,-127L,255L,322794L,8095794L,26928930L,0L,-26928930L,-8095794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154853Inst : IEnumerable<long>
{
public static readonly long[] Value=A154853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154853.Bytes);
public long this[int i]=>Value[i];

public static A154853Inst Instance=new A154853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154854
{
public static readonly long[] Value={ 1L,-1L,4L,0L,-4L,13L,57L,-57L,-13L,40L,688L,0L,-688L,-40L,121L,6115L,11770L,-11770L,-6115L,-121L,364L,48464L,270620L,0L,-270620L,-48464L,-364L,1093L,363965L,4401033L,5613265L,-5613265L,-4401033L,-363965L,-1093L,3280L,2657568L,61590368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154854Inst : IEnumerable<long>
{
public static readonly long[] Value=A154854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154854.Bytes);
public long this[int i]=>Value[i];

public static A154854Inst Instance=new A154854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154855
{
public static readonly long[] Value={ 1L,-1L,5L,0L,-5L,21L,87L,-87L,-21L,85L,1330L,0L,-1330L,-85L,341L,15045L,28160L,-28160L,-15045L,-341L,1365L,152040L,816825L,0L,-816825L,-152040L,-1365L,5461L,1457323L,16786931L,21064365L,-21064365L,-16786931L,-1457323L,-5461L,21845L,13592430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154855Inst : IEnumerable<long>
{
public static readonly long[] Value=A154855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154855.Bytes);
public long this[int i]=>Value[i];

public static A154855Inst Instance=new A154855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154856
{
public static readonly long[] Value={ 1L,5L,8L,1L,2L,4L,6L,4L,7L,4L,6L,0L,4L,5L,6L,9L,2L,1L,0L,8L,4L,5L,8L,2L,3L,9L,8L,7L,0L,2L,4L,3L,2L,2L,8L,1L,2L,4L,1L,3L,1L,8L,4L,8L,9L,2L,7L,0L,6L,0L,2L,0L,9L,8L,1L,3L,0L,6L,8L,0L,5L,5L,3L,3L,4L,7L,0L,4L,0L,0L,0L,5L,6L,6L,2L,7L,7L,6L,4L,3L,9L,2L,5L,8L,6L,4L,6L,9L,9L,4L,7L,8L,7L,3L,7L,5L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154856Inst : IEnumerable<long>
{
public static readonly long[] Value=A154856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154856.Bytes);
public long this[int i]=>Value[i];

public static A154856Inst Instance=new A154856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154857
{
public static readonly long[] Value={ 1L,4L,5L,5L,9L,8L,3L,6L,4L,1L,0L,9L,0L,3L,4L,7L,5L,9L,5L,9L,4L,2L,1L,0L,9L,3L,5L,8L,7L,9L,4L,1L,9L,4L,6L,7L,0L,6L,0L,4L,7L,3L,7L,1L,2L,7L,5L,8L,3L,1L,6L,4L,4L,7L,1L,8L,5L,1L,7L,7L,8L,5L,5L,3L,6L,6L,5L,4L,6L,5L,7L,6L,0L,2L,3L,2L,0L,4L,8L,0L,6L,2L,0L,4L,9L,8L,9L,5L,3L,8L,7L,2L,2L,0L,3L,7L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154857Inst : IEnumerable<long>
{
public static readonly long[] Value=A154857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154857.Bytes);
public long this[int i]=>Value[i];

public static A154857Inst Instance=new A154857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154858
{
public static readonly long[] Value={ 1L,3L,6L,2L,4L,8L,7L,6L,1L,3L,7L,5L,0L,1L,1L,3L,1L,3L,6L,0L,8L,4L,6L,8L,8L,6L,7L,0L,2L,7L,0L,1L,3L,4L,7L,8L,4L,6L,7L,0L,4L,2L,2L,4L,2L,7L,4L,4L,8L,2L,7L,3L,5L,6L,2L,7L,0L,8L,8L,6L,9L,6L,8L,8L,1L,2L,8L,8L,9L,8L,8L,3L,6L,3L,4L,9L,1L,2L,7L,3L,5L,6L,0L,9L,9L,1L,1L,4L,3L,8L,3L,9L,4L,7L,8L,9L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154858Inst : IEnumerable<long>
{
public static readonly long[] Value=A154858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154858.Bytes);
public long this[int i]=>Value[i];

public static A154858Inst Instance=new A154858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154859
{
public static readonly long[] Value={ 1L,2L,8L,9L,4L,5L,0L,9L,6L,1L,5L,8L,1L,2L,8L,2L,9L,4L,6L,7L,5L,8L,1L,8L,7L,1L,2L,2L,3L,2L,0L,0L,8L,8L,8L,2L,2L,2L,4L,0L,8L,7L,7L,1L,4L,7L,3L,6L,9L,7L,2L,3L,3L,9L,4L,7L,4L,6L,8L,8L,7L,3L,0L,4L,4L,7L,0L,4L,8L,6L,8L,4L,3L,5L,2L,6L,1L,9L,0L,7L,1L,2L,8L,1L,5L,0L,6L,9L,8L,7L,9L,9L,9L,5L,8L,1L,8L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154859Inst : IEnumerable<long>
{
public static readonly long[] Value=A154859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154859.Bytes);
public long this[int i]=>Value[i];

public static A154859Inst Instance=new A154859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154860
{
public static readonly long[] Value={ 1L,2L,3L,0L,4L,4L,8L,9L,2L,1L,3L,7L,8L,2L,7L,3L,9L,2L,8L,5L,4L,0L,1L,6L,9L,8L,9L,4L,3L,2L,8L,3L,3L,7L,0L,3L,0L,0L,0L,7L,5L,6L,7L,3L,7L,8L,4L,2L,5L,0L,4L,6L,3L,9L,7L,3L,8L,0L,3L,6L,8L,4L,8L,2L,3L,4L,4L,6L,9L,4L,0L,6L,2L,2L,5L,7L,1L,1L,8L,1L,8L,5L,7L,9L,5L,6L,8L,4L,6L,7L,0L,0L,9L,8L,4L,6L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154860Inst : IEnumerable<long>
{
public static readonly long[] Value=A154860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154860.Bytes);
public long this[int i]=>Value[i];

public static A154860Inst Instance=new A154860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154861
{
public static readonly long[] Value={ 1L,1L,8L,1L,5L,4L,1L,7L,3L,6L,2L,8L,6L,8L,4L,9L,7L,9L,5L,9L,2L,3L,1L,5L,9L,4L,3L,4L,6L,2L,7L,2L,7L,0L,9L,2L,4L,6L,5L,4L,5L,6L,2L,9L,0L,5L,9L,2L,0L,8L,3L,6L,5L,9L,3L,6L,7L,6L,7L,9L,4L,6L,6L,0L,0L,1L,4L,4L,2L,0L,3L,8L,1L,2L,9L,5L,2L,6L,7L,1L,7L,6L,6L,7L,1L,6L,3L,6L,1L,8L,5L,3L,9L,7L,1L,8L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154861Inst : IEnumerable<long>
{
public static readonly long[] Value=A154861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154861.Bytes);
public long this[int i]=>Value[i];

public static A154861Inst Instance=new A154861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154862
{
public static readonly long[] Value={ 1L,1L,9L,21L,45L,51L,65L,105L,133L,153L,209L,243L,247L,325L,357L,385L,413L,459L,495L,531L,675L,707L,729L,789L,805L,845L,891L,913L,951L,981L,1003L,1067L,1083L,1111L,1125L,1203L,1313L,1335L,1347L,1369L,1395L,1417L,1557L,1625L,1703L,1725L,1935L,1967L,2133L,2211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154862Inst : IEnumerable<long>
{
public static readonly long[] Value=A154862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154862.Bytes);
public long this[int i]=>Value[i];

public static A154862Inst Instance=new A154862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154863
{
public static readonly long[] Value={ 13L,23L,47L,53L,61L,79L,83L,89L,103L,107L,151L,179L,181L,197L,227L,257L,277L,281L,283L,311L,313L,331L,347L,353L,389L,409L,569L,601L,607L,631L,643L,647L,653L,701L,709L,739L,743L,761L,769L,797L,821L,823L,827L,829L,857L,859L,877L,881L,883L,929L,947L,991L,997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154863Inst : IEnumerable<long>
{
public static readonly long[] Value=A154863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154863.Bytes);
public long this[int i]=>Value[i];

public static A154863Inst Instance=new A154863Inst();

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