using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201705
{
public static readonly long[] Value={ 17L,41L,137L,401L,521L,809L,977L,1361L,2897L,3209L,3881L,4241L,5009L,5417L,6737L,9257L,12809L,13457L,15497L,16937L,17681L,22481L,25097L,26921L,33809L,39209L,42641L,47441L,49937L,57809L,61961L,63377L,89897L,100361L,102161L,123017L,135209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201705Inst : IEnumerable<long>
{
public static readonly long[] Value=A201705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201705.Bytes);
public long this[int i]=>Value[i];

public static A201705Inst Instance=new A201705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201706
{
public static readonly long[] Value={ 13L,229L,733L,1093L,2029L,3253L,7573L,13693L,18229L,21613L,31333L,33493L,42853L,59053L,65029L,71293L,91813L,127453L,140629L,178933L,189229L,199813L,205213L,227533L,233293L,245029L,257053L,328333L,378229L,439573L,514093L,567013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201706Inst : IEnumerable<long>
{
public static readonly long[] Value=A201706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201706.Bytes);
public long this[int i]=>Value[i];

public static A201706Inst Instance=new A201706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201707
{
public static readonly long[] Value={ 7L,43L,151L,331L,907L,1303L,2311L,3607L,4363L,6091L,13003L,14407L,17431L,19051L,20743L,26251L,34603L,36871L,46663L,51991L,66571L,72907L,79531L,90007L,108907L,129607L,133963L,156823L,161611L,166471L,171403L,219031L,224683L,311371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201707Inst : IEnumerable<long>
{
public static readonly long[] Value=A201707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201707.Bytes);
public long this[int i]=>Value[i];

public static A201707Inst Instance=new A201707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201708
{
public static readonly long[] Value={ 19L,739L,1531L,3259L,6571L,9811L,15139L,16651L,19891L,29251L,35731L,42859L,56179L,62011L,84691L,110899L,131779L,154459L,178939L,199819L,281971L,294859L,349291L,363619L,370891L,431659L,447571L,488611L,549091L,603739L,613099L,804619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201708Inst : IEnumerable<long>
{
public static readonly long[] Value=A201708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201708.Bytes);
public long this[int i]=>Value[i];

public static A201708Inst Instance=new A201708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201709
{
public static readonly long[] Value={ 11L,41L,251L,491L,641L,811L,2251L,4001L,6761L,7841L,9001L,10891L,12251L,13691L,16001L,16811L,22091L,23041L,32491L,33641L,40961L,50411L,68891L,72251L,73961L,81001L,82811L,86491L,98011L,108161L,110251L,112361L,121001L,125441L,127691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201709Inst : IEnumerable<long>
{
public static readonly long[] Value=A201709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201709.Bytes);
public long this[int i]=>Value[i];

public static A201709Inst Instance=new A201709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201710
{
public static readonly long[] Value={ 3L,13L,43L,163L,643L,1213L,1693L,3613L,4003L,6763L,9613L,10243L,12253L,13693L,18493L,21163L,22093L,27043L,30253L,44893L,49003L,72253L,82813L,96043L,100003L,102013L,112363L,114493L,141613L,153763L,156253L,169003L,179563L,196003L,228013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201710Inst : IEnumerable<long>
{
public static readonly long[] Value=A201710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201710.Bytes);
public long this[int i]=>Value[i];

public static A201710Inst Instance=new A201710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201711
{
public static readonly long[] Value={ 19L,499L,1009L,1699L,8419L,9619L,14449L,21169L,24019L,28099L,30259L,34819L,38449L,49009L,53299L,68899L,84649L,94099L,102019L,118819L,141619L,156259L,169009L,176899L,184969L,187699L,240259L,259219L,268969L,306259L,309769L,327619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201711Inst : IEnumerable<long>
{
public static readonly long[] Value=A201711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201711.Bytes);
public long this[int i]=>Value[i];

public static A201711Inst Instance=new A201711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201712
{
public static readonly long[] Value={ 5L,29L,47L,197L,239L,389L,509L,719L,797L,2309L,2447L,3359L,4229L,4799L,6047L,6269L,6959L,8447L,10079L,10949L,11549L,12479L,14447L,17669L,18047L,19997L,20399L,22469L,24197L,28319L,31247L,33797L,34319L,38639L,45599L,51197L,51839L,55109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201712Inst : IEnumerable<long>
{
public static readonly long[] Value=A201712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201712.Bytes);
public long this[int i]=>Value[i];

public static A201712Inst Instance=new A201712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201713
{
public static readonly long[] Value={ 3L,13L,67L,157L,283L,643L,877L,1453L,3037L,4603L,5197L,5827L,7933L,8707L,12163L,14107L,17293L,18427L,19597L,30253L,34843L,38083L,41467L,56443L,58477L,62653L,66973L,71437L,83227L,93307L,95917L,98563L,103963L,109507L,118093L,123997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201713Inst : IEnumerable<long>
{
public static readonly long[] Value=A201713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201713.Bytes);
public long this[int i]=>Value[i];

public static A201713Inst Instance=new A201713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201714
{
public static readonly long[] Value={ 11L,43L,193L,281L,331L,443L,571L,641L,1051L,1451L,2731L,3691L,4993L,6043L,6491L,7193L,7681L,8443L,8971L,9241L,10651L,11243L,12161L,13441L,15131L,16193L,16921L,17291L,18043L,19993L,21211L,23321L,28793L,29761L,32251L,34841L,42043L,43801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201714Inst : IEnumerable<long>
{
public static readonly long[] Value=A201714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201714.Bytes);
public long this[int i]=>Value[i];

public static A201714Inst Instance=new A201714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201715
{
public static readonly long[] Value={ 73L,241L,673L,1321L,1873L,2521L,3673L,4561L,6073L,11161L,14281L,15121L,19681L,21673L,23761L,24841L,27073L,29401L,33073L,49921L,51481L,54673L,63073L,66601L,72073L,77761L,87721L,91873L,102673L,109441L,114073L,118801L,131041L,143881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201715Inst : IEnumerable<long>
{
public static readonly long[] Value=A201715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201715.Bytes);
public long this[int i]=>Value[i];

public static A201715Inst Instance=new A201715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201716
{
public static readonly long[] Value={ 23L,71L,239L,359L,503L,863L,1319L,1583L,1871L,2879L,3671L,5039L,8423L,9743L,11159L,11903L,12671L,13463L,16871L,17783L,18719L,20663L,25943L,29399L,33071L,38303L,39671L,48383L,49919L,51479L,61343L,68399L,70223L,73943L,81671L,83663L,87719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201716Inst : IEnumerable<long>
{
public static readonly long[] Value=A201716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201716.Bytes);
public long this[int i]=>Value[i];

public static A201716Inst Instance=new A201716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201717
{
public static readonly long[] Value={ 7L,43L,103L,967L,1447L,1723L,2347L,3067L,3463L,4327L,6343L,6907L,9403L,11527L,13063L,21163L,23227L,28807L,32443L,33703L,44647L,47623L,52267L,65707L,71143L,74887L,80683L,88747L,90823L,99367L,110587L,137383L,142567L,150523L,175687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201717Inst : IEnumerable<long>
{
public static readonly long[] Value=A201717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201717.Bytes);
public long this[int i]=>Value[i];

public static A201717Inst Instance=new A201717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201718
{
public static readonly long[] Value={ 5L,41L,101L,293L,761L,1193L,1721L,2693L,3461L,3881L,4793L,5801L,8741L,12281L,16421L,17321L,26501L,32441L,36293L,40361L,53861L,62201L,67493L,80681L,86693L,90821L,92921L,101561L,108293L,112901L,119993L,127301L,145193L,167081L,178601L,193541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201718Inst : IEnumerable<long>
{
public static readonly long[] Value=A201718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201718.Bytes);
public long this[int i]=>Value[i];

public static A201718Inst Instance=new A201718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201719
{
public static readonly long[] Value={ 11L,19L,43L,59L,67L,83L,107L,139L,163L,179L,211L,251L,307L,331L,419L,443L,467L,491L,563L,571L,587L,619L,643L,811L,883L,907L,947L,971L,1019L,1091L,1123L,1171L,1259L,1291L,1307L,1427L,1531L,1571L,1579L,1667L,1699L,1747L,1787L,1811L,1907L,1979L,1987L,2003L,2011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201719Inst : IEnumerable<long>
{
public static readonly long[] Value=A201719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201719.Bytes);
public long this[int i]=>Value[i];

public static A201719Inst Instance=new A201719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201720
{
public static readonly BigInteger[] Value={ 0L,1L,3L,12L,64L,420L,3246L,28798L,288072L,3205044L,39234340L,523821936L,7572221328L,117792884872L,1961516974704L,34807390821960L,655594811020096L,13060711726818768L,274358217793164912L,6060159633360214144L,BigInteger.Parse("140404595387426964480") };
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
public class A201720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201720Inst Instance=new A201720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201721
{
public static readonly long[] Value={ 4L,90L,19827L,56836178L,1692459595971L,545947219624185244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201721Inst : IEnumerable<long>
{
public static readonly long[] Value=A201721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201721.Bytes);
public long this[int i]=>Value[i];

public static A201721Inst Instance=new A201721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201722
{
public static readonly long[] Value={ 4L,10L,20L,35L,56L,83L,116L,155L,200L,251L,308L,371L,440L,515L,596L,683L,776L,875L,980L,1091L,1208L,1331L,1460L,1595L,1736L,1883L,2036L,2195L,2360L,2531L,2708L,2891L,3080L,3275L,3476L,3683L,3896L,4115L,4340L,4571L,4808L,5051L,5300L,5555L,5816L,6083L,6356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201722Inst : IEnumerable<long>
{
public static readonly long[] Value=A201722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201722.Bytes);
public long this[int i]=>Value[i];

public static A201722Inst Instance=new A201722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201723
{
public static readonly long[] Value={ 10L,90L,631L,3567L,16493L,64018L,213013L,621757L,1626046L,3878550L,8560638L,17688966L,34541082L,64226182L,114429139L,196357695L,325924563L,525198174L,824157734L,1262790173L,1893568514L,2784353134L,4021759333L,5715036571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201723Inst : IEnumerable<long>
{
public static readonly long[] Value=A201723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201723.Bytes);
public long this[int i]=>Value[i];

public static A201723Inst Instance=new A201723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201724
{
public static readonly long[] Value={ 20L,631L,19827L,499474L,9603489L,144262866L,1757594146L,17915547783L,156619023957L,1198133817532L,8153980411514L,50035648469991L,279906963092730L,1440489290975090L,6871449852708897L,30577097006475471L,127620952939695332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201724Inst : IEnumerable<long>
{
public static readonly long[] Value=A201724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201724.Bytes);
public long this[int i]=>Value[i];

public static A201724Inst Instance=new A201724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201725
{
public static readonly BigInteger[] Value={ 35L,3567L,499474L,56836178L,4720850001L,299927801278L,15249209002599L,640855702702745L,22831719167592564L,703807755707555744L,BigInteger.Parse("19083627099219491070"),BigInteger.Parse("461269189538111185232"),BigInteger.Parse("10047567066462239739922") };
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
public class A201725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201725Inst Instance=new A201725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201726
{
public static readonly BigInteger[] Value={ 56L,16493L,9603489L,4720850001L,1692459595971L,463016032498283L,100953294298736546L,18122671914754530341UL,BigInteger.Parse("2749005920875643617934"),BigInteger.Parse("359691065136570782416660"),BigInteger.Parse("41268528292416431754552427") };
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
public class A201726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201726.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201726Inst Instance=new A201726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201727
{
public static readonly long[] Value={ 83L,64018L,144262866L,299927801278L,463016032498283L,545947219624185244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201727Inst : IEnumerable<long>
{
public static readonly long[] Value=A201727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201727.Bytes);
public long this[int i]=>Value[i];

public static A201727Inst Instance=new A201727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201728
{
public static readonly long[] Value={ 116L,213013L,1757594146L,15249209002599L,100953294298736546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201728Inst : IEnumerable<long>
{
public static readonly long[] Value=A201728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201728.Bytes);
public long this[int i]=>Value[i];

public static A201728Inst Instance=new A201728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201729
{
public static readonly long[] Value={ 4L,10L,10L,20L,90L,20L,35L,631L,631L,35L,56L,3567L,19827L,3567L,56L,83L,16493L,499474L,499474L,16493L,83L,116L,64018L,9603489L,56836178L,9603489L,64018L,116L,155L,213013L,144262866L,4720850001L,4720850001L,144262866L,213013L,155L,200L,621757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201729Inst : IEnumerable<long>
{
public static readonly long[] Value=A201729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201729.Bytes);
public long this[int i]=>Value[i];

public static A201729Inst Instance=new A201729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201730
{
public static readonly long[] Value={ 1L,2L,0L,5L,1L,0L,14L,6L,0L,0L,41L,26L,1L,0L,0L,122L,100L,10L,0L,0L,0L,365L,363L,63L,1L,0L,0L,0L,1094L,1274L,322L,14L,0L,0L,0L,0L,3281L,4372L,1462L,116L,1L,0L,0L,0L,0L,9842L,14760L,6156L,744L,18L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201730Inst : IEnumerable<long>
{
public static readonly long[] Value=A201730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201730.Bytes);
public long this[int i]=>Value[i];

public static A201730Inst Instance=new A201730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201731
{
public static readonly BigInteger[] Value={ 1L,4L,54L,1544L,75750L,5676492L,603041334L,86210654224L,15958892198070L,3713676157320020L,1061084890984465446L,BigInteger.Parse("365202873520507832856"),BigInteger.Parse("149027843082185351506950"),BigInteger.Parse("71144948740332156241755868"),BigInteger.Parse("39282974873393643411310747350"),BigInteger.Parse("24840594864924259316810487005216") };
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
public class A201731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201731Inst Instance=new A201731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201732
{
public static readonly BigInteger[] Value={ 1L,2L,18L,386L,15150L,946082L,86148762L,10776331778L,1773210244230L,371367615732002L,96462262816769586L,BigInteger.Parse("30433572793375652738"),BigInteger.Parse("11463680237091180885150"),BigInteger.Parse("5081782052880868302982562"),BigInteger.Parse("2618864991559576227420716490"),BigInteger.Parse("1552537179057766207300655437826") };
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
public class A201732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201732Inst Instance=new A201732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201733
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,5L,2L,2L,1L,5L,1L,2L,1L,14L,1L,5L,1L,5L,2L,2L,1L,15L,2L,2L,5L,4L,1L,4L,1L,51L,1L,2L,1L,14L,1L,2L,2L,14L,1L,6L,1L,4L,2L,2L,1L,52L,2L,5L,1L,5L,1L,15L,2L,13L,2L,2L,1L,12L,1L,2L,4L,267L,1L,4L,1L,5L,1L,4L,1L,50L,1L,2L,3L,4L,1L,6L,1L,52L,15L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201733Inst : IEnumerable<long>
{
public static readonly long[] Value=A201733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201733.Bytes);
public long this[int i]=>Value[i];

public static A201733Inst Instance=new A201733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201734
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,9L,10L,13L,14L,16L,18L,20L,22L,24L,25L,27L,29L,31L,32L,38L,39L,43L,44L,49L,50L,51L,53L,56L,63L,64L,65L,66L,69L,77L,80L,83L,84L,87L,90L,91L,95L,98L,101L,102L,105L,106L,107L,108L,109L,111L,116L,118L,120L,121L,122L,123L,129L,132L,134L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201734Inst : IEnumerable<long>
{
public static readonly long[] Value=A201734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201734.Bytes);
public long this[int i]=>Value[i];

public static A201734Inst Instance=new A201734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201735
{
public static readonly long[] Value={ 2L,0L,2L,8L,4L,7L,9L,6L,1L,0L,6L,8L,5L,8L,1L,5L,7L,3L,6L,5L,9L,5L,8L,3L,9L,4L,0L,5L,8L,4L,0L,7L,4L,1L,9L,6L,0L,3L,3L,0L,1L,0L,6L,7L,3L,2L,3L,1L,8L,4L,9L,2L,2L,9L,6L,3L,9L,7L,0L,7L,7L,8L,1L,6L,0L,4L,3L,2L,4L,8L,1L,1L,9L,1L,7L,0L,0L,5L,7L,5L,3L,8L,3L,2L,3L,7L,7L,0L,4L,8L,3L,3L,3L,7L,3L,3L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201735Inst : IEnumerable<long>
{
public static readonly long[] Value=A201735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201735.Bytes);
public long this[int i]=>Value[i];

public static A201735Inst Instance=new A201735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201736
{
public static readonly long[] Value={ 2L,9L,6L,8L,7L,1L,1L,9L,8L,1L,1L,6L,1L,4L,1L,2L,4L,4L,6L,7L,5L,5L,4L,0L,4L,3L,9L,2L,7L,2L,3L,9L,4L,3L,5L,0L,6L,7L,7L,5L,0L,7L,0L,0L,7L,7L,8L,9L,2L,3L,2L,6L,2L,9L,2L,3L,9L,0L,3L,1L,2L,1L,2L,3L,6L,6L,6L,1L,0L,5L,9L,8L,6L,6L,3L,4L,1L,4L,8L,9L,1L,2L,6L,0L,8L,0L,6L,5L,8L,5L,6L,2L,5L,1L,6L,6L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201736Inst : IEnumerable<long>
{
public static readonly long[] Value=A201736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201736.Bytes);
public long this[int i]=>Value[i];

public static A201736Inst Instance=new A201736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201737
{
public static readonly long[] Value={ 2L,3L,1L,5L,0L,4L,6L,9L,3L,3L,6L,1L,7L,3L,7L,4L,8L,1L,7L,6L,7L,1L,5L,7L,6L,2L,6L,2L,7L,1L,9L,1L,9L,4L,3L,5L,0L,8L,0L,8L,1L,6L,2L,2L,4L,1L,0L,9L,8L,6L,8L,7L,3L,2L,8L,6L,1L,0L,7L,3L,8L,5L,8L,9L,6L,0L,4L,4L,1L,8L,1L,1L,4L,9L,2L,2L,8L,2L,2L,3L,1L,2L,8L,4L,3L,4L,1L,5L,6L,7L,9L,7L,4L,2L,5L,3L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201737Inst : IEnumerable<long>
{
public static readonly long[] Value=A201737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201737.Bytes);
public long this[int i]=>Value[i];

public static A201737Inst Instance=new A201737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201738
{
public static readonly long[] Value={ 2L,9L,1L,8L,3L,4L,3L,6L,9L,9L,0L,1L,8L,2L,0L,1L,3L,8L,7L,6L,5L,9L,8L,3L,6L,9L,9L,2L,0L,7L,6L,0L,5L,8L,7L,6L,7L,2L,1L,0L,5L,9L,1L,6L,3L,5L,4L,8L,7L,2L,2L,2L,8L,8L,1L,3L,4L,7L,2L,0L,4L,0L,6L,7L,8L,4L,2L,0L,1L,0L,6L,9L,8L,9L,3L,9L,1L,9L,7L,2L,7L,1L,2L,6L,0L,3L,0L,2L,6L,3L,1L,7L,2L,7L,7L,6L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201738Inst : IEnumerable<long>
{
public static readonly long[] Value=A201738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201738.Bytes);
public long this[int i]=>Value[i];

public static A201738Inst Instance=new A201738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201739
{
public static readonly long[] Value={ 0L,4L,5L,6L,7L,9L,10L,11L,12L,14L,17L,23L,27L,28L,30L,31L,32L,33L,34L,37L,38L,39L,41L,44L,45L,47L,48L,53L,54L,61L,65L,70L,73L,74L,75L,76L,77L,80L,83L,84L,88L,89L,91L,96L,98L,100L,102L,105L,108L,109L,110L,114L,117L,119L,125L,126L,128L,132L,136L,139L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201739Inst : IEnumerable<long>
{
public static readonly long[] Value=A201739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201739.Bytes);
public long this[int i]=>Value[i];

public static A201739Inst Instance=new A201739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201740
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,4L,39L,-158L,211L,-186L,-33722L,55130L,192039L,-4032991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201740Inst : IEnumerable<long>
{
public static readonly long[] Value=A201740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201740.Bytes);
public long this[int i]=>Value[i];

public static A201740Inst Instance=new A201740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201741
{
public static readonly long[] Value={ 1L,3L,1L,9L,0L,7L,3L,6L,7L,6L,8L,5L,7L,3L,6L,5L,3L,5L,4L,4L,1L,7L,8L,9L,9L,1L,0L,9L,5L,2L,0L,8L,4L,8L,4L,6L,4L,4L,2L,1L,9L,6L,6L,7L,8L,0L,8L,2L,5L,4L,9L,7L,6L,6L,9L,2L,5L,6L,0L,8L,9L,0L,0L,4L,9L,0L,5L,1L,2L,7L,0L,7L,6L,3L,4L,6L,1L,0L,7L,3L,1L,6L,7L,2L,5L,1L,0L,4L,0L,6L,3L,8L,4L,4L,9L,4L,0L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201741Inst : IEnumerable<long>
{
public static readonly long[] Value=A201741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201741.Bytes);
public long this[int i]=>Value[i];

public static A201741Inst Instance=new A201741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201742
{
public static readonly long[] Value={ 1L,8L,7L,3L,1L,2L,2L,5L,4L,7L,7L,1L,3L,0L,4L,3L,3L,2L,1L,7L,2L,0L,5L,9L,7L,0L,9L,6L,7L,5L,4L,2L,5L,7L,1L,0L,4L,0L,8L,3L,5L,2L,7L,4L,0L,2L,6L,5L,0L,3L,9L,2L,5L,1L,4L,2L,8L,0L,1L,7L,1L,8L,7L,2L,9L,4L,1L,3L,2L,0L,4L,2L,4L,5L,8L,0L,2L,0L,6L,1L,7L,4L,9L,3L,7L,4L,7L,9L,3L,8L,4L,6L,4L,8L,1L,6L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201742Inst : IEnumerable<long>
{
public static readonly long[] Value=A201742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201742.Bytes);
public long this[int i]=>Value[i];

public static A201742Inst Instance=new A201742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201743
{
public static readonly long[] Value={ 2L,1L,5L,8L,7L,2L,6L,0L,6L,4L,4L,8L,1L,2L,2L,4L,6L,2L,4L,1L,4L,0L,2L,4L,0L,7L,5L,4L,8L,1L,3L,8L,5L,6L,7L,1L,7L,7L,5L,5L,9L,0L,7L,4L,1L,5L,7L,7L,7L,6L,7L,1L,4L,4L,8L,1L,8L,8L,9L,1L,8L,6L,8L,7L,0L,6L,0L,8L,7L,1L,9L,1L,2L,4L,9L,3L,2L,1L,3L,0L,0L,3L,1L,3L,3L,2L,4L,6L,9L,2L,4L,2L,5L,8L,6L,0L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201743Inst : IEnumerable<long>
{
public static readonly long[] Value=A201743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201743.Bytes);
public long this[int i]=>Value[i];

public static A201743Inst Instance=new A201743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201744
{
public static readonly long[] Value={ 2L,3L,5L,6L,3L,5L,3L,4L,8L,9L,8L,5L,7L,1L,5L,4L,3L,6L,2L,4L,2L,0L,2L,5L,9L,2L,3L,5L,5L,6L,8L,1L,4L,8L,9L,7L,8L,8L,6L,9L,7L,2L,1L,5L,1L,5L,0L,5L,4L,4L,6L,8L,0L,3L,2L,0L,4L,3L,9L,2L,1L,8L,0L,9L,8L,8L,5L,9L,0L,3L,0L,8L,9L,3L,8L,9L,9L,3L,6L,5L,5L,6L,4L,7L,4L,2L,0L,7L,3L,8L,1L,7L,4L,2L,8L,0L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201744Inst : IEnumerable<long>
{
public static readonly long[] Value=A201744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201744.Bytes);
public long this[int i]=>Value[i];

public static A201744Inst Instance=new A201744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201745
{
public static readonly long[] Value={ 2L,5L,0L,9L,3L,3L,6L,6L,6L,8L,0L,2L,5L,0L,3L,6L,3L,2L,4L,5L,4L,6L,4L,1L,0L,2L,6L,7L,8L,6L,9L,8L,5L,2L,7L,3L,8L,4L,2L,0L,3L,6L,9L,5L,7L,9L,0L,3L,4L,4L,0L,4L,1L,3L,1L,6L,9L,8L,7L,7L,3L,5L,6L,7L,0L,7L,5L,2L,2L,2L,6L,1L,2L,1L,0L,4L,6L,8L,3L,5L,9L,8L,7L,1L,6L,4L,2L,8L,2L,2L,0L,1L,6L,2L,8L,6L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201745Inst : IEnumerable<long>
{
public static readonly long[] Value=A201745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201745.Bytes);
public long this[int i]=>Value[i];

public static A201745Inst Instance=new A201745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201746
{
public static readonly long[] Value={ 2L,6L,3L,4L,9L,8L,9L,9L,1L,5L,7L,5L,9L,3L,4L,7L,9L,1L,8L,3L,9L,4L,7L,4L,7L,7L,4L,3L,7L,3L,8L,5L,9L,6L,5L,4L,3L,7L,3L,6L,2L,5L,4L,5L,6L,0L,2L,7L,0L,1L,4L,0L,7L,8L,9L,1L,4L,4L,9L,4L,6L,0L,8L,3L,4L,5L,9L,3L,3L,4L,7L,6L,4L,5L,6L,3L,8L,5L,6L,6L,9L,2L,3L,6L,4L,4L,5L,1L,8L,3L,4L,9L,0L,4L,9L,1L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201746Inst : IEnumerable<long>
{
public static readonly long[] Value=A201746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201746.Bytes);
public long this[int i]=>Value[i];

public static A201746Inst Instance=new A201746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201747
{
public static readonly long[] Value={ 2L,7L,4L,2L,0L,5L,7L,1L,9L,7L,2L,5L,8L,6L,5L,1L,5L,9L,5L,5L,1L,9L,1L,6L,7L,3L,7L,8L,7L,9L,0L,0L,2L,3L,5L,8L,5L,1L,6L,8L,0L,2L,5L,4L,9L,1L,4L,3L,6L,1L,4L,1L,9L,6L,5L,8L,3L,5L,0L,3L,4L,4L,2L,5L,5L,8L,2L,5L,1L,3L,3L,8L,6L,4L,2L,9L,5L,0L,1L,5L,2L,3L,3L,6L,2L,7L,0L,1L,5L,3L,4L,1L,5L,0L,7L,2L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201747Inst : IEnumerable<long>
{
public static readonly long[] Value=A201747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201747.Bytes);
public long this[int i]=>Value[i];

public static A201747Inst Instance=new A201747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201748
{
public static readonly long[] Value={ 2L,8L,3L,5L,6L,0L,0L,5L,0L,6L,0L,3L,5L,9L,7L,9L,9L,6L,7L,6L,2L,5L,3L,5L,9L,1L,9L,5L,8L,7L,6L,2L,7L,1L,6L,0L,8L,5L,3L,2L,8L,0L,8L,5L,4L,2L,5L,0L,4L,3L,9L,0L,4L,1L,0L,9L,0L,6L,1L,5L,4L,4L,8L,1L,6L,2L,3L,9L,8L,9L,1L,1L,3L,9L,8L,7L,6L,5L,2L,0L,1L,1L,0L,3L,6L,0L,4L,1L,9L,6L,7L,3L,2L,8L,2L,2L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201748Inst : IEnumerable<long>
{
public static readonly long[] Value=A201748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201748.Bytes);
public long this[int i]=>Value[i];

public static A201748Inst Instance=new A201748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201749
{
public static readonly long[] Value={ 2L,9L,1L,8L,8L,2L,6L,9L,8L,2L,3L,0L,6L,3L,4L,5L,3L,4L,3L,6L,5L,1L,7L,4L,6L,4L,8L,0L,5L,4L,0L,9L,7L,6L,2L,4L,9L,9L,4L,9L,0L,9L,4L,7L,6L,8L,1L,0L,7L,5L,4L,5L,8L,9L,8L,0L,6L,0L,7L,0L,7L,6L,5L,2L,1L,3L,8L,3L,0L,5L,8L,3L,0L,4L,9L,6L,7L,5L,8L,6L,5L,8L,2L,8L,3L,3L,0L,5L,7L,0L,1L,9L,6L,1L,1L,6L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201749Inst : IEnumerable<long>
{
public static readonly long[] Value=A201749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201749.Bytes);
public long this[int i]=>Value[i];

public static A201749Inst Instance=new A201749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201750
{
public static readonly long[] Value={ 7L,1L,4L,5L,5L,6L,3L,8L,4L,7L,4L,3L,0L,0L,9L,6L,8L,1L,6L,0L,1L,4L,4L,9L,1L,2L,6L,4L,3L,4L,3L,6L,2L,8L,8L,7L,5L,9L,6L,4L,9L,7L,9L,3L,8L,6L,6L,3L,8L,3L,0L,8L,2L,6L,9L,5L,5L,9L,1L,7L,6L,9L,5L,3L,2L,2L,4L,5L,9L,4L,5L,5L,2L,9L,0L,1L,6L,8L,9L,7L,1L,8L,1L,2L,6L,3L,6L,6L,2L,2L,7L,8L,6L,3L,9L,1L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201750Inst : IEnumerable<long>
{
public static readonly long[] Value=A201750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201750.Bytes);
public long this[int i]=>Value[i];

public static A201750Inst Instance=new A201750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201751
{
public static readonly long[] Value={ 1L,3L,1L,5L,9L,7L,3L,7L,7L,7L,7L,9L,6L,2L,9L,0L,1L,8L,7L,8L,8L,7L,1L,7L,7L,3L,8L,7L,3L,0L,1L,2L,7L,1L,0L,4L,8L,0L,1L,8L,9L,3L,7L,8L,5L,6L,0L,5L,1L,1L,5L,2L,5L,1L,3L,8L,4L,8L,7L,8L,1L,5L,9L,7L,3L,3L,6L,8L,8L,0L,0L,4L,3L,3L,5L,4L,6L,2L,5L,1L,1L,2L,1L,4L,4L,0L,1L,5L,4L,4L,0L,8L,3L,8L,5L,5L,4L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201751Inst : IEnumerable<long>
{
public static readonly long[] Value=A201751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201751.Bytes);
public long this[int i]=>Value[i];

public static A201751Inst Instance=new A201751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201752
{
public static readonly long[] Value={ 5L,3L,7L,2L,7L,4L,4L,4L,9L,1L,7L,3L,8L,5L,6L,6L,0L,4L,2L,5L,6L,7L,6L,2L,9L,8L,9L,7L,7L,9L,6L,7L,5L,3L,8L,1L,4L,2L,7L,5L,2L,4L,0L,1L,4L,0L,0L,0L,1L,0L,4L,1L,0L,7L,7L,7L,6L,6L,8L,1L,9L,9L,6L,5L,4L,7L,3L,3L,7L,7L,3L,2L,7L,5L,1L,1L,3L,7L,7L,2L,9L,9L,1L,5L,2L,4L,7L,5L,6L,9L,1L,5L,5L,4L,3L,6L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201752Inst : IEnumerable<long>
{
public static readonly long[] Value=A201752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201752.Bytes);
public long this[int i]=>Value[i];

public static A201752Inst Instance=new A201752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201753
{
public static readonly long[] Value={ 1L,6L,7L,7L,2L,3L,2L,7L,0L,8L,5L,3L,2L,5L,3L,7L,9L,9L,8L,8L,9L,2L,7L,0L,1L,0L,1L,1L,7L,7L,9L,4L,2L,1L,7L,6L,9L,4L,5L,1L,2L,8L,9L,8L,5L,8L,1L,4L,2L,5L,6L,2L,3L,3L,9L,0L,2L,0L,0L,5L,9L,7L,0L,7L,0L,3L,6L,6L,6L,4L,7L,9L,1L,7L,1L,8L,0L,7L,4L,4L,3L,2L,0L,2L,8L,0L,5L,2L,2L,3L,4L,1L,2L,6L,7L,0L,2L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201753Inst : IEnumerable<long>
{
public static readonly long[] Value=A201753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201753.Bytes);
public long this[int i]=>Value[i];

public static A201753Inst Instance=new A201753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201754
{
public static readonly long[] Value={ 8L,3L,4L,4L,8L,6L,8L,6L,5L,3L,0L,8L,7L,5L,8L,7L,8L,6L,0L,9L,1L,1L,0L,1L,6L,8L,0L,1L,2L,7L,3L,3L,7L,7L,8L,9L,8L,3L,5L,7L,0L,3L,0L,3L,8L,0L,7L,9L,9L,2L,5L,9L,1L,2L,5L,9L,7L,5L,0L,6L,4L,1L,0L,8L,7L,8L,7L,0L,4L,2L,2L,0L,8L,0L,0L,5L,2L,3L,6L,6L,5L,4L,6L,8L,2L,1L,0L,9L,5L,1L,3L,5L,6L,5L,6L,3L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201754Inst : IEnumerable<long>
{
public static readonly long[] Value=A201754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201754.Bytes);
public long this[int i]=>Value[i];

public static A201754Inst Instance=new A201754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201755
{
public static readonly long[] Value={ 1L,9L,6L,4L,6L,3L,5L,5L,9L,7L,4L,8L,8L,8L,6L,4L,5L,0L,7L,6L,2L,2L,6L,5L,9L,6L,9L,2L,1L,1L,0L,9L,7L,7L,5L,8L,8L,3L,7L,5L,3L,0L,7L,5L,0L,6L,3L,7L,9L,4L,2L,2L,8L,1L,1L,5L,2L,1L,9L,7L,9L,5L,8L,3L,2L,3L,5L,7L,0L,1L,6L,4L,3L,2L,2L,0L,8L,8L,1L,3L,2L,7L,7L,9L,0L,4L,8L,2L,1L,7L,3L,5L,1L,7L,0L,4L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201755Inst : IEnumerable<long>
{
public static readonly long[] Value=A201755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201755.Bytes);
public long this[int i]=>Value[i];

public static A201755Inst Instance=new A201755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201756
{
public static readonly long[] Value={ 1L,0L,5L,8L,0L,0L,6L,4L,0L,1L,0L,9L,0L,6L,3L,6L,3L,0L,8L,6L,2L,1L,3L,8L,7L,4L,4L,6L,1L,2L,3L,1L,6L,1L,3L,5L,1L,4L,3L,2L,6L,8L,2L,8L,8L,6L,3L,5L,8L,9L,4L,8L,6L,6L,0L,5L,4L,4L,5L,9L,4L,4L,3L,0L,2L,2L,7L,5L,3L,2L,7L,6L,6L,3L,5L,8L,3L,0L,9L,3L,6L,6L,4L,1L,6L,0L,6L,8L,5L,0L,9L,8L,0L,5L,5L,8L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201756Inst : IEnumerable<long>
{
public static readonly long[] Value=A201756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201756.Bytes);
public long this[int i]=>Value[i];

public static A201756Inst Instance=new A201756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201757
{
public static readonly long[] Value={ 2L,2L,1L,1L,4L,3L,7L,7L,5L,8L,8L,4L,2L,0L,4L,2L,3L,4L,4L,8L,9L,2L,4L,2L,3L,2L,9L,2L,3L,3L,0L,1L,5L,2L,7L,2L,5L,9L,6L,5L,5L,7L,2L,8L,3L,4L,7L,9L,2L,1L,7L,1L,4L,6L,0L,9L,5L,3L,5L,5L,0L,3L,4L,1L,6L,9L,6L,2L,7L,6L,4L,8L,1L,4L,9L,5L,9L,0L,3L,6L,8L,2L,2L,3L,0L,1L,2L,5L,2L,3L,6L,1L,8L,3L,6L,2L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201757Inst : IEnumerable<long>
{
public static readonly long[] Value=A201757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201757.Bytes);
public long this[int i]=>Value[i];

public static A201757Inst Instance=new A201757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201758
{
public static readonly long[] Value={ 1L,2L,4L,1L,1L,4L,2L,7L,5L,8L,3L,9L,9L,5L,9L,7L,6L,9L,3L,5L,7L,2L,2L,5L,1L,2L,4L,4L,8L,9L,7L,7L,8L,8L,7L,2L,9L,5L,6L,2L,5L,3L,8L,9L,9L,9L,3L,8L,5L,7L,2L,1L,6L,3L,2L,1L,1L,7L,4L,5L,5L,9L,0L,4L,6L,6L,7L,3L,3L,4L,1L,2L,8L,7L,1L,5L,6L,0L,9L,7L,6L,8L,1L,4L,8L,7L,1L,2L,6L,0L,0L,2L,0L,5L,3L,6L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201758Inst : IEnumerable<long>
{
public static readonly long[] Value=A201758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201758.Bytes);
public long this[int i]=>Value[i];

public static A201758Inst Instance=new A201758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201759
{
public static readonly long[] Value={ 2L,4L,3L,1L,4L,7L,9L,6L,5L,9L,7L,2L,3L,0L,3L,6L,0L,3L,9L,7L,3L,6L,5L,3L,9L,0L,1L,4L,0L,8L,3L,4L,1L,5L,0L,8L,2L,9L,7L,7L,3L,1L,3L,9L,5L,9L,0L,5L,2L,2L,4L,2L,9L,2L,8L,2L,7L,6L,1L,3L,7L,9L,7L,2L,4L,5L,3L,9L,7L,8L,0L,9L,6L,9L,6L,7L,1L,1L,7L,9L,7L,8L,4L,1L,9L,5L,9L,5L,3L,3L,0L,6L,6L,1L,2L,8L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201759Inst : IEnumerable<long>
{
public static readonly long[] Value=A201759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201759.Bytes);
public long this[int i]=>Value[i];

public static A201759Inst Instance=new A201759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201760
{
public static readonly long[] Value={ 1L,3L,9L,7L,7L,8L,0L,5L,3L,5L,4L,2L,4L,1L,7L,6L,8L,7L,4L,1L,6L,4L,6L,8L,5L,4L,7L,4L,6L,0L,6L,2L,3L,3L,3L,6L,8L,9L,4L,8L,0L,7L,2L,4L,1L,0L,7L,6L,4L,9L,2L,3L,5L,6L,6L,8L,8L,0L,1L,4L,3L,3L,1L,1L,4L,7L,4L,5L,1L,6L,8L,9L,1L,1L,2L,4L,0L,3L,2L,1L,6L,3L,4L,2L,4L,9L,7L,5L,9L,7L,5L,1L,8L,6L,4L,9L,5L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201760Inst : IEnumerable<long>
{
public static readonly long[] Value=A201760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201760.Bytes);
public long this[int i]=>Value[i];

public static A201760Inst Instance=new A201760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201761
{
public static readonly long[] Value={ 2L,6L,3L,2L,1L,2L,3L,5L,6L,0L,6L,1L,4L,2L,2L,2L,9L,5L,3L,8L,7L,5L,3L,0L,7L,6L,7L,1L,3L,3L,8L,3L,1L,2L,9L,3L,4L,3L,3L,8L,3L,6L,4L,8L,3L,7L,1L,0L,4L,3L,3L,0L,3L,7L,5L,4L,2L,5L,0L,6L,9L,9L,4L,5L,0L,8L,9L,0L,4L,6L,2L,8L,2L,9L,1L,2L,8L,7L,6L,5L,5L,1L,4L,9L,7L,2L,6L,1L,3L,6L,8L,4L,8L,2L,4L,1L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201761Inst : IEnumerable<long>
{
public static readonly long[] Value=A201761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201761.Bytes);
public long this[int i]=>Value[i];

public static A201761Inst Instance=new A201761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201762
{
public static readonly long[] Value={ 1L,5L,3L,5L,3L,1L,7L,6L,0L,2L,3L,4L,3L,7L,6L,5L,8L,6L,2L,0L,2L,6L,9L,2L,3L,7L,2L,4L,3L,9L,7L,2L,0L,6L,2L,0L,8L,6L,1L,2L,5L,4L,7L,9L,0L,6L,2L,8L,6L,4L,0L,2L,5L,4L,1L,5L,9L,2L,1L,2L,9L,5L,3L,6L,3L,0L,4L,2L,8L,4L,8L,3L,4L,9L,4L,2L,2L,2L,5L,2L,8L,8L,1L,2L,4L,3L,4L,1L,3L,6L,5L,4L,7L,9L,0L,2L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201762Inst : IEnumerable<long>
{
public static readonly long[] Value=A201762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201762.Bytes);
public long this[int i]=>Value[i];

public static A201762Inst Instance=new A201762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201763
{
public static readonly long[] Value={ 2L,8L,1L,7L,8L,4L,7L,6L,9L,4L,4L,1L,6L,5L,7L,3L,6L,8L,9L,3L,7L,7L,2L,7L,4L,0L,9L,6L,5L,0L,4L,0L,6L,4L,1L,2L,8L,2L,2L,8L,3L,8L,6L,2L,2L,3L,4L,1L,7L,1L,6L,8L,5L,3L,9L,0L,6L,1L,7L,6L,2L,5L,2L,5L,8L,9L,3L,5L,4L,6L,5L,2L,8L,5L,9L,3L,6L,1L,8L,9L,9L,3L,3L,0L,9L,8L,4L,5L,7L,4L,8L,7L,6L,0L,5L,6L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201763Inst : IEnumerable<long>
{
public static readonly long[] Value=A201763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201763.Bytes);
public long this[int i]=>Value[i];

public static A201763Inst Instance=new A201763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201764
{
public static readonly long[] Value={ 1L,6L,5L,8L,2L,6L,0L,7L,2L,0L,4L,5L,2L,4L,9L,8L,8L,7L,8L,7L,9L,6L,3L,8L,4L,3L,7L,9L,6L,4L,6L,4L,5L,2L,5L,6L,4L,3L,4L,8L,2L,8L,5L,7L,0L,8L,4L,4L,4L,2L,2L,7L,3L,0L,9L,1L,1L,5L,4L,0L,2L,8L,3L,5L,2L,2L,7L,6L,1L,8L,9L,0L,1L,2L,8L,8L,9L,4L,1L,0L,6L,5L,4L,4L,8L,8L,5L,6L,1L,7L,1L,8L,5L,8L,5L,8L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201764Inst : IEnumerable<long>
{
public static readonly long[] Value=A201764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201764.Bytes);
public long this[int i]=>Value[i];

public static A201764Inst Instance=new A201764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201765
{
public static readonly long[] Value={ 2L,9L,9L,1L,6L,2L,0L,6L,3L,0L,1L,2L,8L,1L,8L,7L,5L,0L,5L,2L,3L,7L,9L,6L,0L,2L,9L,2L,2L,9L,2L,9L,3L,8L,0L,3L,8L,0L,3L,8L,7L,8L,7L,3L,4L,2L,2L,5L,3L,6L,1L,2L,3L,8L,5L,4L,8L,1L,1L,5L,0L,4L,1L,9L,3L,5L,3L,0L,4L,6L,1L,3L,5L,5L,8L,0L,8L,8L,7L,2L,0L,8L,2L,9L,3L,3L,1L,7L,9L,3L,1L,3L,0L,2L,6L,5L,6L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201765Inst : IEnumerable<long>
{
public static readonly long[] Value=A201765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201765.Bytes);
public long this[int i]=>Value[i];

public static A201765Inst Instance=new A201765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201766
{
public static readonly long[] Value={ 1L,7L,6L,9L,6L,0L,1L,1L,0L,0L,1L,9L,9L,3L,5L,7L,6L,8L,9L,1L,8L,6L,5L,9L,6L,7L,7L,4L,7L,1L,0L,6L,7L,8L,5L,1L,9L,9L,3L,5L,1L,5L,9L,4L,7L,9L,1L,3L,4L,5L,7L,5L,9L,2L,4L,5L,1L,3L,4L,1L,4L,7L,4L,3L,8L,1L,3L,3L,3L,1L,5L,0L,8L,9L,2L,9L,8L,9L,2L,9L,1L,0L,0L,7L,5L,8L,9L,1L,5L,3L,9L,3L,7L,6L,1L,9L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201766Inst : IEnumerable<long>
{
public static readonly long[] Value=A201766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201766.Bytes);
public long this[int i]=>Value[i];

public static A201766Inst Instance=new A201766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201767
{
public static readonly long[] Value={ 3L,1L,5L,5L,5L,3L,2L,3L,3L,0L,7L,9L,6L,3L,4L,6L,4L,4L,6L,9L,3L,2L,3L,0L,3L,3L,1L,9L,2L,6L,5L,8L,4L,0L,7L,0L,0L,0L,1L,0L,4L,2L,5L,6L,4L,4L,8L,9L,1L,1L,1L,9L,8L,6L,3L,7L,4L,6L,9L,1L,3L,5L,4L,3L,7L,9L,8L,7L,6L,6L,6L,9L,4L,4L,2L,6L,5L,5L,6L,4L,0L,3L,8L,8L,5L,0L,7L,3L,6L,1L,5L,0L,3L,2L,5L,5L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201767Inst : IEnumerable<long>
{
public static readonly long[] Value=A201767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201767.Bytes);
public long this[int i]=>Value[i];

public static A201767Inst Instance=new A201767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201768
{
public static readonly long[] Value={ 1L,8L,7L,1L,4L,4L,6L,4L,4L,9L,8L,4L,6L,8L,0L,6L,5L,6L,5L,2L,9L,1L,1L,4L,0L,4L,5L,6L,5L,0L,4L,1L,7L,2L,3L,7L,6L,2L,2L,9L,5L,9L,5L,6L,2L,1L,9L,7L,0L,1L,7L,6L,6L,6L,4L,1L,0L,2L,7L,7L,0L,1L,4L,1L,5L,5L,0L,1L,3L,6L,6L,8L,3L,3L,5L,0L,0L,9L,1L,5L,8L,7L,5L,2L,4L,9L,3L,6L,5L,2L,1L,0L,8L,9L,4L,4L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201768Inst : IEnumerable<long>
{
public static readonly long[] Value=A201768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201768.Bytes);
public long this[int i]=>Value[i];

public static A201768Inst Instance=new A201768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201769
{
public static readonly long[] Value={ 1L,2L,3L,5L,3L,4L,6L,2L,3L,3L,4L,6L,4L,6L,8L,7L,1L,6L,8L,0L,3L,1L,0L,1L,5L,6L,3L,0L,6L,3L,7L,1L,6L,4L,7L,0L,1L,6L,9L,5L,9L,6L,7L,0L,1L,4L,5L,1L,7L,1L,8L,5L,3L,0L,6L,1L,5L,4L,8L,8L,5L,4L,3L,3L,3L,9L,4L,0L,3L,6L,9L,6L,0L,6L,1L,8L,5L,1L,6L,7L,5L,8L,4L,6L,7L,2L,6L,8L,2L,4L,1L,1L,4L,7L,7L,9L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201769Inst : IEnumerable<long>
{
public static readonly long[] Value=A201769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201769.Bytes);
public long this[int i]=>Value[i];

public static A201769Inst Instance=new A201769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201770
{
public static readonly long[] Value={ 1L,7L,9L,3L,2L,8L,2L,1L,3L,2L,9L,0L,0L,7L,6L,1L,0L,0L,7L,5L,5L,7L,5L,5L,3L,3L,6L,3L,9L,0L,1L,0L,4L,2L,4L,0L,0L,7L,9L,8L,4L,9L,5L,0L,1L,1L,3L,5L,2L,8L,4L,4L,8L,4L,0L,1L,8L,7L,3L,6L,8L,6L,9L,2L,7L,9L,3L,6L,4L,0L,3L,5L,0L,3L,1L,2L,1L,4L,5L,3L,0L,7L,1L,0L,1L,8L,1L,6L,0L,3L,1L,2L,8L,4L,5L,5L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201770Inst : IEnumerable<long>
{
public static readonly long[] Value=A201770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201770.Bytes);
public long this[int i]=>Value[i];

public static A201770Inst Instance=new A201770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201771
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3600L,2882737L,229095676L,6655170642L,103395053720L,1051588999820L,7878155295948L,46838274976147L,232322652402464L,995789500001315L,3784235129731708L,12999197522073908L,40969826999523768L,119876498636101786L,328726265508168780L,851369417500529061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201771Inst : IEnumerable<long>
{
public static readonly long[] Value=A201771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201771.Bytes);
public long this[int i]=>Value[i];

public static A201771Inst Instance=new A201771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201772
{
public static readonly long[] Value={ 2L,5L,8L,5L,5L,5L,4L,6L,3L,3L,7L,1L,1L,7L,3L,7L,7L,9L,5L,6L,2L,4L,6L,8L,6L,3L,6L,3L,0L,2L,7L,8L,0L,6L,7L,7L,3L,2L,3L,0L,8L,3L,3L,3L,0L,0L,0L,0L,1L,7L,5L,4L,9L,2L,6L,0L,5L,2L,1L,4L,0L,3L,5L,9L,1L,1L,2L,8L,2L,4L,2L,8L,7L,0L,2L,2L,1L,9L,0L,7L,6L,1L,4L,0L,1L,3L,8L,0L,9L,7L,5L,8L,6L,7L,0L,3L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201772Inst : IEnumerable<long>
{
public static readonly long[] Value=A201772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201772.Bytes);
public long this[int i]=>Value[i];

public static A201772Inst Instance=new A201772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201773
{
public static readonly long[] Value={ 0L,13L,13L,21L,34L,55L,86L,139L,216L,342L,550L,898L,1445L,2337L,3774L,6107L,9879L,15973L,25840L,41818L,67653L,109461L,177118L,286576L,463684L,750255L,1213933L,1964184L,3178110L,5142292L,8320401L,13462694L,21783096L,35245782L,57028879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201773Inst : IEnumerable<long>
{
public static readonly long[] Value=A201773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201773.Bytes);
public long this[int i]=>Value[i];

public static A201773Inst Instance=new A201773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201774
{
public static readonly long[] Value={ 2L,4L,1L,4L,5L,3L,0L,0L,7L,0L,0L,5L,2L,2L,3L,8L,5L,4L,6L,5L,5L,5L,6L,9L,3L,1L,0L,9L,5L,5L,1L,0L,7L,1L,3L,5L,8L,6L,1L,5L,7L,3L,6L,3L,4L,3L,5L,9L,4L,6L,9L,0L,0L,3L,3L,3L,1L,0L,1L,1L,7L,8L,6L,2L,1L,7L,4L,5L,1L,8L,6L,2L,8L,9L,9L,0L,4L,2L,6L,2L,3L,6L,7L,9L,3L,6L,6L,8L,2L,5L,9L,8L,4L,6L,4L,4L,2L,2L,7L,5L,4L,3L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201774Inst : IEnumerable<long>
{
public static readonly long[] Value=A201774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201774.Bytes);
public long this[int i]=>Value[i];

public static A201774Inst Instance=new A201774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201775
{
public static readonly long[] Value={ 4L,6L,6L,9L,4L,2L,2L,0L,6L,9L,2L,4L,2L,5L,9L,8L,5L,9L,9L,8L,3L,3L,9L,4L,8L,1L,3L,2L,3L,3L,6L,6L,7L,5L,7L,3L,1L,4L,3L,2L,6L,8L,4L,0L,6L,7L,4L,3L,1L,8L,2L,3L,6L,7L,2L,5L,3L,4L,1L,3L,1L,0L,1L,6L,6L,1L,0L,9L,9L,7L,8L,5L,6L,4L,6L,4L,5L,8L,9L,1L,8L,8L,7L,5L,2L,2L,2L,3L,6L,9L,5L,5L,6L,8L,5L,4L,1L,3L,9L,6L,8L,0L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201775Inst : IEnumerable<long>
{
public static readonly long[] Value=A201775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201775.Bytes);
public long this[int i]=>Value[i];

public static A201775Inst Instance=new A201775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201776
{
public static readonly long[] Value={ 2L,6L,8L,9L,4L,1L,4L,2L,1L,3L,6L,9L,9L,9L,5L,1L,2L,0L,7L,4L,8L,8L,4L,0L,7L,5L,8L,1L,7L,8L,1L,6L,3L,7L,2L,5L,6L,3L,4L,8L,5L,5L,3L,5L,9L,8L,3L,4L,9L,4L,3L,4L,8L,0L,7L,2L,3L,6L,3L,4L,0L,9L,2L,0L,8L,0L,9L,5L,9L,5L,4L,6L,9L,2L,9L,7L,9L,5L,3L,6L,0L,6L,1L,2L,5L,2L,5L,4L,6L,7L,9L,2L,4L,0L,1L,8L,7L,5L,4L,7L,0L,7L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201776Inst : IEnumerable<long>
{
public static readonly long[] Value=A201776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201776.Bytes);
public long this[int i]=>Value[i];

public static A201776Inst Instance=new A201776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201777
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,4L,8L,202L,-1024L,-17718L,590262L,-4319954L,-250042344L,11097553206L,-110198613306L,-12018093009424L,791558086255136L,-14143565415027956L,-1546249362315735600L,BigInteger.Parse("162730885462262914406"),BigInteger.Parse("-5686938689391780668440"),BigInteger.Parse("-410162666115593769228098"),BigInteger.Parse("77767801528714637765717294") };
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
public class A201777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201777Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201777.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201777.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201777Inst Instance=new A201777Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201778
{
public static readonly long[] Value={ 1L,0L,1L,2L,5L,14L,39L,110L,323L,956L,2835L,8648L,26449L,80356L,253709L,789110L,2400681L,8095578L,24339611L,71349218L,314555855L,559848480L,2096495479L,23012907844L,-84278218251L,415921423864L,2974067144745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201778Inst : IEnumerable<long>
{
public static readonly long[] Value=A201778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201778.Bytes);
public long this[int i]=>Value[i];

public static A201778Inst Instance=new A201778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201779
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,23L,52L,120L,247L,534L,1433L,2540L,3264L,30169L,19123L,-363258L,2951500L,-1601367L,-99325484L,799655132L,-1194225728L,-32599353806L,345568196667L,-1063427879019L,-13137091603516L,205598895773140L,-1103275663780401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201779Inst : IEnumerable<long>
{
public static readonly long[] Value=A201779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201779.Bytes);
public long this[int i]=>Value[i];

public static A201779Inst Instance=new A201779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201780
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,2L,5L,4L,1L,4L,12L,13L,6L,1L,8L,28L,38L,25L,8L,1L,16L,64L,104L,88L,41L,10L,1L,32L,144L,272L,280L,170L,61L,12L,1L,64L,320L,688L,832L,620L,292L,85L,14L,1L,128L,704L,1696L,2352L,2072L,1204L,462L,113L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201780Inst : IEnumerable<long>
{
public static readonly long[] Value=A201780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201780.Bytes);
public long this[int i]=>Value[i];

public static A201780Inst Instance=new A201780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201781
{
public static readonly long[] Value={ 19L,67L,139L,499L,859L,1579L,1867L,2179L,3259L,4099L,6067L,6619L,8419L,9067L,9739L,22699L,25939L,27067L,28219L,38299L,39667L,46867L,54667L,56299L,61339L,63067L,73939L,79699L,81667L,89779L,91867L,93979L,100459L,102667L,114067L,123619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201781Inst : IEnumerable<long>
{
public static readonly long[] Value=A201781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201781.Bytes);
public long this[int i]=>Value[i];

public static A201781Inst Instance=new A201781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201782
{
public static readonly long[] Value={ 2L,17L,137L,233L,353L,857L,3257L,7193L,7793L,10433L,11897L,13457L,18713L,22697L,23753L,30593L,31817L,34337L,41057L,42473L,43913L,45377L,51473L,64817L,66593L,75833L,79697L,109433L,141257L,143873L,146513L,160073L,185993L,201233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201782Inst : IEnumerable<long>
{
public static readonly long[] Value=A201782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201782.Bytes);
public long this[int i]=>Value[i];

public static A201782Inst Instance=new A201782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201783
{
public static readonly long[] Value={ 19L,79L,179L,499L,719L,1279L,1619L,1999L,2879L,3919L,5119L,5779L,7219L,8819L,9679L,11519L,15679L,19219L,20479L,24499L,25919L,28879L,33619L,35279L,36979L,40499L,44179L,49999L,56179L,71999L,74419L,79379L,81919L,84499L,87119L,89779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201783Inst : IEnumerable<long>
{
public static readonly long[] Value=A201783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201783.Bytes);
public long this[int i]=>Value[i];

public static A201783Inst Instance=new A201783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201784
{
public static readonly long[] Value={ 3L,43L,1123L,2203L,3643L,5443L,7603L,13003L,19843L,28123L,32803L,49003L,61603L,68443L,83203L,117043L,146203L,167443L,178603L,214243L,226843L,239803L,280843L,356443L,406123L,423403L,441043L,496123L,595123L,616003L,637243L,680803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201784Inst : IEnumerable<long>
{
public static readonly long[] Value=A201784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201784.Bytes);
public long this[int i]=>Value[i];

public static A201784Inst Instance=new A201784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201785
{
public static readonly long[] Value={ 2L,17L,317L,977L,1277L,1997L,2417L,3917L,9677L,12497L,20477L,23117L,33617L,48017L,60497L,109517L,127997L,137777L,144497L,154877L,165617L,180497L,216317L,224717L,269117L,353777L,369917L,499277L,511997L,518417L,612497L,662477L,721997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201785Inst : IEnumerable<long>
{
public static readonly long[] Value=A201785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201785.Bytes);
public long this[int i]=>Value[i];

public static A201785Inst Instance=new A201785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201786
{
public static readonly long[] Value={ 41L,241L,401L,601L,1801L,3121L,4201L,4801L,5441L,6121L,6841L,9241L,13001L,15121L,17401L,19841L,21121L,22441L,23801L,26641L,29641L,32801L,45121L,47041L,51001L,57241L,63841L,75641L,78121L,91121L,96601L,99401L,102241L,108041L,114001L,117041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201786Inst : IEnumerable<long>
{
public static readonly long[] Value=A201786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201786.Bytes);
public long this[int i]=>Value[i];

public static A201786Inst Instance=new A201786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201787
{
public static readonly long[] Value={ 239L,599L,839L,1439L,3119L,4799L,9239L,34439L,41399L,45119L,59399L,63839L,123239L,139439L,142799L,186239L,206039L,235439L,244199L,248639L,257639L,285599L,290399L,300119L,320039L,361799L,465119L,508799L,588239L,602039L,608999L,666119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201787Inst : IEnumerable<long>
{
public static readonly long[] Value=A201787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201787.Bytes);
public long this[int i]=>Value[i];

public static A201787Inst Instance=new A201787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201788
{
public static readonly long[] Value={ 13L,73L,173L,313L,1613L,1993L,3373L,4493L,5113L,6473L,7213L,7993L,13513L,19213L,21773L,25913L,33613L,36973L,38713L,40493L,46073L,49993L,58313L,60493L,67273L,71993L,74413L,76873L,95213L,115513L,131213L,154873L,172973L,176713L,204013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201788Inst : IEnumerable<long>
{
public static readonly long[] Value=A201788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201788.Bytes);
public long this[int i]=>Value[i];

public static A201788Inst Instance=new A201788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201789
{
public static readonly long[] Value={ 37L,397L,1117L,3637L,5437L,32797L,43237L,55117L,68437L,99397L,108037L,117037L,126397L,146197L,167437L,178597L,201997L,214237L,266797L,280837L,295237L,372637L,406117L,459037L,534637L,574597L,595117L,615997L,658837L,703117L,795997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201789Inst : IEnumerable<long>
{
public static readonly long[] Value=A201789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201789.Bytes);
public long this[int i]=>Value[i];

public static A201789Inst Instance=new A201789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201790
{
public static readonly long[] Value={ 11L,71L,311L,491L,971L,2411L,3371L,3911L,7211L,12491L,15671L,16811L,19211L,28871L,31991L,38711L,44171L,49991L,56171L,67271L,74411L,76871L,100811L,118571L,134471L,137771L,154871L,165611L,176711L,180491L,188171L,224711L,250871L,255371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201790Inst : IEnumerable<long>
{
public static readonly long[] Value=A201790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201790.Bytes);
public long this[int i]=>Value[i];

public static A201790Inst Instance=new A201790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201791
{
public static readonly long[] Value={ 19L,211L,379L,859L,1009L,1171L,1531L,2161L,3169L,4051L,6529L,8209L,13249L,14401L,15601L,17491L,19489L,23059L,24571L,27739L,30241L,34651L,35569L,37441L,42331L,44371L,47521L,49681L,55291L,63649L,64891L,67411L,82129L,84961L,92251L,96769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201791Inst : IEnumerable<long>
{
public static readonly long[] Value=A201791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201791.Bytes);
public long this[int i]=>Value[i];

public static A201791Inst Instance=new A201791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201792
{
public static readonly long[] Value={ 17L,47L,89L,479L,593L,719L,857L,2393L,2897L,3167L,3449L,4049L,5039L,5393L,10079L,11087L,12143L,12689L,16217L,17489L,18143L,20177L,20879L,23057L,25343L,26927L,27737L,28559L,34649L,36497L,38393L,39359L,46457L,48593L,50777L,62417L,63647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201792Inst : IEnumerable<long>
{
public static readonly long[] Value=A201792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201792.Bytes);
public long this[int i]=>Value[i];

public static A201792Inst Instance=new A201792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201793
{
public static readonly long[] Value={ 251L,2267L,6299L,12347L,16127L,20411L,30491L,49391L,81647L,90971L,100799L,121967L,170351L,183707L,197567L,211931L,226799L,242171L,344987L,363887L,383291L,444527L,465947L,510299L,580607L,605051L,681407L,790271L,847727L,907199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201793Inst : IEnumerable<long>
{
public static readonly long[] Value=A201793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201793.Bytes);
public long this[int i]=>Value[i];

public static A201793Inst Instance=new A201793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201794
{
public static readonly BigInteger[] Value={ 1L,1L,3L,7L,30L,96L,343L,4117L,-7200L,-117350L,13210791L,-301763373L,352971853L,347188696141L,-18233731779780L,353928253113421L,23894270709259005L,-2906056754069734431L,BigInteger.Parse("143316419628690145837"),BigInteger.Parse("1110191131102178184400"),BigInteger.Parse("-954513349352250528933834"),BigInteger.Parse("97402126796076086688319561"),BigInteger.Parse("-3777060544481584990339497402") };
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
public class A201794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201794Inst Instance=new A201794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201795
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,80L,621L,5887L,65689L,844587L,12289825L,199702646L,3584177829L,70418168977L,1503204079573L,34644744039375L,857391850897201L,22677415997829788L,638386960029846921L,BigInteger.Parse("19057447729907765407"),BigInteger.Parse("601346850250707128125") };
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
public class A201795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201795Inst Instance=new A201795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201796
{
public static readonly long[] Value={ 1L,85L,4057L,988589L,722587629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201796Inst : IEnumerable<long>
{
public static readonly long[] Value=A201796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201796.Bytes);
public long this[int i]=>Value[i];

public static A201796Inst Instance=new A201796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201797
{
public static readonly long[] Value={ 5L,85L,455L,3617L,28625L,235827L,1972115L,16703881L,142672901L,1226999941L,10610923603L,92180196507L,803840798219L,7032319990027L,61691173120353L,542479698511869L,4780243712781261L,42200307665852185L,373156481784589911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201797Inst : IEnumerable<long>
{
public static readonly long[] Value=A201797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201797.Bytes);
public long this[int i]=>Value[i];

public static A201797Inst Instance=new A201797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201798
{
public static readonly long[] Value={ 19L,455L,4057L,48335L,562961L,7099021L,90062519L,1168520339L,15269686011L,201396758073L,2670595602167L,35597100656221L,476317522683397L,6395415423401799L,86112911010980123L,1162374111689802707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201798Inst : IEnumerable<long>
{
public static readonly long[] Value=A201798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201798.Bytes);
public long this[int i]=>Value[i];

public static A201798Inst Instance=new A201798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201799
{
public static readonly long[] Value={ 85L,3617L,48335L,988589L,20960485L,472565771L,10857153407L,253641348337L,5979418257253L,142075597768273L,3395164032578079L,81529069984570623L,1965470518289395959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201799Inst : IEnumerable<long>
{
public static readonly long[] Value=A201799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201799.Bytes);
public long this[int i]=>Value[i];

public static A201799Inst Instance=new A201799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201800
{
public static readonly long[] Value={ 381L,28625L,562961L,20960485L,722587629L,27941324053L,1077779765471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201800Inst : IEnumerable<long>
{
public static readonly long[] Value=A201800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201800.Bytes);
public long this[int i]=>Value[i];

public static A201800Inst Instance=new A201800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201801
{
public static readonly long[] Value={ 1751L,235827L,7099021L,472565771L,27941324053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201801Inst : IEnumerable<long>
{
public static readonly long[] Value=A201801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201801.Bytes);
public long this[int i]=>Value[i];

public static A201801Inst Instance=new A201801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201802
{
public static readonly long[] Value={ 8135L,1972115L,90062519L,10857153407L,1077779765471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201802Inst : IEnumerable<long>
{
public static readonly long[] Value=A201802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201802.Bytes);
public long this[int i]=>Value[i];

public static A201802Inst Instance=new A201802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201803
{
public static readonly long[] Value={ 1L,5L,5L,19L,85L,19L,85L,455L,455L,85L,381L,3617L,4057L,3617L,381L,1751L,28625L,48335L,48335L,28625L,1751L,8135L,235827L,562961L,988589L,562961L,235827L,8135L,38165L,1972115L,7099021L,20960485L,20960485L,7099021L,1972115L,38165L,180325L,16703881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201803Inst : IEnumerable<long>
{
public static readonly long[] Value=A201803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201803.Bytes);
public long this[int i]=>Value[i];

public static A201803Inst Instance=new A201803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201804
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,9L,10L,12L,13L,15L,16L,19L,20L,21L,23L,26L,27L,28L,29L,30L,31L,36L,41L,43L,47L,49L,52L,54L,56L,58L,61L,62L,65L,68L,69L,70L,72L,73L,75L,79L,80L,83L,87L,90L,92L,97L,98L,100L,103L,104L,105L,106L,112L,113L,114L,118L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201804Inst : IEnumerable<long>
{
public static readonly long[] Value=A201804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201804.Bytes);
public long this[int i]=>Value[i];

public static A201804Inst Instance=new A201804Inst();

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