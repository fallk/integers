using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A276598
{
public static readonly long[] Value={ 0L,5L,30L,175L,1020L,5945L,34650L,201955L,1177080L,6860525L,39986070L,233055895L,1358349300L,7917039905L,46143890130L,268946300875L,1567533915120L,9136257189845L,53250009223950L,310363798153855L,1808932779699180L,10543232880041225L,61450464500548170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276598Inst : IEnumerable<long>
{
public static readonly long[] Value=A276598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276598.Bytes);
public long this[int i]=>Value[i];

public static A276598Inst Instance=new A276598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276599
{
public static readonly long[] Value={ 1L,4L,10L,25L,59L,146L,344L,851L,2005L,4960L,11686L,28909L,68111L,168494L,396980L,982055L,2313769L,5723836L,13485634L,33360961L,78600035L,194441930L,458114576L,1133290619L,2670087421L,6605301784L,15562409950L,38498520085L,90704372279L,224385818726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276599Inst : IEnumerable<long>
{
public static readonly long[] Value=A276599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276599.Bytes);
public long this[int i]=>Value[i];

public static A276599Inst Instance=new A276599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276600
{
public static readonly long[] Value={ 0L,2L,3L,7L,15L,20L,42L,88L,117L,245L,513L,682L,1428L,2990L,3975L,8323L,17427L,23168L,48510L,101572L,135033L,282737L,592005L,787030L,1647912L,3450458L,4587147L,9604735L,20110743L,26735852L,55980498L,117214000L,155827965L,326278253L,683173257L,908231938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276600Inst : IEnumerable<long>
{
public static readonly long[] Value=A276600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276600.Bytes);
public long this[int i]=>Value[i];

public static A276600Inst Instance=new A276600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276601
{
public static readonly long[] Value={ 1L,6L,12L,37L,71L,216L,414L,1259L,2413L,7338L,14064L,42769L,81971L,249276L,477762L,1452887L,2784601L,8468046L,16229844L,49355389L,94594463L,287664288L,551336934L,1676630339L,3213427141L,9772117746L,18729225912L,56956076137L,109161928331L,331964339076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276601Inst : IEnumerable<long>
{
public static readonly long[] Value=A276601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276601.Bytes);
public long this[int i]=>Value[i];

public static A276601Inst Instance=new A276601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276602
{
public static readonly long[] Value={ 0L,9L,54L,315L,1836L,10701L,62370L,363519L,2118744L,12348945L,71974926L,419500611L,2445028740L,14250671829L,83059002234L,484103341575L,2821561047216L,16445262941721L,95850016603110L,558654836676939L,3256079003458524L,18977819184074205L,110610836100986706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276602Inst : IEnumerable<long>
{
public static readonly long[] Value=A276602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276602.Bytes);
public long this[int i]=>Value[i];

public static A276602Inst Instance=new A276602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276603
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,10L,13L,14L,15L,17L,19L,21L,23L,26L,28L,31L,34L,36L,40L,41L,42L,44L,46L,48L,50L,53L,55L,58L,61L,63L,67L,70L,72L,76L,80L,82L,85L,88L,90L,94L,97L,99L,102L,106L,108L,112L,116L,121L,122L,123L,125L,127L,129L,131L,134L,136L,139L,142L,144L,148L,151L,153L,157L,161L,163L,166L,169L,171L,175L,178L,180L,183L,187L,189L,193L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276603Inst : IEnumerable<long>
{
public static readonly long[] Value=A276603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276603.Bytes);
public long this[int i]=>Value[i];

public static A276603Inst Instance=new A276603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276604
{
public static readonly long[] Value={ 0L,2L,2L,4L,2L,2L,4L,4L,6L,2L,2L,4L,4L,4L,4L,6L,4L,6L,6L,4L,8L,2L,2L,4L,4L,4L,4L,6L,4L,6L,6L,4L,8L,6L,4L,8L,8L,4L,6L,6L,4L,8L,6L,4L,6L,8L,4L,8L,8L,10L,2L,2L,4L,4L,4L,4L,6L,4L,6L,6L,4L,8L,6L,4L,8L,8L,4L,6L,6L,4L,8L,6L,4L,6L,8L,4L,8L,8L,10L,6L,4L,6L,8L,4L,8L,8L,10L,8L,8L,10L,4L,6L,6L,4L,8L,6L,4L,6L,8L,4L,8L,8L,10L,6L,4L,6L,8L,4L,8L,8L,8L,8L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276604Inst : IEnumerable<long>
{
public static readonly long[] Value=A276604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276604.Bytes);
public long this[int i]=>Value[i];

public static A276604Inst Instance=new A276604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276605
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,2L,2L,3L,1L,1L,2L,2L,2L,2L,3L,2L,3L,3L,2L,4L,1L,1L,2L,2L,2L,2L,3L,2L,3L,3L,2L,4L,3L,2L,4L,4L,2L,3L,3L,2L,4L,3L,2L,3L,4L,2L,4L,4L,5L,1L,1L,2L,2L,2L,2L,3L,2L,3L,3L,2L,4L,3L,2L,4L,4L,2L,3L,3L,2L,4L,3L,2L,3L,4L,2L,4L,4L,5L,3L,2L,3L,4L,2L,4L,4L,5L,4L,4L,5L,2L,3L,3L,2L,4L,3L,2L,3L,4L,2L,4L,4L,5L,3L,2L,3L,4L,2L,4L,4L,4L,4L,4L,5L,2L,4L,4L,4L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276605Inst : IEnumerable<long>
{
public static readonly long[] Value=A276605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276605.Bytes);
public long this[int i]=>Value[i];

public static A276605Inst Instance=new A276605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276606
{
public static readonly long[] Value={ 5L,10L,12L,24L,18L,28L,44L,22L,38L,48L,40L,24L,38L,58L,60L,48L,48L,54L,54L,60L,26L,70L,84L,66L,44L,24L,70L,50L,102L,64L,74L,60L,100L,48L,44L,18L,126L,150L,34L,96L,26L,58L,74L,30L,60L,66L,96L,96L,120L,58L,60L,146L,70L,66L,164L,30L,64L,60L,132L,50L,40L,168L,78L,62L,100L,108L,104L,42L,58L,98L,40L,50L,100L,198L,44L,88L,60L,138L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276606Inst : IEnumerable<long>
{
public static readonly long[] Value=A276606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276606.Bytes);
public long this[int i]=>Value[i];

public static A276606Inst Instance=new A276606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276607
{
public static readonly long[] Value={ 4L,8L,10L,20L,16L,24L,38L,20L,34L,40L,36L,22L,34L,52L,52L,42L,44L,48L,48L,54L,24L,64L,74L,58L,40L,22L,64L,46L,90L,58L,66L,56L,88L,46L,40L,16L,114L,134L,32L,86L,24L,54L,68L,28L,56L,58L,86L,88L,108L,52L,56L,132L,64L,60L,148L,28L,58L,56L,120L,44L,38L,152L,72L,56L,92L,98L,96L,38L,56L,88L,38L,46L,92L,180L,40L,80L,54L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276607Inst : IEnumerable<long>
{
public static readonly long[] Value=A276607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276607.Bytes);
public long this[int i]=>Value[i];

public static A276607Inst Instance=new A276607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276608
{
public static readonly long[] Value={ 2L,4L,5L,10L,8L,12L,19L,10L,17L,20L,18L,11L,17L,26L,26L,21L,22L,24L,24L,27L,12L,32L,37L,29L,20L,11L,32L,23L,45L,29L,33L,28L,44L,23L,20L,8L,57L,67L,16L,43L,12L,27L,34L,14L,28L,29L,43L,44L,54L,26L,28L,66L,32L,30L,74L,14L,29L,28L,60L,22L,19L,76L,36L,28L,46L,49L,48L,19L,28L,44L,19L,23L,46L,90L,20L,40L,27L,63L,28L,31L,30L,43L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276608Inst : IEnumerable<long>
{
public static readonly long[] Value=A276608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276608.Bytes);
public long this[int i]=>Value[i];

public static A276608Inst Instance=new A276608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276609
{
public static readonly long[] Value={ 1L,2L,5L,2L,10L,9L,4L,12L,20L,13L,2L,24L,24L,28L,17L,4L,18L,44L,36L,38L,21L,6L,28L,30L,66L,48L,46L,25L,2L,44L,54L,46L,90L,58L,56L,29L,4L,22L,84L,84L,60L,114L,68L,64L,33L,8L,38L,40L,122L,104L,74L,136L,82L,74L,37L,4L,48L,60L,54L,156L,136L,86L,152L,92L,82L,41L,2L,40L,116L,94L,76L,194L,162L,106L,174L,102L,92L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276609Inst : IEnumerable<long>
{
public static readonly long[] Value=A276609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276609.Bytes);
public long this[int i]=>Value[i];

public static A276609Inst Instance=new A276609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276610
{
public static readonly long[] Value={ 1L,5L,2L,9L,10L,2L,13L,20L,12L,4L,17L,28L,24L,24L,2L,21L,38L,36L,44L,18L,4L,25L,46L,48L,66L,30L,28L,6L,29L,56L,58L,90L,46L,54L,44L,2L,33L,64L,68L,114L,60L,84L,84L,22L,4L,37L,74L,82L,136L,74L,104L,122L,40L,38L,8L,41L,82L,92L,152L,86L,136L,156L,54L,60L,48L,4L,45L,92L,102L,174L,106L,162L,194L,76L,94L,116L,40L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276610Inst : IEnumerable<long>
{
public static readonly long[] Value=A276610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276610.Bytes);
public long this[int i]=>Value[i];

public static A276610Inst Instance=new A276610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276611
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276611Inst : IEnumerable<long>
{
public static readonly long[] Value=A276611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276611.Bytes);
public long this[int i]=>Value[i];

public static A276611Inst Instance=new A276611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276932
{
public static readonly long[] Value={ 2L,8L,12L,14L,26L,32L,36L,38L,50L,56L,60L,62L,72L,74L,78L,80L,84L,86L,122L,128L,132L,134L,146L,152L,156L,158L,170L,176L,180L,182L,192L,194L,198L,200L,204L,206L,242L,248L,252L,254L,266L,272L,276L,278L,290L,296L,300L,302L,312L,314L,318L,320L,324L,326L,362L,368L,372L,374L,386L,392L,396L,398L,410L,416L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276932Inst : IEnumerable<long>
{
public static readonly long[] Value=A276932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276932.Bytes);
public long this[int i]=>Value[i];

public static A276932Inst Instance=new A276932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276933
{
public static readonly long[] Value={ 6L,30L,48L,54L,126L,150L,168L,174L,246L,270L,288L,294L,360L,366L,384L,390L,408L,414L,726L,750L,768L,774L,846L,870L,888L,894L,966L,990L,1008L,1014L,1080L,1086L,1104L,1110L,1128L,1134L,1446L,1470L,1488L,1494L,1566L,1590L,1608L,1614L,1686L,1710L,1728L,1734L,1800L,1806L,1824L,1830L,1848L,1854L,2166L,2190L,2208L,2214L,2286L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276933Inst : IEnumerable<long>
{
public static readonly long[] Value=A276933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276933.Bytes);
public long this[int i]=>Value[i];

public static A276933Inst Instance=new A276933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276934
{
public static readonly long[] Value={ 1L,5L,8L,9L,21L,25L,28L,29L,41L,45L,48L,49L,60L,61L,64L,65L,68L,69L,121L,125L,128L,129L,141L,145L,148L,149L,161L,165L,168L,169L,180L,181L,184L,185L,188L,189L,241L,245L,248L,249L,261L,265L,268L,269L,281L,285L,288L,289L,300L,301L,304L,305L,308L,309L,361L,365L,368L,369L,381L,385L,388L,389L,401L,405L,408L,409L,420L,421L,424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276934Inst : IEnumerable<long>
{
public static readonly long[] Value=A276934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276934.Bytes);
public long this[int i]=>Value[i];

public static A276934Inst Instance=new A276934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276935
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276935Inst : IEnumerable<long>
{
public static readonly long[] Value=A276935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276935.Bytes);
public long this[int i]=>Value[i];

public static A276935Inst Instance=new A276935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276936
{
public static readonly long[] Value={ 2L,6L,9L,10L,14L,18L,22L,26L,30L,34L,36L,38L,42L,45L,46L,50L,54L,58L,62L,63L,66L,70L,72L,74L,78L,82L,86L,90L,94L,98L,99L,102L,106L,110L,114L,117L,118L,122L,125L,126L,130L,134L,138L,142L,144L,146L,150L,153L,154L,158L,162L,166L,170L,171L,174L,178L,180L,182L,186L,190L,194L,198L,202L,206L,207L,210L,214L,218L,222L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276936Inst : IEnumerable<long>
{
public static readonly long[] Value=A276936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276936.Bytes);
public long this[int i]=>Value[i];

public static A276936Inst Instance=new A276936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276937
{
public static readonly long[] Value={ 2L,6L,9L,10L,14L,18L,22L,26L,30L,34L,38L,42L,45L,46L,50L,58L,62L,63L,66L,70L,74L,78L,82L,86L,90L,94L,98L,99L,102L,106L,110L,114L,117L,118L,122L,125L,126L,130L,134L,138L,142L,146L,150L,153L,154L,158L,166L,170L,171L,174L,178L,182L,186L,190L,194L,198L,202L,206L,207L,210L,214L,218L,222L,225L,226L,230L,234L,238L,242L,246L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276937Inst : IEnumerable<long>
{
public static readonly long[] Value=A276937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276937.Bytes);
public long this[int i]=>Value[i];

public static A276937Inst Instance=new A276937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276938
{
public static readonly long[] Value={ 3L,15L,25L,21L,33L,75L,39L,51L,105L,57L,69L,165L,175L,87L,147L,93L,111L,275L,195L,231L,123L,255L,129L,141L,525L,159L,363L,325L,285L,177L,273L,345L,425L,183L,201L,343L,825L,357L,213L,435L,219L,237L,735L,475L,429L,249L,267L,399L,575L,465L,291L,561L,555L,483L,303L,975L,309L,321L,725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276938Inst : IEnumerable<long>
{
public static readonly long[] Value=A276938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276938.Bytes);
public long this[int i]=>Value[i];

public static A276938Inst Instance=new A276938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276939
{
public static readonly BigInteger[] Value={ 3L,8L,36L,240L,2520L,32340L,540540L,10210200L,232792560L,6692786100L,207030183360L,7621298624940L,311671001662020L,13387011595197240L,627972543920161440L,BigInteger.Parse("33204048259778536140"),BigInteger.Parse("1955349508631402683800"),BigInteger.Parse("119211141709561183622340"),BigInteger.Parse("7975609932439674026862360"),BigInteger.Parse("565799151677779228023294480"),BigInteger.Parse("41287621429375723111588738860") };
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
public class A276939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276939Inst Instance=new A276939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276940
{
public static readonly BigInteger[] Value={ 2L,8L,27L,128L,750L,5184L,41160L,368640L,3674160L,40320000L,482993280L,6270566400L,87697209600L,1314380390400L,21016195200000L,357082280755200L,6424604169984000L,122021710626816000L,2439660069310464000L,BigInteger.Parse("51218989645824000000"),BigInteger.Parse("1126555274886193152000"),BigInteger.Parse("25905540583064862720000"),BigInteger.Parse("621623493403188756480000"),BigInteger.Parse("15538186060797648568320000") };
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
public class A276940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276940Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276940.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276940.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276940Inst Instance=new A276940Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276941
{
public static readonly long[] Value={ 2L,6L,3L,9L,15L,5L,10L,25L,35L,7L,14L,21L,49L,77L,11L,18L,33L,55L,121L,143L,13L,22L,75L,65L,91L,169L,221L,17L,26L,39L,245L,119L,187L,289L,323L,19L,30L,51L,85L,847L,209L,247L,361L,437L,23L,34L,105L,95L,133L,1859L,299L,391L,529L,667L,29L,38L,57L,385L,161L,253L,3757L,493L,551L,841L,899L,31L,42L,69L,115L,1001L,319L,377L,6137L,589L,713L,961L,1147L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276941Inst : IEnumerable<long>
{
public static readonly long[] Value=A276941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276941.Bytes);
public long this[int i]=>Value[i];

public static A276941Inst Instance=new A276941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276942
{
public static readonly long[] Value={ 2L,3L,6L,5L,15L,9L,7L,35L,25L,10L,11L,77L,49L,21L,14L,13L,143L,121L,55L,33L,18L,17L,221L,169L,91L,65L,75L,22L,19L,323L,289L,187L,119L,245L,39L,26L,23L,437L,361L,247L,209L,847L,85L,51L,30L,29L,667L,529L,391L,299L,1859L,133L,95L,105L,34L,31L,899L,841L,551L,493L,3757L,253L,161L,385L,57L,38L,37L,1147L,961L,713L,589L,6137L,377L,319L,1001L,115L,69L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276942Inst : IEnumerable<long>
{
public static readonly long[] Value=A276942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276942.Bytes);
public long this[int i]=>Value[i];

public static A276942Inst Instance=new A276942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276943
{
public static readonly long[] Value={ 1L,3L,2L,4L,8L,6L,5L,12L,36L,30L,7L,14L,60L,240L,210L,9L,32L,66L,420L,2520L,2310L,10L,38L,216L,450L,4620L,32340L,30030L,11L,42L,246L,2340L,4830L,60060L,540540L,510510L,13L,44L,270L,2550L,30240L,62370L,1021020L,10210200L,9699690L,15L,62L,276L,2730L,32550L,512820L,1051050L,19399380L,232792560L,223092870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276943Inst : IEnumerable<long>
{
public static readonly long[] Value=A276943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276943.Bytes);
public long this[int i]=>Value[i];

public static A276943Inst Instance=new A276943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276944
{
public static readonly long[] Value={ 1L,3L,2L,4L,7L,6L,11L,5L,16L,22L,29L,8L,37L,12L,46L,56L,67L,79L,92L,106L,121L,137L,154L,172L,191L,211L,232L,254L,277L,10L,301L,17L,326L,352L,379L,9L,407L,23L,436L,466L,497L,30L,529L,38L,562L,596L,631L,667L,704L,742L,781L,821L,862L,904L,947L,991L,1036L,1082L,1129L,13L,1177L,47L,1226L,1276L,1327L,18L,1379L,57L,1432L,1486L,1541L,68L,1597L,80L,1654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276944Inst : IEnumerable<long>
{
public static readonly long[] Value=A276944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276944.Bytes);
public long this[int i]=>Value[i];

public static A276944Inst Instance=new A276944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276945
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,4L,30L,36L,12L,5L,210L,240L,60L,14L,7L,2310L,2520L,420L,66L,32L,9L,30030L,32340L,4620L,450L,216L,38L,10L,510510L,540540L,60060L,4830L,2340L,246L,42L,11L,9699690L,10210200L,1021020L,62370L,30240L,2550L,270L,44L,13L,223092870L,232792560L,19399380L,1051050L,512820L,32550L,2730L,276L,62L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276945Inst : IEnumerable<long>
{
public static readonly long[] Value=A276945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276945.Bytes);
public long this[int i]=>Value[i];

public static A276945Inst Instance=new A276945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276946
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,4L,15L,5L,21L,28L,36L,9L,45L,14L,55L,66L,78L,91L,105L,120L,136L,153L,171L,190L,210L,231L,253L,276L,300L,7L,325L,20L,351L,378L,406L,8L,435L,27L,465L,496L,528L,35L,561L,44L,595L,630L,666L,703L,741L,780L,820L,861L,903L,946L,990L,1035L,1081L,1128L,1176L,13L,1225L,54L,1275L,1326L,1378L,19L,1431L,65L,1485L,1540L,1596L,77L,1653L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276946Inst : IEnumerable<long>
{
public static readonly long[] Value=A276946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276946.Bytes);
public long this[int i]=>Value[i];

public static A276946Inst Instance=new A276946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276947
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276947Inst : IEnumerable<long>
{
public static readonly long[] Value=A276947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276947.Bytes);
public long this[int i]=>Value[i];

public static A276947Inst Instance=new A276947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276964
{
public static readonly BigInteger[] Value={ 1L,3L,39L,949L,36573L,2029551L,152451283L,14840686449L,1812664465209L,270925848659323L,48571769994336831L,10276325760127883853UL,BigInteger.Parse("2531148652596607988629"),BigInteger.Parse("717525135328209346300839"),BigInteger.Parse("231804543407519025287933163") };
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
public class A276964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276964Inst Instance=new A276964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276965
{
public static readonly BigInteger[] Value={ 1L,1L,5L,73L,2017L,86801L,5289301L,430814665L,45052534913L,5868875082817L,930114039075301L,175964489469769001L,BigInteger.Parse("39125942325820605025"),BigInteger.Parse("10092849114680961297553"),BigInteger.Parse("2987365449592984040715317"),BigInteger.Parse("1005030253302269078318250601") };
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
public class A276965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276965Inst Instance=new A276965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276966
{
public static readonly long[] Value={ 1L,0L,1L,12L,1L,60L,1L,244L,1L,1012L,1L,4084L,1L,16340L,1L,65364L,1L,261972L,1L,1048404L,1L,4194132L,1L,16777044L,1L,67108180L,1L,268432724L,1L,1073730900L,1L,4294923604L,1L,17179825492L,1L,68719433044L,1L,274877863252L,1L,1099511584084L,1L,4398046467412L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276966Inst : IEnumerable<long>
{
public static readonly long[] Value=A276966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276966.Bytes);
public long this[int i]=>Value[i];

public static A276966Inst Instance=new A276966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276967
{
public static readonly long[] Value={ 1L,3L,9L,15L,21L,33L,39L,51L,57L,63L,69L,87L,93L,111L,123L,129L,141L,159L,177L,183L,195L,201L,213L,219L,237L,249L,267L,291L,303L,309L,315L,321L,327L,339L,381L,393L,399L,411L,417L,447L,453L,471L,489L,501L,519L,537L,543L,573L,579L,591L,597L,633L,669L,681L,687L,693L,699L,717L,723L,731L,753L,771L,789L,807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276967Inst : IEnumerable<long>
{
public static readonly long[] Value=A276967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276967.Bytes);
public long this[int i]=>Value[i];

public static A276967Inst Instance=new A276967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276968
{
public static readonly long[] Value={ 1L,3L,5L,25L,65L,85L,145L,165L,185L,205L,221L,265L,305L,365L,445L,465L,485L,505L,545L,565L,685L,745L,785L,825L,865L,905L,965L,985L,1025L,1085L,1145L,1165L,1205L,1285L,1345L,1385L,1405L,1465L,1565L,1585L,1685L,1705L,1745L,1765L,1865L,1925L,1945L,1985L,2005L,2045L,2105L,2165L,2245L,2285L,2305L,2325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276968Inst : IEnumerable<long>
{
public static readonly long[] Value=A276968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276968.Bytes);
public long this[int i]=>Value[i];

public static A276968Inst Instance=new A276968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276969
{
public static readonly long[] Value={ 1L,3L,7L,15L,49L,91L,133L,217L,255L,259L,301L,427L,469L,511L,527L,553L,679L,721L,763L,889L,973L,1015L,1057L,1099L,1141L,1267L,1351L,1393L,1477L,1561L,1603L,1687L,1897L,1939L,1981L,2107L,2149L,2191L,2317L,2359L,2443L,2569L,2611L,2653L,2779L,2863L,2947L,3031L,3073L,3199L,3241L,3409L,3493L,3661L,3787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276969Inst : IEnumerable<long>
{
public static readonly long[] Value=A276969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276969.Bytes);
public long this[int i]=>Value[i];

public static A276969Inst Instance=new A276969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276970
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,21L,27L,45L,63L,99L,105L,117L,153L,171L,189L,207L,261L,273L,279L,333L,369L,387L,423L,429L,477L,513L,531L,549L,585L,603L,639L,657L,711L,747L,801L,873L,909L,927L,945L,963L,981L,1017L,1143L,1179L,1197L,1209L,1233L,1251L,1341L,1359L,1365L,1413L,1467L,1503L,1557L,1611L,1629L,1665L,1719L,1737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276970Inst : IEnumerable<long>
{
public static readonly long[] Value=A276970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276970.Bytes);
public long this[int i]=>Value[i];

public static A276970Inst Instance=new A276970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276971
{
public static readonly long[] Value={ 1L,3L,11L,15L,31L,35L,51L,121L,341L,451L,455L,671L,781L,1111L,1235L,1271L,1441L,1547L,1661L,1991L,2091L,2101L,2321L,2651L,2761L,2981L,3091L,3421L,3641L,3731L,3751L,4403L,4411L,4631L,4741L,5071L,5401L,5731L,5951L,6171L,6191L,6281L,6611L,6851L,6941L,7051L,7271L,7601L,7711L,8261L,8371L,8435L,8921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276971Inst : IEnumerable<long>
{
public static readonly long[] Value=A276971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276971.Bytes);
public long this[int i]=>Value[i];

public static A276971Inst Instance=new A276971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276972
{
public static readonly BigInteger[] Value={ 0L,1L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("589881151426658740854227725580736348849310352832644300781946246613899173590427") };
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
public class A276972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276972Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276972.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276972.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276972Inst Instance=new A276972Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276973
{
public static readonly long[] Value={ 6L,11L,15L,26L,30L,35L,51L,55L,60L,75L,101L,105L,110L,125L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276973Inst : IEnumerable<long>
{
public static readonly long[] Value=A276973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276973.Bytes);
public long this[int i]=>Value[i];

public static A276973Inst Instance=new A276973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276974
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,4L,1L,1L,0L,19L,3L,1L,1L,0L,103L,12L,3L,1L,1L,0L,651L,54L,10L,3L,1L,1L,0L,4702L,281L,42L,10L,3L,1L,1L,0L,38413L,1652L,203L,37L,10L,3L,1L,1L,0L,350559L,11017L,1086L,166L,37L,10L,3L,1L,1L,0L,3539511L,81665L,6564L,857L,151L,37L,10L,3L,1L,1L,0L,39196758L,669948L,44265L,4900L,726L,151L,37L,10L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276974Inst : IEnumerable<long>
{
public static readonly long[] Value=A276974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276974.Bytes);
public long this[int i]=>Value[i];

public static A276974Inst Instance=new A276974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276975
{
public static readonly BigInteger[] Value={ 1L,1L,4L,19L,103L,651L,4702L,38413L,350559L,3539511L,39196758L,472612883L,6165080443L,86526834271L,1300282224846L,20832761552453L,354515666646827L,6386139146435035L,121406489336263622L,2429193186525638435L,BigInteger.Parse("51030147426536745655"),BigInteger.Parse("1122952442325988152627") };
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
public class A276975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276975.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276975Inst Instance=new A276975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276976
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,4L,3L,2L,1L,2L,1L,2L,3L,4L,1L,6L,1L,4L,3L,2L,1L,4L,5L,2L,9L,4L,1L,2L,1L,8L,3L,2L,11L,6L,1L,2L,3L,4L,1L,6L,1L,4L,9L,2L,1L,4L,7L,10L,3L,4L,1L,18L,15L,8L,3L,2L,1L,4L,1L,2L,3L,16L,5L,6L,1L,4L,3L,10L,1L,6L,1L,2L,15L,4L,17L,6L,1L,4L,27L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276976Inst : IEnumerable<long>
{
public static readonly long[] Value=A276976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276976.Bytes);
public long this[int i]=>Value[i];

public static A276976Inst Instance=new A276976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276977
{
public static readonly BigInteger[] Value={ 1L,1L,11L,315L,17129L,1510425L,196385475L,35327367075L,8399994587985L,2550903574364145L,963207568455370875L,BigInteger.Parse("442613044315692124875"),BigInteger.Parse("243195136160954426677305"),BigInteger.Parse("157442856285298191126143625"),BigInteger.Parse("118607799383105394973766029875"),BigInteger.Parse("102867257381973743111023517821875") };
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
public class A276977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276977Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276977.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276977.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276977Inst Instance=new A276977Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276978
{
public static readonly BigInteger[] Value={ 1L,1L,8L,16L,243L,729L,16384L,65536L,1953125L,9765625L,362797056L,2176782336L,96889010407L,678223072849L,35184372088832L,281474976710656L,16677181699666569L,150094635296999121L,10000000000000000000UL,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("7400249944258160101211") };
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
public class A276978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276978.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276978Inst Instance=new A276978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276979
{
public static readonly BigInteger[] Value={ 1L,4L,8L,81L,243L,4096L,16384L,390625L,1953125L,60466176L,362797056L,13841287201L,96889010407L,4398046511104L,35184372088832L,1853020188851841L,16677181699666569L,1000000000000000000L,10000000000000000000UL,BigInteger.Parse("672749994932560009201") };
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
public class A276979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276979.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276979Inst Instance=new A276979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277012
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,13L,4L,9L,10L,21L,22L,45L,12L,25L,26L,53L,54L,109L,28L,57L,58L,117L,118L,237L,8L,17L,18L,37L,38L,77L,20L,41L,42L,85L,86L,173L,44L,89L,90L,181L,182L,365L,92L,185L,186L,373L,374L,749L,24L,49L,50L,101L,102L,205L,52L,105L,106L,213L,214L,429L,108L,217L,218L,437L,438L,877L,220L,441L,442L,885L,886L,1773L,56L,113L,114L,229L,230L,461L,116L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277012Inst : IEnumerable<long>
{
public static readonly long[] Value=A277012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277012.Bytes);
public long this[int i]=>Value[i];

public static A277012Inst Instance=new A277012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277013
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,1L,2L,2L,4L,1L,3L,1L,3L,2L,2L,1L,4L,1L,2L,3L,3L,1L,3L,1L,5L,2L,2L,2L,4L,1L,2L,2L,4L,1L,3L,1L,3L,3L,2L,1L,5L,2L,2L,2L,3L,1L,4L,1L,4L,2L,2L,1L,4L,1L,2L,3L,6L,1L,3L,1L,3L,2L,3L,1L,5L,1L,2L,3L,3L,1L,3L,1L,5L,2L,2L,1L,4L,2L,2L,2L,4L,1L,4L,1L,3L,2L,2L,1L,6L,1L,3L,3L,3L,1L,3L,1L,4L,3L,2L,1L,5L,1L,2L,2L,5L,1L,3L,1L,3L,2L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277013Inst : IEnumerable<long>
{
public static readonly long[] Value=A277013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277013.Bytes);
public long this[int i]=>Value[i];

public static A277013Inst Instance=new A277013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277014
{
public static readonly long[] Value={ 0L,6L,24L,53L,92L,132L,145L,208L,462L,568L,716L,815L,1106L,1270L,1625L,1822L,2245L,2415L,2474L,2960L,3222L,3777L,4148L,4377L,5022L,5359L,6064L,6436L,6815L,7204L,7508L,7611L,8452L,8888L,9339L,9797L,10383L,10744L,11237L,12775L,14413L,14982L,15409L,16146L,16741L,17352L,17978L,18612L,19423L,19916L,21944L,24067L,25533L,26099L,26289L,27053L,27831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277014Inst : IEnumerable<long>
{
public static readonly long[] Value=A277014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277014.Bytes);
public long this[int i]=>Value[i];

public static A277014Inst Instance=new A277014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277015
{
public static readonly long[] Value={ 0L,4L,8L,12L,16L,19L,20L,24L,36L,40L,45L,48L,56L,60L,68L,72L,80L,83L,84L,92L,96L,104L,109L,112L,120L,124L,132L,136L,140L,144L,147L,148L,156L,160L,164L,168L,173L,176L,180L,192L,204L,208L,211L,216L,220L,224L,228L,232L,237L,240L,252L,264L,272L,275L,276L,280L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277015Inst : IEnumerable<long>
{
public static readonly long[] Value=A277015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277015.Bytes);
public long this[int i]=>Value[i];

public static A277015Inst Instance=new A277015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277016
{
public static readonly long[] Value={ 0L,16L,64L,144L,256L,361L,400L,576L,1296L,1600L,2025L,2304L,3136L,3600L,4624L,5184L,6400L,6889L,7056L,8464L,9216L,10816L,11881L,12544L,14400L,15376L,17424L,18496L,19600L,20736L,21609L,21904L,24336L,25600L,26896L,28224L,29929L,30976L,32400L,36864L,41616L,43264L,44521L,46656L,48400L,50176L,51984L,53824L,56169L,57600L,63504L,69696L,73984L,75625L,76176L,78400L,80656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277016Inst : IEnumerable<long>
{
public static readonly long[] Value=A277016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277016.Bytes);
public long this[int i]=>Value[i];

public static A277016Inst Instance=new A277016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277017
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277017Inst : IEnumerable<long>
{
public static readonly long[] Value=A277017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277017.Bytes);
public long this[int i]=>Value[i];

public static A277017Inst Instance=new A277017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277018
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,16L,17L,18L,20L,21L,22L,24L,25L,26L,28L,32L,33L,34L,36L,37L,38L,40L,41L,42L,44L,45L,48L,49L,50L,52L,53L,54L,56L,57L,58L,60L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,80L,81L,82L,84L,85L,86L,88L,89L,90L,92L,96L,97L,98L,100L,101L,102L,104L,105L,106L,108L,109L,112L,113L,114L,116L,117L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277018Inst : IEnumerable<long>
{
public static readonly long[] Value=A277018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277018.Bytes);
public long this[int i]=>Value[i];

public static A277018Inst Instance=new A277018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277019
{
public static readonly long[] Value={ 3L,7L,11L,14L,15L,19L,23L,27L,29L,30L,31L,35L,39L,43L,46L,47L,51L,55L,59L,61L,62L,63L,67L,71L,75L,78L,79L,83L,87L,91L,93L,94L,95L,99L,103L,107L,110L,111L,115L,119L,123L,124L,125L,126L,127L,131L,135L,139L,142L,143L,147L,151L,155L,157L,158L,159L,163L,167L,171L,174L,175L,179L,183L,187L,189L,190L,191L,195L,199L,203L,206L,207L,211L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277019Inst : IEnumerable<long>
{
public static readonly long[] Value=A277019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277019.Bytes);
public long this[int i]=>Value[i];

public static A277019Inst Instance=new A277019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277020
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,13L,10L,21L,8L,45L,26L,93L,20L,109L,42L,85L,16L,173L,90L,477L,52L,957L,186L,733L,40L,749L,218L,1501L,84L,877L,170L,341L,32L,685L,346L,3549L,180L,12221L,954L,7133L,104L,14269L,1914L,49021L,372L,28605L,1466L,5853L,80L,5869L,1498L,30685L,436L,61373L,3002L,23517L,168L,12013L,1754L,24029L,340L,7021L,682L,1365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277020Inst : IEnumerable<long>
{
public static readonly long[] Value=A277020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277020.Bytes);
public long this[int i]=>Value[i];

public static A277020Inst Instance=new A277020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277021
{
public static readonly long[] Value={ 0L,1L,2L,2L,6L,3L,4L,3L,30L,7L,8L,4L,12L,5L,6L,4L,210L,31L,32L,8L,36L,9L,10L,5L,60L,13L,14L,6L,18L,7L,8L,5L,2310L,211L,212L,32L,216L,33L,34L,9L,240L,37L,38L,10L,42L,11L,12L,6L,420L,61L,62L,14L,66L,15L,16L,7L,90L,19L,20L,8L,24L,9L,10L,6L,30030L,2311L,2312L,212L,2316L,213L,214L,33L,2340L,217L,218L,34L,222L,35L,36L,10L,2520L,241L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277021Inst : IEnumerable<long>
{
public static readonly long[] Value=A277021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277021.Bytes);
public long this[int i]=>Value[i];

public static A277021Inst Instance=new A277021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277022
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,13L,4L,9L,10L,21L,22L,45L,12L,25L,26L,53L,54L,109L,28L,57L,58L,117L,118L,237L,60L,121L,122L,245L,246L,493L,8L,17L,18L,37L,38L,77L,20L,41L,42L,85L,86L,173L,44L,89L,90L,181L,182L,365L,92L,185L,186L,373L,374L,749L,188L,377L,378L,757L,758L,1517L,24L,49L,50L,101L,102L,205L,52L,105L,106L,213L,214L,429L,108L,217L,218L,437L,438L,877L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277022Inst : IEnumerable<long>
{
public static readonly long[] Value=A277022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277022.Bytes);
public long this[int i]=>Value[i];

public static A277022Inst Instance=new A277022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277023
{
public static readonly long[] Value={ 0L,3L,6L,11L,16L,27L,38L,51L,64L,83L,102L,123L,144L,171L,198L,227L,256L,291L,326L,361L,400L,444L,486L,531L,576L,627L,678L,731L,786L,843L,902L,963L,1026L,1091L,1158L,1227L,1296L,1371L,1446L,1523L,1600L,1683L,1767L,1851L,1938L,2025L,2118L,2211L,2304L,2403L,2502L,2603L,2706L,2811L,2918L,3027L,3136L,3251L,3366L,3483L,3600L,3723L,3846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277023Inst : IEnumerable<long>
{
public static readonly long[] Value=A277023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277023.Bytes);
public long this[int i]=>Value[i];

public static A277023Inst Instance=new A277023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277024
{
public static readonly long[] Value={ 0L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,0L,0L,3L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,3L,2L,2L,0L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,0L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L,2L,3L,2L,2L,0L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277024Inst : IEnumerable<long>
{
public static readonly long[] Value=A277024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277024.Bytes);
public long this[int i]=>Value[i];

public static A277024Inst Instance=new A277024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277025
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,12L,14L,15L,17L,18L,20L,21L,23L,24L,26L,28L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,44L,45L,48L,51L,52L,54L,55L,56L,57L,58L,60L,63L,66L,68L,69L,70L,71L,72L,74L,78L,80L,81L,84L,88L,90L,91L,93L,95L,96L,98L,99L,102L,105L,107L,108L,110L,111L,112L,114L,117L,118L,120L,121L,123L,126L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277025Inst : IEnumerable<long>
{
public static readonly long[] Value=A277025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277025.Bytes);
public long this[int i]=>Value[i];

public static A277025Inst Instance=new A277025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277026
{
public static readonly long[] Value={ 7L,8L,11L,13L,16L,19L,22L,25L,27L,29L,32L,38L,43L,46L,47L,49L,50L,53L,59L,61L,62L,64L,65L,67L,73L,75L,76L,77L,79L,82L,83L,85L,86L,87L,89L,92L,94L,97L,100L,101L,103L,104L,106L,109L,113L,115L,116L,119L,122L,124L,125L,127L,128L,130L,133L,134L,137L,140L,141L,143L,145L,146L,148L,151L,152L,154L,155L,163L,164L,167L,168L,169L,170L,173L,174L,176L,178L,179L,181L,184L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277026Inst : IEnumerable<long>
{
public static readonly long[] Value=A277026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277026.Bytes);
public long this[int i]=>Value[i];

public static A277026Inst Instance=new A277026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277027
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,4L,1L,9L,4L,4L,1L,9L,1L,4L,4L,16L,1L,9L,1L,9L,4L,4L,1L,16L,1L,4L,9L,9L,1L,9L,1L,25L,4L,4L,4L,16L,1L,4L,4L,16L,1L,9L,1L,9L,9L,4L,1L,25L,4L,4L,4L,9L,1L,16L,1L,16L,4L,4L,1L,16L,1L,4L,9L,36L,1L,9L,1L,9L,4L,9L,1L,25L,1L,4L,9L,9L,1L,9L,1L,25L,4L,4L,1L,16L,4L,4L,4L,16L,1L,16L,1L,9L,4L,4L,1L,36L,1L,9L,9L,9L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277027Inst : IEnumerable<long>
{
public static readonly long[] Value=A277027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277027.Bytes);
public long this[int i]=>Value[i];

public static A277027Inst Instance=new A277027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277380
{
public static readonly BigInteger[] Value={ 1L,2L,10L,92L,1068L,15352L,265752L,5368400L,123919248L,3217983008L,92851377312L,2947037232064L,102040223376576L,3827536020146048L,154615082607931776L,6691872388083371264L,BigInteger.Parse("308938595472492867840"),BigInteger.Parse("15153942107317778727424"),BigInteger.Parse("787050616613300039649792") };
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
public class A277380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277380Inst Instance=new A277380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277381
{
public static readonly BigInteger[] Value={ 1L,2L,6L,28L,156L,984L,7112L,57488L,508688L,4887840L,50639200L,561416640L,6621963712L,82719611264L,1089925195904L,15094182365440L,219035852333312L,3321573144437248L,52511336993334784L,863594855161338880L,14746060593172585472UL,BigInteger.Parse("260971042697438779392") };
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
public class A277381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277381.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277381Inst Instance=new A277381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277382
{
public static readonly BigInteger[] Value={ 1L,4L,23L,168L,1473L,14988L,173007L,2228544L,31636449L,490102164L,8219695239L,148262469336L,2860241078817L,58736954622492L,1278727896354687L,29406849577341552L,712119108949808193L,18108134430393657636UL,BigInteger.Parse("482306685868464422391"),BigInteger.Parse("13425231879291031821576") };
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
public class A277382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277382.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277382Inst Instance=new A277382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277383
{
public static readonly long[] Value={ 0L,2L,1L,3L,4L,5L,7L,9L,11L,6L,13L,15L,17L,19L,21L,23L,8L,25L,27L,29L,31L,33L,35L,37L,39L,10L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,12L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,14L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,16L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277383Inst : IEnumerable<long>
{
public static readonly long[] Value=A277383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277383.Bytes);
public long this[int i]=>Value[i];

public static A277383Inst Instance=new A277383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277384
{
public static readonly long[] Value={ 15L,6L,7L,0L,9L,10L,33L,12L,65L,42L,105L,16L,153L,90L,209L,60L,273L,154L,345L,48L,425L,234L,513L,140L,609L,330L,713L,96L,825L,442L,945L,252L,1073L,570L,1209L,160L,1353L,714L,1505L,396L,1665L,874L,1833L,240L,2009L,1050L,2193L,572L,2385L,1242L,2585L,336L,2793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277384Inst : IEnumerable<long>
{
public static readonly long[] Value=A277384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277384.Bytes);
public long this[int i]=>Value[i];

public static A277384Inst Instance=new A277384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277385
{
public static readonly long[] Value={ 15L,33L,65L,105L,153L,209L,273L,345L,425L,513L,609L,713L,825L,945L,1073L,1209L,1353L,1505L,1665L,1833L,2009L,2193L,2385L,2585L,2793L,3009L,3233L,3465L,3705L,3953L,4209L,4473L,4745L,5025L,5313L,5609L,5913L,6225L,6545L,6873L,7209L,7553L,7905L,8265L,8633L,9009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277385Inst : IEnumerable<long>
{
public static readonly long[] Value=A277385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277385.Bytes);
public long this[int i]=>Value[i];

public static A277385Inst Instance=new A277385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277386
{
public static readonly BigInteger[] Value={ 1L,4L,35L,438L,6873L,127488L,2703447L,64121130L,1674999009L,47638235484L,1461975938379L,48068355965886L,1683311251028265L,62477888170824792L,2447583053876363727L,BigInteger.Parse("100842325515959413842"),BigInteger.Parse("4356021203508275392833"),BigInteger.Parse("196739133595421931988020"),BigInteger.Parse("9268144156277932321747251") };
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
public class A277386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277386.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277386Inst Instance=new A277386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277387
{
public static readonly long[] Value={ 1L,17L,138L,670L,2355L,6671L,16212L,35148L,69765L,129085L,225566L,375882L,601783L,931035L,1398440L,2046936L,2928777L,4106793L,5655730L,7663670L,10233531L,13484647L,17554428L,22600100L,28800525L,36358101L,45500742L,56483938L,69592895L,85144755L,103490896L,125019312L,150157073L,179372865L,213179610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277387Inst : IEnumerable<long>
{
public static readonly long[] Value=A277387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277387.Bytes);
public long this[int i]=>Value[i];

public static A277387Inst Instance=new A277387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277388
{
public static readonly long[] Value={ 3L,47L,306L,1270L,4005L,10493L,24052L,49836L,95415L,171435L,292358L,477282L,750841L,1144185L,1696040L,2453848L,3474987L,4828071L,6594330L,8869070L,11763213L,15404917L,19941276L,25540100L,32391775L,40711203L,50739822L,62747706L,77035745L,93937905L,113823568L,137099952L,164214611L,195658015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277388Inst : IEnumerable<long>
{
public static readonly long[] Value=A277388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277388.Bytes);
public long this[int i]=>Value[i];

public static A277388Inst Instance=new A277388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277389
{
public static readonly long[] Value={ 1L,2L,1729L,19683001L,367804801L,631071001L,2064236401L,2320690177L,24899816449L,40017045601L,110592000001L,137299665601L,432081216001L,479534887801L,760355883001L,1111195454401L,3176523000001L,3495866888449L,3837165696001L,8571867768001L,14373832968001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277389Inst : IEnumerable<long>
{
public static readonly long[] Value=A277389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277389.Bytes);
public long this[int i]=>Value[i];

public static A277389Inst Instance=new A277389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277390
{
public static readonly long[] Value={ 1L,4L,2L,5L,9L,1L,9L,9L,9L,8L,1L,5L,9L,5L,9L,1L,3L,5L,2L,0L,6L,5L,5L,4L,2L,9L,6L,6L,1L,3L,2L,5L,0L,1L,1L,0L,4L,2L,7L,7L,1L,8L,8L,2L,4L,5L,4L,1L,9L,1L,1L,5L,5L,9L,0L,2L,4L,7L,1L,6L,2L,7L,7L,7L,5L,1L,6L,5L,7L,3L,2L,6L,1L,6L,8L,2L,4L,3L,1L,8L,5L,4L,3L,6L,4L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277390Inst : IEnumerable<long>
{
public static readonly long[] Value=A277390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277390.Bytes);
public long this[int i]=>Value[i];

public static A277390Inst Instance=new A277390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277391
{
public static readonly BigInteger[] Value={ 1L,3L,34L,654L,17688L,616120L,26252496L,1322624016L,76909665664L,5069558461824L,373529452588800L,30422117430022912L,2713911389090970624L,BigInteger.Parse("263171888496899625984"),BigInteger.Parse("27563036166079327578112"),BigInteger.Parse("3100736138961250867968000"),BigInteger.Parse("372888702864658105915244544") };
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
public class A277391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277391.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277391Inst Instance=new A277391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277392
{
public static readonly BigInteger[] Value={ 1L,4L,62L,1626L,59928L,2844120L,165100752L,11331597942L,897635712384L,80602042275756L,8090067511468800L,897561658361441106L,BigInteger.Parse("109072492644378442752"),BigInteger.Parse("14407931244544181001216"),BigInteger.Parse("2055559499598438969956352"),BigInteger.Parse("314997663481165477898736750"),BigInteger.Parse("51601245736595962597616222208") };
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
public class A277392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277392Inst Instance=new A277392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277393
{
public static readonly BigInteger[] Value={ 1L,2L,6L,36L,300L,3000L,35880L,502320L,8038800L,144698400L,2893937760L,63666630720L,1527999802560L,39727994866560L,1112383838966400L,33371515168992000L,1067888485926662400L,BigInteger.Parse("36308208521506521600"),BigInteger.Parse("1307095506756591552000"),BigInteger.Parse("49669629256750478976000") };
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
public class A277393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277393Inst Instance=new A277393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277394
{
public static readonly long[] Value={ 1L,-2L,10L,1L,-280L,56L,-1L,15400L,-4260L,120L,126L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277394Inst : IEnumerable<long>
{
public static readonly long[] Value=A277394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277394.Bytes);
public long this[int i]=>Value[i];

public static A277394Inst Instance=new A277394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277395
{
public static readonly long[] Value={ 1L,3L,9L,33L,145L,713L,3745L,20513L,115713L,667329L,3916033L,23305857L,140327681L,853262465L,5231925761L,32313686529L,200843829249L,1255308123137L,7884792852481L,49745076576257L,315091155558401L,2003009460686849L,12774610185633793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277395Inst : IEnumerable<long>
{
public static readonly long[] Value=A277395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277395.Bytes);
public long this[int i]=>Value[i];

public static A277395Inst Instance=new A277395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277460
{
public static readonly long[] Value={ 103L,388L,434L,437L,528L,657L,883L,1109L,1182L,1532L,1547L,1556L,1668L,1798L,1823L,1824L,1914L,1992L,2010L,2075L,2084L,2152L,2312L,2354L,2371L,2616L,2627L,2647L,2672L,3203L,3233L,3257L,3279L,3294L,3372L,3414L,3512L,3600L,3635L,3905L,3930L,3935L,4124L,4153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277460Inst : IEnumerable<long>
{
public static readonly long[] Value=A277460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277460.Bytes);
public long this[int i]=>Value[i];

public static A277460Inst Instance=new A277460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277461
{
public static readonly BigInteger[] Value={ 0L,1L,2L,11L,104L,1241L,18216L,317715L,6414848L,147107953L,3776164000L,107253230171L,3339157316736L,113070818225353L,4137170839854976L,162653198951193059L,6837934005096620032L,BigInteger.Parse("306093463368534049761"),BigInteger.Parse("14535589272368159900160"),BigInteger.Parse("729835620496621069643179") };
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
public class A277461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277461Inst Instance=new A277461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277462
{
public static readonly BigInteger[] Value={ 1L,1L,3L,24L,233L,2860L,42875L,758856L,15488657L,358164432L,9254769459L,264273873600L,8264362186489L,280896392748608L,10310601442639147L,406479520869636480L,17129450693008029729UL,BigInteger.Parse("768404013933189112064"),BigInteger.Parse("36557893891263190204259"),BigInteger.Parse("1838650651518153170939904") };
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
public class A277462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277462Inst Instance=new A277462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277463
{
public static readonly BigInteger[] Value={ 0L,1L,2L,13L,112L,1321L,19296L,335637L,6764864L,154946449L,3973820800L,112789880413L,3509627281920L,118790978349369L,4344883388878592L,170767066282574821L,7177162988688031744L,BigInteger.Parse("321206181612447781921"),BigInteger.Parse("15250250261039350358016"),BigInteger.Parse("765586309042945067185581") };
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
public class A277463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277463Inst Instance=new A277463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277464
{
public static readonly BigInteger[] Value={ 1L,1L,5L,30L,281L,3400L,50557L,890120L,18101617L,417464064L,10764826421L,306893014912L,9584448407305L,325407839778944L,11933432488693549L,470087171351873280L,BigInteger.Parse("19796492491889197025"),BigInteger.Parse("887518214183286390784"),BigInteger.Parse("42202928616264032249701"),BigInteger.Parse("2121583256369642798845952") };
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
public class A277464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277464Inst Instance=new A277464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277465
{
public static readonly BigInteger[] Value={ 0L,1L,1L,11L,86L,1084L,15654L,275113L,5548024L,127423728L,3272008650L,92988690893L,2896148079516L,98104636748468L,3590611928294286L,141201205469361945L,5937400341113630032L,BigInteger.Parse("265833516437952849024"),BigInteger.Parse("12625912572901413474834"),BigInteger.Parse("634047172218326393377149") };
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
public class A277465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277465Inst Instance=new A277465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277466
{
public static readonly BigInteger[] Value={ 0L,1L,3L,17L,146L,1684L,24294L,419383L,8412760L,192078864L,4914973770L,139265564723L,4327699948956L,146323675764044L,5347193667136398L,210005149832116455L,8820722263274822992L,BigInteger.Parse("394546588041904397184"),BigInteger.Parse("18723398414958791004690"),BigInteger.Parse("939550079246853331267203") };
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
public class A277466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277466Inst Instance=new A277466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277467
{
public static readonly BigInteger[] Value={ 0L,1L,2L,14L,116L,1376L,19926L,346128L,6964712L,159396352L,4085415850L,115906440704L,3605365584732L,121998144397312L,4461190462108030L,175305587376883712L,7366747721719011280L,BigInteger.Parse("329646098258032459776"),BigInteger.Parse("15649117182518598570834"),BigInteger.Parse("785528920149992297070592") };
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
public class A277467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277467Inst Instance=new A277467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277468
{
public static readonly BigInteger[] Value={ 0L,1L,2L,10L,100L,1216L,17766L,309744L,6260360L,143641600L,3688352650L,104786813440L,3263080663404L,110514370068480L,4044232154193518L,159019302501971968L,6685886706336107536L,BigInteger.Parse("299315231931854749696"),BigInteger.Parse("14214873507079452102162"),BigInteger.Parse("713784039156929684963328") };
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
public class A277468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277468Inst Instance=new A277468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277469
{
public static readonly BigInteger[] Value={ 0L,1L,2L,13L,112L,1329L,19344L,336533L,6778752L,155247777L,3980956800L,112984562813L,3515475849216L,118984054897681L,4351800687259648L,171034439586509445L,7188243684485414912L,BigInteger.Parse("321696219477456836929"),BigInteger.Parse("15273278824827215388672"),BigInteger.Parse("766732102664665113137517") };
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
public class A277469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277469Inst Instance=new A277469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277470
{
public static readonly BigInteger[] Value={ 0L,1L,2L,11L,104L,1249L,18264L,318163L,6425152L,147344769L,3781848480L,107408279483L,3343875651456L,113227469886881L,4142804357946240L,162871544915116035L,6847004160475236352L,BigInteger.Parse("306495323034774157569"),BigInteger.Parse("14554502490109085839872"),BigInteger.Parse("730777840212988501198059") };
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
public class A277470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277470Inst Instance=new A277470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277471
{
public static readonly BigInteger[] Value={ 2L,1L,5L,105L,7007L,1298745L,619247475L,723733375365L,2006532782969715L,12889909959143502285UL,BigInteger.Parse("188494585656727188486375"),BigInteger.Parse("6188497678605937441851529425"),BigInteger.Parse("451101946262511157576785806552415"),BigInteger.Parse("72341127537387548941434093006996374625"),BigInteger.Parse("25326487488712595887856341442148826764706875") };
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
public class A277471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277471Inst Instance=new A277471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277472
{
public static readonly BigInteger[] Value={ 1L,2L,10L,60L,492L,4920L,59160L,828240L,13253520L,238563360L,4771297440L,104968543680L,2519245713600L,65500388553600L,1834010896798080L,55020326903942400L,1760650461445075200L,BigInteger.Parse("59862115689132556800"),BigInteger.Parse("2155036164826415270400"),BigInteger.Parse("81891374263403780275200") };
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
public class A277472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277472Inst Instance=new A277472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277473
{
public static readonly BigInteger[] Value={ 0L,1L,4L,18L,116L,1060L,12702L,187810L,3296120L,66897288L,1540762010L,39693752494L,1130866726596L,35300006582620L,1198036854980630L,43921652697277170L,1729775120233353968L,BigInteger.Parse("72831210167041246480"),BigInteger.Parse("3264674481128340280242"),BigInteger.Parse("155220967397580333229270") };
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
public class A277473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277473Inst Instance=new A277473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277474
{
public static readonly BigInteger[] Value={ 0L,1L,0L,6L,36L,380L,4830L,74382L,1342712L,27825912L,651274650L,16994464850L,489240628932L,15404364096420L,526634857318934L,19428038813967630L,769280055136105200L,BigInteger.Parse("32543192449030871792"),BigInteger.Parse("1464827827285673677746"),BigInteger.Parse("69903432558329996409642"),BigInteger.Parse("3525344776953738276010940") };
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
public class A277474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277474.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277474Inst Instance=new A277474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277475
{
public static readonly BigInteger[] Value={ 0L,0L,2L,6L,32L,300L,3576L,52234L,906688L,18229176L,416505760L,10657541422L,301871501568L,9375794555556L,316817746172032L,11570642333807730L,454152692297009152L,BigInteger.Parse("19064517871187079408"),BigInteger.Parse("852278820775206658560"),BigInteger.Parse("40424330665968520135382"),BigInteger.Parse("2027524052626732381306880") };
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
public class A277475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277475Inst Instance=new A277475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277764
{
public static readonly BigInteger[] Value={ 0L,80L,1989L,275018L,20049229L,1762881313L,145416104585L,12253138042478L,1025207978301185L,85977721285058269L,7204885193038036176L,BigInteger.Parse("603918178598058203435"),BigInteger.Parse("50616585384840289440801"),BigInteger.Parse("4242477668915521353604820") };
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
public class A277764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277764Inst Instance=new A277764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277765
{
public static readonly BigInteger[] Value={ 0L,356L,21141L,7824415L,1487830718L,343944986355L,74591651561541L,16513537201433122L,3631417278822015869L,BigInteger.Parse("800314315609344769958"),BigInteger.Parse("176252542616326417994974"),BigInteger.Parse("38825002002696841996583880") };
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
public class A277765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277765Inst Instance=new A277765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277766
{
public static readonly BigInteger[] Value={ 0L,1584L,220549L,221983169L,110036582827L,67079817376928L,38224184451654485L,BigInteger.Parse("22257182633194608078"),BigInteger.Parse("12869705874813306766481"),BigInteger.Parse("7458446559929491293690613"),BigInteger.Parse("4319259920844964071189461906"),BigInteger.Parse("2501924582698962860252708115060") };
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
public class A277766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277766Inst Instance=new A277766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277767
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,4L,2L,0L,0L,18L,17L,14L,0L,0L,80L,204L,330L,56L,0L,0L,356L,1989L,9741L,3666L,284L,0L,0L,1584L,21141L,275018L,270291L,46289L,1304L,0L,0L,7048L,220549L,7824415L,20049229L,8971150L,560809L,6248L,0L,0L,31360L,2292380L,221983169L,1487830718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277767Inst : IEnumerable<long>
{
public static readonly long[] Value=A277767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277767.Bytes);
public long this[int i]=>Value[i];

public static A277767Inst Instance=new A277767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277768
{
public static readonly long[] Value={ 0L,2L,17L,204L,1989L,21141L,220549L,2292380L,23911889L,249253583L,2597767946L,27078215723L,282249897665L,2942003150449L,30665850885332L,319644266438138L,3331797339053418L,34728844714392948L,361994612635214032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277768Inst : IEnumerable<long>
{
public static readonly long[] Value=A277768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277768.Bytes);
public long this[int i]=>Value[i];

public static A277768Inst Instance=new A277768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277769
{
public static readonly BigInteger[] Value={ 0L,14L,330L,9741L,275018L,7824415L,221983169L,6298326387L,178728649865L,5071423132367L,143902812077769L,4083281399156407L,115864087742823865L,3287671351656190808L,BigInteger.Parse("93288470977649320614"),BigInteger.Parse("2647082885606708742103") };
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
public class A277769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277769Inst Instance=new A277769Inst();

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