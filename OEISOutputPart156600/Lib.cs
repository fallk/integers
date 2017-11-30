using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199705
{
public static readonly long[] Value={ 6L,14L,32L,52L,82L,114L,156L,200L,254L,310L,376L,444L,522L,602L,692L,784L,886L,990L,1104L,1220L,1346L,1474L,1612L,1752L,1902L,2054L,2216L,2380L,2554L,2730L,2916L,3104L,3302L,3502L,3712L,3924L,4146L,4370L,4604L,4840L,5086L,5334L,5592L,5852L,6122L,6394L,6676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199705Inst : IEnumerable<long>
{
public static readonly long[] Value=A199705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199705.Bytes);
public long this[int i]=>Value[i];

public static A199705Inst Instance=new A199705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199706
{
public static readonly long[] Value={ 8L,52L,168L,380L,724L,1236L,1940L,2872L,4068L,5552L,7360L,9528L,12080L,15052L,18480L,22388L,26812L,31788L,37340L,43504L,50316L,57800L,65992L,74928L,84632L,95140L,106488L,118700L,131812L,145860L,160868L,176872L,193908L,212000L,231184L,251496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199706Inst : IEnumerable<long>
{
public static readonly long[] Value=A199706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199706.Bytes);
public long this[int i]=>Value[i];

public static A199706Inst Instance=new A199706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199707
{
public static readonly long[] Value={ 14L,200L,892L,2734L,6504L,13324L,24394L,41344L,65788L,99858L,145596L,205612L,282386L,379036L,498440L,644218L,819692L,1028960L,1275766L,1564716L,1899968L,2286630L,2729288L,3233528L,3804374L,4447920L,5169588L,5975974L,6872944L,7867572L,8966146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199707Inst : IEnumerable<long>
{
public static readonly long[] Value=A199707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199707.Bytes);
public long this[int i]=>Value[i];

public static A199707Inst Instance=new A199707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199708
{
public static readonly long[] Value={ 32L,708L,4964L,20116L,59992L,147072L,314532L,608420L,1089752L,1836600L,2946204L,4537152L,6751384L,9756388L,13747296L,18948952L,25618064L,34045344L,44557532L,57519592L,73336788L,92456792L,115371796L,142620672L,174790996L,212521224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199708Inst : IEnumerable<long>
{
public static readonly long[] Value=A199708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199708.Bytes);
public long this[int i]=>Value[i];

public static A199708Inst Instance=new A199708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199709
{
public static readonly long[] Value={ 56L,2642L,27854L,149942L,559028L,1643204L,4099204L,9059092L,18251656L,34171380L,60292468L,101279218L,163252890L,254042820L,383508158L,563826638L,809873706L,1139548482L,1574209250L,2139036592L,2863528108L,3781894246L,4933615190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199709Inst : IEnumerable<long>
{
public static readonly long[] Value=A199709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199709.Bytes);
public long this[int i]=>Value[i];

public static A199709Inst Instance=new A199709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199710
{
public static readonly long[] Value={ 1L,1L,14L,41L,223L,979L,3878L,20483L,70897L,408073L,1329734L,7964417L,25250959L,154039339L,482301806L,2967115019L,9237038497L,57046572241L,177128072702L,1095861584537L,3398526529663L,21043253658307L,65224098543926L,404010494645843L,1251923775716881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199710Inst : IEnumerable<long>
{
public static readonly long[] Value=A199710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199710.Bytes);
public long this[int i]=>Value[i];

public static A199710Inst Instance=new A199710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199711
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,4L,4L,1L,1L,3L,6L,7L,5L,1L,1L,3L,7L,10L,11L,6L,1L,1L,3L,9L,13L,17L,16L,7L,1L,1L,4L,11L,16L,27L,28L,22L,8L,1L,1L,4L,13L,22L,37L,44L,44L,29L,9L,1L,1L,4L,15L,24L,49L,64L,72L,66L,37L,10L,1L,1L,5L,18L,32L,66L,85L,116L,116L,95L,46L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199711Inst : IEnumerable<long>
{
public static readonly long[] Value=A199711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199711.Bytes);
public long this[int i]=>Value[i];

public static A199711Inst Instance=new A199711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199712
{
public static readonly long[] Value={ 3L,7L,8L,5L,8L,0L,6L,5L,6L,7L,5L,1L,9L,7L,4L,0L,6L,6L,6L,7L,6L,7L,6L,8L,4L,2L,8L,1L,7L,8L,8L,3L,1L,6L,0L,8L,6L,9L,8L,0L,2L,8L,9L,6L,1L,3L,5L,7L,8L,4L,4L,1L,9L,5L,8L,2L,1L,8L,7L,9L,2L,0L,7L,5L,8L,2L,9L,1L,4L,2L,0L,7L,4L,1L,6L,0L,0L,7L,4L,2L,2L,4L,2L,6L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199712Inst : IEnumerable<long>
{
public static readonly long[] Value=A199712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199712.Bytes);
public long this[int i]=>Value[i];

public static A199712Inst Instance=new A199712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199713
{
public static readonly long[] Value={ 23L,13L,53L,17L,101L,31L,71L,109L,223L,229L,103L,73L,149L,347L,347L,353L,359L,163L,167L,107L,137L,97L,283L,389L,179L,1013L,1013L,701L,1009L,131L,271L,311L,173L,193L,419L,1051L,571L,613L,617L,317L,197L,811L,911L,1039L,719L,919L,1021L,1223L,2027L,1229L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199713Inst : IEnumerable<long>
{
public static readonly long[] Value=A199713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199713.Bytes);
public long this[int i]=>Value[i];

public static A199713Inst Instance=new A199713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199714
{
public static readonly long[] Value={ 0L,9L,23L,30L,35L,49L,58L,73L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199714Inst : IEnumerable<long>
{
public static readonly long[] Value=A199714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199714.Bytes);
public long this[int i]=>Value[i];

public static A199714Inst Instance=new A199714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199715
{
public static readonly long[] Value={ 2L,8L,2L,3L,4L,9L,4L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199715Inst : IEnumerable<long>
{
public static readonly long[] Value=A199715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199715.Bytes);
public long this[int i]=>Value[i];

public static A199715Inst Instance=new A199715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199716
{
public static readonly long[] Value={ 16L,20L,21L,35L,37L,50L,51L,54L,55L,61L,66L,68L,76L,79L,81L,83L,86L,89L,90L,105L,112L,115L,118L,121L,125L,128L,130L,131L,134L,141L,142L,145L,146L,149L,150L,151L,153L,156L,160L,161L,165L,168L,180L,181L,186L,190L,191L,195L,200L,202L,208L,211L,212L,219L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199716Inst : IEnumerable<long>
{
public static readonly long[] Value=A199716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199716.Bytes);
public long this[int i]=>Value[i];

public static A199716Inst Instance=new A199716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199717
{
public static readonly long[] Value={ 6L,11L,13L,24L,26L,27L,31L,34L,36L,41L,46L,48L,56L,57L,62L,63L,69L,71L,73L,88L,91L,92L,96L,97L,101L,102L,104L,106L,111L,116L,119L,122L,123L,126L,132L,136L,139L,154L,166L,167L,171L,173L,174L,176L,178L,179L,187L,188L,189L,193L,196L,201L,206L,207L,209L,216L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199717Inst : IEnumerable<long>
{
public static readonly long[] Value=A199717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199717.Bytes);
public long this[int i]=>Value[i];

public static A199717Inst Instance=new A199717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199718
{
public static readonly long[] Value={ 5L,9L,10L,15L,23L,25L,29L,30L,32L,40L,42L,43L,44L,45L,49L,58L,60L,65L,70L,72L,75L,80L,85L,87L,93L,94L,95L,98L,99L,100L,107L,109L,110L,114L,117L,120L,133L,135L,137L,140L,155L,158L,159L,163L,164L,170L,172L,175L,177L,184L,185L,192L,194L,197L,198L,199L,204L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199718Inst : IEnumerable<long>
{
public static readonly long[] Value=A199718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199718.Bytes);
public long this[int i]=>Value[i];

public static A199718Inst Instance=new A199718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199719
{
public static readonly long[] Value={ 1L,8L,3L,7L,1L,8L,8L,7L,3L,0L,0L,1L,5L,1L,4L,3L,9L,2L,4L,2L,5L,7L,5L,6L,9L,4L,4L,1L,6L,2L,2L,0L,0L,8L,2L,3L,2L,5L,5L,8L,4L,2L,3L,7L,5L,1L,1L,5L,2L,9L,8L,6L,0L,1L,3L,5L,4L,9L,2L,3L,6L,1L,7L,3L,4L,8L,3L,1L,2L,5L,7L,1L,2L,9L,0L,7L,2L,5L,7L,0L,9L,7L,2L,6L,5L,2L,8L,7L,3L,8L,1L,9L,8L,4L,7L,6L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199719Inst : IEnumerable<long>
{
public static readonly long[] Value=A199719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199719.Bytes);
public long this[int i]=>Value[i];

public static A199719Inst Instance=new A199719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199720
{
public static readonly long[] Value={ 1L,6L,7L,5L,7L,1L,3L,3L,5L,8L,1L,7L,7L,0L,1L,5L,2L,7L,0L,4L,0L,5L,4L,3L,4L,8L,9L,1L,5L,2L,9L,3L,0L,4L,6L,0L,2L,9L,7L,1L,7L,0L,1L,7L,0L,7L,7L,6L,4L,1L,4L,8L,9L,9L,7L,3L,1L,7L,4L,6L,6L,7L,6L,8L,1L,8L,4L,0L,9L,5L,0L,6L,8L,2L,0L,7L,2L,6L,1L,6L,0L,3L,0L,4L,1L,5L,2L,6L,7L,8L,4L,1L,6L,2L,3L,6L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199720Inst : IEnumerable<long>
{
public static readonly long[] Value=A199720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199720.Bytes);
public long this[int i]=>Value[i];

public static A199720Inst Instance=new A199720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199721
{
public static readonly long[] Value={ 1L,4L,6L,4L,3L,3L,5L,1L,0L,3L,8L,6L,8L,0L,6L,7L,6L,6L,9L,6L,2L,3L,7L,2L,0L,4L,7L,8L,4L,2L,0L,4L,0L,8L,3L,7L,6L,2L,4L,9L,2L,5L,7L,4L,8L,6L,5L,8L,7L,2L,1L,7L,0L,0L,0L,4L,2L,3L,4L,7L,0L,1L,5L,6L,4L,2L,9L,2L,1L,9L,5L,7L,5L,8L,3L,4L,2L,4L,6L,0L,5L,7L,9L,4L,7L,6L,4L,9L,5L,8L,0L,7L,8L,8L,8L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199721Inst : IEnumerable<long>
{
public static readonly long[] Value=A199721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199721.Bytes);
public long this[int i]=>Value[i];

public static A199721Inst Instance=new A199721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199722
{
public static readonly long[] Value={ 1L,1L,7L,3L,1L,4L,8L,3L,8L,0L,8L,5L,5L,4L,0L,4L,0L,7L,9L,5L,3L,5L,9L,8L,3L,2L,2L,6L,8L,7L,2L,9L,2L,2L,6L,3L,8L,8L,3L,5L,8L,6L,5L,0L,3L,2L,0L,0L,9L,5L,2L,8L,9L,8L,4L,1L,2L,5L,8L,8L,4L,1L,1L,2L,4L,3L,1L,2L,6L,8L,6L,4L,8L,6L,0L,3L,4L,7L,1L,1L,7L,9L,6L,5L,8L,1L,0L,0L,6L,8L,7L,5L,2L,5L,3L,9L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199722Inst : IEnumerable<long>
{
public static readonly long[] Value=A199722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199722.Bytes);
public long this[int i]=>Value[i];

public static A199722Inst Instance=new A199722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199723
{
public static readonly long[] Value={ 1L,7L,8L,0L,6L,0L,8L,1L,1L,9L,9L,6L,6L,6L,3L,5L,2L,0L,4L,3L,3L,7L,8L,0L,1L,8L,4L,9L,0L,7L,6L,6L,6L,6L,9L,2L,2L,1L,7L,0L,4L,2L,1L,7L,2L,5L,7L,3L,1L,8L,2L,1L,6L,4L,4L,5L,0L,6L,1L,2L,5L,1L,4L,5L,5L,7L,4L,8L,0L,4L,1L,0L,5L,0L,9L,3L,6L,1L,6L,8L,3L,3L,2L,8L,5L,0L,1L,3L,2L,4L,6L,4L,7L,8L,4L,6L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199723Inst : IEnumerable<long>
{
public static readonly long[] Value=A199723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199723.Bytes);
public long this[int i]=>Value[i];

public static A199723Inst Instance=new A199723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199724
{
public static readonly long[] Value={ 1L,6L,5L,1L,0L,0L,0L,9L,3L,4L,4L,3L,9L,7L,1L,5L,7L,9L,8L,3L,0L,6L,8L,4L,8L,0L,8L,9L,8L,0L,4L,5L,7L,2L,8L,1L,4L,4L,1L,5L,8L,2L,8L,5L,5L,2L,9L,2L,4L,1L,7L,7L,2L,2L,7L,0L,8L,0L,6L,8L,6L,3L,4L,0L,5L,3L,0L,3L,9L,3L,7L,2L,0L,6L,4L,5L,5L,1L,8L,9L,7L,0L,1L,0L,4L,9L,1L,3L,7L,3L,7L,4L,0L,8L,3L,2L,9L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199724Inst : IEnumerable<long>
{
public static readonly long[] Value=A199724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199724.Bytes);
public long this[int i]=>Value[i];

public static A199724Inst Instance=new A199724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199725
{
public static readonly long[] Value={ 1L,4L,9L,2L,4L,6L,3L,2L,3L,9L,8L,0L,6L,3L,7L,8L,6L,7L,2L,0L,7L,0L,4L,0L,6L,5L,8L,9L,5L,2L,8L,0L,4L,3L,7L,9L,9L,0L,6L,1L,7L,7L,3L,6L,3L,5L,7L,2L,8L,3L,4L,3L,9L,2L,8L,5L,2L,5L,8L,7L,8L,2L,8L,0L,2L,6L,8L,9L,2L,1L,3L,0L,5L,6L,7L,0L,6L,7L,6L,5L,8L,6L,7L,6L,6L,6L,9L,3L,5L,0L,8L,0L,7L,5L,7L,2L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199725Inst : IEnumerable<long>
{
public static readonly long[] Value=A199725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199725.Bytes);
public long this[int i]=>Value[i];

public static A199725Inst Instance=new A199725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199726
{
public static readonly long[] Value={ 1L,2L,9L,2L,7L,6L,2L,3L,8L,4L,7L,7L,3L,4L,9L,5L,8L,4L,6L,0L,6L,7L,8L,8L,8L,4L,3L,5L,4L,1L,5L,7L,7L,9L,4L,2L,1L,7L,5L,7L,9L,7L,4L,4L,3L,8L,5L,3L,3L,8L,3L,3L,0L,4L,0L,0L,1L,6L,5L,1L,7L,8L,5L,7L,9L,6L,3L,9L,9L,4L,3L,6L,1L,3L,5L,4L,8L,4L,5L,8L,8L,3L,6L,6L,0L,3L,3L,9L,3L,1L,8L,8L,8L,5L,3L,3L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199726Inst : IEnumerable<long>
{
public static readonly long[] Value=A199726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199726.Bytes);
public long this[int i]=>Value[i];

public static A199726Inst Instance=new A199726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199727
{
public static readonly long[] Value={ 1L,7L,4L,3L,6L,8L,8L,9L,5L,6L,4L,9L,1L,3L,0L,2L,3L,1L,6L,1L,6L,2L,9L,2L,1L,5L,5L,3L,0L,1L,3L,6L,0L,0L,8L,5L,3L,4L,0L,4L,4L,2L,1L,2L,6L,5L,1L,5L,2L,8L,7L,9L,2L,8L,4L,2L,3L,0L,9L,1L,7L,6L,0L,3L,6L,8L,5L,9L,2L,4L,2L,1L,5L,3L,6L,5L,0L,9L,1L,4L,4L,6L,5L,7L,6L,4L,8L,3L,9L,1L,2L,3L,1L,9L,0L,1L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199727Inst : IEnumerable<long>
{
public static readonly long[] Value=A199727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199727.Bytes);
public long this[int i]=>Value[i];

public static A199727Inst Instance=new A199727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199728
{
public static readonly long[] Value={ 1L,6L,3L,5L,6L,8L,8L,7L,5L,1L,1L,5L,4L,1L,1L,0L,1L,7L,9L,7L,7L,8L,6L,1L,4L,4L,1L,8L,0L,3L,7L,7L,9L,0L,9L,4L,8L,4L,0L,9L,9L,5L,7L,9L,5L,1L,2L,3L,6L,0L,7L,1L,2L,7L,8L,3L,2L,8L,3L,6L,7L,8L,3L,3L,6L,7L,9L,0L,7L,1L,7L,4L,8L,1L,6L,2L,8L,8L,7L,4L,5L,8L,1L,5L,6L,0L,2L,3L,7L,3L,3L,8L,9L,0L,7L,7L,6L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199728Inst : IEnumerable<long>
{
public static readonly long[] Value=A199728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199728.Bytes);
public long this[int i]=>Value[i];

public static A199728Inst Instance=new A199728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199729
{
public static readonly long[] Value={ 1L,5L,0L,8L,8L,1L,6L,7L,0L,3L,3L,4L,9L,5L,0L,3L,0L,5L,0L,7L,8L,1L,0L,1L,8L,0L,8L,2L,7L,2L,2L,1L,6L,3L,4L,0L,4L,3L,9L,1L,6L,0L,1L,1L,1L,5L,3L,6L,3L,4L,9L,5L,7L,1L,8L,3L,5L,6L,9L,7L,7L,9L,0L,0L,4L,5L,5L,7L,7L,3L,8L,6L,2L,8L,6L,5L,0L,7L,4L,7L,7L,6L,6L,5L,3L,0L,0L,1L,4L,4L,2L,4L,5L,8L,4L,3L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199729Inst : IEnumerable<long>
{
public static readonly long[] Value=A199729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199729.Bytes);
public long this[int i]=>Value[i];

public static A199729Inst Instance=new A199729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199730
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,2L,0L,0L,6L,2L,3L,6L,1L,3L,7L,1L,8L,4L,4L,2L,2L,5L,1L,0L,3L,4L,8L,6L,3L,3L,7L,3L,9L,6L,5L,4L,6L,2L,4L,7L,3L,4L,9L,1L,7L,2L,6L,7L,2L,4L,4L,4L,8L,6L,3L,3L,6L,7L,0L,9L,2L,9L,2L,5L,2L,1L,6L,1L,5L,6L,1L,8L,7L,2L,8L,0L,4L,4L,8L,2L,8L,9L,4L,3L,7L,5L,7L,3L,7L,2L,4L,8L,0L,7L,5L,1L,2L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199730Inst : IEnumerable<long>
{
public static readonly long[] Value=A199730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199730.Bytes);
public long this[int i]=>Value[i];

public static A199730Inst Instance=new A199730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199731
{
public static readonly long[] Value={ 3L,8L,0L,2L,8L,4L,2L,7L,0L,0L,6L,2L,3L,5L,9L,1L,7L,1L,6L,4L,0L,4L,3L,7L,9L,7L,5L,1L,8L,8L,5L,5L,4L,9L,8L,3L,5L,2L,0L,1L,6L,2L,3L,0L,2L,9L,5L,9L,6L,2L,4L,3L,7L,0L,5L,5L,8L,8L,6L,2L,4L,0L,5L,4L,1L,0L,7L,3L,1L,2L,1L,0L,7L,7L,9L,5L,1L,0L,7L,4L,3L,9L,3L,3L,6L,0L,5L,3L,6L,4L,5L,4L,5L,6L,8L,5L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199731Inst : IEnumerable<long>
{
public static readonly long[] Value=A199731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199731.Bytes);
public long this[int i]=>Value[i];

public static A199731Inst Instance=new A199731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199732
{
public static readonly long[] Value={ 1L,7L,1L,7L,7L,6L,1L,7L,0L,1L,5L,5L,9L,1L,4L,6L,7L,3L,7L,9L,4L,6L,5L,4L,6L,9L,3L,7L,6L,8L,3L,0L,8L,4L,0L,1L,0L,8L,3L,6L,6L,9L,6L,2L,7L,3L,2L,6L,4L,6L,5L,7L,0L,5L,3L,1L,8L,2L,8L,1L,3L,5L,5L,1L,1L,2L,3L,7L,5L,0L,4L,2L,0L,1L,0L,9L,6L,6L,9L,3L,3L,1L,2L,8L,9L,7L,5L,5L,1L,6L,9L,0L,7L,5L,6L,1L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199732Inst : IEnumerable<long>
{
public static readonly long[] Value=A199732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199732.Bytes);
public long this[int i]=>Value[i];

public static A199732Inst Instance=new A199732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199733
{
public static readonly long[] Value={ 3L,7L,4L,6L,1L,6L,8L,5L,6L,5L,5L,2L,8L,2L,2L,1L,3L,4L,0L,6L,8L,7L,0L,1L,3L,5L,6L,0L,5L,2L,7L,5L,9L,6L,9L,7L,8L,8L,5L,6L,5L,4L,6L,3L,8L,9L,1L,5L,6L,5L,1L,1L,2L,9L,8L,1L,8L,6L,5L,6L,4L,7L,4L,8L,5L,8L,6L,8L,4L,6L,3L,2L,8L,1L,8L,3L,2L,6L,3L,6L,7L,2L,5L,2L,8L,2L,4L,8L,1L,0L,6L,7L,7L,2L,4L,4L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199733Inst : IEnumerable<long>
{
public static readonly long[] Value=A199733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199733.Bytes);
public long this[int i]=>Value[i];

public static A199733Inst Instance=new A199733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199734
{
public static readonly long[] Value={ 1L,6L,2L,5L,2L,7L,8L,3L,8L,3L,3L,7L,8L,4L,4L,8L,6L,4L,3L,9L,3L,3L,0L,0L,3L,2L,2L,6L,2L,4L,6L,8L,3L,6L,1L,0L,6L,0L,8L,6L,5L,5L,9L,6L,7L,1L,6L,5L,8L,5L,7L,2L,8L,1L,5L,4L,4L,7L,5L,9L,5L,5L,8L,3L,7L,9L,3L,6L,1L,2L,3L,7L,9L,4L,4L,8L,6L,8L,8L,1L,9L,7L,7L,8L,7L,3L,1L,5L,2L,5L,4L,9L,3L,4L,0L,9L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199734Inst : IEnumerable<long>
{
public static readonly long[] Value=A199734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199734.Bytes);
public long this[int i]=>Value[i];

public static A199734Inst Instance=new A199734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199735
{
public static readonly long[] Value={ 3L,6L,9L,2L,2L,1L,4L,2L,4L,5L,4L,3L,5L,8L,4L,0L,4L,6L,1L,1L,2L,1L,0L,1L,6L,8L,2L,9L,3L,7L,2L,6L,8L,7L,5L,3L,8L,5L,0L,8L,6L,7L,2L,6L,7L,2L,8L,8L,7L,7L,5L,4L,8L,6L,6L,1L,1L,3L,9L,7L,7L,6L,9L,2L,3L,2L,9L,4L,3L,2L,8L,2L,7L,9L,0L,8L,1L,8L,4L,0L,2L,9L,2L,5L,4L,9L,9L,1L,9L,7L,2L,2L,4L,2L,6L,7L,1L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199735Inst : IEnumerable<long>
{
public static readonly long[] Value=A199735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199735.Bytes);
public long this[int i]=>Value[i];

public static A199735Inst Instance=new A199735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199736
{
public static readonly long[] Value={ 1L,5L,1L,9L,5L,1L,4L,9L,2L,6L,4L,7L,0L,4L,0L,1L,2L,2L,1L,5L,8L,5L,7L,0L,5L,1L,6L,2L,0L,9L,8L,1L,4L,8L,9L,9L,0L,5L,5L,6L,3L,3L,9L,8L,8L,6L,8L,9L,3L,4L,3L,5L,6L,3L,8L,8L,5L,1L,9L,2L,1L,5L,1L,6L,1L,7L,9L,8L,1L,3L,3L,8L,5L,2L,1L,7L,2L,7L,8L,9L,7L,2L,6L,8L,0L,2L,0L,5L,3L,1L,2L,0L,1L,8L,1L,2L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199736Inst : IEnumerable<long>
{
public static readonly long[] Value=A199736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199736.Bytes);
public long this[int i]=>Value[i];

public static A199736Inst Instance=new A199736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199737
{
public static readonly long[] Value={ 3L,6L,4L,1L,7L,3L,6L,5L,1L,0L,4L,2L,3L,2L,0L,3L,0L,8L,9L,1L,5L,6L,8L,0L,1L,7L,1L,2L,1L,9L,1L,6L,8L,8L,9L,1L,9L,4L,7L,4L,4L,1L,5L,6L,3L,0L,6L,1L,3L,8L,5L,4L,5L,6L,9L,0L,8L,9L,9L,4L,2L,4L,5L,1L,9L,9L,5L,8L,6L,1L,0L,9L,4L,0L,3L,4L,5L,1L,0L,1L,0L,9L,8L,2L,7L,9L,2L,6L,9L,6L,7L,0L,5L,5L,8L,2L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199737Inst : IEnumerable<long>
{
public static readonly long[] Value=A199737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199737.Bytes);
public long this[int i]=>Value[i];

public static A199737Inst Instance=new A199737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199738
{
public static readonly long[] Value={ 1L,3L,9L,6L,9L,4L,8L,6L,8L,3L,5L,4L,5L,6L,8L,4L,7L,7L,2L,3L,5L,2L,8L,6L,3L,5L,7L,9L,4L,6L,5L,2L,6L,8L,2L,1L,3L,9L,8L,0L,4L,3L,6L,8L,9L,7L,5L,9L,2L,7L,1L,4L,1L,0L,6L,1L,4L,0L,9L,5L,0L,0L,9L,7L,9L,8L,5L,7L,9L,4L,3L,9L,4L,6L,9L,5L,5L,3L,7L,2L,4L,5L,5L,0L,3L,7L,8L,5L,0L,4L,7L,9L,5L,3L,7L,9L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199738Inst : IEnumerable<long>
{
public static readonly long[] Value=A199738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199738.Bytes);
public long this[int i]=>Value[i];

public static A199738Inst Instance=new A199738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199739
{
public static readonly long[] Value={ 1L,4L,4L,0L,9L,8L,5L,1L,6L,3L,2L,1L,0L,3L,7L,3L,7L,7L,8L,4L,5L,1L,3L,8L,0L,4L,5L,4L,2L,3L,4L,8L,2L,8L,4L,2L,7L,0L,0L,4L,4L,4L,9L,0L,2L,5L,8L,2L,4L,3L,7L,6L,1L,9L,4L,5L,8L,1L,2L,3L,9L,0L,7L,5L,8L,1L,0L,0L,9L,0L,6L,8L,5L,1L,7L,2L,3L,1L,6L,1L,3L,5L,1L,8L,1L,2L,2L,7L,6L,6L,1L,9L,1L,2L,4L,3L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199739Inst : IEnumerable<long>
{
public static readonly long[] Value=A199739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199739.Bytes);
public long this[int i]=>Value[i];

public static A199739Inst Instance=new A199739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199740
{
public static readonly long[] Value={ 1L,2L,7L,3L,0L,8L,0L,7L,1L,4L,9L,0L,1L,0L,1L,5L,3L,5L,9L,2L,5L,0L,2L,7L,2L,7L,8L,3L,1L,5L,1L,9L,3L,1L,8L,9L,0L,6L,6L,8L,3L,2L,5L,7L,2L,2L,2L,0L,8L,4L,0L,8L,0L,9L,8L,9L,7L,0L,7L,5L,2L,5L,0L,5L,4L,1L,1L,7L,3L,9L,5L,0L,4L,6L,9L,5L,9L,7L,1L,1L,5L,0L,7L,2L,8L,6L,7L,7L,2L,1L,6L,8L,7L,1L,1L,5L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199740Inst : IEnumerable<long>
{
public static readonly long[] Value=A199740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199740.Bytes);
public long this[int i]=>Value[i];

public static A199740Inst Instance=new A199740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199741
{
public static readonly long[] Value={ 1L,0L,6L,4L,2L,3L,0L,2L,2L,2L,8L,7L,1L,0L,7L,3L,0L,2L,6L,1L,0L,0L,2L,1L,4L,1L,1L,4L,3L,2L,9L,4L,3L,7L,0L,9L,6L,1L,8L,8L,5L,3L,9L,5L,1L,3L,2L,8L,5L,9L,0L,3L,4L,3L,2L,7L,7L,7L,8L,0L,7L,8L,2L,9L,8L,7L,6L,2L,3L,4L,5L,8L,5L,6L,7L,8L,1L,2L,6L,1L,3L,4L,2L,7L,5L,4L,9L,5L,8L,7L,5L,5L,7L,3L,7L,3L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199741Inst : IEnumerable<long>
{
public static readonly long[] Value=A199741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199741.Bytes);
public long this[int i]=>Value[i];

public static A199741Inst Instance=new A199741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199742
{
public static readonly long[] Value={ 7L,9L,7L,7L,7L,5L,5L,9L,3L,3L,0L,1L,3L,9L,6L,5L,6L,4L,7L,3L,4L,0L,8L,3L,2L,2L,9L,1L,2L,9L,0L,2L,4L,5L,4L,4L,4L,1L,8L,4L,2L,8L,9L,4L,1L,3L,6L,1L,8L,0L,6L,2L,5L,8L,3L,6L,2L,8L,4L,6L,0L,1L,5L,1L,1L,2L,9L,9L,9L,1L,1L,6L,8L,4L,5L,4L,0L,3L,8L,6L,7L,5L,8L,8L,2L,3L,3L,0L,3L,1L,6L,3L,1L,5L,3L,5L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199742Inst : IEnumerable<long>
{
public static readonly long[] Value=A199742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199742.Bytes);
public long this[int i]=>Value[i];

public static A199742Inst Instance=new A199742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199743
{
public static readonly long[] Value={ 15L,32L,96L,960L,5280L,640320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199743Inst : IEnumerable<long>
{
public static readonly long[] Value=A199743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199743.Bytes);
public long this[int i]=>Value[i];

public static A199743Inst Instance=new A199743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199744
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,2L,-1L,-4L,1L,7L,0L,-12L,-3L,20L,10L,-32L,-25L,49L,55L,-71L,-112L,95L,216L,-111L,-399L,94L,710L,11L,-1220L,-316L,2024L,1037L,-3233L,-2573L,4941L,5634L,-7137L,-11440L,9505L,22015L,-11008L,-40592L,9073L,72112L,1934L,-123712L,-33453L,204897L,107499L,-326675L,-264664L,498119L,577060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199744Inst : IEnumerable<long>
{
public static readonly long[] Value=A199744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199744.Bytes);
public long this[int i]=>Value[i];

public static A199744Inst Instance=new A199744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199745
{
public static readonly long[] Value={ 2145L,2730L,4641L,4845L,5005L,5460L,5610L,6435L,7410L,8190L,8778L,9177L,10725L,10920L,11220L,11305L,11730L,13485L,13585L,13650L,13923L,14535L,14820L,16380L,16830L,17017L,17556L,19110L,19305L,20010L,20930L,21489L,21505L,21840L,22230L,22440L,23460L,23529L,23595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199745Inst : IEnumerable<long>
{
public static readonly long[] Value=A199745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199745.Bytes);
public long this[int i]=>Value[i];

public static A199745Inst Instance=new A199745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199746
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,66L,449L,3678L,35111L,383192L,4704300L,64172052L,962908056L,15762088585L,279514500434L,5338014558032L,109224066408835L,2383887010044728L,55281768382909480L,1357381019671809552L,BigInteger.Parse("35180557115610914376"),BigInteger.Parse("959798458208463538416"),BigInteger.Parse("27494554196938752676656") };
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
public class A199746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199746Inst Instance=new A199746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199747
{
public static readonly BigInteger[] Value={ 1L,2L,21L,455L,14950L,658008L,36288252L,2404808340L,186087894300L,16466440817750L,1639875152957965L,181513211783531667L,BigInteger.Parse("22105238818111121361"),BigInteger.Parse("2937279723907795168000"),BigInteger.Parse("422879027090638497044400"),BigInteger.Parse("65572027180886570401929144"),BigInteger.Parse("10894880155433107077641916792") };
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
public class A199747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199747Inst Instance=new A199747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199748
{
public static readonly BigInteger[] Value={ 1L,1L,10L,220L,7315L,324632L,18009460L,1198774720L,93080887185L,8258898672310L,824313388697656L,91408035226209520L,11149106984707682900UL,BigInteger.Parse("1483408105790477598270"),BigInteger.Parse("213807915740948618992925"),BigInteger.Parse("33186033477308745271085760"),BigInteger.Parse("5518696446064784220490766525") };
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
public class A199748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199748Inst Instance=new A199748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199749
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,1L,61L,-23L,-391L,149L,8731L,-50299L,-422111L,7453L,1282822973L,57034969L,-20654287L,-312999143L,9991318331L,1542439211L,-22986862505597L,-201806454439L,-211506271693601L,5229666198697L,1077172798985427449L,-61387659243913771L,-6860376024090670391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199749Inst : IEnumerable<long>
{
public static readonly long[] Value=A199749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199749.Bytes);
public long this[int i]=>Value[i];

public static A199749Inst Instance=new A199749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199750
{
public static readonly ulong[] Value={ 3L,23L,243L,2663L,29283L,322103L,3543123L,38974343L,428717763L,4715895383L,51874849203L,570623341223L,6276856753443L,69045424287863L,759499667166483L,8354496338831303L,91899459727144323L,1010894056998587543L,11119834626984462963UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199750Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199750.Bytes);
public ulong this[int i]=>Value[i];

public static A199750Inst Instance=new A199750Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199751
{
public static readonly long[] Value={ 2L,17L,182L,1997L,21962L,241577L,2657342L,29230757L,321538322L,3536921537L,38906136902L,427967505917L,4707642565082L,51784068215897L,569624750374862L,6265872254123477L,68924594795358242L,758170542748940657L,8339875970238347222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199751Inst : IEnumerable<long>
{
public static readonly long[] Value=A199751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199751.Bytes);
public long this[int i]=>Value[i];

public static A199751Inst Instance=new A199751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199752
{
public static readonly long[] Value={ 4L,34L,364L,3994L,43924L,483154L,5314684L,58461514L,643076644L,7073843074L,77812273804L,855935011834L,9415285130164L,103568136431794L,1139249500749724L,12531744508246954L,137849189590716484L,1516341085497881314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199752Inst : IEnumerable<long>
{
public static readonly long[] Value=A199752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199752.Bytes);
public long this[int i]=>Value[i];

public static A199752Inst Instance=new A199752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199753
{
public static readonly long[] Value={ 5L,45L,485L,5325L,58565L,644205L,7086245L,77948685L,857435525L,9431790765L,103749698405L,1141246682445L,12553713506885L,138090848575725L,1518999334332965L,16708992677662605L,183798919454288645L,2021788113997175085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199753Inst : IEnumerable<long>
{
public static readonly long[] Value=A199753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199753.Bytes);
public long this[int i]=>Value[i];

public static A199753Inst Instance=new A199753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199754
{
public static readonly long[] Value={ 3L,28L,303L,3328L,36603L,402628L,4428903L,48717928L,535897203L,5894869228L,64843561503L,713279176528L,7846070941803L,86306780359828L,949374583958103L,10443120423539128L,114874324658930403L,1263617571248234428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199754Inst : IEnumerable<long>
{
public static readonly long[] Value=A199754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199754.Bytes);
public long this[int i]=>Value[i];

public static A199754Inst Instance=new A199754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199755
{
public static readonly long[] Value={ 6L,56L,606L,6656L,73206L,805256L,8857806L,97435856L,1071794406L,11789738456L,129687123006L,1426558353056L,15692141883606L,172613560719656L,1898749167916206L,20886240847078256L,229748649317860806L,2527235142496468856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199755Inst : IEnumerable<long>
{
public static readonly long[] Value=A199755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199755.Bytes);
public long this[int i]=>Value[i];

public static A199755Inst Instance=new A199755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199756
{
public static readonly long[] Value={ 7L,67L,727L,7987L,87847L,966307L,10629367L,116923027L,1286153287L,14147686147L,155624547607L,1711870023667L,18830570260327L,207136272863587L,2278499001499447L,25063489016493907L,275698379181432967L,3032682170995762627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199756Inst : IEnumerable<long>
{
public static readonly long[] Value=A199756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199756.Bytes);
public long this[int i]=>Value[i];

public static A199756Inst Instance=new A199756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199757
{
public static readonly long[] Value={ 4L,39L,424L,4659L,51244L,563679L,6200464L,68205099L,750256084L,8252816919L,90780986104L,998590847139L,10984499318524L,120829492503759L,1329124417541344L,14620368592954779L,160824054522502564L,1769064599747528199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199757Inst : IEnumerable<long>
{
public static readonly long[] Value=A199757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199757.Bytes);
public long this[int i]=>Value[i];

public static A199757Inst Instance=new A199757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199758
{
public static readonly long[] Value={ 8L,78L,848L,9318L,102488L,1127358L,12400928L,136410198L,1500512168L,16505633838L,181561972208L,1997181694278L,21968998637048L,241658985007518L,2658248835082688L,29240737185909558L,321648109045005128L,3538129199495056398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199758Inst : IEnumerable<long>
{
public static readonly long[] Value=A199758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199758.Bytes);
public long this[int i]=>Value[i];

public static A199758Inst Instance=new A199758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199759
{
public static readonly long[] Value={ 9L,89L,969L,10649L,117129L,1288409L,14172489L,155897369L,1714871049L,18863581529L,207499396809L,2282493364889L,25107427013769L,276181697151449L,3037998668665929L,33417985355325209L,367597838908577289L,4043576227994350169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199759Inst : IEnumerable<long>
{
public static readonly long[] Value=A199759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199759.Bytes);
public long this[int i]=>Value[i];

public static A199759Inst Instance=new A199759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199760
{
public static readonly long[] Value={ 1L,10L,109L,1198L,13177L,144946L,1594405L,17538454L,192922993L,2122152922L,23343682141L,256780503550L,2824585539049L,31070440929538L,341774850224917L,3759523352474086L,41354756877214945L,454902325649364394L,5003925582143008333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199760Inst : IEnumerable<long>
{
public static readonly long[] Value=A199760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199760.Bytes);
public long this[int i]=>Value[i];

public static A199760Inst Instance=new A199760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199761
{
public static readonly ulong[] Value={ 2L,20L,218L,2396L,26354L,289892L,3188810L,35076908L,385845986L,4244305844L,46687364282L,513561007100L,5649171078098L,62140881859076L,683549700449834L,7519046704948172L,82709513754429890L,909804651298728788L,10007851164286016666UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199761Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199761.Bytes);
public ulong this[int i]=>Value[i];

public static A199761Inst Instance=new A199761Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199762
{
public static readonly long[] Value={ 5L,50L,545L,5990L,65885L,724730L,7972025L,87692270L,964614965L,10610764610L,116718410705L,1283902517750L,14122927695245L,155352204647690L,1708874251124585L,18797616762370430L,206773784386074725L,2274511628246821970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199762Inst : IEnumerable<long>
{
public static readonly long[] Value=A199762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199762.Bytes);
public long this[int i]=>Value[i];

public static A199762Inst Instance=new A199762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199763
{
public static readonly long[] Value={ 10L,100L,1090L,11980L,131770L,1449460L,15944050L,175384540L,1929229930L,21221529220L,233436821410L,2567805035500L,28245855390490L,310704409295380L,3417748502249170L,37595233524740860L,413547568772149450L,4549023256493643940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199763Inst : IEnumerable<long>
{
public static readonly long[] Value=A199763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199763.Bytes);
public long this[int i]=>Value[i];

public static A199763Inst Instance=new A199763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199764
{
public static readonly long[] Value={ 11L,111L,1211L,13311L,146411L,1610511L,17715611L,194871711L,2143588811L,23579476911L,259374246011L,2853116706111L,31384283767211L,345227121439311L,3797498335832411L,41772481694156511L,459497298635721611L,5054470284992937711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199764Inst : IEnumerable<long>
{
public static readonly long[] Value=A199764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199764.Bytes);
public long this[int i]=>Value[i];

public static A199764Inst Instance=new A199764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199765
{
public static readonly long[] Value={ 1L,4L,10L,12L,18L,26L,30L,34L,38L,42L,48L,50L,58L,68L,76L,72L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199765Inst : IEnumerable<long>
{
public static readonly long[] Value=A199765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199765.Bytes);
public long this[int i]=>Value[i];

public static A199765Inst Instance=new A199765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199766
{
public static readonly long[] Value={ 1L,6L,8L,14L,22L,24L,28L,36L,44L,48L,52L,52L,62L,70L,72L,76L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199766Inst : IEnumerable<long>
{
public static readonly long[] Value=A199766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199766.Bytes);
public long this[int i]=>Value[i];

public static A199766Inst Instance=new A199766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199767
{
public static readonly long[] Value={ 21L,45L,432L,740L,1728L,3456L,3888L,5616L,12096L,23760L,46656L,52164L,131328L,152064L,186624L,195656L,233280L,311472L,606528L,618192L,746496L,926208L,933120L,979776L,1273536L,1403136L,2985984L,3221456L,3732480L,5178816L,5412096L,5971968L,9704448L,13651200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199767Inst : IEnumerable<long>
{
public static readonly long[] Value=A199767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199767.Bytes);
public long this[int i]=>Value[i];

public static A199767Inst Instance=new A199767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199768
{
public static readonly long[] Value={ 4L,6L,8L,12L,16L,18L,20L,24L,27L,30L,32L,36L,40L,42L,45L,48L,50L,54L,56L,60L,64L,70L,72L,75L,80L,81L,84L,90L,96L,100L,105L,108L,112L,120L,126L,128L,132L,135L,140L,144L,150L,160L,162L,168L,180L,189L,192L,196L,198L,200L,210L,216L,220L,224L,225L,240L,243L,250L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199768Inst : IEnumerable<long>
{
public static readonly long[] Value=A199768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199768.Bytes);
public long this[int i]=>Value[i];

public static A199768Inst Instance=new A199768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199769
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199769Inst : IEnumerable<long>
{
public static readonly long[] Value=A199769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199769.Bytes);
public long this[int i]=>Value[i];

public static A199769Inst Instance=new A199769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199770
{
public static readonly long[] Value={ 1L,0L,2L,6L,18L,50L,146L,426L,1282L,3810L,11394L,34082L,102338L,306658L,919874L,2759154L,8276898L,24828386L,74484386L,223444258L,670326242L,2010964770L,6032902242L,18098635298L,54295809826L,162887261410L,488661978274L,1465985458850L,4397955924386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199770Inst : IEnumerable<long>
{
public static readonly long[] Value=A199770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199770.Bytes);
public long this[int i]=>Value[i];

public static A199770Inst Instance=new A199770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199771
{
public static readonly long[] Value={ 1L,5L,12L,26L,45L,75L,112L,164L,225L,305L,396L,510L,637L,791L,960L,1160L,1377L,1629L,1900L,2210L,2541L,2915L,3312L,3756L,4225L,4745L,5292L,5894L,6525L,7215L,7936L,8720L,9537L,10421L,11340L,12330L,13357L,14459L,15600L,16820L,18081L,19425L,20812L,22286L,23805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199771Inst : IEnumerable<long>
{
public static readonly long[] Value=A199771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199771.Bytes);
public long this[int i]=>Value[i];

public static A199771Inst Instance=new A199771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199772
{
public static readonly long[] Value={ 1L,4L,25L,41L,260L,1649L,2705L,17156L,108809L,178489L,1132036L,7179745L,11777569L,74697220L,473754361L,777141065L,4928884484L,31260608081L,51279532721L,325231678724L,2062726378985L,3383672018521L,21460361911300L,136108680404929L,223271073689665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199772Inst : IEnumerable<long>
{
public static readonly long[] Value=A199772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199772.Bytes);
public long this[int i]=>Value[i];

public static A199772Inst Instance=new A199772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199773
{
public static readonly long[] Value={ 1L,16L,103L,169L,1072L,6799L,11153L,70736L,448631L,735929L,4667504L,29602847L,48560161L,307984528L,1953339271L,3204234697L,20322311344L,128890789039L,211430929841L,1340964564176L,8504838737303L,13951237134809L,88483338924272L,561190465872959L,920570219967553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199773Inst : IEnumerable<long>
{
public static readonly long[] Value=A199773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199773.Bytes);
public long this[int i]=>Value[i];

public static A199773Inst Instance=new A199773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199774
{
public static readonly long[] Value={ 0L,3L,5L,32L,203L,333L,2112L,13395L,21973L,139360L,883867L,1449885L,9195648L,58321827L,95670437L,606773408L,3848356715L,6312798957L,40037849280L,253933221363L,416549060725L,2641891279072L,16755744253243L,27485925208893L,174324786569472L,1105625187492675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199774Inst : IEnumerable<long>
{
public static readonly long[] Value=A199774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199774.Bytes);
public long this[int i]=>Value[i];

public static A199774Inst Instance=new A199774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199775
{
public static readonly long[] Value={ 1L,3L,3L,1L,4L,8L,6L,9L,5L,9L,3L,3L,5L,0L,4L,0L,5L,0L,3L,3L,2L,7L,3L,6L,3L,0L,6L,9L,9L,1L,7L,3L,3L,9L,5L,4L,3L,0L,2L,5L,8L,7L,5L,9L,3L,3L,5L,7L,9L,9L,5L,1L,5L,0L,9L,6L,9L,6L,3L,2L,6L,4L,2L,5L,4L,4L,8L,5L,8L,5L,9L,0L,2L,5L,5L,4L,7L,7L,3L,3L,3L,0L,2L,3L,5L,2L,2L,9L,3L,3L,0L,2L,9L,4L,9L,4L,4L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199775Inst : IEnumerable<long>
{
public static readonly long[] Value=A199775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199775.Bytes);
public long this[int i]=>Value[i];

public static A199775Inst Instance=new A199775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199776
{
public static readonly long[] Value={ 9L,8L,0L,3L,7L,6L,8L,4L,1L,9L,0L,9L,5L,6L,1L,4L,5L,1L,7L,1L,1L,7L,1L,7L,8L,8L,0L,2L,6L,9L,3L,9L,6L,3L,0L,3L,3L,7L,7L,0L,0L,5L,9L,2L,1L,1L,8L,0L,7L,6L,9L,9L,5L,2L,0L,9L,7L,3L,5L,8L,9L,2L,5L,6L,1L,0L,5L,5L,1L,5L,0L,3L,4L,9L,7L,4L,0L,4L,8L,2L,7L,3L,3L,7L,9L,2L,9L,0L,8L,2L,4L,6L,8L,5L,7L,6L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199776Inst : IEnumerable<long>
{
public static readonly long[] Value=A199776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199776.Bytes);
public long this[int i]=>Value[i];

public static A199776Inst Instance=new A199776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199777
{
public static readonly long[] Value={ 1L,4L,8L,0L,5L,4L,6L,3L,3L,1L,7L,5L,4L,9L,1L,2L,0L,3L,7L,7L,6L,7L,6L,4L,3L,0L,5L,7L,9L,2L,3L,2L,7L,5L,8L,7L,3L,2L,9L,8L,5L,3L,8L,3L,0L,2L,7L,5L,8L,0L,3L,5L,3L,7L,3L,4L,1L,7L,0L,4L,6L,2L,9L,8L,7L,3L,8L,9L,1L,5L,6L,6L,9L,3L,9L,7L,3L,7L,1L,1L,7L,9L,3L,1L,8L,4L,7L,5L,2L,0L,5L,7L,3L,9L,5L,4L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199777Inst : IEnumerable<long>
{
public static readonly long[] Value=A199777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199777.Bytes);
public long this[int i]=>Value[i];

public static A199777Inst Instance=new A199777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199778
{
public static readonly long[] Value={ 1L,3L,7L,0L,6L,8L,0L,9L,7L,2L,6L,0L,4L,8L,9L,3L,4L,8L,5L,7L,9L,1L,1L,2L,0L,8L,0L,6L,8L,8L,0L,2L,9L,0L,4L,3L,2L,9L,8L,3L,6L,4L,6L,0L,2L,7L,1L,3L,0L,0L,5L,1L,0L,3L,9L,5L,0L,8L,9L,7L,8L,5L,0L,7L,0L,4L,2L,4L,5L,6L,7L,8L,3L,5L,4L,6L,2L,7L,6L,4L,3L,4L,1L,4L,5L,8L,4L,8L,6L,1L,9L,2L,2L,1L,7L,3L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199778Inst : IEnumerable<long>
{
public static readonly long[] Value=A199778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199778.Bytes);
public long this[int i]=>Value[i];

public static A199778Inst Instance=new A199778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199779
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,8L,5L,2L,1L,1L,0L,7L,1L,3L,5L,0L,4L,6L,9L,9L,4L,5L,7L,6L,2L,0L,0L,7L,1L,7L,9L,5L,5L,7L,8L,8L,1L,3L,2L,0L,0L,1L,5L,4L,2L,2L,5L,8L,5L,7L,3L,9L,1L,4L,2L,2L,7L,9L,4L,5L,7L,5L,9L,2L,9L,6L,4L,5L,1L,7L,7L,8L,4L,0L,2L,5L,7L,6L,5L,5L,7L,3L,2L,8L,6L,6L,8L,3L,6L,1L,8L,4L,8L,1L,4L,1L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199779Inst : IEnumerable<long>
{
public static readonly long[] Value=A199779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199779.Bytes);
public long this[int i]=>Value[i];

public static A199779Inst Instance=new A199779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199780
{
public static readonly long[] Value={ 1L,0L,9L,4L,1L,8L,7L,4L,5L,1L,4L,7L,9L,3L,4L,4L,8L,8L,1L,8L,5L,5L,5L,6L,0L,8L,9L,0L,9L,0L,2L,4L,8L,5L,1L,6L,6L,2L,7L,3L,2L,0L,4L,4L,6L,6L,3L,0L,2L,8L,6L,6L,4L,8L,4L,1L,4L,5L,0L,6L,8L,6L,7L,5L,0L,1L,0L,6L,7L,9L,0L,0L,1L,6L,6L,7L,3L,2L,8L,8L,2L,2L,8L,6L,4L,7L,5L,0L,6L,2L,5L,4L,7L,3L,3L,9L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199780Inst : IEnumerable<long>
{
public static readonly long[] Value=A199780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199780.Bytes);
public long this[int i]=>Value[i];

public static A199780Inst Instance=new A199780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199781
{
public static readonly long[] Value={ 1L,3L,9L,8L,8L,0L,6L,8L,9L,3L,8L,9L,4L,9L,0L,3L,2L,5L,9L,7L,9L,1L,2L,3L,8L,1L,1L,8L,9L,8L,3L,7L,9L,1L,3L,8L,4L,0L,2L,8L,5L,1L,9L,8L,5L,7L,0L,6L,5L,0L,4L,7L,1L,7L,1L,7L,2L,5L,2L,4L,0L,7L,5L,2L,9L,7L,8L,9L,2L,2L,8L,5L,1L,5L,2L,4L,5L,5L,8L,2L,5L,5L,9L,1L,7L,2L,4L,8L,0L,9L,4L,0L,3L,7L,0L,1L,1L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199781Inst : IEnumerable<long>
{
public static readonly long[] Value=A199781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199781.Bytes);
public long this[int i]=>Value[i];

public static A199781Inst Instance=new A199781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199782
{
public static readonly long[] Value={ 1L,1L,7L,1L,2L,5L,7L,3L,0L,0L,3L,4L,2L,5L,6L,2L,9L,5L,6L,1L,8L,4L,6L,1L,2L,5L,0L,0L,5L,3L,9L,2L,0L,6L,8L,9L,4L,0L,5L,9L,3L,7L,3L,6L,4L,3L,4L,6L,9L,1L,8L,6L,8L,8L,3L,7L,6L,7L,5L,5L,8L,2L,7L,7L,1L,2L,6L,3L,9L,1L,8L,5L,7L,2L,1L,0L,7L,8L,6L,7L,7L,1L,5L,3L,0L,7L,8L,7L,5L,7L,3L,6L,3L,3L,4L,3L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199782Inst : IEnumerable<long>
{
public static readonly long[] Value=A199782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199782.Bytes);
public long this[int i]=>Value[i];

public static A199782Inst Instance=new A199782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199783
{
public static readonly long[] Value={ 1L,3L,1L,6L,1L,8L,8L,8L,7L,0L,7L,7L,3L,5L,2L,8L,4L,8L,6L,8L,5L,0L,0L,1L,0L,8L,0L,6L,8L,9L,9L,2L,2L,1L,1L,4L,5L,2L,8L,1L,0L,0L,1L,6L,5L,0L,0L,5L,0L,7L,2L,9L,0L,0L,8L,3L,0L,7L,1L,3L,9L,9L,6L,0L,5L,6L,4L,2L,3L,9L,5L,3L,4L,1L,3L,2L,2L,8L,0L,5L,3L,4L,0L,7L,2L,8L,1L,2L,1L,7L,3L,4L,8L,6L,3L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199783Inst : IEnumerable<long>
{
public static readonly long[] Value=A199783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199783.Bytes);
public long this[int i]=>Value[i];

public static A199783Inst Instance=new A199783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199784
{
public static readonly long[] Value={ 1L,2L,2L,3L,0L,5L,4L,0L,6L,5L,5L,1L,1L,1L,0L,2L,5L,7L,1L,3L,5L,0L,4L,8L,0L,4L,9L,4L,7L,2L,1L,9L,2L,8L,6L,9L,1L,7L,4L,0L,2L,7L,3L,8L,8L,0L,5L,8L,3L,4L,0L,0L,1L,0L,9L,7L,3L,4L,3L,6L,4L,6L,8L,8L,3L,7L,6L,6L,4L,9L,6L,6L,5L,1L,4L,5L,7L,5L,8L,5L,2L,5L,0L,3L,7L,8L,0L,7L,8L,9L,2L,1L,2L,4L,6L,1L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199784Inst : IEnumerable<long>
{
public static readonly long[] Value=A199784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199784.Bytes);
public long this[int i]=>Value[i];

public static A199784Inst Instance=new A199784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199785
{
public static readonly long[] Value={ 1L,1L,1L,8L,6L,2L,8L,9L,9L,9L,6L,3L,4L,8L,7L,2L,1L,4L,0L,6L,5L,4L,9L,6L,1L,6L,6L,3L,2L,4L,7L,1L,8L,1L,0L,4L,7L,8L,1L,7L,0L,9L,4L,6L,7L,8L,4L,0L,6L,5L,8L,1L,6L,8L,3L,4L,4L,1L,4L,7L,4L,3L,6L,0L,9L,9L,5L,6L,2L,8L,7L,6L,8L,5L,9L,4L,3L,8L,5L,2L,4L,0L,0L,1L,5L,4L,4L,9L,5L,9L,4L,9L,2L,3L,1L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199785Inst : IEnumerable<long>
{
public static readonly long[] Value=A199785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199785.Bytes);
public long this[int i]=>Value[i];

public static A199785Inst Instance=new A199785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199786
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,0L,1L,9L,7L,8L,8L,8L,6L,3L,4L,9L,0L,7L,2L,5L,7L,6L,8L,0L,0L,1L,8L,2L,2L,0L,1L,2L,1L,2L,2L,7L,9L,6L,5L,9L,7L,9L,1L,5L,5L,3L,4L,2L,1L,3L,2L,2L,2L,1L,8L,3L,2L,6L,4L,0L,9L,7L,1L,7L,5L,4L,3L,0L,3L,7L,5L,8L,2L,5L,3L,0L,3L,8L,2L,5L,2L,0L,8L,1L,2L,5L,9L,1L,4L,5L,8L,6L,1L,2L,9L,9L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199786Inst : IEnumerable<long>
{
public static readonly long[] Value=A199786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199786.Bytes);
public long this[int i]=>Value[i];

public static A199786Inst Instance=new A199786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199787
{
public static readonly long[] Value={ 1L,2L,8L,1L,9L,0L,5L,4L,7L,3L,9L,8L,3L,4L,0L,5L,3L,7L,7L,3L,8L,4L,5L,5L,4L,8L,5L,6L,8L,3L,4L,7L,5L,8L,5L,2L,2L,4L,3L,9L,7L,4L,4L,3L,0L,2L,8L,9L,4L,1L,7L,5L,2L,9L,5L,4L,5L,5L,4L,6L,3L,7L,5L,6L,6L,6L,9L,7L,1L,1L,2L,7L,7L,7L,3L,4L,3L,9L,8L,3L,9L,6L,7L,1L,8L,8L,3L,5L,4L,6L,8L,5L,6L,6L,5L,0L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199787Inst : IEnumerable<long>
{
public static readonly long[] Value=A199787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199787.Bytes);
public long this[int i]=>Value[i];

public static A199787Inst Instance=new A199787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199788
{
public static readonly long[] Value={ 1L,0L,4L,9L,1L,8L,8L,7L,0L,8L,2L,0L,0L,4L,3L,4L,2L,1L,3L,4L,2L,7L,2L,0L,7L,6L,6L,5L,0L,0L,3L,9L,2L,6L,6L,0L,8L,2L,9L,4L,3L,9L,0L,2L,2L,5L,2L,1L,7L,1L,6L,7L,1L,4L,5L,2L,0L,4L,5L,1L,3L,7L,6L,6L,6L,9L,0L,4L,4L,5L,3L,3L,1L,2L,1L,1L,4L,9L,3L,0L,9L,0L,6L,6L,9L,8L,5L,1L,3L,7L,0L,9L,0L,5L,0L,4L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199788Inst : IEnumerable<long>
{
public static readonly long[] Value=A199788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199788.Bytes);
public long this[int i]=>Value[i];

public static A199788Inst Instance=new A199788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199789
{
public static readonly long[] Value={ 9L,0L,6L,2L,4L,7L,6L,9L,1L,6L,3L,5L,6L,4L,4L,0L,7L,9L,9L,1L,8L,6L,2L,3L,6L,3L,1L,0L,2L,9L,6L,4L,6L,7L,4L,1L,4L,2L,5L,1L,9L,2L,7L,7L,4L,8L,0L,8L,0L,0L,3L,6L,7L,8L,6L,9L,4L,0L,0L,0L,9L,6L,1L,3L,7L,2L,9L,8L,7L,2L,0L,1L,3L,0L,7L,6L,3L,3L,7L,9L,1L,9L,7L,9L,6L,3L,5L,8L,5L,8L,3L,4L,5L,6L,4L,9L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199789Inst : IEnumerable<long>
{
public static readonly long[] Value=A199789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199789.Bytes);
public long this[int i]=>Value[i];

public static A199789Inst Instance=new A199789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199790
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,0L,7L,1L,4L,9L,1L,2L,2L,4L,4L,1L,6L,1L,2L,8L,5L,9L,3L,2L,5L,7L,6L,3L,7L,3L,4L,5L,1L,5L,2L,8L,6L,1L,1L,7L,5L,0L,1L,9L,6L,9L,5L,2L,9L,0L,2L,4L,3L,9L,7L,1L,0L,9L,9L,5L,1L,1L,3L,8L,5L,4L,8L,7L,5L,6L,0L,3L,7L,1L,5L,4L,5L,5L,2L,2L,1L,8L,6L,1L,5L,3L,7L,4L,4L,0L,4L,4L,9L,6L,2L,2L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199790Inst : IEnumerable<long>
{
public static readonly long[] Value=A199790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199790.Bytes);
public long this[int i]=>Value[i];

public static A199790Inst Instance=new A199790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199791
{
public static readonly long[] Value={ 1L,1L,0L,6L,5L,5L,5L,0L,9L,2L,4L,6L,9L,1L,8L,0L,9L,7L,0L,2L,4L,4L,6L,4L,6L,1L,1L,4L,9L,7L,3L,3L,0L,2L,4L,7L,1L,5L,9L,9L,9L,6L,1L,2L,7L,2L,7L,7L,6L,6L,2L,6L,1L,4L,8L,9L,4L,4L,2L,9L,4L,0L,2L,1L,7L,6L,2L,4L,2L,3L,9L,9L,0L,1L,7L,1L,3L,6L,9L,5L,6L,5L,9L,9L,8L,1L,6L,3L,4L,6L,7L,6L,7L,7L,4L,9L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199791Inst : IEnumerable<long>
{
public static readonly long[] Value=A199791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199791.Bytes);
public long this[int i]=>Value[i];

public static A199791Inst Instance=new A199791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199792
{
public static readonly long[] Value={ 9L,5L,4L,9L,5L,6L,8L,5L,5L,8L,6L,2L,7L,9L,1L,4L,3L,4L,7L,2L,5L,7L,1L,4L,1L,1L,1L,6L,0L,9L,9L,5L,6L,1L,5L,7L,9L,6L,4L,9L,1L,2L,2L,5L,0L,6L,0L,6L,8L,6L,8L,6L,0L,5L,7L,5L,9L,6L,8L,5L,7L,5L,2L,9L,0L,3L,4L,9L,7L,4L,5L,9L,0L,1L,2L,0L,6L,4L,9L,1L,6L,2L,6L,2L,7L,1L,6L,3L,6L,5L,7L,7L,8L,1L,2L,8L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199792Inst : IEnumerable<long>
{
public static readonly long[] Value=A199792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199792.Bytes);
public long this[int i]=>Value[i];

public static A199792Inst Instance=new A199792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199793
{
public static readonly long[] Value={ 7L,7L,6L,4L,4L,3L,1L,0L,8L,9L,0L,3L,8L,3L,8L,1L,0L,1L,9L,0L,9L,6L,6L,9L,9L,4L,9L,1L,6L,2L,9L,8L,2L,8L,8L,7L,9L,1L,8L,0L,0L,5L,1L,4L,7L,8L,0L,9L,6L,9L,7L,4L,8L,0L,0L,4L,9L,6L,7L,4L,3L,2L,3L,2L,8L,0L,2L,5L,3L,5L,0L,0L,9L,6L,6L,9L,9L,4L,8L,0L,5L,6L,9L,3L,4L,9L,4L,0L,5L,2L,8L,4L,9L,8L,9L,3L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199793Inst : IEnumerable<long>
{
public static readonly long[] Value=A199793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199793.Bytes);
public long this[int i]=>Value[i];

public static A199793Inst Instance=new A199793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199794
{
public static readonly long[] Value={ 1L,1L,7L,5L,3L,0L,5L,6L,3L,4L,8L,9L,1L,9L,4L,3L,1L,0L,3L,8L,5L,3L,1L,1L,5L,2L,1L,6L,2L,8L,7L,2L,0L,2L,9L,4L,9L,7L,2L,0L,4L,5L,9L,1L,7L,8L,4L,5L,1L,0L,4L,9L,8L,0L,8L,4L,0L,3L,5L,5L,9L,9L,1L,2L,2L,7L,8L,0L,4L,5L,5L,5L,5L,3L,6L,2L,8L,7L,2L,8L,5L,0L,0L,8L,3L,9L,3L,8L,4L,5L,8L,6L,2L,6L,8L,1L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199794Inst : IEnumerable<long>
{
public static readonly long[] Value=A199794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199794.Bytes);
public long this[int i]=>Value[i];

public static A199794Inst Instance=new A199794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199795
{
public static readonly long[] Value={ 1L,0L,1L,3L,6L,1L,4L,2L,4L,5L,6L,5L,0L,4L,0L,0L,9L,4L,5L,3L,6L,8L,8L,5L,8L,7L,8L,9L,7L,2L,4L,4L,7L,6L,7L,1L,2L,1L,1L,4L,4L,9L,0L,1L,5L,1L,0L,0L,5L,2L,0L,9L,9L,7L,6L,7L,2L,6L,6L,8L,0L,7L,6L,1L,7L,2L,9L,5L,7L,1L,2L,7L,8L,5L,0L,4L,9L,3L,2L,6L,3L,4L,8L,7L,6L,6L,6L,4L,7L,0L,0L,4L,0L,6L,0L,3L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199795Inst : IEnumerable<long>
{
public static readonly long[] Value=A199795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199795.Bytes);
public long this[int i]=>Value[i];

public static A199795Inst Instance=new A199795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199796
{
public static readonly long[] Value={ 8L,2L,1L,2L,9L,7L,2L,1L,5L,5L,5L,5L,7L,4L,6L,2L,4L,9L,3L,2L,3L,2L,7L,1L,2L,7L,6L,5L,3L,2L,9L,1L,5L,9L,2L,1L,8L,0L,7L,9L,1L,5L,5L,7L,7L,6L,3L,7L,3L,4L,0L,8L,0L,9L,1L,3L,2L,3L,6L,8L,5L,9L,7L,6L,1L,7L,8L,6L,4L,2L,0L,7L,8L,4L,0L,9L,9L,2L,3L,5L,4L,5L,4L,6L,0L,0L,4L,5L,9L,1L,3L,6L,1L,5L,7L,2L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199796Inst : IEnumerable<long>
{
public static readonly long[] Value=A199796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199796.Bytes);
public long this[int i]=>Value[i];

public static A199796Inst Instance=new A199796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199797
{
public static readonly long[] Value={ 5L,9L,1L,0L,4L,7L,6L,6L,8L,0L,7L,2L,5L,4L,9L,5L,8L,7L,3L,9L,7L,8L,0L,9L,8L,4L,5L,4L,6L,4L,2L,1L,2L,4L,7L,3L,0L,5L,1L,6L,9L,0L,1L,3L,6L,4L,2L,8L,0L,1L,9L,8L,6L,6L,1L,9L,8L,3L,5L,2L,5L,6L,0L,1L,2L,6L,2L,6L,2L,3L,5L,7L,9L,0L,3L,0L,4L,5L,0L,7L,2L,7L,3L,2L,0L,7L,5L,4L,2L,5L,6L,1L,5L,9L,2L,7L,3L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199797Inst : IEnumerable<long>
{
public static readonly long[] Value=A199797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199797.Bytes);
public long this[int i]=>Value[i];

public static A199797Inst Instance=new A199797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199798
{
public static readonly long[] Value={ 4L,13L,21L,132L,837L,1373L,8708L,55229L,90597L,574596L,3644277L,5978029L,37914628L,240467053L,394459317L,2501790852L,15867181221L,26028336893L,165080281604L,1046993493533L,1717475775621L,10892796795012L,69085703391957L,113327372854093L,718759508189188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199798Inst : IEnumerable<long>
{
public static readonly long[] Value=A199798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199798.Bytes);
public long this[int i]=>Value[i];

public static A199798Inst Instance=new A199798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199799
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,16L,17L,19L,20L,23L,25L,29L,31L,32L,34L,38L,40L,41L,43L,46L,47L,50L,53L,58L,59L,61L,62L,64L,67L,68L,71L,73L,76L,79L,80L,82L,83L,85L,86L,89L,92L,94L,95L,97L,100L,101L,103L,106L,107L,109L,113L,115L,116L,118L,122L,124L,125L,127L,128L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199799Inst : IEnumerable<long>
{
public static readonly long[] Value=A199799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199799.Bytes);
public long this[int i]=>Value[i];

public static A199799Inst Instance=new A199799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199800
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,2L,3L,2L,3L,0L,4L,2L,4L,3L,2L,2L,3L,3L,5L,3L,3L,3L,4L,4L,3L,2L,4L,3L,5L,3L,4L,3L,5L,5L,6L,3L,4L,3L,5L,5L,5L,6L,5L,4L,5L,5L,6L,7L,5L,4L,5L,4L,7L,6L,4L,4L,4L,5L,6L,6L,5L,6L,7L,4L,5L,2L,4L,7L,5L,7L,4L,5L,6L,7L,7L,7L,5L,6L,4L,7L,4L,7L,7L,6L,5L,3L,5L,8L,7L,7L,5L,5L,6L,4L,5L,4L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199800Inst : IEnumerable<long>
{
public static readonly long[] Value=A199800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199800.Bytes);
public long this[int i]=>Value[i];

public static A199800Inst Instance=new A199800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199801
{
public static readonly long[] Value={ 8L,675L,9800L,12167L,235224L,465124L,11309768L,4931691075L,5425069447L,13051463048L,8192480787000L,11968683934831L,15061377048200L,28821995554247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199801Inst : IEnumerable<long>
{
public static readonly long[] Value=A199801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199801.Bytes);
public long this[int i]=>Value[i];

public static A199801Inst Instance=new A199801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199802
{
public static readonly long[] Value={ 1L,2L,2L,1L,-1L,-4L,-7L,-8L,-5L,3L,15L,27L,32L,22L,-8L,-55L,-104L,-128L,-95L,17L,200L,399L,510L,405L,-11L,-721L,-1525L,-2024L,-1708L,-172L,2573L,5806L,8002L,7137L,1503L,-9072L,-22015L,-31520L,-29585L,-9073L,31519L,83119L,123712L,121778L,47732L,-107499L,-312396L,-483840L,-498119L,-233455L,357884L,1168399L,1885694L,2025929L,1090985L,-1152593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199802Inst : IEnumerable<long>
{
public static readonly long[] Value=A199802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199802.Bytes);
public long this[int i]=>Value[i];

public static A199802Inst Instance=new A199802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199803
{
public static readonly long[] Value={ 1L,-1L,2L,-2L,2L,-1L,-1L,4L,-8L,12L,-15L,15L,-10L,-2L,22L,-49L,79L,-104L,112L,-88L,17L,111L,-294L,510L,-710L,815L,-721L,316L,488L,-1708L,3233L,-4769L,5806L,-5634L,3438L,1503L,-9505L,20080L,-31520L,40592L,-42527L,31519L,-1934L,-49666L,121778L,-204897L,278943L,-312396L,264664L,-93220L,-233455L,717295L,-1308634L,1885694L,-2243578L,2103343L,-1152593L,-873336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199803Inst : IEnumerable<long>
{
public static readonly long[] Value=A199803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199803.Bytes);
public long this[int i]=>Value[i];

public static A199803Inst Instance=new A199803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199804
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,3L,-4L,6L,-9L,13L,-19L,28L,-41L,60L,-88L,129L,-189L,277L,-406L,595L,-872L,1278L,-1873L,2745L,-4023L,5896L,-8641L,12664L,-18560L,27201L,-39865L,58425L,-85626L,125491L,-183916L,269542L,-395033L,578949L,-848491L,1243524L,-1822473L,2670964L,-3914488L,5736961L,-8407925L,12322413L,-18059374L,26467299L,-38789712L,56849086L,-83316385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199804Inst : IEnumerable<long>
{
public static readonly long[] Value=A199804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199804.Bytes);
public long this[int i]=>Value[i];

public static A199804Inst Instance=new A199804Inst();

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